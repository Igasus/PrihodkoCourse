using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrihodkoCourse.Models;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms.Dialog
{
    public partial class DosagesForm : Form
    {
        private static class ColumnName
        {
            public const string Id = "IdColumn";
            public const string DiseaseMedicamentId = "DiseaseMedicamentIdColumn";
            public const string DiseaseName = "DiseaseNameColumn";
            public const string MedicamentName = "MedicamentNameColumn";
            public const string MinAge = "MinAgeColumn";
            public const string Dose = "DoseColumn";
        }
        
        private readonly DiseaseMedicament _diseaseMedicament;
        private readonly DosagesService _dosagesService;
        private readonly DataGridViewService _dosagesDataGridViewService;
        
        public DosagesForm(DiseaseMedicament diseaseMedicament, DosagesService dosagesService)
        {
            _diseaseMedicament = diseaseMedicament;
            _dosagesService = dosagesService;
            
            InitializeComponent();
            
            _dosagesDataGridViewService = new DataGridViewService(DosagesDataGridView);
        }
        
        private async Task RefreshDataViewGridAsync()
        {
            var dosagesList = (await _dosagesService.ReadListAsync())
                .Where(d => d.DiseaseMedicamentId == _diseaseMedicament.Id)
                .ToList();
            
            _dosagesDataGridViewService.Clear();
            foreach (var dosage in dosagesList)
                _dosagesDataGridViewService.AddRow(dosage.Id,
                    dosage.DiseaseMedicamentId,
                    dosage.DiseaseMedicament.Disease.Name,
                    dosage.DiseaseMedicament.Medicament.Name,
                    dosage.MinAge,
                    dosage.Dose);
        }

        private async void DosagesForm_Load(object sender, EventArgs e)
        {
            await RefreshDataViewGridAsync();
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            var createForm = new DosageCreateDialogForm(_diseaseMedicament);
            
            var dialogResult = createForm.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                var createModel = createForm.DialogResultEntity;
                await _dosagesService.CreateAsync(createModel);
                await RefreshDataViewGridAsync();
            }
            
            createForm.Close();
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            if (!_dosagesDataGridViewService.TryGetSelectedCellIndices(out var columnIndex, out var rowIndex, true))
                return;
            
            if (columnIndex == -1)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("Select cell you want to edit.");
                return;
            }
            
            var columnName = _dosagesDataGridViewService.GetColumnName(columnIndex);
            if (columnName == ColumnName.Id ||
                columnName == ColumnName.DiseaseMedicamentId ||
                columnName == ColumnName.DiseaseName ||
                columnName == ColumnName.MedicamentName)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("You can't edit id.");
                return;
            }
            
            if (!_dosagesDataGridViewService.TryParseIntCell(ColumnName.Id, rowIndex, out var dosageId))
                return;
            var dosage = await _dosagesService.ReadByIdAsync(dosageId);

            switch (columnName)
            {
                case ColumnName.MinAge:
                {
                    if (!_dosagesDataGridViewService.TryParseIntCell(columnName, rowIndex, out var oldValue))
                        return;
                    var editForm = new EditIntDialogForm(oldValue);
                    editForm.ShowDialog(this);
                
                    var editResult = editForm.DialogResult;
                    var newValue = editForm.NewValue;
                    editForm.Close();
                
                    if (editResult == DialogResult.Cancel)
                        return;

                    dosage.MinAge = newValue;
                    break;
                }
                case ColumnName.Dose:
                {
                    if (!_dosagesDataGridViewService.TryParseDoubleCell(columnName, rowIndex, out var oldValue))
                        return;
                    var editForm = new EditDoubleDialogForm(oldValue);
                    editForm.ShowDialog(this);
                
                    var editResult = editForm.DialogResult;
                    var newValue = editForm.NewValue;
                    editForm.Close();
                
                    if (editResult == DialogResult.Cancel)
                        return;

                    dosage.Dose = newValue;
                    break;
                }
                default:
                    MessageBox.Show(@"Check database and debug code.",
                        @"Unknown field.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
            }

            await _dosagesService.UpdateAsync(dosage);
            await RefreshDataViewGridAsync();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!_dosagesDataGridViewService.TryGetSelectedCellIndices(out _, out var rowIndex, true) ||
                !_dosagesDataGridViewService.TryParseIntCell(ColumnName.Id, rowIndex, out var dosageId))
                return;

            var diseaseName = _dosagesDataGridViewService.GetCellValue(ColumnName.DiseaseName, rowIndex);
            var medicamentName = _dosagesDataGridViewService.GetCellValue(ColumnName.MedicamentName, rowIndex);

            if (!MessageBoxService.ShowDeleteQuestion(
                $"Are you sure you want to delete Dosage '{diseaseName} - {medicamentName}'?"))
                return;

            await _dosagesService.DeleteByIdAsync(dosageId);
            await RefreshDataViewGridAsync();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Navigation.Pop();
        }
    }
}
