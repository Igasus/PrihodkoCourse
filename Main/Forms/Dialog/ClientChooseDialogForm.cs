using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrihodkoCourse.Models;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms.Dialog
{
    public partial class ClientChooseDialogForm : Form
    {
        private static class ColumnName
        {
            public const string Id = "IdColumn";
            public const string FullName = "FullNameColumn";
            public const string PhoneNumber = "PhoneNumberColumn";
            public const string InsurancePolicyNumber = "InsurancePolicyNumberColumn";
            public const string Sex = "SexColumn";
        }
        
        private readonly ClientsService _clientsService;
        private readonly DataGridViewService _clientsDataGridViewService;

        private string SearchFullName { get; set; } = "";
        
        public Client DialogResultEntity { get; private set; }
        
        public ClientChooseDialogForm(ClientsService clientsService)
        {
            _clientsService = clientsService;
            
            InitializeComponent();
            
            _clientsDataGridViewService = new DataGridViewService(ClientsDataGridView);
        }

        private async Task RefreshDataViewGridAsync()
        {
            var clientsList = await _clientsService.ReadListAsync(SearchFullName);
            
            _clientsDataGridViewService.Clear();
            foreach (var client in clientsList)
                _clientsDataGridViewService.AddRow(client.Id,
                    client.FullName,
                    client.PhoneNumber,
                    client.InsurancePolicyNumber,
                    client.Sex);
        }

        private async void ClientsForm_Load(object sender, EventArgs e)
        {
            await RefreshDataViewGridAsync();
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            using var createForm = new ClientCreateDialogForm();
            
            var dialogResult = createForm.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                var createModel = createForm.DialogResultEntity;
                await _clientsService.CreateAsync(createModel);
                await RefreshDataViewGridAsync();
            }

            createForm.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private async void ChooseButton_Click(object sender, EventArgs e)
        {
            if (!_clientsDataGridViewService.TryGetSelectedCellIndices(out var columnIndex, out var rowIndex, true))
                return;
            
            if (columnIndex == -1)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("Select cell you want to edit.");
                return;
            }
            
            if (!_clientsDataGridViewService.TryParseIntCell(ColumnName.Id, rowIndex, out var clientId))
                return;

            DialogResultEntity = await _clientsService.ReadByIdAsync(clientId);
            DialogResult = DialogResult.OK;
        }
        
        private async void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchFullName = SearchTextBox.Text;

            await RefreshDataViewGridAsync();
        }
    }
}