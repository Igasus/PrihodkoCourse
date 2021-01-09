using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrihodkoCourse.Forms.Dialog;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms
{
    public partial class RecipesForm : Form
    {
        private static class ColumnName
        {
            public const string Id = "IdColumn";
            public const string ClientId = "ClientIdColumn";
            public const string ClientName = "ClientNameColumn";
            public const string DiseaseId = "DisaeseIdColumn";
            public const string DiseaseName = "DiseaseNameColumn";
            public const string Date = "DateColumn";
        }
        private readonly RecipesService _recipesService;
        private readonly RecipesMedicamentsService _recipesMedicamentsService;
        private readonly MedicamentsService _medicamentsService;
        private readonly DataGridViewService _recipesDataGridViewService;
        private readonly ClientsService _clientsService;
        private readonly DiseasesService _diseasesService;
        private readonly RecipeCreator _recipeCreator;

        private string SearchText { get; set; } = "";

        public RecipesForm(RecipesService recipesService,
            RecipesMedicamentsService recipesMedicamentsService,
            MedicamentsService medicamentsService,
            ClientsService clientsService,
            DiseasesService diseasesService,
            RecipeCreator recipeCreator)
        {
            _recipesService = recipesService;
            _recipesMedicamentsService = recipesMedicamentsService;
            _medicamentsService = medicamentsService;
            _clientsService = clientsService;
            _diseasesService = diseasesService;
            _recipeCreator = recipeCreator;
            
            InitializeComponent();
            
            _recipesDataGridViewService = new DataGridViewService(RecipesDataGridView);
        }

        public async Task RefreshRecipesDataGridViewAsync()
        {
            var recipesList = await _recipesService.ReadListAsync(SearchText);
            
            _recipesDataGridViewService.Clear();
            foreach (var recipe in recipesList)
                _recipesDataGridViewService.AddRow(recipe.Id,
                    recipe.ClientId,
                    recipe.Client.FullName,
                    recipe.DiseaseId,
                    recipe.Disease.Name,
                    recipe.Date.ToShortDateString());
        }

        private async void RecipesForm_Load(object sender, EventArgs e)
        {
            await RefreshRecipesDataGridViewAsync();
        }

        private async void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchText = SearchTextBox.Text;

            await RefreshRecipesDataGridViewAsync();
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            using var createForm = new RecipeCreateDialogForm(_clientsService, _diseasesService, _recipeCreator);
            
            var dialogResult = createForm.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                var createModel = createForm.DialogResultEntity;
                
                var recipeMedicaments = createModel.RecipeMedicaments.ToList();
                createModel.RecipeMedicaments = null;
                
                var recipe = await _recipesService.CreateAsync(createModel);
                foreach (var recipeMedicament in recipeMedicaments)
                {
                    recipeMedicament.RecipeId = recipe.Id;
                    await _recipesMedicamentsService.CreateRelationAsync(recipeMedicament);

                    var medicament = await _medicamentsService.ReadByIdAsync(recipeMedicament.MedicamentId);
                    medicament.StockQuantity -= recipeMedicament.Dose;
                    await _medicamentsService.UpdateAsync(medicament);
                }
                await RefreshRecipesDataGridViewAsync();
            }
            
            createForm.Close();
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            if (!_recipesDataGridViewService.TryGetSelectedCellIndices(out var columnIndex, out var rowIndex, true))
                return;
            
            if (columnIndex == -1)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("Select cell you want to edit.");
                return;
            }
            
            var columnName = _recipesDataGridViewService.GetColumnName(columnIndex);
            if (columnName == ColumnName.Id ||
                columnName == ColumnName.ClientId ||
                columnName == ColumnName.ClientName ||
                columnName == ColumnName.DiseaseId ||
                columnName == ColumnName.DiseaseName)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("You can't edit id.");
                return;
            }
            
            if (!_recipesDataGridViewService.TryParseIntCell(ColumnName.Id, rowIndex, out var recipeId))
                return;
            var recipe = await _recipesService.ReadByIdAsync(recipeId);

            switch (columnName)
            {
                case ColumnName.Date:
                {
                    var oldValue = recipe.Date;
                    var editForm = new EditDateDialogForm(oldValue);
                    editForm.ShowDialog(this);
                
                    var editResult = editForm.DialogResult;
                    var newValue = editForm.NewValue;
                    editForm.Close();

                    if (editResult == DialogResult.Cancel)
                        return;

                    recipe.Date = newValue;
                    break;
                }
                default:
                    MessageBox.Show(@"Check database and debug code.",
                        @"Unknown field.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
            }

            await _recipesService.UpdateAsync(recipe);
            await RefreshRecipesDataGridViewAsync();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!_recipesDataGridViewService.TryGetSelectedCellIndices(out _, out var rowIndex, true) ||
                !_recipesDataGridViewService.TryParseIntCell(ColumnName.Id, rowIndex, out var recipeId))
                return;

            var clientFullName = _recipesDataGridViewService.GetCellValue(ColumnName.ClientName, rowIndex);
            var diseaseName = _recipesDataGridViewService.GetCellValue(ColumnName.DiseaseName, rowIndex);

            if (!MessageBoxService.ShowDeleteQuestion(
                $"Are you sure you want to delete Recipe '{clientFullName}' - '{diseaseName}'?"))
                return;

            await _recipesService.DeleteByIdAsync(recipeId);
            await RefreshRecipesDataGridViewAsync();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Navigation.Pop();
        }

        private void MedicamentsButton_Click(object sender, EventArgs e)
        {
            if (!_recipesDataGridViewService.TryGetSelectedCellIndices(out _, out var rowIndex, true) ||
                !_recipesDataGridViewService.TryParseIntCell(ColumnName.Id, rowIndex, out var recipeId))
                return;
            
            var recipeMedicamentsForm = new RecipeMedicamentsForm(recipeId, _recipesMedicamentsService);
            Navigation.Push(recipeMedicamentsForm);
        }
    }
}
