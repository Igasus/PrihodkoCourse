using System;
using System.Windows.Forms;
using PrihodkoCourse.Models;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms.Dialog
{
    public partial class ClientCreateDialogForm : Form
    {
        public Client DialogResultEntity { get; private set; }
        
        public ClientCreateDialogForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var sex = SexTextBox.Text;
            var fullName = FullNameTextBox.Text;
            var phoneNumber = PhoneNumberTextBox.Text;
            var insurancePolicyNumber = InsurancePolicyNumberTextBox.Text;
            
            if (string.IsNullOrEmpty(sex) ||
                string.IsNullOrEmpty(fullName) ||
                string.IsNullOrEmpty(phoneNumber) ||
                string.IsNullOrEmpty(insurancePolicyNumber))
            {
                MessageBoxService.ShowIncorrectInputWarning("All fields must not be empty.");
                return;
            }

            int age;

            try
            {
                age = Convert.ToInt32(AgeTextBox.Text);
            }
            catch (Exception)
            {
                MessageBoxService.ShowIncorrectInputWarning("'Age' is 'int' type field.");

                return;
            }
            
            DialogResultEntity = new Client
            {
                Sex = sex,
                Age = age,
                FullName = fullName,
                PhoneNumber = phoneNumber,
                InsurancePolicyNumber = insurancePolicyNumber
            };

            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
