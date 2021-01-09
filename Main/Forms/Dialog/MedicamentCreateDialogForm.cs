using System;
using System.Windows.Forms;
using PrihodkoCourse.Models;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms.Dialog
{
    public partial class MedicamentCreateDialogForm : Form
    {
        public Medicament DialogResultEntity { get; private set; }
        
        public MedicamentCreateDialogForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var name = NameTextBox.Text;
            
            if (string.IsNullOrEmpty(name))
            {
                MessageBoxService.ShowIncorrectInputWarning("Field 'Name' must not be empty.");
                return;
            }

            double stockQuantity;
            
            try
            {
                stockQuantity = Convert.ToDouble(StockQuantityTextBox.Text);
            }
            catch (Exception)
            {
                MessageBoxService.ShowIncorrectInputWarning("Field 'StockQuantity' must have value of type double.");
                return;
            }

            if (stockQuantity < 0)
            {
                MessageBoxService.ShowIncorrectInputWarning("Field 'StockQuantity' must not be less than 0.");
                return;
            }
            
            DialogResultEntity = new Medicament
            {
                Name = name,
                StockQuantity = stockQuantity
            };
            
            DialogResult = DialogResult.OK;
        }
    }
}
