using System.Windows.Forms;
using PrihodkoCourse.Models;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms.Dialog
{
    public partial class SymptomCreateDialogForm : Form
    {
        public Symptom DialogResultEntity { get; private set; }
        
        public SymptomCreateDialogForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SubmitButton_Click(object sender, System.EventArgs e)
        {
            var name = NameTextBox.Text;
            
            if (string.IsNullOrEmpty(name))
            {
                MessageBoxService.ShowIncorrectInputWarning("Field 'Name' must not be empty.");
                return;
            }
            
            DialogResultEntity = new Symptom
            {
                Name = name
            };
            
            DialogResult = DialogResult.OK;
        }
    }
}