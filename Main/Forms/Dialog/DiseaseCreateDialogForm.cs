using System.Windows.Forms;
using PrihodkoCourse.Models;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms.Dialog
{
    public partial class DiseaseCreateDialogForm : Form
    {
        public Disease DialogResultEntity { get; private set; }
        
        public DiseaseCreateDialogForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, System.EventArgs e)
        {
            var name = NameTextBox.Text;
            
            if (string.IsNullOrEmpty(name))
            {
                MessageBoxService.ShowIncorrectInputWarning("Field 'Name' must not be empty.");
                return;
            }
            
            DialogResultEntity = new Disease
            {
                Name = name
            };

            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}