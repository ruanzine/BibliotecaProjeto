namespace BIBLIOTECA_PROJETO.gui
{
    partial class frmFilteredListing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilteredListing));
            this.dgvFilteredListing = new System.Windows.Forms.DataGridView();
            this.pnlFormFooter = new BIBLIOTECA_PROJETO.controls.RoundedPanelBottom();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPagination = new System.Windows.Forms.Label();
            this.bttPrint = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.bttPreviousPage = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.bttNextPage = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.pnlFormHeader = new BIBLIOTECA_PROJETO.controls.RoundedPanel();
            this.bttAdvanced = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.pnlLineTop = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.cbxFilter = new MetroFramework.Controls.MetroComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLineBottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilteredListing)).BeginInit();
            this.pnlFormFooter.SuspendLayout();
            this.pnlFormHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFilteredListing
            // 
            this.dgvFilteredListing.AllowUserToAddRows = false;
            this.dgvFilteredListing.AllowUserToDeleteRows = false;
            this.dgvFilteredListing.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.dgvFilteredListing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFilteredListing.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.dgvFilteredListing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFilteredListing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFilteredListing.ColumnHeadersHeight = 40;
            this.dgvFilteredListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFilteredListing.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFilteredListing.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFilteredListing.GridColor = System.Drawing.Color.Silver;
            this.dgvFilteredListing.Location = new System.Drawing.Point(40, 96);
            this.dgvFilteredListing.MultiSelect = false;
            this.dgvFilteredListing.Name = "dgvFilteredListing";
            this.dgvFilteredListing.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime;
            this.dgvFilteredListing.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFilteredListing.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvFilteredListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilteredListing.Size = new System.Drawing.Size(1104, 488);
            this.dgvFilteredListing.TabIndex = 49;
            this.dgvFilteredListing.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvFilteredListing_DataBindingComplete);
            // 
            // pnlFormFooter
            // 
            this.pnlFormFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.pnlFormFooter.Controls.Add(this.lblAmount);
            this.pnlFormFooter.Controls.Add(this.lblPagination);
            this.pnlFormFooter.Controls.Add(this.bttPrint);
            this.pnlFormFooter.Controls.Add(this.bttPreviousPage);
            this.pnlFormFooter.Controls.Add(this.bttNextPage);
            this.pnlFormFooter.CornerRadius = 10;
            this.pnlFormFooter.Location = new System.Drawing.Point(40, 584);
            this.pnlFormFooter.Name = "pnlFormFooter";
            this.pnlFormFooter.Size = new System.Drawing.Size(1104, 64);
            this.pnlFormFooter.TabIndex = 50;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.lblAmount.Location = new System.Drawing.Point(72, 24);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(185, 21);
            this.lblAmount.TabIndex = 54;
            this.lblAmount.Text = "0 registos encontrados";
            // 
            // lblPagination
            // 
            this.lblPagination.AutoSize = true;
            this.lblPagination.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.lblPagination.Location = new System.Drawing.Point(840, 24);
            this.lblPagination.Name = "lblPagination";
            this.lblPagination.Size = new System.Drawing.Size(0, 21);
            this.lblPagination.TabIndex = 46;
            // 
            // bttPrint
            // 
            this.bttPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.bttPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttPrint.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttPrint.BorderRadius = 5;
            this.bttPrint.BorderSize = 0;
            this.bttPrint.FlatAppearance.BorderSize = 0;
            this.bttPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttPrint.ForeColor = System.Drawing.Color.White;
            this.bttPrint.Image = global::BIBLIOTECA_PROJETO.Properties.Resources.icon_download;
            this.bttPrint.Location = new System.Drawing.Point(16, 16);
            this.bttPrint.Margin = new System.Windows.Forms.Padding(0);
            this.bttPrint.Name = "bttPrint";
            this.bttPrint.Size = new System.Drawing.Size(35, 35);
            this.bttPrint.TabIndex = 45;
            this.bttPrint.UseVisualStyleBackColor = false;
            this.bttPrint.Click += new System.EventHandler(this.bttPrint_Click);
            // 
            // bttPreviousPage
            // 
            this.bttPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.bttPreviousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttPreviousPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttPreviousPage.BorderRadius = 5;
            this.bttPreviousPage.BorderSize = 0;
            this.bttPreviousPage.FlatAppearance.BorderSize = 0;
            this.bttPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttPreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPreviousPage.ForeColor = System.Drawing.Color.White;
            this.bttPreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("bttPreviousPage.Image")));
            this.bttPreviousPage.Location = new System.Drawing.Point(984, 16);
            this.bttPreviousPage.Margin = new System.Windows.Forms.Padding(0);
            this.bttPreviousPage.Name = "bttPreviousPage";
            this.bttPreviousPage.Size = new System.Drawing.Size(35, 35);
            this.bttPreviousPage.TabIndex = 44;
            this.bttPreviousPage.UseVisualStyleBackColor = false;
            this.bttPreviousPage.Click += new System.EventHandler(this.bttPreviousPage_Click);
            // 
            // bttNextPage
            // 
            this.bttNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.bttNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttNextPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttNextPage.BorderRadius = 5;
            this.bttNextPage.BorderSize = 0;
            this.bttNextPage.FlatAppearance.BorderSize = 0;
            this.bttNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNextPage.ForeColor = System.Drawing.Color.White;
            this.bttNextPage.Image = ((System.Drawing.Image)(resources.GetObject("bttNextPage.Image")));
            this.bttNextPage.Location = new System.Drawing.Point(1040, 16);
            this.bttNextPage.Margin = new System.Windows.Forms.Padding(0);
            this.bttNextPage.Name = "bttNextPage";
            this.bttNextPage.Size = new System.Drawing.Size(35, 35);
            this.bttNextPage.TabIndex = 10;
            this.bttNextPage.UseVisualStyleBackColor = false;
            this.bttNextPage.Click += new System.EventHandler(this.bttNextPage_Click);
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.pnlFormHeader.Controls.Add(this.bttAdvanced);
            this.pnlFormHeader.Controls.Add(this.pnlLineTop);
            this.pnlFormHeader.Controls.Add(this.lblSubtitle);
            this.pnlFormHeader.Controls.Add(this.cbxFilter);
            this.pnlFormHeader.Controls.Add(this.lblTitle);
            this.pnlFormHeader.CornerRadius = 10;
            this.pnlFormHeader.Location = new System.Drawing.Point(40, 32);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(1104, 64);
            this.pnlFormHeader.TabIndex = 48;
            // 
            // bttAdvanced
            // 
            this.bttAdvanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.bttAdvanced.BorderColor = System.Drawing.Color.White;
            this.bttAdvanced.BorderRadius = 5;
            this.bttAdvanced.BorderSize = 0;
            this.bttAdvanced.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttAdvanced.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.bttAdvanced.FlatAppearance.BorderSize = 0;
            this.bttAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdvanced.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdvanced.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttAdvanced.Location = new System.Drawing.Point(1000, 16);
            this.bttAdvanced.Margin = new System.Windows.Forms.Padding(0);
            this.bttAdvanced.Name = "bttAdvanced";
            this.bttAdvanced.Size = new System.Drawing.Size(88, 32);
            this.bttAdvanced.TabIndex = 54;
            this.bttAdvanced.Text = "Detalhes";
            this.bttAdvanced.UseVisualStyleBackColor = false;
            // 
            // pnlLineTop
            // 
            this.pnlLineTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.pnlLineTop.Location = new System.Drawing.Point(0, 62);
            this.pnlLineTop.Name = "pnlLineTop";
            this.pnlLineTop.Size = new System.Drawing.Size(1104, 12);
            this.pnlLineTop.TabIndex = 51;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.lblSubtitle.Location = new System.Drawing.Point(704, 22);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(53, 23);
            this.lblSubtitle.TabIndex = 52;
            this.lblSubtitle.Text = "Filtro";
            // 
            // cbxFilter
            // 
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.ItemHeight = 23;
            this.cbxFilter.Items.AddRange(new object[] {
            "Número de Registo",
            "Título",
            "Autor",
            "Cota",
            "Estado"});
            this.cbxFilter.Location = new System.Drawing.Point(760, 18);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(192, 29);
            this.cbxFilter.TabIndex = 49;
            this.cbxFilter.UseSelectable = true;
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_OnSelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 26);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Listagem";
            // 
            // pnlLineBottom
            // 
            this.pnlLineBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.pnlLineBottom.Location = new System.Drawing.Point(40, 582);
            this.pnlLineBottom.Name = "pnlLineBottom";
            this.pnlLineBottom.Size = new System.Drawing.Size(1104, 12);
            this.pnlLineBottom.TabIndex = 52;
            // 
            // frmFilteredListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 685);
            this.Controls.Add(this.pnlFormFooter);
            this.Controls.Add(this.pnlLineBottom);
            this.Controls.Add(this.dgvFilteredListing);
            this.Controls.Add(this.pnlFormHeader);
            this.Name = "frmFilteredListing";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilteredListing)).EndInit();
            this.pnlFormFooter.ResumeLayout(false);
            this.pnlFormFooter.PerformLayout();
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvFilteredListing;
        private System.Windows.Forms.Label lblPagination;
        private controls.RoundedButton bttPreviousPage;
        private controls.RoundedButton bttNextPage;
        private controls.RoundedPanel pnlFormHeader;
        private controls.RoundedPanelBottom pnlFormFooter;
        private MetroFramework.Controls.MetroComboBox cbxFilter;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlLineTop;
        private System.Windows.Forms.Panel pnlLineBottom;
        private controls.RoundedButton bttAdvanced;
        private System.Windows.Forms.Label lblAmount;
        private controls.RoundedButton bttPrint;
    }
}