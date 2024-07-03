namespace BIBLIOTECA_PROJETO.gui
{
    partial class frmStatistics
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlFormBody = new System.Windows.Forms.Panel();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.cbxChartMode = new MetroFramework.Controls.MetroComboBox();
            this.pnlLineTop = new System.Windows.Forms.Panel();
            this.pnlFormHeader = new RoundedPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFormFooter = new RoundedPanelBottom();
            this.chartStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlLineBottom = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlFormBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.pnlFormHeader.SuspendLayout();
            this.pnlFormFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormBody
            // 
            this.pnlFormBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.pnlFormBody.Controls.Add(this.dgvStatistics);
            this.pnlFormBody.Controls.Add(this.cbxChartMode);
            this.pnlFormBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormBody.Location = new System.Drawing.Point(0, 48);
            this.pnlFormBody.Name = "pnlFormBody";
            this.pnlFormBody.Size = new System.Drawing.Size(1132, 256);
            this.pnlFormBody.TabIndex = 5;
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStatistics.Location = new System.Drawing.Point(0, 56);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.RowHeadersVisible = false;
            this.dgvStatistics.Size = new System.Drawing.Size(1132, 200);
            this.dgvStatistics.TabIndex = 1;
            // 
            // cbxChartMode
            // 
            this.cbxChartMode.FormattingEnabled = true;
            this.cbxChartMode.ItemHeight = 23;
            this.cbxChartMode.Items.AddRange(new object[] {
            "Book Conditions",
            "Books Added By Date"});
            this.cbxChartMode.Location = new System.Drawing.Point(96, 16);
            this.cbxChartMode.Name = "cbxChartMode";
            this.cbxChartMode.Size = new System.Drawing.Size(233, 29);
            this.cbxChartMode.TabIndex = 0;
            this.cbxChartMode.UseSelectable = true;
            // 
            // pnlLineTop
            // 
            this.pnlLineTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.pnlLineTop.Location = new System.Drawing.Point(104, 62);
            this.pnlLineTop.Name = "pnlLineTop";
            this.pnlLineTop.Size = new System.Drawing.Size(904, 12);
            this.pnlLineTop.TabIndex = 64;
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.pnlFormHeader.Controls.Add(this.lblTitle);
            this.pnlFormHeader.CornerRadius = 10;
            this.pnlFormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(1132, 48);
            this.pnlFormHeader.TabIndex = 60;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 26);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Estatísticas";
            // 
            // pnlFormFooter
            // 
            this.pnlFormFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.pnlFormFooter.Controls.Add(this.chartStatistics);
            this.pnlFormFooter.Controls.Add(this.pnlLineBottom);
            this.pnlFormFooter.CornerRadius = 10;
            this.pnlFormFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormFooter.Location = new System.Drawing.Point(0, 0);
            this.pnlFormFooter.Name = "pnlFormFooter";
            this.pnlFormFooter.Size = new System.Drawing.Size(1132, 749);
            this.pnlFormFooter.TabIndex = 62;
            // 
            // chartStatistics
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatistics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatistics.Legends.Add(legend1);
            this.chartStatistics.Location = new System.Drawing.Point(160, 336);
            this.chartStatistics.Name = "chartStatistics";
            this.chartStatistics.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStatistics.Series.Add(series1);
            this.chartStatistics.Size = new System.Drawing.Size(832, 300);
            this.chartStatistics.TabIndex = 66;
            this.chartStatistics.Text = "chart1";
            // 
            // pnlLineBottom
            // 
            this.pnlLineBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.pnlLineBottom.Location = new System.Drawing.Point(0, -10);
            this.pnlLineBottom.Name = "pnlLineBottom";
            this.pnlLineBottom.Size = new System.Drawing.Size(904, 12);
            this.pnlLineBottom.TabIndex = 65;
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 749);
            this.Controls.Add(this.pnlFormBody);
            this.Controls.Add(this.pnlLineTop);
            this.Controls.Add(this.pnlFormHeader);
            this.Controls.Add(this.pnlFormFooter);
            this.Name = "frmStatistics";
            this.Text = "Estatísticas";
            this.pnlFormBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.pnlFormFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private RoundedPanel pnlFormHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFormBody;
        private RoundedPanelBottom pnlFormFooter;
        private System.Windows.Forms.Panel pnlLineBottom;
        private System.Windows.Forms.Panel pnlLineTop;
        private MetroFramework.Controls.MetroComboBox cbxChartMode;
        private System.Windows.Forms.DataGridView dgvStatistics;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
