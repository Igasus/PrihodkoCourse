using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrihodkoCourse.Forms.Dialog;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms
{
    public partial class DiseasesMedicamentsForm : Form
    {
        private static class ColumnName
        {
            public const string Id = "IdColumn";
            public const string DiseaseId = "DiseaseIdColumn";
            public const string DiseaseName = "DiseaseNameColumn";
            public const string MedicamentId = "MedicamentIdColumn";
            public const string MedicamentName = "MedicamentNameColumn";
        }

        private readonly int? _initialDiseaseId;
        private readonly int? _initialMedicamentId;
        private readonly DiseasesMedicamentsService _diseasesMedicamentsService;
        private readonly DataGridViewService _dataGridViewService;
        
        private readonly DiseasesService _diseasesService;
        private readonly MedicamentsService _medicamentsService;
        private readonly DosagesService _dosagesService;

        private string SearchDiseaseName { get; set; } = "";
        private string SearchMedicamentName { get; set; } = "";
        
        public DiseasesMedicamentsForm(int? diseaseId,
            int? medicamentId,
            DiseasesMedicamentsService diseasesMedicamentsService,
            DiseasesService diseasesService,
            MedicamentsService medicamentsService,
            DosagesService dosagesService)
        {
            _initialDiseaseId = diseaseId;
            _initialMedicamentId = medicamentId;

            _diseasesMedicamentsService = diseasesMedicamentsService;
            _diseasesService = diseasesService;
            _medicamentsService = medicamentsService;
            _dosagesService = dosagesService;
            
            InitializeComponent();
            
            _dataGridViewService = new DataGridViewService(DiseasesMedicamentsDataGridView);
        }

        private async void DiseasesMedicamentsForm_Load(object sender, EventArgs e)
        {
            await RefreshDataViewGridAsync();
        }

        private async Task RefreshDataViewGridAsync()
        {
            var list = await _diseasesMedicamentsService.ReadListAsync(_initialDiseaseId,
                _initialMedicamentId,
                SearchDiseaseName,
                SearchMedicamentName);
            
            _dataGridViewService.Clear();
            foreach (var diseaseMedicament in list)
                _dataGridViewService.AddRow(diseaseMedicament.Id,
                    diseaseMedicament.DiseaseId,
                    diseaseMedicament.Disease.Name,
                    diseaseMedicament.MedicamentId,
                    diseaseMedicament.Medicament.Name);
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            var createForm = new DiseaseMedicamentCreateDialogForm(_initialDiseaseId,
                _initialMedicamentId,
                _diseasesService,
                _medicamentsService);
            
            var dialogResult = createForm.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                var createModel = createForm.DialogResultEntity;
                await _diseasesMedicamentsService.CreateRelationAsync(createModel.DiseaseId, createModel.MedicamentId);
                await RefreshDataViewGridAsync();
            }
            
            createForm.Close();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!_dataGridViewService.TryGetSelectedCellIndices(out _, out var rowIndex, true) ||
                !_dataGridViewService.TryParseIntCell(ColumnName.Id, rowIndex, out var modelId))
                return;
            
            var dataGridViewData = new
            {
                DiseaseName = _dataGridViewService.GetCellValue(ColumnName.DiseaseName, rowIndex),
                MedicamentName = _dataGridViewService.GetCellValue(ColumnName.MedicamentName, rowIndex)
            };

            if (!MessageBoxService.ShowDeleteQuestion(@"Are you sure you want to delete relation between " +
                $@"Disease '{dataGridViewData.DiseaseName}' and Medicament '{dataGridViewData.MedicamentName}'?"))
                return;

            await _diseasesMedicamentsService.DeleteRelationByIdAsync(modelId);
            await RefreshDataViewGridAsync();
        }

        private async void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_initialDiseaseId != null)
                SearchDiseaseName = SearchTextBox.Text;

            if (_initialMedicamentId != null)
                SearchMedicamentName = SearchTextBox.Text;
            
            await RefreshDataViewGridAsync();
        }

        private async void DosagesButton_Click(object sender, EventArgs e)
        {
            if (!_dataGridViewService.TryGetSelectedCellIndices(out _, out var rowIndex, true) ||
                !_dataGridViewService.TryParseIntCell(ColumnName.Id, rowIndex, out var relationModelId))
                return;

            var diseaseMedicament = await _diseasesMedicamentsService.ReadByIdAsync(relationModelId);
            
            var dosagesForm = new DosagesForm(diseaseMedicament, _dosagesService);

            Navigation.Push(dosagesForm);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Navigation.Pop();
        }
    }
}
