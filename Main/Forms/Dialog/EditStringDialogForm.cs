using System.Windows.Forms;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms.Dialog
{
    public partial class EditStringDialogForm : Form
    {
        private readonly string _oldValue;
        
        public string NewValue { get; private set; }
        
        public EditStringDialogForm(string oldValue)
        {
            _oldValue = oldValue;
            
            InitializeComponent();
        }

        private void EditDialogForm_Load(object sender, System.EventArgs e)
        {
            OldValueTextBox.Text = _oldValue;
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SubmitButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(NewValueTextBox.Text))
            {
                MessageBoxService.ShowIncorrectInputWarning("Input value must not be empty.");
                return;
            }

            NewValue = NewValueTextBox.Text;
            
            DialogResult = DialogResult.OK;
        }
    }
}