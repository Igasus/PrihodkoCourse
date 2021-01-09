using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PrihodkoCourse
{
    public static class Navigation
    {
        private static readonly List<Form> Stack = new List<Form>();

        public static void Refresh(Form initialForm)
        {
            Stack.Clear();
            Stack.Add(initialForm); 
        }

        public static void Push(Form form)
        {
            var lastForm = Stack.Last();
            lastForm.Hide();

            //TODO: Add processing on 'X' Press to close form.
            Stack.Add(form);
            form.Show(lastForm);
        }

        public static void Pop()
        {
            Stack.Last().Close();
            Stack.Remove(Stack.Last());
            Stack.Last().Show();
        }
    }
}