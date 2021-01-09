using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrihodkoCourse.Forms.Dialog;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms
{
    public partial class DiseasesForm : Form
    {
        private static class ColumnName
        {
            public const string Id = "IdColumn";
            public const string Name = "NameColumn";
        }
        
        private readonly DiseasesService _diseasesService;
        private readonly DataGridViewService _dataGridViewService;
        
        private readonly DiseasesMedicamentsService _diseasesMedicamentsService;
        private readonly DiseasesSymptomsService _diseasesSymptomsService;
        private readonly MedicamentsService _medicamentsService;
        private readonly SymptomsService _symptomsService;
        private readonly DosagesService _dosagesService;

        private string SearchName { get; set; } = "";
        
        public DiseasesForm(DiseasesService diseasesService,
            DiseasesMedicamentsService diseasesMedicamentsService,
            DiseasesSymptomsService diseasesSymptomsService,
            MedicamentsService medicamentsService,
            SymptomsService symptomsService,
            DosagesService dosagesService)
        {
            _diseasesService = diseasesService;
            
            _diseasesMedicamentsService = diseasesMedicamentsService;
            _diseasesSymptomsService = diseasesSymptomsService;
            _medicamentsService = medicamentsService;
            _symptomsService = symptomsService;
            _dosagesService = dosagesService;
            
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

        private async void DiseasesForm_Load(object sender, EventArgs e)
        {
            await RefreshDataViewGridAsync();
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            using var createForm = new DiseaseCreateDialogForm();
            
            var dialogResult = createForm.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                var createModel = createForm.DialogResultEntity;
                await _diseasesService.CreateAsync(createModel);
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
            
            if (!_dataGridViewService.TryParseIntCell(ColumnName.Id, rowIndex, out var diseaseId))
                return;
            var disease = await _diseasesService.ReadByIdAsync(diseaseId);

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
                    disease.Name = newValue;
                    break;
                default:
                    MessageBox.Show(@"Unknown field.",
                        @"Check database and debug code.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
            }

            await _diseasesService.UpdateAsync(disease);
            await RefreshDataViewGridAsync();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!_dataGridViewService.TryGetSelectedCellIndices(out _, out var rowIndex, true) ||
                !_dataGridViewService.TryParseIntCell(ColumnName.Id, rowIndex, out var diseaseId))
                return;
            
            var diseaseName = _dataGridViewService.GetCellValue(ColumnName.Name, rowIndex);

            if (!MessageBoxService.ShowDeleteQuestion($@"Are you sure you want to delete Disease '{diseaseName}'?"))
                return;

            await _diseasesService.DeleteByIdAsync(diseaseId);
            await RefreshDataViewGridAsync();
        }

        private async void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchName = SearchTextBox.Text;
            
            await RefreshDataViewGridAsync();
        }

        private void SymptomsButton_Click(object sender, EventArgs e)
        {
            if (!_dataGridViewService.TryGetSelectedCellIndices(out _, out var selectedRowIndex, true) ||
                !_dataGridViewService.TryParseIntCell(ColumnName.Id, selectedRowIndex, out var diseaseId))
                return;
            
            var relationForm = new DiseasesSymptomsForm(diseaseId,
                null,
                _diseasesSymptomsService,
                _diseasesService,
                _symptomsService);
            
            Navigation.Push(relationForm);
        }

        private void MedicamentsButton_Click(object sender, EventArgs e)
        {
            if (!_dataGridViewService.TryGetSelectedCellIndices(out _, out var selectedRowIndex, true) ||
                !_dataGridViewService.TryParseIntCell(ColumnName.Id, selectedRowIndex, out var diseaseId))
                return;
            
            var relationForm = new DiseasesMedicamentsForm(diseaseId,
                null,
                _diseasesMedicamentsService,
                _diseasesService,
                _medicamentsService,
                _dosagesService);
            
            Navigation.Push(relationForm);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Navigation.Pop();
        }
    }
}