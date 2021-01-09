using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrihodkoCourse.Forms.Dialog;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms
{
    public partial class DiseasesSymptomsForm : Form
    {
        private static class ColumnName
        {
            public const string DiseaseId = "DiseaseIdColumn";
            public const string DiseaseName = "DiseaseNameColumn";
            public const string SymptomId = "SymptomIdColumn";
            public const string SymptomName = "SymptomNameColumn";
        }
        
        private readonly int? _initialDiseaseId;
        private readonly int? _initialSymptomId;
        private readonly DiseasesSymptomsService _diseasesSymptomsService;
        private readonly DataGridViewService _dataGridViewService;
        
        private readonly DiseasesService _diseasesService;
        private readonly SymptomsService _symptomsService;

        private string SearchDiseaseName { get; set; } = "";
        private string SearchSymptomName { get; set; } = "";
        
        public DiseasesSymptomsForm(int? diseaseId,
            int? symptomId,
            DiseasesSymptomsService diseasesSymptomsService,
            DiseasesService diseasesService,
            SymptomsService symptomsService)
        {
            _initialDiseaseId = diseaseId;
            _initialSymptomId = symptomId;

            _diseasesSymptomsService = diseasesSymptomsService;
            _diseasesService = diseasesService;
            _symptomsService = symptomsService;

            InitializeComponent();
            
            _dataGridViewService = new DataGridViewService(DiseasesSymptomsDataGridView);
        }

        private async void DiseasesSymptomsForm_Load(object sender, EventArgs e)
        {
            await RefreshDataViewGridAsync();
        }

        private async Task RefreshDataViewGridAsync()
        {
            var list = await _diseasesSymptomsService.ReadListAsync(_initialDiseaseId,
                _initialSymptomId,
                SearchDiseaseName,
                SearchSymptomName);
            
            _dataGridViewService.Clear();
            foreach (var diseaseSymptom in list)
                _dataGridViewService.AddRow(diseaseSymptom.DiseaseId,
                    diseaseSymptom.Disease.Name,
                    diseaseSymptom.SymptomId,
                    diseaseSymptom.Symptom.Name);
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            var createForm = new DiseaseSymptomCreateDialogForm(_initialDiseaseId,
                _initialSymptomId,
                _diseasesService,
                _symptomsService);
            
            var dialogResult = createForm.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                var createModel = createForm.DialogResultEntity;
                await _diseasesSymptomsService.CreateRelationAsync(createModel.DiseaseId, createModel.SymptomId);
                await RefreshDataViewGridAsync();
            }
            
            createForm.Close();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!_dataGridViewService.TryGetSelectedCellIndices(out _, out var rowIndex, true) ||
                !_dataGridViewService.TryParseIntCell(ColumnName.DiseaseId, rowIndex, out var diseaseId) ||
                !_dataGridViewService.TryParseIntCell(ColumnName.SymptomId, rowIndex, out var symptomId))
                return;
            
            var dataGridViewData = new
            {
                DiseaseName = _dataGridViewService.GetCellValue(ColumnName.DiseaseName, rowIndex),
                SymptomName = _dataGridViewService.GetCellValue(ColumnName.SymptomName, rowIndex)
            };

            if (!MessageBoxService.ShowDeleteQuestion(@"Are you sure you want to delete relation between " +
                $@"Disease '{dataGridViewData.DiseaseName}' and Symptom '{dataGridViewData.SymptomName}'?"))
                return;

            await _diseasesSymptomsService.DeleteRelationByIdAsync(diseaseId, symptomId);
            await RefreshDataViewGridAsync();
        }

        private async void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_initialDiseaseId != null)
                SearchDiseaseName = SearchTextBox.Text;

            if (_initialSymptomId != null)
                SearchSymptomName = SearchTextBox.Text;
            
            await RefreshDataViewGridAsync();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Navigation.Pop();
        }
    }
}