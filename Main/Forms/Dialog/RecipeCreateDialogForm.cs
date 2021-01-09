using System;
using System.Linq;
using System.Windows.Forms;
using PrihodkoCourse.Models;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms.Dialog
{
    public partial class RecipeCreateDialogForm : Form
    {
        private readonly ClientsService _clientsService;
        private readonly DiseasesService _diseasesService;
        private readonly RecipeCreator _recipeCreator;

        private Client ChosenClient { get; set; }
        private Disease ChosenDisease { get; set; }
        
        public Recipe DialogResultEntity { get; private set; }
        
        public RecipeCreateDialogForm(ClientsService clientsService,
            DiseasesService diseasesService,
            RecipeCreator recipeCreator)
        {
            _clientsService = clientsService;
            _diseasesService = diseasesService;
            _recipeCreator = recipeCreator;
            
            InitializeComponent();
        }

        private void ClientChooseButton_Click(object sender, EventArgs e)
        {
            var clientChooseDialogForm = new ClientChooseDialogForm(_clientsService);
            
            var dialogResult = clientChooseDialogForm.ShowDialog(this);
            if (dialogResult != DialogResult.OK)
                return;
            
            ChosenClient = clientChooseDialogForm.DialogResultEntity;

            ClientTextBox.Text = ChosenClient.FullName;
        }

        private void DiseaseChooseButton_Click(object sender, EventArgs e)
        {
            var diseaseChooseDialogForm = new DiseaseChooseDialogForm(_diseasesService);
            
            var dialogResult = diseaseChooseDialogForm.ShowDialog(this);
            if (dialogResult != DialogResult.OK)
                return;
            
            ChosenDisease = diseaseChooseDialogForm.DialogResultEntity;

            DiseaseTextBox.Text = ChosenDisease.Name;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private async void CreateRecipeButton_Click(object sender, EventArgs e)
        {
            if (ChosenClient == null)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("You should select Client before this.");
                return;
            }
            
            if (ChosenDisease == null)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("You should select Disease before this.");
                return;
            }

            var recipeMedicaments = (await _recipeCreator.GetExistingMedicamentsListByDiseaseAndClientAsync(
                ChosenDisease,
                ChosenClient.Age))?.ToList();

            if (recipeMedicaments == null)
            {
                MessageBoxService.ShowStockWarning("Not enough medicaments in stock.");

                return;
            }
            
            var finishForm = new RecipeCreateFinishDialogForm(recipeMedicaments);
            
            var dialogResult = finishForm.ShowDialog(this);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    DialogResultEntity = new Recipe
                    {
                        ClientId = ChosenClient.Id,
                        Date = DateTime.Now,
                        DiseaseId = ChosenDisease.Id,
                        RecipeMedicaments = recipeMedicaments
                    };
                    DialogResult = DialogResult.OK;
                    break;
                case DialogResult.No:
                    DialogResult = DialogResult.Cancel;
                    break;
            }
        }
    }
}
