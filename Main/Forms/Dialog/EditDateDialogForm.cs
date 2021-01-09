using System;
using System.Windows.Forms;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms.Dialog
{
    public partial class EditDateDialogForm : Form
    {
        private readonly DateTime _oldValue;

        public DateTime NewValue { get; private set; }
        
        public EditDateDialogForm(DateTime oldValue)
        {
            _oldValue = oldValue;
            
            InitializeComponent();
        }

        private void EditDateDialogForm_Load(object sender, EventArgs e)
        {
            OldValueTextBox.Text = _oldValue.ToShortDateString();
            NewValueCalendar.SelectionStart = _oldValue;
            NewValueCalendar.SelectionEnd = _oldValue;
        }

        private void NewValueCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            NewValue = NewValueCalendar.SelectionStart;
            NewValueTextBox.Text = NewValue.ToShortDateString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (NewValue == default)
            {
                MessageBoxService.ShowIncorrectInputWarning("Input value must not be empty.");
                return;
            }
            
            DialogResult = DialogResult.OK;
        }
    }
}
