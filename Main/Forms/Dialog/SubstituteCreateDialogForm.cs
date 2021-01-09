using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrihodkoCourse.Models;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms.Dialog
{
    public partial class SubstituteCreateDialogForm : Form
    {
        private readonly MedicamentsService _medicamentsService;

        private int SelectedOriginalMedicamentId { get; set; }
        private int SelectedSubstituteMedicamentId { get; set; }
        public Substitute DialogResultEntity { get; private set; }

        public SubstituteCreateDialogForm(int? initialOriginalMedicamentId,
            int? initialSubstituteMedicamentId,
            MedicamentsService medicamentsService)
        {
            _medicamentsService = medicamentsService;

            SelectedOriginalMedicamentId = initialOriginalMedicamentId ?? -1;
            SelectedSubstituteMedicamentId = initialSubstituteMedicamentId ?? -1;

            InitializeComponent();
        }

        private async void SubstituteCreateDialogForm_Load(object sender, EventArgs e)
        {
            await InitComboBoxesAsync();
        }

        private async Task InitComboBoxesAsync()
        {
            var originalMedicamentsList = (await _medicamentsService.ReadListAsync("")).ToList();
            var substituteMedicamentsList = (await _medicamentsService.ReadListAsync("")).ToList();

            var initialOriginalMedicament = originalMedicamentsList.FirstOrDefault(medicament =>
                medicament.Id == SelectedOriginalMedicamentId);
            var initialSubstituteMedicament = substituteMedicamentsList.FirstOrDefault(medicament =>
                medicament.Id == SelectedSubstituteMedicamentId);

            if (initialOriginalMedicament == null && initialSubstituteMedicament == null)
            {
                var originalComboBoxItems = originalMedicamentsList
                    .Select(medicament => $"{medicament.Id}: {medicament.Name}")
                    .ToArray();
                OriginalComboBox.Items.AddRange(originalComboBoxItems);
                OriginalComboBox.Enabled = true;

                var substituteComboBoxItems = substituteMedicamentsList
                    .Select(medicament => $"{medicament.Id}: {medicament.Name}")
                    .ToArray();
                SubstituteComboBox.Items.AddRange(substituteComboBoxItems);
                SubstituteComboBox.Enabled = true;
            }
            
            if (initialOriginalMedicament != null && initialSubstituteMedicament == null)
            {
                OriginalComboBox.Items.Insert(0, $"{initialOriginalMedicament.Id}: {initialOriginalMedicament.Name}");
                OriginalComboBox.SelectedIndex = 0;
                OriginalComboBox.Enabled = false;

                var substituteComboBoxItems = substituteMedicamentsList
                    .Where(substituteMedicament =>
                        substituteMedicament.Id != SelectedOriginalMedicamentId &&
                        substituteMedicament.SubstituteOfMedicaments.All(substitute =>
                            substitute.OriginalMedicamentId != SelectedOriginalMedicamentId))
                    .Select(medicament => $@"{medicament.Id}: {medicament.Name}")
                    .ToArray();
                SubstituteComboBox.Items.AddRange(substituteComboBoxItems);
                SubstituteComboBox.Enabled = true;
            }

            if (initialOriginalMedicament == null && initialSubstituteMedicament != null)
            {
                var originalComboBoxItems = originalMedicamentsList
                    .Where(originalMedicament =>
                        originalMedicament.Id != SelectedSubstituteMedicamentId &&
                        originalMedicament.MedicamentSubstitutes.All(substitute =>
                            substitute.SubstituteMedicamentId != SelectedSubstituteMedicamentId))
                    .Select(medicament => $"{medicament.Id}: {medicament.Name}")
                    .ToArray();
                OriginalComboBox.Items.AddRange(originalComboBoxItems);
                OriginalComboBox.Enabled = true;
                
                SubstituteComboBox.Items.Insert(0, $"{initialSubstituteMedicament.Id}: {initialSubstituteMedicament.Name}");
                SubstituteComboBox.SelectedIndex = 0;
                SubstituteComboBox.Enabled = false;
            }

            if (initialOriginalMedicament != null && initialSubstituteMedicament != null)
            {
                OriginalComboBox.Items.Insert(0, $"{initialOriginalMedicament.Id}: {initialOriginalMedicament.Name}");
                OriginalComboBox.SelectedIndex = 0;
                OriginalComboBox.Enabled = false;
                
                SubstituteComboBox.Items.Insert(0, $"{initialSubstituteMedicament.Id}: {initialSubstituteMedicament.Name}");
                SubstituteComboBox.SelectedIndex = 0;
                SubstituteComboBox.Enabled = false;
            }
        }

        private void OriginalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedOriginalMedicamentId = Convert.ToInt32(((string) OriginalComboBox.SelectedItem)
                .Split(':')[0]);
        }

        private void SubstituteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSubstituteMedicamentId = Convert.ToInt32(((string) SubstituteComboBox.SelectedItem)
                .Split(':')[0]);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            float dosageMultiplier;
            try
            {
                dosageMultiplier = (float) Convert.ToDouble(DosageMultiplierTextBox.Text);
            }
            catch (Exception)
            {
                MessageBoxService.ShowIncorrectInputWarning(
                    "Make sure you entered float type value into the 'Dosage multiplier' field.");
                return;
            }

            DialogResultEntity = new Substitute
            {
                OriginalMedicamentId = SelectedOriginalMedicamentId,
                SubstituteMedicamentId = SelectedSubstituteMedicamentId,
                DosageMultiplier = dosageMultiplier
            };

            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}