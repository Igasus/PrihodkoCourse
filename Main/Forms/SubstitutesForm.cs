using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrihodkoCourse.Forms.Dialog;
using PrihodkoCourse.Models;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms
{
    public partial class SubstitutesForm : Form
    {
        private static class OriginalColumnName
        {
            public const string MedicamentId = "OriginalMedicamentIdColumn";
            public const string MedicamentName = "OriginalMedicamentNameColumn";
            public const string DosageMultiplier = "OriginalDosageMultiplierColumn";
        }

        private static class SubstituteColumnName
        {
            public const string MedicamentId = "SubstituteMedicamentIdColumn";
            public const string MedicamentName = "SubstituteMedicamentNameColumn";
            public const string DosageMultiplier = "SubstituteDosageMultiplierColumn";
        }
        
        private readonly Medicament _medicament;
        private readonly SubstitutesService _substitutesService;
        private readonly MedicamentsService _medicamentsService;
        private readonly DataGridViewService _originalDataGridViewService;
        private readonly DataGridViewService _substituteDataGridViewService;

        private string OriginalSearchName { get; set; } = "";
        private string SubstituteSearchName { get; set; } = "";

        public SubstitutesForm(Medicament medicament, SubstitutesService substitutesService, MedicamentsService medicamentsService)
        {
            _medicament = medicament;
            _substitutesService = substitutesService;
            _medicamentsService = medicamentsService;
            
            InitializeComponent();
            
            _originalDataGridViewService = new DataGridViewService(OriginalDataGridView);
            _substituteDataGridViewService = new DataGridViewService(SubstituteDataGridView);
        }

        private async Task RefreshOriginalDataGridViewAsync()
        {
            var medicamentsList = await _substitutesService.ReadMedicamentsListBySubstituteMedicamentIdAsync(
                _medicament.Id,
                OriginalSearchName);
            
            _originalDataGridViewService.Clear();
            foreach (var substitute in medicamentsList)
                _originalDataGridViewService.AddRow(substitute.OriginalMedicamentId,
                    substitute.OriginalMedicament.Name,
                    substitute.DosageMultiplier);
        }

        private async Task RefreshSubstituteDataGridViewAsync()
        {
            var medicamentsList = await _substitutesService.ReadSubstitutesListByOriginalMedicamentIdAsync(
                _medicament.Id,
                SubstituteSearchName);
            
            _substituteDataGridViewService.Clear();
            foreach (var substitute in medicamentsList)
                _substituteDataGridViewService.AddRow(substitute.SubstituteMedicamentId,
                    substitute.SubstituteMedicament.Name,
                    substitute.DosageMultiplier);
        }

        private async void SubstitutesForm_Load(object sender, EventArgs e)
        {
            MedicamentTextBox.Text = _medicament.Name;
            
            await RefreshOriginalDataGridViewAsync();
            await RefreshSubstituteDataGridViewAsync();
        }

        private async void OriginalTextBox_TextChanged(object sender, EventArgs e)
        {
            OriginalSearchName = OriginalTextBox.Text;

            await RefreshOriginalDataGridViewAsync();
        }

        private async void SubstituteTextBox_TextChanged(object sender, EventArgs e)
        {
            SubstituteSearchName = SubstituteTextBox.Text;

            await RefreshSubstituteDataGridViewAsync();
        }

        private async void OriginalCreateButton_Click(object sender, EventArgs e)
        {
            var createForm = new SubstituteCreateDialogForm(null,
                _medicament.Id,
                _medicamentsService);
            
            var dialogResult = createForm.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                var createModel = createForm.DialogResultEntity;
                await _substitutesService.CreateAsync(createModel.OriginalMedicamentId,
                    createModel.SubstituteMedicamentId,
                    createModel.DosageMultiplier);
                await RefreshOriginalDataGridViewAsync();
            }
            
            createForm.Close();
        }

        private async void SubstituteCreateButton_Click(object sender, EventArgs e)
        {
            var createForm = new SubstituteCreateDialogForm(_medicament.Id,
                null,
                _medicamentsService);
            
            var dialogResult = createForm.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                var createModel = createForm.DialogResultEntity;
                await _substitutesService.CreateAsync(createModel.OriginalMedicamentId,
                    createModel.SubstituteMedicamentId,
                    createModel.DosageMultiplier);
                await RefreshSubstituteDataGridViewAsync();
            }
            
            createForm.Close();
        }

        private async void OriginalEditButton_Click(object sender, EventArgs e)
        {
            if (!_originalDataGridViewService.TryGetSelectedCellIndices(out var columnIndex, out var rowIndex, true))
                return;
            
            if (columnIndex == -1)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("Select cell you want to edit.");
                return;
            }
            
            var columnName = _originalDataGridViewService.GetColumnName(columnIndex);
            if (columnName == OriginalColumnName.MedicamentId || columnName == OriginalColumnName.MedicamentName)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("You can't edit this field.");
                return;
            }
            
            if (!_originalDataGridViewService.TryParseIntCell(OriginalColumnName.MedicamentId,
                rowIndex,
                out var originalMedicamentId))
                return;
            var updateModel = await _substitutesService.ReadByIdAsync(originalMedicamentId, _medicament.Id);

            switch (columnName)
            {
                case OriginalColumnName.DosageMultiplier:
                {
                    if (!_substituteDataGridViewService.TryParseDoubleCell(columnName, rowIndex, out var oldValue))
                        return;
                    var editForm = new EditDoubleDialogForm(oldValue);
                    editForm.ShowDialog(this);

                    var editResult = editForm.DialogResult;
                    var newValue = (float) editForm.NewValue;
                    editForm.Close();

                    if (editResult == DialogResult.Cancel)
                        return;

                    updateModel.DosageMultiplier = newValue;
                    break;
                }
                default:
                    MessageBox.Show(@"Check database and debug code.",
                        @"Unknown field.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
            }

            await _substitutesService.UpdateByIdAsync(updateModel);
            await RefreshOriginalDataGridViewAsync();
        }

        private async void SubstituteEditButton_Click(object sender, EventArgs e)
        {
            if (!_substituteDataGridViewService.TryGetSelectedCellIndices(out var columnIndex, out var rowIndex, true))
                return;
            
            if (columnIndex == -1)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("Select cell you want to edit.");
                return;
            }
            
            var columnName = _substituteDataGridViewService.GetColumnName(columnIndex);
            if (columnName == SubstituteColumnName.MedicamentId || columnName == SubstituteColumnName.MedicamentName)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("You can't edit this field.");
                return;
            }
            
            if (!_substituteDataGridViewService.TryParseIntCell(SubstituteColumnName.MedicamentId,
                rowIndex,
                out var substituteMedicamentId))
                return;
            var updateModel = await _substitutesService.ReadByIdAsync(_medicament.Id, substituteMedicamentId);

            switch (columnName)
            {
                case SubstituteColumnName.DosageMultiplier:
                {
                    if (!_substituteDataGridViewService.TryParseDoubleCell(columnName, rowIndex, out var oldValue))
                        return;
                    var editForm = new EditDoubleDialogForm(oldValue);
                    editForm.ShowDialog(this);

                    var editResult = editForm.DialogResult;
                    var newValue = (float) editForm.NewValue;
                    editForm.Close();

                    if (editResult == DialogResult.Cancel)
                        return;

                    updateModel.DosageMultiplier = newValue;
                    break;
                }
                default:
                    MessageBox.Show(@"Check database and debug code.",
                        @"Unknown field.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
            }

            await _substitutesService.UpdateByIdAsync(updateModel);
            await RefreshSubstituteDataGridViewAsync();
        }

        private async void OriginalDeleteButton_Click(object sender, EventArgs e)
        {
            if (!_originalDataGridViewService.TryGetSelectedCellIndices(out _, out var rowIndex, true) ||
                !_originalDataGridViewService.TryParseIntCell(OriginalColumnName.MedicamentId,
                    rowIndex,
                    out var originalMedicamentId))
                return;

            var originalMedicamentName = _originalDataGridViewService.GetCellValue(OriginalColumnName.MedicamentName,
                rowIndex);

            if (!MessageBoxService.ShowDeleteQuestion(
                $"Are you sure you want to delete Medicament '{originalMedicamentName}'?"))
                return;

            await _substitutesService.DeleteByIdAsync(originalMedicamentId, _medicament.Id);
            await RefreshOriginalDataGridViewAsync();
        }

        private async void SubstituteDeleteButton_Click(object sender, EventArgs e)
        {
            if (!_substituteDataGridViewService.TryGetSelectedCellIndices(out _, out var rowIndex, true) ||
                !_substituteDataGridViewService.TryParseIntCell(SubstituteColumnName.MedicamentId,
                    rowIndex,
                    out var substituteMedicamentId))
                return;

            var substituteMedicamentName = _substituteDataGridViewService.GetCellValue(
                SubstituteColumnName.MedicamentName,
                rowIndex);

            if (!MessageBoxService.ShowDeleteQuestion(
                $"Are you sure you want to delete Medicament '{substituteMedicamentName}'?"))
                return;

            await _substitutesService.DeleteByIdAsync(_medicament.Id, substituteMedicamentId);
            await RefreshSubstituteDataGridViewAsync();
        }

        private async void OriginalSubstitutesButton_Click(object sender, EventArgs e)
        {
            if (!_originalDataGridViewService.TryGetSelectedCellIndices(out _, out var rowIndex, true) ||
                !_originalDataGridViewService.TryParseIntCell(OriginalColumnName.MedicamentId,
                    rowIndex,
                    out var originalMedicamentId))
                return;

            var originalMedicament = await _medicamentsService.ReadByIdAsync(originalMedicamentId);
            
            var nextSubstitutesForm = new SubstitutesForm(originalMedicament, _substitutesService, _medicamentsService);
            Navigation.Push(nextSubstitutesForm);
        }

        private async void SubstituteSubstitutesButton_Click(object sender, EventArgs e)
        {
            if (!_substituteDataGridViewService.TryGetSelectedCellIndices(out _, out var rowIndex, true) ||
                !_substituteDataGridViewService.TryParseIntCell(SubstituteColumnName.MedicamentId,
                    rowIndex,
                    out var substituteMedicamentId))
                return;

            var substituteMedicament = await _medicamentsService.ReadByIdAsync(substituteMedicamentId);
            
            var nextSubstitutesForm = new SubstitutesForm(substituteMedicament, _substitutesService, _medicamentsService);
            Navigation.Push(nextSubstitutesForm);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Navigation.Pop();
        }
    }
}
