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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chartStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlFormBody = new System.Windows.Forms.Panel();
            this.bttSearch = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.cbxMonth = new MetroFramework.Controls.MetroComboBox();
            this.cbxYear = new MetroFramework.Controls.MetroComboBox();
            this.gpbLeft = new BIBLIOTECA_PROJETO.controls.RoundedGroupBox();
            this.dgvStatistics_Main = new System.Windows.Forms.DataGridView();
            this.lblPurchases = new System.Windows.Forms.Label();
            this.lblOffers = new System.Windows.Forms.Label();
            this.lblClassifications = new System.Windows.Forms.Label();
            this.lblPurchases_Label = new System.Windows.Forms.Label();
            this.lblOffers_Label = new System.Windows.Forms.Label();
            this.lblClassifications_Label = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblAuthorsAmount_Label = new System.Windows.Forms.Label();
            this.lblTitleAmount = new System.Windows.Forms.Label();
            this.lblTitleAmount_Label = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.gpbRight = new BIBLIOTECA_PROJETO.controls.RoundedGroupBox();
            this.pnlFormHeader = new BIBLIOTECA_PROJETO.controls.RoundedPanel();
            this.pnlLineTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFormFooter = new BIBLIOTECA_PROJETO.controls.RoundedPanelBottom();
            this.pnlLineBottom = new System.Windows.Forms.Panel();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.lblSubtitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).BeginInit();
            this.pnlFormBody.SuspendLayout();
            this.gpbLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics_Main)).BeginInit();
            this.gpbRight.SuspendLayout();
            this.pnlFormHeader.SuspendLayout();
            this.pnlFormFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStatistics
            // 
            chartArea3.Name = "ChartArea1";
            this.chartStatistics.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartStatistics.Legends.Add(legend3);
            this.chartStatistics.Location = new System.Drawing.Point(12, 216);
            this.chartStatistics.Name = "chartStatistics";
            this.chartStatistics.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartStatistics.Series.Add(series3);
            this.chartStatistics.Size = new System.Drawing.Size(416, 248);
            this.chartStatistics.TabIndex = 66;
            this.chartStatistics.Text = "chart1";
            // 
            // pnlFormBody
            // 
            this.pnlFormBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.pnlFormBody.Controls.Add(this.gpbLeft);
            this.pnlFormBody.Controls.Add(this.gpbRight);
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
            this.bttSearch.Location = new System.Drawing.Point(280, 72);
            this.bttSearch.Margin = new System.Windows.Forms.Padding(0);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(104, 75);
            this.bttSearch.TabIndex = 70;
            this.bttSearch.Text = "Procurar";
            this.bttSearch.UseVisualStyleBackColor = false;
            // 
            // cbxMonth
            // 
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.ItemHeight = 23;
            this.cbxMonth.Location = new System.Drawing.Point(72, 120);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(192, 29);
            this.cbxMonth.TabIndex = 68;
            this.cbxMonth.UseSelectable = true;
            // 
            // cbxYear
            // 
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.ItemHeight = 23;
            this.cbxYear.Location = new System.Drawing.Point(72, 72);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(192, 29);
            this.cbxYear.TabIndex = 67;
            this.cbxYear.UseSelectable = true;
            // 
            // gpbLeft
            // 
            this.gpbLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.gpbLeft.BorderRadius = 5;
            this.gpbLeft.Controls.Add(this.lblSubtitle);
            this.gpbLeft.Controls.Add(this.cbxYear);
            this.gpbLeft.Controls.Add(this.cbxMonth);
            this.gpbLeft.Controls.Add(this.bttSearch);
            this.gpbLeft.Controls.Add(this.dgvStatistics_Main);
            this.gpbLeft.Controls.Add(this.lblPurchases);
            this.gpbLeft.Controls.Add(this.lblOffers);
            this.gpbLeft.Controls.Add(this.lblClassifications);
            this.gpbLeft.Controls.Add(this.lblPurchases_Label);
            this.gpbLeft.Controls.Add(this.lblOffers_Label);
            this.gpbLeft.Controls.Add(this.lblClassifications_Label);
            this.gpbLeft.Controls.Add(this.lblAuthor);
            this.gpbLeft.Controls.Add(this.lblAuthorsAmount_Label);
            this.gpbLeft.Controls.Add(this.lblTitleAmount);
            this.gpbLeft.Controls.Add(this.lblTitleAmount_Label);
            this.gpbLeft.Controls.Add(this.lblMonth);
            this.gpbLeft.Controls.Add(this.lblYear);
            this.gpbLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.gpbLeft.Location = new System.Drawing.Point(40, 16);
            this.gpbLeft.Name = "gpbLeft";
            this.gpbLeft.Size = new System.Drawing.Size(424, 480);
            this.gpbLeft.TabIndex = 71;
            this.gpbLeft.TabStop = false;
            // 
            // dgvStatistics_Main
            // 
            this.dgvStatistics_Main.AllowUserToAddRows = false;
            this.dgvStatistics_Main.AllowUserToDeleteRows = false;
            this.dgvStatistics_Main.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.dgvStatistics_Main.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvStatistics_Main.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvStatistics_Main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatistics_Main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvStatistics_Main.ColumnHeadersHeight = 40;
            this.dgvStatistics_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatistics_Main.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvStatistics_Main.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStatistics_Main.GridColor = System.Drawing.Color.Silver;
            this.dgvStatistics_Main.Location = new System.Drawing.Point(24, 176);
            this.dgvStatistics_Main.MultiSelect = false;
            this.dgvStatistics_Main.Name = "dgvStatistics_Main";
            this.dgvStatistics_Main.RowHeadersVisible = false;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvStatistics_Main.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvStatistics_Main.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStatistics_Main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatistics_Main.Size = new System.Drawing.Size(376, 200);
            this.dgvStatistics_Main.TabIndex = 80;
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
            this.lblPurchases.Text = "_";
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
            this.lblOffers.Text = "_";
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
            this.lblClassifications.Text = "_";
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
            // lblClassifications_Label
            // 
            this.lblClassifications_Label.AutoSize = true;
            this.lblClassifications_Label.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassifications_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblClassifications_Label.Location = new System.Drawing.Point(184, 400);
            this.lblClassifications_Label.Name = "lblClassifications_Label";
            this.lblClassifications_Label.Size = new System.Drawing.Size(54, 18);
            this.lblClassifications_Label.TabIndex = 74;
            this.lblClassifications_Label.Text = "Cotas:";
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
            this.lblAuthor.Text = "_";
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
            this.lblTitleAmount.Text = "_";
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
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblMonth.Location = new System.Drawing.Point(24, 124);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(40, 20);
            this.lblMonth.TabIndex = 32;
            this.lblMonth.Text = "Mês";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblYear.Location = new System.Drawing.Point(24, 76);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 20);
            this.lblYear.TabIndex = 30;
            this.lblYear.Text = "Ano";
            // 
            // gpbRight
            // 
            this.gpbRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.gpbRight.BorderRadius = 5;
            this.gpbRight.Controls.Add(this.dgvStatistics);
            this.gpbRight.Controls.Add(this.chartStatistics);
            this.gpbRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.gpbRight.Location = new System.Drawing.Point(496, 16);
            this.gpbRight.Name = "gpbRight";
            this.gpbRight.Size = new System.Drawing.Size(440, 480);
            this.gpbRight.TabIndex = 72;
            this.gpbRight.TabStop = false;
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
            // dgvStatistics
            // 
            this.dgvStatistics.AllowUserToAddRows = false;
            this.dgvStatistics.AllowUserToDeleteRows = false;
            this.dgvStatistics.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.dgvStatistics.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvStatistics.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvStatistics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatistics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvStatistics.ColumnHeadersHeight = 40;
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatistics.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvStatistics.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStatistics.GridColor = System.Drawing.Color.Silver;
            this.dgvStatistics.Location = new System.Drawing.Point(16, 16);
            this.dgvStatistics.MultiSelect = false;
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.RowHeadersVisible = false;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvStatistics.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvStatistics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatistics.Size = new System.Drawing.Size(408, 184);
            this.dgvStatistics.TabIndex = 81;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblSubtitle.Location = new System.Drawing.Point(24, 32);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(281, 22);
            this.lblSubtitle.TabIndex = 81;
            this.lblSubtitle.Text = "Número de Registos realizados";
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
            this.gpbLeft.ResumeLayout(false);
            this.gpbLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics_Main)).EndInit();
            this.gpbRight.ResumeLayout(false);
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.pnlFormFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
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
        private MetroFramework.Controls.MetroComboBox cbxMonth;
        private MetroFramework.Controls.MetroComboBox cbxYear;
        private controls.RoundedButton bttSearch;
        private controls.RoundedGroupBox gpbRight;
        private controls.RoundedGroupBox gpbLeft;
        private System.Windows.Forms.Label lblClassifications_Label;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblAuthorsAmount_Label;
        private System.Windows.Forms.Label lblTitleAmount;
        private System.Windows.Forms.Label lblTitleAmount_Label;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblPurchases_Label;
        private System.Windows.Forms.Label lblOffers_Label;
        private System.Windows.Forms.Label lblPurchases;
        private System.Windows.Forms.Label lblOffers;
        private System.Windows.Forms.Label lblClassifications;
        private System.Windows.Forms.DataGridView dgvStatistics_Main;
        private System.Windows.Forms.DataGridView dgvStatistics;
        private System.Windows.Forms.Label lblSubtitle;
    }
}
