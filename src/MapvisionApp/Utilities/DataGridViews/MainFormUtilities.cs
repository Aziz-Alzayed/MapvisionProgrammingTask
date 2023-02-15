using MapvisionApp.Utilities.Lists;
using MapvisionTask.Data.Models;
using System.ComponentModel;

namespace MapvisionApp.Utilities.DataGridViews
{
    public static class MainFormUtilities
    {
        /// <summary>
        /// Search inside DataGridView datasource and filter and color points and values outliers.
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="values"></param>
        /// <param name="enumAxis"></param>
        public static void SearchForOutliersAndChangeColor(this DataGridView dataGridView, List<double> values, EnumAxis enumAxis)
        {
            int columnIndex = (int)enumAxis;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[columnIndex].Value != null && values.Contains((double)row.Cells[columnIndex].Value))
                {
                    row.Cells[columnIndex].Style.BackColor = Color.Red;
                    row.Cells[columnIndex].ToolTipText = "An outlier value";
                }
            }
        }
        public static void AddToGridView(this DataGridView dataGridView, IEnumerable<PartPoint> values)
        {
            if (values == null || values?.Count() == 0)
                dataGridView.DataSource = null;

            //This code has been added so the columns could be sorted in the gridview.
            var bindingSource = new SortedBindingList<PartPoint>(values.ToList());
            bindingSource.ApplySort("Id", ListSortDirection.Ascending);
            dataGridView.DataSource = bindingSource;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
                //Since values are numbers, the alignment should be on the right side.
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
        public static List<PartPoint> SearchInDataGridView(this IEnumerable<PartPoint> partPoints, string SearchType, string searchText)
        {
            if (searchText == null) return null;

            var searchResult = new List<PartPoint>();
            switch (SearchType.ToLower())
            {
                case "all":

                    searchResult = partPoints.ToList().SearchAllProperties(searchText);
                    break;
                case "id":
                    searchResult = partPoints.Where(v => v.Id == int.Parse(searchText)).ToList();
                    break;
                case "x":
                    searchResult = partPoints.Where(x => x.X == Convert.ToDouble(searchText)).ToList();
                    break;
                case "y":
                    searchResult = partPoints.Where(y => y.Y == Convert.ToDouble(searchText)).ToList();
                    break;
                case "z":
                    searchResult = partPoints.Where(z => z.Z == Convert.ToDouble(searchText)).ToList();
                    break;
            }
            return searchResult;
        }
    }

}
