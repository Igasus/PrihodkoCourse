using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrihodkoCourse.Models;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms.Dialog
{
    public partial class DiseaseSymptomCreateDialogForm : Form
    {
        private readonly DiseasesService _diseasesService;
        private readonly SymptomsService _symptomsService;

        private int SelectedDiseaseId { get; set; }
        private int SelectedSymptomId { get; set; }
        public DiseaseSymptom DialogResultEntity { get; private set; }

        public DiseaseSymptomCreateDialogForm(int? initialDiseaseId,
            int? initialSymptomId,
            DiseasesService diseasesService,
            SymptomsService symptomsService)
        {
            _diseasesService = diseasesService;
            _symptomsService = symptomsService;

            SelectedDiseaseId = initialDiseaseId ?? -1;
            SelectedSymptomId = initialSymptomId ?? -1;

            InitializeComponent();
        }

        private async void DiseaseSymptomCreateDialogForm_Load(object sender, EventArgs e)
        {
            await InitComboBoxesAsync();
        }

        private async Task InitComboBoxesAsync()
        {
            var diseasesList = (await _diseasesService.ReadListAsync("")).ToList();
            var symptomsList = (await _symptomsService.ReadListAsync("")).ToList();

            var initialDisease = diseasesList.FirstOrDefault(disease => disease.Id == SelectedDiseaseId);
            var initialSymptom = symptomsList.FirstOrDefault(symptom => symptom.Id == SelectedSymptomId);

            if (initialDisease == null && initialSymptom == null)
            {
                var diseaseComboBoxItems = diseasesList.Select(disease => $"{disease.Id}: {disease.Name}").ToArray();
                DiseaseComboBox.Items.AddRange(diseaseComboBoxItems);
                DiseaseComboBox.Enabled = true;

                var symptomComboBoxItems = symptomsList.Select(symptom => $"{symptom.Id}: {symptom.Name}").ToArray();
                SymptomComboBox.Items.AddRange(symptomComboBoxItems);
                SymptomComboBox.Enabled = true;
            }
            
            if (initialDisease != null && initialSymptom == null)
            {
                DiseaseComboBox.Items.Insert(0, $"{initialDisease.Id}: {initialDisease.Name}");
                DiseaseComboBox.SelectedIndex = 0;
                DiseaseComboBox.Enabled = false;

                var symptomComboBoxItems = symptomsList
                    .Where(symptom =>
                        symptom.SymptomDiseases.All(relation => relation.DiseaseId != SelectedDiseaseId))
                    .Select(symptom => $@"{symptom.Id}: {symptom.Name}")
                    .ToArray();
                SymptomComboBox.Items.AddRange(symptomComboBoxItems);
                SymptomComboBox.Enabled = true;
            }

            if (initialDisease == null && initialSymptom != null)
            {
                var diseaseComboBoxItems = diseasesList
                    .Where(disease =>
                        disease.DiseaseSymptoms.All(relation => relation.SymptomId != SelectedSymptomId))
                    .Select(disease => $"{disease.Id}: {disease.Name}")
                    .ToArray();
                DiseaseComboBox.Items.AddRange(diseaseComboBoxItems);
                DiseaseComboBox.Enabled = true;
                
                SymptomComboBox.Items.Insert(0, $"{initialSymptom.Id}: {initialSymptom.Name}");
                SymptomComboBox.SelectedIndex = 0;
                SymptomComboBox.Enabled = false;
            }

            if (initialDisease != null && initialSymptom != null)
            {
                DiseaseComboBox.Items.Insert(0, $"{initialDisease.Id}: {initialDisease.Name}");
                DiseaseComboBox.SelectedIndex = 0;
                DiseaseComboBox.Enabled = false;
                
                SymptomComboBox.Items.Insert(0, $"{initialSymptom.Id}: {initialSymptom.Name}");
                SymptomComboBox.SelectedIndex = 0;
                SymptomComboBox.Enabled = false;
            }
        }

        private void DiseaseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedDiseaseId = Convert.ToInt32(((string) DiseaseComboBox.SelectedItem).Split(':')[0]);
        }

        private void SymptomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSymptomId = Convert.ToInt32(((string) SymptomComboBox.SelectedItem).Split(':')[0]);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DialogResultEntity = new DiseaseSymptom
            {
                DiseaseId = SelectedDiseaseId,
                SymptomId = SelectedSymptomId
            };

            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}