using System;
using System.Windows.Forms;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms.Dialog
{
    public partial class EditDoubleDialogForm : Form
    {
        private readonly double _oldValue;
        
        public double NewValue { get; private set; }
        
        public EditDoubleDialogForm(double oldValue)
        {
            _oldValue = oldValue;
            
            InitializeComponent();
        }

        private void EditDoubleDialogForm_Load(object sender, EventArgs e)
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
                NewValue = Convert.ToDouble(NewValueTextBox.Text);
            }
            catch (Exception)
            {
                MessageBoxService.ShowIncorrectInputWarning("New value must be of type double.");
                return;
            }
            
            DialogResult = DialogResult.OK;
        }
    }
}
