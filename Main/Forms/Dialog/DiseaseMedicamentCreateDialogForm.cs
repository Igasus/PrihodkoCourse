using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrihodkoCourse.Models;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms.Dialog
{
    public partial class DiseaseMedicamentCreateDialogForm : Form
    {
        private readonly DiseasesService _diseasesService;
        private readonly MedicamentsService _medicamentsService;

        private int SelectedDiseaseId { get; set; }
        private int SelectedMedicamentId { get; set; }
        public DiseaseMedicament DialogResultEntity { get; private set; }

        public DiseaseMedicamentCreateDialogForm(int? initialDiseaseId,
            int? initialMedicamentId,
            DiseasesService diseasesService,
            MedicamentsService medicamentsService)
        {
            _diseasesService = diseasesService;
            _medicamentsService = medicamentsService;

            SelectedDiseaseId = initialDiseaseId ?? -1;
            SelectedMedicamentId = initialMedicamentId ?? -1;

            InitializeComponent();
        }

        private async void DiseaseMedicamentCreateDialogForm_Load(object sender, EventArgs e)
        {
            await InitComboBoxesAsync();
        }

        private async Task InitComboBoxesAsync()
        {
            var diseasesList = (await _diseasesService.ReadListAsync("")).ToList();
            var medicamentsList = (await _medicamentsService.ReadListAsync("")).ToList();

            var initialDisease = diseasesList.FirstOrDefault(disease => disease.Id == SelectedDiseaseId);
            var initialMedicament = medicamentsList.FirstOrDefault(medicament => medicament.Id == SelectedMedicamentId);

            if (initialDisease == null && initialMedicament == null)
            {
                var diseaseComboBoxItems = diseasesList.Select(disease => $"{disease.Id}: {disease.Name}").ToArray();
                DiseaseComboBox.Items.AddRange(diseaseComboBoxItems);
                DiseaseComboBox.Enabled = true;

                var medicamentComboBoxItems = medicamentsList.Select(medicament => $"{medicament.Id}: {medicament.Name}").ToArray();
                MedicamentComboBox.Items.AddRange(medicamentComboBoxItems);
                MedicamentComboBox.Enabled = true;
            }
            
            if (initialDisease != null && initialMedicament == null)
            {
                DiseaseComboBox.Items.Insert(0, $"{initialDisease.Id}: {initialDisease.Name}");
                DiseaseComboBox.SelectedIndex = 0;
                DiseaseComboBox.Enabled = false;

                var medicamentComboBoxItems = medicamentsList
                    .Where(medicament =>
                        medicament.MedicamentDiseases.All(relation => relation.DiseaseId != SelectedDiseaseId))
                    .Select(medicament => $"{medicament.Id}: {medicament.Name}")
                    .ToArray();
                MedicamentComboBox.Items.AddRange(medicamentComboBoxItems);
                MedicamentComboBox.Enabled = true;
            }

            if (initialDisease == null && initialMedicament != null)
            {
                var diseaseComboBoxItems = diseasesList
                    .Where(disease =>
                        disease.DiseaseMedicaments.All(relation => relation.MedicamentId != SelectedMedicamentId))
                    .Select(disease => $"{disease.Id}: {disease.Name}")
                    .ToArray();
                DiseaseComboBox.Items.AddRange(diseaseComboBoxItems);
                DiseaseComboBox.Enabled = true;
                
                MedicamentComboBox.Items.Insert(0, $"{initialMedicament.Id}: {initialMedicament.Name}");
                MedicamentComboBox.SelectedIndex = 0;
                MedicamentComboBox.Enabled = false;
            }

            if (initialDisease != null && initialMedicament != null)
            {
                DiseaseComboBox.Items.Insert(0, $"{initialDisease.Id}: {initialDisease.Name}");
                DiseaseComboBox.SelectedIndex = 0;
                DiseaseComboBox.Enabled = false;
                
                MedicamentComboBox.SelectedItem = $"{initialMedicament.Id}: {initialMedicament.Name}";
                MedicamentComboBox.SelectedIndex = 0;
                MedicamentComboBox.Enabled = false;
            }
        }

        private void DiseaseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedDiseaseId = Convert.ToInt32(((string) DiseaseComboBox.SelectedItem).Split(':')[0]);
        }

        private void MedicamentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedMedicamentId = Convert.ToInt32(((string) MedicamentComboBox.SelectedItem).Split(':')[0]);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DialogResultEntity = new DiseaseMedicament
            {
                DiseaseId = SelectedDiseaseId,
                MedicamentId = SelectedMedicamentId
            };

            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
