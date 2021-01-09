using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PrihodkoCourse.Models;

namespace PrihodkoCourse.Forms.Dialog
{
    public partial class RecipeCreateFinishDialogForm : Form
    {
        private IEnumerable<RecipeMedicament> _recipeMedicaments;
        
        public RecipeCreateFinishDialogForm(IEnumerable<RecipeMedicament> recipeMedicaments)
        {
            _recipeMedicaments = recipeMedicaments;
            
            InitializeComponent();
        }

        public void InitMedicamentsDataGridView()
        {
            foreach (var recipeMedicament in _recipeMedicaments)
                MedicamentsDataGridView.Rows.Add(recipeMedicament.MedicamentId,
                    recipeMedicament.Medicament.Name,
                    recipeMedicament.Dose);
        }

        private void RecipeCreateFinishDialogForm_Load(object sender, EventArgs e)
        {
            InitMedicamentsDataGridView();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
    }
}