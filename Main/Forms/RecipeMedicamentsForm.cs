using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrihodkoCourse.Forms.Dialog;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms
{
    public partial class RecipeMedicamentsForm : Form
    {
        private static class ColumnName
        {
            public const string RecipeId = "RecipeIdColumn";
            public const string MedicamentId = "MedicamentIdColumn";
            public const string MedicamentName = "MedicamentNameColumn";
            public const string Dose = "DoseColumn";
        }
        
        private readonly int _recipeId;
        
        private readonly RecipesMedicamentsService _recipesMedicamentsService;
        private readonly DataGridViewService _dataGridViewService;
        
        public RecipeMedicamentsForm(int recipeId, RecipesMedicamentsService recipesMedicamentsService)
        {
            _recipeId = recipeId;
            _recipesMedicamentsService = recipesMedicamentsService;
            
            InitializeComponent();
            
            _dataGridViewService = new DataGridViewService(RecipeMedicamentsDataGridView);
        }

        private async Task RefreshDataGridViewAsync()
        {
            var recipeMedicaments = await _recipesMedicamentsService.ReadListByRecipeIdAsync(_recipeId);

            foreach (var recipeMedicament in recipeMedicaments)
                RecipeMedicamentsDataGridView.Rows.Add(recipeMedicament.RecipeId,
                    recipeMedicament.MedicamentId,
                    recipeMedicament.Medicament.Name,
                    recipeMedicament.Dose);
        }

        private async void RecipeMedicamentsForm_Load(object sender, EventArgs e)
        {
            await RefreshDataGridViewAsync();
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            if (!_dataGridViewService.TryGetSelectedCellIndices(out var columnIndex, out var rowIndex, true))
                return;
            
            if (columnIndex == -1)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("Select cell you want to edit.");
                return;
            }
            
            var columnName = _dataGridViewService.GetColumnName(columnIndex);
            if (columnName == ColumnName.RecipeId ||
                columnName == ColumnName.MedicamentId ||
                columnName == ColumnName.MedicamentName)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("You can't edit id.");
                return;
            }
            
            if (!_dataGridViewService.TryParseIntCell(ColumnName.RecipeId, rowIndex, out var recipeId))
                return;
            if (!_dataGridViewService.TryParseIntCell(ColumnName.MedicamentId, rowIndex, out var medicamentId))
                return;
            var recipeMedicament = await _recipesMedicamentsService.ReadByIdAsync(recipeId, medicamentId);

            switch (columnName)
            {
                case ColumnName.Dose:
                {
                    if (!_dataGridViewService.TryParseDoubleCell(columnName, rowIndex, out var oldValue))
                        return;
                    var editForm = new EditDoubleDialogForm(oldValue);
                    editForm.ShowDialog(this);
                
                    var editResult = editForm.DialogResult;
                    var newValue = editForm.NewValue;
                    editForm.Close();

                    if (editResult == DialogResult.Cancel)
                        return;

                    recipeMedicament.Dose = newValue;
                    break;
                }
                default:
                    MessageBox.Show(@"Check database and debug code.",
                        @"Unknown field.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
            }

            await _recipesMedicamentsService.UpdateAsync(recipeMedicament);
            await RefreshDataGridViewAsync();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!_dataGridViewService.TryGetSelectedCellIndices(out _, out var rowIndex, true) ||
                !_dataGridViewService.TryParseIntCell(ColumnName.RecipeId, rowIndex, out var recipeId) ||
                !_dataGridViewService.TryParseIntCell(ColumnName.MedicamentId, rowIndex, out var medicamentId))
                return;

            if (!MessageBoxService.ShowDeleteQuestion(
                $"Are you sure you want to delete this relation?"))
                return;

            await _recipesMedicamentsService.DeleteRelationByIdAsync(recipeId, medicamentId);
            await RefreshDataGridViewAsync();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Navigation.Pop();
        }
    }
}