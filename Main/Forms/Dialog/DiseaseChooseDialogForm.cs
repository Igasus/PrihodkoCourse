using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrihodkoCourse.Models;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms.Dialog
{
    public partial class DiseaseChooseDialogForm : Form
    {
        private static class ColumnName
        {
            public const string Id = "IdColumn";
            public const string Name = "NameColumn";
        }
        
        private readonly DiseasesService _diseasesService;
        private readonly DataGridViewService _dataGridViewService;

        private string SearchName { get; set; } = "";
        
        public Disease DialogResultEntity { get; private set; }
        
        public DiseaseChooseDialogForm(DiseasesService diseasesService)
        {
            _diseasesService = diseasesService;
            
            InitializeComponent();
            
            _dataGridViewService = new DataGridViewService(DiseasesDataGridView);
        }

        private async Task RefreshDataViewGridAsync()
        {
            var diseasesList = await _diseasesService.ReadListAsync(SearchName);
            
            _dataGridViewService.Clear();
            foreach (var disease in diseasesList)
                _dataGridViewService.AddRow(disease.Id, disease.Name);
        }

        private async void DiseaseChooseDialogForm_Load(object sender, EventArgs e)
        {
            await RefreshDataViewGridAsync();
        }

        private async void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchName = SearchTextBox.Text;
            
            await RefreshDataViewGridAsync();
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            var createForm = new DiseaseCreateDialogForm();
            
            var dialogResult = createForm.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                var createModel = createForm.DialogResultEntity;
                await _diseasesService.CreateAsync(createModel);
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
            if (!_dataGridViewService.TryGetSelectedCellIndices(out var columnIndex, out var rowIndex, true))
                return;
            
            if (columnIndex == -1)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("Select cell you want to edit.");
                return;
            }
            
            if (!_dataGridViewService.TryParseIntCell(ColumnName.Id, rowIndex, out var diseaseId))
                return;

            DialogResultEntity = await _diseasesService.ReadByIdAsync(diseaseId);
            DialogResult = DialogResult.OK;
        }
    }
}