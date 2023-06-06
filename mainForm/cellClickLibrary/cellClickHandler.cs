using System;
using System.Windows.Forms;

namespace cellClickLibrary;
    public class CellClickHandler
    {
        public static void AttachClickEvent(DataGridView dataGridView, string columnName, Action<int, int> action)
        {
            dataGridView.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView.Columns[columnName].Index)
                {
                    action(e.RowIndex, e.ColumnIndex);
                }
            };
        }

    }
