using MapvisionApp.ExceptionHandlers;
using MapvisionApp.Utilities.DataGridViews;
using MapvisionTask.Data.Models;
using MapvisionTask.Data.Queries;
using MapvisionTask.Services.Calculations;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace MapvisionApp
{
    public partial class Main : Form
    {
        private readonly ICalculationsSvc _calculationsSvc;
        private readonly IPartPointsQueries _partPointsQueries;
        private readonly IEnumerable<PartPoint> _partPoints;
        private EnumDataType _enumDataType;

        #region Events Handlers
        public Main(ICalculationsSvc calculationsSvc, IPartPointsQueries partPointsQueries)
        {
            InitializeComponent();
            _calculationsSvc = calculationsSvc;
            _partPointsQueries = partPointsQueries;
            _partPoints = _partPointsQueries.GetAllPartPoints();
            Load += ExceptionFormsHandler.OnLoadForm;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            DataGridView.AddToGridView(_partPoints);
            SearchTypeComboBox.DataSource = new List<string> { "All","Id", "X", "Y", "Z" };
            WriteInStatusBar("Welcome!", $"Row count: {_partPoints.Count()}.");
        }      
        private void CalculateVariancesButton_Click(object sender, EventArgs e)
        {
            CalculateVarianceXTextBox.Text = _calculationsSvc.GetVariance(EnumAxis.X).ToString();
            CalculateVarianceYTextBox.Text = _calculationsSvc.GetVariance(EnumAxis.Y).ToString();
            CalculateVarianceZTextBox.Text = _calculationsSvc.GetVariance(EnumAxis.Z).ToString();
            WriteInStatusBar($"Calculate variances is done!");
        }
        private void ShowOutliersButton_Click(object sender, EventArgs e)
        {
            _enumDataType = EnumDataType.OutliersData;
            var result = _calculationsSvc.GetOutlier(out List<double> xOutliers, out List<double> yOutliers, out List<double> zOutliers);
            DataGridView.AddToGridView(result);
            DataGridView.SearchForOutliersAndChangeColor(xOutliers, EnumAxis.X);
            DataGridView.SearchForOutliersAndChangeColor(yOutliers, EnumAxis.Y);
            DataGridView.SearchForOutliersAndChangeColor(zOutliers, EnumAxis.Z);
            WriteInStatusBar("Get outliers is done!", $"Row count: {result.Count()}.");
        }
        private void DataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = DataGridView.Columns[e.ColumnIndex];
            ListSortDirection direction;
            // Check the current sort direction and toggle it
            if (column.HeaderCell.SortGlyphDirection != SortOrder.Ascending)
            {
                direction = ListSortDirection.Descending;
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }
            // Clear the current sort glyph direction
            foreach (DataGridViewColumn col in DataGridView.Columns)
            {
                col.HeaderCell.SortGlyphDirection = SortOrder.None;
            }
            // Set the new sort glyph direction
            column.HeaderCell.SortGlyphDirection = (direction == ListSortDirection.Ascending) ? SortOrder.Ascending : SortOrder.Descending;
            // Perform the sort
            DataGridView.Sort(column, direction);           
        }
        private void CheckTrendsButton_Click(object sender, EventArgs e)
        {
            CheckTrendTextBox.Text = _calculationsSvc.CheckTrend();
            WriteInStatusBar("Check trends is done!");
        }
        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            _enumDataType = EnumDataType.AllData;
            DataGridView.AddToGridView(_partPoints);
            WriteInStatusBar("Show all data.", $"Row count: {_partPoints.Count()}.");
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SearchTextBox.Text)) return;
            _enumDataType = EnumDataType.FilteredData;
            var searchResult = _partPoints.SearchInDataGridView(SearchTypeComboBox.Text, SearchTextBox.Text);
            DataGridView.AddToGridView(searchResult);
            WriteInStatusBar("Search is done!", $"Row count: {searchResult.Count()}.");            
        }        
        private void PrintSplitButton_ButtonClick(object sender, EventArgs e)
        {

            // Write the datagridview data to the export file
            DataGridView.ExportToCsv(_enumDataType.ToString());

        }
        #endregion
        private void WriteInStatusBar(string? label = null, string? result = null)
        {
            if (label != null) LabelStripStatus.Text = label;
            if (result != null) ResultStripStatus.Text = result;
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // Allow only one negative sign at the beginning
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }
    }
}