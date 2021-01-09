using System;
using System.Windows.Forms;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms.Dialog
{
    public partial class EditIntDialogForm : Form
    {
        private readonly double _oldValue;
        
        public int NewValue { get; private set; }
        
        public EditIntDialogForm(int oldValue)
        {
            _oldValue = oldValue;
            
            InitializeComponent();
        }

        private void EditIntDialogForm_Load(object sender, EventArgs e)
        {
            OldValueTextBox.Text = _oldValue.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                NewValue = Convert.ToInt32(NewValueTextBox.Text);
            }
            catch (Exception)
            {
                MessageBoxService.ShowIncorrectInputWarning("New value must be of type int.");
                return;
            }
            
            DialogResult = DialogResult.OK;
        }
    }
}
