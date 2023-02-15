using System.Text;

namespace MapvisionApp.Utilities.DataGridViews
{
    public static class ExportToCsvUtility
    {
        public static void ExportToCsv(this DataGridView dataGridView, string fileName)
        {
            StringBuilder sb = new StringBuilder();

            // write header row
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                sb.Append(column.HeaderText + ",");
            }
            sb.AppendLine();

            // write data rows
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    sb.Append(cell.Value.ToString() + ",");
                }
                sb.AppendLine();
            }

            // save file
            File.WriteAllText(fileName, sb.ToString());
        }
    }
}
