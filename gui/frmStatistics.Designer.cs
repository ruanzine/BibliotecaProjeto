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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlFormBody = new System.Windows.Forms.Panel();
            this.bttSearch = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.cbxMonth = new MetroFramework.Controls.MetroComboBox();
            this.cbxYear = new MetroFramework.Controls.MetroComboBox();
            this.gpbTop = new BIBLIOTECA_PROJETO.controls.RoundedGroupBox();
            this.lblPurchases = new System.Windows.Forms.Label();
            this.lblOffers = new System.Windows.Forms.Label();
            this.lblClassifications = new System.Windows.Forms.Label();
            this.lblPurchases_Label = new System.Windows.Forms.Label();
            this.lblOffers_Label = new System.Windows.Forms.Label();
            this.lblClassifications_LAbel = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblAuthorsAmount_Label = new System.Windows.Forms.Label();
            this.lblTitleAmount = new System.Windows.Forms.Label();
            this.lblTitleAmount_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStatistics_Main = new System.Windows.Forms.DataGridView();
            this.lblRegNum = new System.Windows.Forms.Label();
            this.roundedGroupBox1 = new BIBLIOTECA_PROJETO.controls.RoundedGroupBox();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.pnlFormHeader = new BIBLIOTECA_PROJETO.controls.RoundedPanel();
            this.pnlLineTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFormFooter = new BIBLIOTECA_PROJETO.controls.RoundedPanelBottom();
            this.pnlLineBottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).BeginInit();
            this.pnlFormBody.SuspendLayout();
            this.gpbTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics_Main)).BeginInit();
            this.roundedGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.pnlFormHeader.SuspendLayout();
            this.pnlFormFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartStatistics
            // 
            chartArea2.Name = "ChartArea1";
            this.chartStatistics.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStatistics.Legends.Add(legend2);
            this.chartStatistics.Location = new System.Drawing.Point(12, 216);
            this.chartStatistics.Name = "chartStatistics";
            this.chartStatistics.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartStatistics.Series.Add(series2);
            this.chartStatistics.Size = new System.Drawing.Size(416, 248);
            this.chartStatistics.TabIndex = 66;
            this.chartStatistics.Text = "chart1";
            // 
            // pnlFormBody
            // 
            this.pnlFormBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.pnlFormBody.Controls.Add(this.bttSearch);
            this.pnlFormBody.Controls.Add(this.cbxMonth);
            this.pnlFormBody.Controls.Add(this.cbxYear);
            this.pnlFormBody.Controls.Add(this.gpbTop);
            this.pnlFormBody.Controls.Add(this.roundedGroupBox1);
            this.pnlFormBody.Location = new System.Drawing.Point(88, 72);
            this.pnlFormBody.Name = "pnlFormBody";
            this.pnlFormBody.Size = new System.Drawing.Size(968, 520);
            this.pnlFormBody.TabIndex = 67;
            // 
            // bttSearch
            // 
            this.bttSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.bttSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttSearch.BorderRadius = 5;
            this.bttSearch.BorderSize = 0;
            this.bttSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSearch.ForeColor = System.Drawing.Color.White;
            this.bttSearch.Location = new System.Drawing.Point(304, 136);
            this.bttSearch.Margin = new System.Windows.Forms.Padding(0);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(104, 35);
            this.bttSearch.TabIndex = 70;
            this.bttSearch.Text = "Procurar";
            this.bttSearch.UseVisualStyleBackColor = false;
            // 
            // cbxMonth
            // 
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.ItemHeight = 23;
            this.cbxMonth.Location = new System.Drawing.Point(160, 88);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(248, 29);
            this.cbxMonth.TabIndex = 68;
            this.cbxMonth.UseSelectable = true;
            // 
            // cbxYear
            // 
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.ItemHeight = 23;
            this.cbxYear.Location = new System.Drawing.Point(160, 40);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(248, 29);
            this.cbxYear.TabIndex = 67;
            this.cbxYear.UseSelectable = true;
            // 
            // gpbTop
            // 
            this.gpbTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.gpbTop.BorderRadius = 5;
            this.gpbTop.Controls.Add(this.lblPurchases);
            this.gpbTop.Controls.Add(this.lblOffers);
            this.gpbTop.Controls.Add(this.lblClassifications);
            this.gpbTop.Controls.Add(this.lblPurchases_Label);
            this.gpbTop.Controls.Add(this.lblOffers_Label);
            this.gpbTop.Controls.Add(this.lblClassifications_LAbel);
            this.gpbTop.Controls.Add(this.lblAuthor);
            this.gpbTop.Controls.Add(this.lblAuthorsAmount_Label);
            this.gpbTop.Controls.Add(this.lblTitleAmount);
            this.gpbTop.Controls.Add(this.lblTitleAmount_Label);
            this.gpbTop.Controls.Add(this.label1);
            this.gpbTop.Controls.Add(this.dgvStatistics_Main);
            this.gpbTop.Controls.Add(this.lblRegNum);
            this.gpbTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.gpbTop.Location = new System.Drawing.Point(40, 16);
            this.gpbTop.Name = "gpbTop";
            this.gpbTop.Size = new System.Drawing.Size(424, 480);
            this.gpbTop.TabIndex = 71;
            this.gpbTop.TabStop = false;
            // 
            // lblPurchases
            // 
            this.lblPurchases.AutoSize = true;
            this.lblPurchases.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblPurchases.Location = new System.Drawing.Point(376, 400);
            this.lblPurchases.Name = "lblPurchases";
            this.lblPurchases.Size = new System.Drawing.Size(17, 20);
            this.lblPurchases.TabIndex = 79;
            this.lblPurchases.Text = "1";
            // 
            // lblOffers
            // 
            this.lblOffers.AutoSize = true;
            this.lblOffers.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblOffers.Location = new System.Drawing.Point(248, 440);
            this.lblOffers.Name = "lblOffers";
            this.lblOffers.Size = new System.Drawing.Size(17, 20);
            this.lblOffers.TabIndex = 78;
            this.lblOffers.Text = "1";
            // 
            // lblClassifications
            // 
            this.lblClassifications.AutoSize = true;
            this.lblClassifications.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassifications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblClassifications.Location = new System.Drawing.Point(232, 400);
            this.lblClassifications.Name = "lblClassifications";
            this.lblClassifications.Size = new System.Drawing.Size(17, 20);
            this.lblClassifications.TabIndex = 77;
            this.lblClassifications.Text = "1";
            // 
            // lblPurchases_Label
            // 
            this.lblPurchases_Label.AutoSize = true;
            this.lblPurchases_Label.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchases_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblPurchases_Label.Location = new System.Drawing.Point(304, 400);
            this.lblPurchases_Label.Name = "lblPurchases_Label";
            this.lblPurchases_Label.Size = new System.Drawing.Size(79, 18);
            this.lblPurchases_Label.TabIndex = 76;
            this.lblPurchases_Label.Text = "Compras:";
            // 
            // lblOffers_Label
            // 
            this.lblOffers_Label.AutoSize = true;
            this.lblOffers_Label.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffers_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblOffers_Label.Location = new System.Drawing.Point(184, 440);
            this.lblOffers_Label.Name = "lblOffers_Label";
            this.lblOffers_Label.Size = new System.Drawing.Size(64, 18);
            this.lblOffers_Label.TabIndex = 75;
            this.lblOffers_Label.Text = "Ofertas:";
            // 
            // lblClassifications_LAbel
            // 
            this.lblClassifications_LAbel.AutoSize = true;
            this.lblClassifications_LAbel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassifications_LAbel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblClassifications_LAbel.Location = new System.Drawing.Point(184, 400);
            this.lblClassifications_LAbel.Name = "lblClassifications_LAbel";
            this.lblClassifications_LAbel.Size = new System.Drawing.Size(54, 18);
            this.lblClassifications_LAbel.TabIndex = 74;
            this.lblClassifications_LAbel.Text = "Cotas:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblAuthor.Location = new System.Drawing.Point(80, 440);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(17, 20);
            this.lblAuthor.TabIndex = 73;
            this.lblAuthor.Text = "1";
            // 
            // lblAuthorsAmount_Label
            // 
            this.lblAuthorsAmount_Label.AutoSize = true;
            this.lblAuthorsAmount_Label.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorsAmount_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblAuthorsAmount_Label.Location = new System.Drawing.Point(16, 440);
            this.lblAuthorsAmount_Label.Name = "lblAuthorsAmount_Label";
            this.lblAuthorsAmount_Label.Size = new System.Drawing.Size(67, 18);
            this.lblAuthorsAmount_Label.TabIndex = 72;
            this.lblAuthorsAmount_Label.Text = "Autores:";
            // 
            // lblTitleAmount
            // 
            this.lblTitleAmount.AutoSize = true;
            this.lblTitleAmount.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblTitleAmount.Location = new System.Drawing.Point(112, 400);
            this.lblTitleAmount.Name = "lblTitleAmount";
            this.lblTitleAmount.Size = new System.Drawing.Size(17, 20);
            this.lblTitleAmount.TabIndex = 71;
            this.lblTitleAmount.Text = "1";
            // 
            // lblTitleAmount_Label
            // 
            this.lblTitleAmount_Label.AutoSize = true;
            this.lblTitleAmount_Label.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAmount_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblTitleAmount_Label.Location = new System.Drawing.Point(16, 400);
            this.lblTitleAmount_Label.Name = "lblTitleAmount_Label";
            this.lblTitleAmount_Label.Size = new System.Drawing.Size(97, 18);
            this.lblTitleAmount_Label.TabIndex = 70;
            this.lblTitleAmount_Label.Text = "Exemplares:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(72, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mês";
            // 
            // dgvStatistics_Main
            // 
            this.dgvStatistics_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistics_Main.Location = new System.Drawing.Point(12, 176);
            this.dgvStatistics_Main.Name = "dgvStatistics_Main";
            this.dgvStatistics_Main.RowHeadersVisible = false;
            this.dgvStatistics_Main.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStatistics_Main.Size = new System.Drawing.Size(400, 208);
            this.dgvStatistics_Main.TabIndex = 69;
            // 
            // lblRegNum
            // 
            this.lblRegNum.AutoSize = true;
            this.lblRegNum.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblRegNum.Location = new System.Drawing.Point(73, 32);
            this.lblRegNum.Name = "lblRegNum";
            this.lblRegNum.Size = new System.Drawing.Size(39, 20);
            this.lblRegNum.TabIndex = 30;
            this.lblRegNum.Text = "Ano";
            // 
            // roundedGroupBox1
            // 
            this.roundedGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.roundedGroupBox1.BorderRadius = 5;
            this.roundedGroupBox1.Controls.Add(this.dgvStatistics);
            this.roundedGroupBox1.Controls.Add(this.chartStatistics);
            this.roundedGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.roundedGroupBox1.Location = new System.Drawing.Point(496, 16);
            this.roundedGroupBox1.Name = "roundedGroupBox1";
            this.roundedGroupBox1.Size = new System.Drawing.Size(440, 480);
            this.roundedGroupBox1.TabIndex = 72;
            this.roundedGroupBox1.TabStop = false;
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistics.Location = new System.Drawing.Point(12, 24);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.RowHeadersVisible = false;
            this.dgvStatistics.Size = new System.Drawing.Size(416, 176);
            this.dgvStatistics.TabIndex = 1;
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.pnlFormHeader.Controls.Add(this.pnlLineTop);
            this.pnlFormHeader.Controls.Add(this.lblTitle);
            this.pnlFormHeader.CornerRadius = 10;
            this.pnlFormHeader.Location = new System.Drawing.Point(88, 24);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(968, 48);
            this.pnlFormHeader.TabIndex = 60;
            // 
            // pnlLineTop
            // 
            this.pnlLineTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.pnlLineTop.Location = new System.Drawing.Point(-8, 46);
            this.pnlLineTop.Name = "pnlLineTop";
            this.pnlLineTop.Size = new System.Drawing.Size(1104, 12);
            this.pnlLineTop.TabIndex = 63;
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
            this.pnlFormFooter.Controls.Add(this.pnlLineBottom);
            this.pnlFormFooter.CornerRadius = 10;
            this.pnlFormFooter.Location = new System.Drawing.Point(88, 592);
            this.pnlFormFooter.Name = "pnlFormFooter";
            this.pnlFormFooter.Size = new System.Drawing.Size(968, 40);
            this.pnlFormFooter.TabIndex = 62;
            // 
            // pnlLineBottom
            // 
            this.pnlLineBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.pnlLineBottom.Location = new System.Drawing.Point(0, -10);
            this.pnlLineBottom.Name = "pnlLineBottom";
            this.pnlLineBottom.Size = new System.Drawing.Size(968, 12);
            this.pnlLineBottom.TabIndex = 65;
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 749);
            this.Controls.Add(this.pnlFormBody);
            this.Controls.Add(this.pnlFormHeader);
            this.Controls.Add(this.pnlFormFooter);
            this.Name = "frmStatistics";
            this.Text = "Estatísticas";
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).EndInit();
            this.pnlFormBody.ResumeLayout(false);
            this.gpbTop.ResumeLayout(false);
            this.gpbTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics_Main)).EndInit();
            this.roundedGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.pnlFormFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private controls.RoundedPanel pnlFormHeader;
        private System.Windows.Forms.Label lblTitle;
        private controls.RoundedPanelBottom pnlFormFooter;
        private System.Windows.Forms.Panel pnlLineBottom;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlLineTop;
        private System.Windows.Forms.Panel pnlFormBody;
        private System.Windows.Forms.DataGridView dgvStatistics;
        private MetroFramework.Controls.MetroComboBox cbxMonth;
        private MetroFramework.Controls.MetroComboBox cbxYear;
        private controls.RoundedButton bttSearch;
        private controls.RoundedGroupBox roundedGroupBox1;
        private controls.RoundedGroupBox gpbTop;
        private System.Windows.Forms.Label lblClassifications_LAbel;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblAuthorsAmount_Label;
        private System.Windows.Forms.Label lblTitleAmount;
        private System.Windows.Forms.Label lblTitleAmount_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStatistics_Main;
        private System.Windows.Forms.Label lblRegNum;
        private System.Windows.Forms.Label lblPurchases_Label;
        private System.Windows.Forms.Label lblOffers_Label;
        private System.Windows.Forms.Label lblPurchases;
        private System.Windows.Forms.Label lblOffers;
        private System.Windows.Forms.Label lblClassifications;
    }
}
