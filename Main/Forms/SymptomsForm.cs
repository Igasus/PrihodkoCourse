using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrihodkoCourse.Forms.Dialog;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms
{
    public partial class SymptomsForm : Form
    {
        private static class ColumnName
        {
            public const string Id = "IdColumn";
            public const string Name = "NameColumn";
        }
        
        private readonly SymptomsService _symptomsService;
        private readonly DataGridViewService _dataGridViewService;

        private readonly DiseasesSymptomsService _diseasesSymptomsService;
        private readonly DiseasesService _diseasesService;

        private string SearchName { get; set; } = "";
        
        public SymptomsForm(SymptomsService symptomsService,
            DiseasesSymptomsService diseasesSymptomsService,
            DiseasesService diseasesService)
        {
            _symptomsService = symptomsService;
            
            _diseasesSymptomsService = diseasesSymptomsService;
            _diseasesService = diseasesService;
            
            InitializeComponent();
            
            _dataGridViewService = new DataGridViewService(SymptomsDataGridView);
        }

        private async Task RefreshDataViewGridAsync()
        {
            var symptomsList = await _symptomsService.ReadListAsync(SearchName);
            
            _dataGridViewService.Clear();
            foreach (var symptom in symptomsList)
                _dataGridViewService.AddRow(symptom.Id, symptom.Name);
        }
        
        private async void SymptomsForm_Load(object sender, EventArgs e)
        {
            await RefreshDataViewGridAsync();
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            using var createForm = new SymptomCreateDialogForm();
            
            var dialogResult = createForm.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                var createModel = createForm.DialogResultEntity;
                await _symptomsService.CreateAsync(createModel);
                await RefreshDataViewGridAsync();
            }
            
            createForm.Close();
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            if (!_dataGridViewService.TryGetSelectedCellIndices(out var columnIndex, out var rowIndex, true))
                return;
            
            if (columnIndex == -1)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("Select cell you want to edit.");
                return;
            }
            
            var columnName = _dataGridViewService.GetColumnName(columnIndex);
            if (columnName == ColumnName.Id)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("You can't edit id.");
                return;
            }
            
            if (!_dataGridViewService.TryParseIntCell(ColumnName.Id, rowIndex, out var symptomId))
                return;
            var symptom = await _symptomsService.ReadByIdAsync(symptomId);

            var oldValue = _dataGridViewService.GetCellValue(columnIndex, rowIndex);
            var editForm = new EditStringDialogForm(oldValue);
            editForm.ShowDialog(this);
            
            var editResult = editForm.DialogResult;
            var newValue = editForm.NewValue;
            editForm.Close();
            
            if (editResult == DialogResult.Cancel)
                return;

            switch (columnName)
            {
                case ColumnName.Name:
                    symptom.Name = newValue;
                    break;
                default:
                    MessageBox.Show(@"Unknown field.",
                        @"Check database and debug code.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
            }

            await _symptomsService.UpdateAsync(symptom);
            await RefreshDataViewGridAsync();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!_dataGridViewService.TryGetSelectedCellIndices(out _, out var rowIndex, true) ||
                !_dataGridViewService.TryParseIntCell(ColumnName.Id, rowIndex, out var symptomId))
                return;

            var symptomName = _dataGridViewService.GetCellValue(ColumnName.Name, rowIndex);

            if (!MessageBoxService.ShowDeleteQuestion($@"Are you sure you want to delete Symptom '{symptomName}'?"))
                return;

            await _symptomsService.DeleteByIdAsync(symptomId);
            await RefreshDataViewGridAsync();
        }

        private async void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchName = SearchTextBox.Text;
            await RefreshDataViewGridAsync();
        }

        private void DiseasesButton_Click(object sender, EventArgs e)
        {
            if (!_dataGridViewService.TryGetSelectedCellIndices(out _, out var selectedRowIndex, true))
                return;

            if (!_dataGridViewService.TryParseIntCell(ColumnName.Id, selectedRowIndex, out var symptomId))
                return;
            
            var relationForm = new DiseasesSymptomsForm(null,
                symptomId,
                _diseasesSymptomsService,
                _diseasesService,
                _symptomsService);
            
            Navigation.Push(relationForm);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Navigation.Pop();
        }
    }
}