using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrihodkoCourse.Forms.Dialog;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms
{
    public partial class ClientsForm : Form
    {
        private static class ColumnName
        {
            public const string Id = "IdColumn";
            public const string FullName = "FullNameColumn";
            public const string PhoneNumber = "PhoneNumberColumn";
            public const string InsurancePolicyNumber = "InsurancePolicyNumberColumn";
            public const string Sex = "SexColumn";
            public const string Age = "AgeColumn";
        }
        
        private readonly ClientsService _clientsService;
        private readonly DataGridViewService _clientsDataGridViewService;

        private string SearchFullName { get; set; } = "";
        
        public ClientsForm(ClientsService clientsService)
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
                    client.Sex,
                    client.Age);
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

        private async void EditButton_Click(object sender, EventArgs e)
        {
            if (!_clientsDataGridViewService.TryGetSelectedCellIndices(out var columnIndex, out var rowIndex, true))
                return;
            
            if (columnIndex == -1)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("Select cell you want to edit.");
                return;
            }
            
            var columnName = _clientsDataGridViewService.GetColumnName(columnIndex);
            if (columnName == ColumnName.Id)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("You can't edit id.");
                return;
            }
            
            if (!_clientsDataGridViewService.TryParseIntCell(ColumnName.Id, rowIndex, out var clientId))
                return;
            var client = await _clientsService.ReadByIdAsync(clientId);

            if (columnName == ColumnName.Age)
            {
                if (!_clientsDataGridViewService.TryParseIntCell(ColumnName.Age, rowIndex, out var oldValue))
                    return;
                var editForm = new EditIntDialogForm(oldValue);
                editForm.ShowDialog(this);
            
                var editResult = editForm.DialogResult;
                var newValue = editForm.NewValue;
                editForm.Close();
            
                if (editResult == DialogResult.Cancel)
                    return;

                client.Age = newValue;
            }
            else
            {
                var oldValue = _clientsDataGridViewService.GetCellValue(columnIndex, rowIndex);
                var editForm = new EditStringDialogForm(oldValue);
                editForm.ShowDialog(this);
            
                var editResult = editForm.DialogResult;
                var newValue = editForm.NewValue;
                editForm.Close();
            
                if (editResult == DialogResult.Cancel)
                    return;

                switch (columnName)
                {
                    case ColumnName.FullName:
                        client.FullName = newValue;
                        break;
                    case ColumnName.PhoneNumber:
                        client.PhoneNumber = newValue;
                        break;
                    case ColumnName.InsurancePolicyNumber:
                        client.InsurancePolicyNumber = newValue;
                        break;
                    case ColumnName.Sex:
                        client.Sex = newValue;
                        break;
                    default:
                        MessageBox.Show(@"Unknown field.",
                            @"Check database and debug code.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                }
            }

            await _clientsService.UpdateAsync(client);
            await RefreshDataViewGridAsync();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!_clientsDataGridViewService.TryGetSelectedCellIndices(out _, out var rowIndex, true) ||
                !_clientsDataGridViewService.TryParseIntCell(ColumnName.Id, rowIndex, out var clientId))
                return;
            
            var clientFullName = _clientsDataGridViewService.GetCellValue(ColumnName.FullName, rowIndex);

            if (!MessageBoxService.ShowDeleteQuestion($@"Are you sure you want to delete Client '{clientFullName}'?"))
                return;

            await _clientsService.DeleteByIdAsync(clientId);
            await RefreshDataViewGridAsync();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Navigation.Pop();
        }

        private async void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchFullName = SearchTextBox.Text;

            await RefreshDataViewGridAsync();
        }
    }
}
