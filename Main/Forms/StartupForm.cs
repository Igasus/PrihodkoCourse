using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace PrihodkoCourse.Forms
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }
        
        private void SymptomsButton_Click(object sender, EventArgs e)
        {
            var symptomsForm = ServiceProviderFactory.ServiceProvider.GetService<SymptomsForm>();
            Navigation.Push(symptomsForm);
        }

        private void DiseasesButton_Click(object sender, EventArgs e)
        {
            var diseasesForm = ServiceProviderFactory.ServiceProvider.GetService<DiseasesForm>();
            Navigation.Push(diseasesForm);
        }

        private void MedicamentsButton_Click(object sender, EventArgs e)
        {
            var medicamentsForm = ServiceProviderFactory.ServiceProvider.GetService<MedicamentsForm>();
            Navigation.Push(medicamentsForm);
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            var clientsForm = ServiceProviderFactory.ServiceProvider.GetService<ClientsForm>();
            Navigation.Push(clientsForm);
        }

        private void RecipesButton_Click(object sender, EventArgs e)
        {
            var recipesForm = ServiceProviderFactory.ServiceProvider.GetService<RecipesForm>();
            Navigation.Push(recipesForm);
        }
    }
}
