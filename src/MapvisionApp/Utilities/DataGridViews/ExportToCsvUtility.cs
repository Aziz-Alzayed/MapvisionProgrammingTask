using System.Text;
using System.Windows.Forms;

namespace MapvisionApp.Utilities.DataGridViews
{
    public static class ExportToCsvUtility
    {
        /// <summary>
        /// Export Datagridview Data as CSV file.
        /// </summary>
        public static void ExportToCsv(this DataGridView dataGridView,string filename)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Save as CSV file";
            saveFileDialog.FileName = $"Mapvision_{filename}";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Write the datagridview data to the export file
                using (var writer = new StreamWriter(saveFileDialog.FileName))
                {
                    // Write the header row
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        writer.Write(column.HeaderText + ",");
                    }
                    writer.WriteLine();

                    // Write the data rows
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            writer.Write(cell.Value + ",");
                        }
                        writer.WriteLine();
                    }
                }
            }
        }
    }
}
