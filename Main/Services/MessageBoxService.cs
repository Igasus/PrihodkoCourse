using System.Windows.Forms;

namespace PrihodkoCourse.Services
{
    public static class MessageBoxService
    {
        public static bool ShowDeleteQuestion(string message)
        {
            var submitResult = MessageBox.Show(message,
                @"Submit deletion.",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return submitResult == DialogResult.Yes;
        }

        public static void ShowIncorrectSelectionWarning(string message)
        {
            MessageBox.Show(message, @"Incorrect selection.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowIncorrectInputWarning(string message)
        {
            MessageBox.Show(message, @"Incorrect input data.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowStockWarning(string message)
        {
            MessageBox.Show(message, @"Stock warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowDeleteWarning(string message)
        {
            MessageBox.Show(message, @"Deletion warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}