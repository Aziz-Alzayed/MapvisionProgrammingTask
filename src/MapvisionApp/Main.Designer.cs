namespace MapvisionApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckTrendTextBox = new System.Windows.Forms.TextBox();
            this.CalculateVarianceZTextBox = new System.Windows.Forms.TextBox();
            this.CheckTrendsButton = new System.Windows.Forms.Button();
            this.CalculateVarianceYTextBox = new System.Windows.Forms.TextBox();
            this.CalculateVarianceXTextBox = new System.Windows.Forms.TextBox();
            this.ZAxisLabel = new System.Windows.Forms.Label();
            this.CalculateVariancesButton = new System.Windows.Forms.Button();
            this.YAxisLabel = new System.Windows.Forms.Label();
            this.XAxisLabel = new System.Windows.Forms.Label();
            this.ShowOutliersButton = new System.Windows.Forms.Button();
            this.CalculateVariancesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SearchValueLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.LabelStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ResultStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.PrintSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.HeaderTabControl = new System.Windows.Forms.TabControl();
            this.DataTabPage = new System.Windows.Forms.TabPage();
            this.CalculationsTabPage = new System.Windows.Forms.TabPage();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.HeaderTabControl.SuspendLayout();
            this.DataTabPage.SuspendLayout();
            this.CalculationsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView.Location = new System.Drawing.Point(0, 94);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridView.RowTemplate.Height = 25;
            this.DataGridView.Size = new System.Drawing.Size(832, 464);
            this.DataGridView.TabIndex = 23;
            this.DataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_ColumnHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "The status of the trends is:";
            // 
            // CheckTrendTextBox
            // 
            this.CheckTrendTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CheckTrendTextBox.Location = new System.Drawing.Point(721, 30);
            this.CheckTrendTextBox.Name = "CheckTrendTextBox";
            this.CheckTrendTextBox.ReadOnly = true;
            this.CheckTrendTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckTrendTextBox.Size = new System.Drawing.Size(78, 23);
            this.CheckTrendTextBox.TabIndex = 19;
            this.CalculateVariancesToolTip.SetToolTip(this.CheckTrendTextBox, "Status of the trend");
            // 
            // CalculateVarianceZTextBox
            // 
            this.CalculateVarianceZTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CalculateVarianceZTextBox.Location = new System.Drawing.Point(356, 28);
            this.CalculateVarianceZTextBox.Name = "CalculateVarianceZTextBox";
            this.CalculateVarianceZTextBox.ReadOnly = true;
            this.CalculateVarianceZTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CalculateVarianceZTextBox.Size = new System.Drawing.Size(78, 23);
            this.CalculateVarianceZTextBox.TabIndex = 16;
            this.CalculateVariancesToolTip.SetToolTip(this.CalculateVarianceZTextBox, "Z Axis variance");
            // 
            // CheckTrendsButton
            // 
            this.CheckTrendsButton.Location = new System.Drawing.Point(442, 29);
            this.CheckTrendsButton.Name = "CheckTrendsButton";
            this.CheckTrendsButton.Size = new System.Drawing.Size(123, 23);
            this.CheckTrendsButton.TabIndex = 17;
            this.CheckTrendsButton.Text = "Check trends";
            this.CalculateVariancesToolTip.SetToolTip(this.CheckTrendsButton, "Get the status ofthe trends, increasing, decreasing or flat.");
            this.CheckTrendsButton.UseVisualStyleBackColor = true;
            this.CheckTrendsButton.Click += new System.EventHandler(this.CheckTrendsButton_Click);
            // 
            // CalculateVarianceYTextBox
            // 
            this.CalculateVarianceYTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CalculateVarianceYTextBox.Location = new System.Drawing.Point(263, 29);
            this.CalculateVarianceYTextBox.Name = "CalculateVarianceYTextBox";
            this.CalculateVarianceYTextBox.ReadOnly = true;
            this.CalculateVarianceYTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CalculateVarianceYTextBox.Size = new System.Drawing.Size(78, 23);
            this.CalculateVarianceYTextBox.TabIndex = 14;
            this.CalculateVariancesToolTip.SetToolTip(this.CalculateVarianceYTextBox, "Y Axis variance");
            // 
            // CalculateVarianceXTextBox
            // 
            this.CalculateVarianceXTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CalculateVarianceXTextBox.Location = new System.Drawing.Point(170, 29);
            this.CalculateVarianceXTextBox.Name = "CalculateVarianceXTextBox";
            this.CalculateVarianceXTextBox.ReadOnly = true;
            this.CalculateVarianceXTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CalculateVarianceXTextBox.Size = new System.Drawing.Size(78, 23);
            this.CalculateVarianceXTextBox.TabIndex = 12;
            this.CalculateVariancesToolTip.SetToolTip(this.CalculateVarianceXTextBox, "X Axis variance");
            // 
            // ZAxisLabel
            // 
            this.ZAxisLabel.AutoSize = true;
            this.ZAxisLabel.Location = new System.Drawing.Point(356, 10);
            this.ZAxisLabel.Name = "ZAxisLabel";
            this.ZAxisLabel.Size = new System.Drawing.Size(78, 15);
            this.ZAxisLabel.TabIndex = 15;
            this.ZAxisLabel.Text = "Z Axis Values:";
            // 
            // CalculateVariancesButton
            // 
            this.CalculateVariancesButton.Location = new System.Drawing.Point(26, 28);
            this.CalculateVariancesButton.Name = "CalculateVariancesButton";
            this.CalculateVariancesButton.Size = new System.Drawing.Size(125, 24);
            this.CalculateVariancesButton.TabIndex = 10;
            this.CalculateVariancesButton.Text = "Calculate variances";
            this.CalculateVariancesToolTip.SetToolTip(this.CalculateVariancesButton, "Calculate how much variation is there in the values for each axis");
            this.CalculateVariancesButton.UseVisualStyleBackColor = true;
            this.CalculateVariancesButton.Click += new System.EventHandler(this.CalculateVariancesButton_Click);
            // 
            // YAxisLabel
            // 
            this.YAxisLabel.AutoSize = true;
            this.YAxisLabel.Location = new System.Drawing.Point(263, 11);
            this.YAxisLabel.Name = "YAxisLabel";
            this.YAxisLabel.Size = new System.Drawing.Size(78, 15);
            this.YAxisLabel.TabIndex = 13;
            this.YAxisLabel.Text = "Y Axis Values:";
            // 
            // XAxisLabel
            // 
            this.XAxisLabel.AutoSize = true;
            this.XAxisLabel.Location = new System.Drawing.Point(170, 11);
            this.XAxisLabel.Name = "XAxisLabel";
            this.XAxisLabel.Size = new System.Drawing.Size(78, 15);
            this.XAxisLabel.TabIndex = 11;
            this.XAxisLabel.Text = "X Axis Values:";
            // 
            // ShowOutliersButton
            // 
            this.ShowOutliersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowOutliersButton.Location = new System.Drawing.Point(627, 25);
            this.ShowOutliersButton.Name = "ShowOutliersButton";
            this.ShowOutliersButton.Size = new System.Drawing.Size(125, 23);
            this.ShowOutliersButton.TabIndex = 8;
            this.ShowOutliersButton.Text = "Show outliers";
            this.CalculateVariancesToolTip.SetToolTip(this.ShowOutliersButton, "Get outliers points, and highlight the outliers\' values in them.");
            this.ShowOutliersButton.UseVisualStyleBackColor = true;
            this.ShowOutliersButton.Click += new System.EventHandler(this.ShowOutliersButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SearchTextBox.Location = new System.Drawing.Point(274, 24);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SearchTextBox.Size = new System.Drawing.Size(89, 23);
            this.SearchTextBox.TabIndex = 5;
            this.CalculateVariancesToolTip.SetToolTip(this.SearchTextBox, "Search for value.");
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowAllButton.Location = new System.Drawing.Point(498, 24);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(123, 24);
            this.ShowAllButton.TabIndex = 7;
            this.ShowAllButton.Text = "Show all";
            this.CalculateVariancesToolTip.SetToolTip(this.ShowAllButton, "Show all data from CSV file.");
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(369, 24);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(123, 25);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.CalculateVariancesToolTip.SetToolTip(this.SearchButton, "Click to search.");
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTypeComboBox
            // 
            this.SearchTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTypeComboBox.FormattingEnabled = true;
            this.SearchTypeComboBox.ItemHeight = 15;
            this.SearchTypeComboBox.Items.AddRange(new object[] {
            "Id",
            "X",
            "Y",
            "Z"});
            this.SearchTypeComboBox.Location = new System.Drawing.Point(110, 25);
            this.SearchTypeComboBox.Name = "SearchTypeComboBox";
            this.SearchTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.SearchTypeComboBox.TabIndex = 17;
            this.CalculateVariancesToolTip.SetToolTip(this.SearchTypeComboBox, "Search in the selected column");
            // 
            // SearchValueLabel
            // 
            this.SearchValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchValueLabel.AutoSize = true;
            this.SearchValueLabel.Location = new System.Drawing.Point(241, 29);
            this.SearchValueLabel.Name = "SearchValueLabel";
            this.SearchValueLabel.Size = new System.Drawing.Size(27, 15);
            this.SearchValueLabel.TabIndex = 4;
            this.SearchValueLabel.Text = "For:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search by: ";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelStripStatus,
            this.ResultStripStatus,
            this.PrintSplitButton});
            this.StatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StatusStrip.Location = new System.Drawing.Point(0, 558);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(832, 22);
            this.StatusStrip.TabIndex = 0;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // LabelStripStatus
            // 
            this.LabelStripStatus.Name = "LabelStripStatus";
            this.LabelStripStatus.Size = new System.Drawing.Size(60, 17);
            this.LabelStripStatus.Text = "Welcome!";
            // 
            // ResultStripStatus
            // 
            this.ResultStripStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ResultStripStatus.Name = "ResultStripStatus";
            this.ResultStripStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // PrintSplitButton
            // 
            this.PrintSplitButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.PrintSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintSplitButton.DropDownButtonWidth = 0;
            this.PrintSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintSplitButton.Image")));
            this.PrintSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintSplitButton.Name = "PrintSplitButton";
            this.PrintSplitButton.Size = new System.Drawing.Size(21, 20);
            this.PrintSplitButton.ToolTipText = "Save data as CSV.";
            this.PrintSplitButton.ButtonClick += new System.EventHandler(this.PrintSplitButton_ButtonClick);
            // 
            // HeaderTabControl
            // 
            this.HeaderTabControl.Controls.Add(this.DataTabPage);
            this.HeaderTabControl.Controls.Add(this.CalculationsTabPage);
            this.HeaderTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderTabControl.Location = new System.Drawing.Point(0, 0);
            this.HeaderTabControl.Name = "HeaderTabControl";
            this.HeaderTabControl.SelectedIndex = 0;
            this.HeaderTabControl.Size = new System.Drawing.Size(832, 94);
            this.HeaderTabControl.TabIndex = 9;
            // 
            // DataTabPage
            // 
            this.DataTabPage.Controls.Add(this.SearchValueLabel);
            this.DataTabPage.Controls.Add(this.ShowAllButton);
            this.DataTabPage.Controls.Add(this.SearchTextBox);
            this.DataTabPage.Controls.Add(this.label2);
            this.DataTabPage.Controls.Add(this.ShowOutliersButton);
            this.DataTabPage.Controls.Add(this.SearchTypeComboBox);
            this.DataTabPage.Controls.Add(this.SearchButton);
            this.DataTabPage.Location = new System.Drawing.Point(4, 24);
            this.DataTabPage.Name = "DataTabPage";
            this.DataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DataTabPage.Size = new System.Drawing.Size(824, 66);
            this.DataTabPage.TabIndex = 0;
            this.DataTabPage.Text = "Data";
            this.DataTabPage.UseVisualStyleBackColor = true;
            // 
            // CalculationsTabPage
            // 
            this.CalculationsTabPage.Controls.Add(this.label1);
            this.CalculationsTabPage.Controls.Add(this.CheckTrendTextBox);
            this.CalculationsTabPage.Controls.Add(this.XAxisLabel);
            this.CalculationsTabPage.Controls.Add(this.CalculateVarianceZTextBox);
            this.CalculationsTabPage.Controls.Add(this.YAxisLabel);
            this.CalculationsTabPage.Controls.Add(this.CheckTrendsButton);
            this.CalculationsTabPage.Controls.Add(this.CalculateVariancesButton);
            this.CalculationsTabPage.Controls.Add(this.CalculateVarianceYTextBox);
            this.CalculationsTabPage.Controls.Add(this.ZAxisLabel);
            this.CalculationsTabPage.Controls.Add(this.CalculateVarianceXTextBox);
            this.CalculationsTabPage.Location = new System.Drawing.Point(4, 24);
            this.CalculationsTabPage.Name = "CalculationsTabPage";
            this.CalculationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CalculationsTabPage.Size = new System.Drawing.Size(824, 66);
            this.CalculationsTabPage.TabIndex = 1;
            this.CalculationsTabPage.Text = "Calculations";
            this.CalculationsTabPage.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 580);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.HeaderTabControl);
            this.Controls.Add(this.StatusStrip);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(848, 619);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainvision Task";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.HeaderTabControl.ResumeLayout(false);
            this.DataTabPage.ResumeLayout(false);
            this.DataTabPage.PerformLayout();
            this.CalculationsTabPage.ResumeLayout(false);
            this.CalculationsTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView DataGridView;
        private Button CheckTrendsButton;
        private Label ZAxisLabel;
        private Label YAxisLabel;
        private Label XAxisLabel;
        private ToolTip CalculateVariancesToolTip;
        private TextBox CalculateVarianceZTextBox;
        private TextBox CalculateVarianceYTextBox;
        private TextBox CalculateVarianceXTextBox;
        private Button CalculateVariancesButton;
        private Button ShowOutliersButton;
        private TextBox CheckTrendTextBox;
        private Label label1;
        private Button ShowAllButton;
        private Button SearchButton;
        private ComboBox SearchTypeComboBox;
        private Label label2;
        private TextBox SearchTextBox;
        private Label SearchValueLabel;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel LabelStripStatus;
        private ToolStripStatusLabel ResultStripStatus;
        private TabControl HeaderTabControl;
        private TabPage DataTabPage;
        private TabPage CalculationsTabPage;
        private ToolStripSplitButton PrintSplitButton;
        private OpenFileDialog openFileDialog;
    }
}