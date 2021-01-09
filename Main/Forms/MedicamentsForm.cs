using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrihodkoCourse.Forms.Dialog;
using PrihodkoCourse.Services;

namespace PrihodkoCourse.Forms
{
    public partial class MedicamentsForm : Form
    {
        private static class ColumnName
        {
            public const string Id = "IdColumn";
            public const string Name = "NameColumn";
            public const string StockQuantity = "StockQuantityColumn";
        }
        
        private readonly MedicamentsService _medicamentsService;
        private readonly DataGridViewService _dataGridViewService;

        private readonly DiseasesService _diseasesService;
        private readonly DiseasesMedicamentsService _diseasesMedicamentsService;
        private readonly SubstitutesService _substitutesService;
        private readonly DosagesService _dosagesService;

        private string SearchName { get; set; } = "";
        
        public MedicamentsForm(MedicamentsService medicamentsService,
            DiseasesService diseasesService,
            DiseasesMedicamentsService diseasesMedicamentsService,
            SubstitutesService substitutesService,
            DosagesService dosagesService)
        {
            _medicamentsService = medicamentsService;

            _diseasesService = diseasesService;
            _diseasesMedicamentsService = diseasesMedicamentsService;
            _substitutesService = substitutesService;
            _dosagesService = dosagesService;
            
            InitializeComponent();
            
            _dataGridViewService = new DataGridViewService(MedicamentsDataGridView);
        }

        private async Task RefreshDataViewGridAsync()
        {
            var medicamentsList = await _medicamentsService.ReadListAsync(SearchName);
            
            _dataGridViewService.Clear();
            foreach (var medicament in medicamentsList)
                _dataGridViewService.AddRow(medicament.Id, medicament.Name, medicament.StockQuantity);
        }
        
        private async void MedicamentsForm_Load(object sender, EventArgs e)
        {
            await RefreshDataViewGridAsync();
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            using var createForm = new MedicamentCreateDialogForm();
            
            var dialogResult = createForm.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                var createModel = createForm.DialogResultEntity;
                await _medicamentsService.CreateAsync(createModel);
                await RefreshDataViewGridAsync();
            }
            
            createForm.Close();
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
            if (columnName == ColumnName.Id)
            {
                MessageBoxService.ShowIncorrectSelectionWarning("You can't edit id.");
                return;
            }
            
            if (!_dataGridViewService.TryParseIntCell(ColumnName.Id, rowIndex, out var medicamentId))
                return;
            var medicament = await _medicamentsService.ReadByIdAsync(medicamentId);

            switch (columnName)
            {
                case ColumnName.Name:
                {
                    var oldValue = _dataGridViewService.GetCellValue(columnIndex, rowIndex);
                    var editForm = new EditStringDialogForm(oldValue);
                    editForm.ShowDialog(this);
                
                    var editResult = editForm.DialogResult;
                    var newValue = editForm.NewValue;
                    editForm.Close();

                    if (editResult == DialogResult.Cancel)
                        return;

                    medicament.Name = newValue;
                    break;
                }
                case ColumnName.StockQuantity:
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

                    medicament.StockQuantity = newValue;
                    break;
                }
                default:
                    MessageBox.Show(@"Check database and debug code.",
                        @"Unknown field.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
            }

            await _medicamentsService.UpdateAsync(medicament);
            await RefreshDataViewGridAsync();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!_dataGridViewService.TryGetSelectedCellIndices(out _, out var rowIndex, true) ||
                !_dataGridViewService.TryParseIntCell(ColumnName.Id, rowIndex, out var medicamentId))
                return;

            var medicamentName = _dataGridViewService.GetCellValue(ColumnName.Name, rowIndex);

            if (!MessageBoxService.ShowDeleteQuestion(
                $"Are you sure you want to delete Medicament '{medicamentName}'?"))
                return;

            await _medicamentsService.DeleteByIdAsync(medicamentId);
            await RefreshDataViewGridAsync();
        }

        private async void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchName = SearchTextBox.Text;
            await RefreshDataViewGridAsync();
        }

        private void DiseasesButton_Click(object sender, EventArgs e)
        {
            if (!_dataGridViewService.TryGetSelectedCellIndices(out _, out var selectedRowIndex, true) ||
                !_dataGridViewService.TryParseIntCell(ColumnName.Id, selectedRowIndex, out var medicamentId))
                return;
            
            var relationForm = new DiseasesMedicamentsForm(null,
                medicamentId,
                _diseasesMedicamentsService,
                _diseasesService,
                _medicamentsService,
                _dosagesService);
            
            Navigation.Push(relationForm);
        }

        private async void SubstitutesButton_Click(object sender, EventArgs e)
        {
            if (!_dataGridViewService.TryGetSelectedCellIndices(out _, out var rowIndex, true) ||
                !_dataGridViewService.TryParseIntCell(ColumnName.Id, rowIndex, out var medicamentId))
                return;

            var medicament = await _medicamentsService.ReadByIdAsync(medicamentId);
            
            var substitutesForm = new SubstitutesForm(medicament, _substitutesService, _medicamentsService);
            Navigation.Push(substitutesForm);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Navigation.Pop();
        }
    }
}
