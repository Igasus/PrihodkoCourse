using System;
using System.Windows.Forms;
using PrihodkoCourse.Models;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms.Dialog
{
    public partial class DosageCreateDialogForm : Form
    {
        private readonly DiseaseMedicament _diseaseMedicament;
        
        public Dosage DialogResultEntity { get; private set; }
        
        public DosageCreateDialogForm(DiseaseMedicament diseaseMedicament)
        {
            _diseaseMedicament = diseaseMedicament;
            
            InitializeComponent();
        }

        private void DosageCreateDialogForm_Load(object sender, EventArgs e)
        {
            DiseaseNameTextBox.Text = _diseaseMedicament.Disease.Name;
            MedicamentNameTextBox.Text = _diseaseMedicament.Medicament.Name;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int minAge;

            try
            {
                minAge = Convert.ToInt32(MinAgeTextBox.Text);
            }
            catch (Exception)
            {
                MessageBoxService.ShowIncorrectInputWarning("Minimum age must be int type value.");
                return;
            }

            if (minAge < 0)
            {
                MessageBoxService.ShowIncorrectInputWarning("Minimum age must be greater or equal than '0'.");
                return;
            }

            double dose;

            try
            {
                dose = Convert.ToDouble(DoseTextBox.Text);
            }
            catch (Exception)
            {
                MessageBoxService.ShowIncorrectInputWarning("Dose must be double type value.");
                return;
            }

            if (dose <= 0)
            {
                MessageBoxService.ShowIncorrectInputWarning("Dose must be greater than '0'.");
                return;
            }
            
            DialogResultEntity = new Dosage
            {
                DiseaseMedicamentId = _diseaseMedicament.Id,
                MinAge = minAge,
                Dose = dose
            };

            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
