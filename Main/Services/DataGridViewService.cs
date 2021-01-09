using System.Windows.Forms;

namespace PrihodkoCourse.Services
{
    public class DataGridViewService
    {
        private readonly DataGridView _dataGridView;
        
        public DataGridViewService(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
        }

        public string GetCellValue(string columnName, int rowIndex)
        {
            return _dataGridView[columnName, rowIndex].Value.ToString();
        }
        
        public string GetCellValue(int columnIndex, int rowIndex)
        {
            return _dataGridView[columnIndex, rowIndex].Value.ToString();
        }

        public void Clear()
        {
            _dataGridView.Rows.Clear();
        }

        public void AddRow(params object[] columnsValues)
        {
            _dataGridView.Rows.Add(columnsValues);
        }

        public bool TryParseIntCell(string columnName, int rowIndex, out int variable)
        {
            if (int.TryParse(GetCellValue(columnName, rowIndex), out variable))
                return true;
            
            MessageBox.Show(@"Try to debug code.",
                @"Unable to parse string to int.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return false;
        }
        
        public bool TryParseDoubleCell(string columnName, int rowIndex, out double variable)
        {
            if (double.TryParse(GetCellValue(columnName, rowIndex), out variable))
                return true;
            
            MessageBox.Show(@"Try to debug code.",
                @"Unable to parse string to int.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return false;
        }
        
        public bool TryGetSelectedCellIndices(out int columnIndex, out int rowIndex, bool withWarning = false)
        {
            columnIndex = -1;
            rowIndex = -1;
            
            switch (_dataGridView.SelectedCells.Count)
            {
                case 0:
                    if (withWarning)
                    {
                        MessageBox.Show(@"Please, select cell that you want to use.",
                            @"Incorrect selection.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    return false;
                case 1:
                    columnIndex = _dataGridView.SelectedCells[0].ColumnIndex;
                    break;
            }

            rowIndex = _dataGridView.SelectedCells[0].RowIndex;

            return true;
        }

        public string GetColumnName(int columnIndex)
        {
            return _dataGridView.Columns[columnIndex].Name;
        }
    }
}