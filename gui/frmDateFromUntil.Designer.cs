namespace BIBLIOTECA_PROJETO.gui
{
    partial class frmDateFromUntil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDateFromUntil));
            this.dgvDateListing = new System.Windows.Forms.DataGridView();
            this.pnlFormFooter = new BIBLIOTECA_PROJETO.controls.RoundedPanelBottom();
            this.lblAmount = new System.Windows.Forms.Label();
            this.pnlLineBottom = new System.Windows.Forms.Panel();
            this.lblPagination = new System.Windows.Forms.Label();
            this.bttPrintDate = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.bttPreviousPage = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.bttNextPage = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.pnlFormHeader = new BIBLIOTECA_PROJETO.controls.RoundedPanel();
            this.dtpUntil = new MetroFramework.Controls.MetroDateTime();
            this.dtpFrom = new MetroFramework.Controls.MetroDateTime();
            this.pnlLineTop = new System.Windows.Forms.Panel();
            this.lblUntil = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.bttFilterDate = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDateListing)).BeginInit();
            this.pnlFormFooter.SuspendLayout();
            this.pnlFormHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDateListing
            // 
            this.dgvDateListing.AllowUserToAddRows = false;
            this.dgvDateListing.AllowUserToDeleteRows = false;
            this.dgvDateListing.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDateListing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDateListing.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.dgvDateListing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDateListing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDateListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDateListing.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDateListing.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDateListing.GridColor = System.Drawing.Color.Silver;
            this.dgvDateListing.Location = new System.Drawing.Point(40, 96);
            this.dgvDateListing.MultiSelect = false;
            this.dgvDateListing.Name = "dgvDateListing";
            this.dgvDateListing.RowHeadersVisible = false;
            this.dgvDateListing.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvDateListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDateListing.Size = new System.Drawing.Size(1104, 488);
            this.dgvDateListing.TabIndex = 46;
            // 
            // pnlFormFooter
            // 
            this.pnlFormFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.pnlFormFooter.Controls.Add(this.lblAmount);
            this.pnlFormFooter.Controls.Add(this.pnlLineBottom);
            this.pnlFormFooter.Controls.Add(this.lblPagination);
            this.pnlFormFooter.Controls.Add(this.bttPrintDate);
            this.pnlFormFooter.Controls.Add(this.bttPreviousPage);
            this.pnlFormFooter.Controls.Add(this.bttNextPage);
            this.pnlFormFooter.CornerRadius = 10;
            this.pnlFormFooter.Location = new System.Drawing.Point(40, 584);
            this.pnlFormFooter.Name = "pnlFormFooter";
            this.pnlFormFooter.Size = new System.Drawing.Size(1104, 64);
            this.pnlFormFooter.TabIndex = 48;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.lblAmount.Location = new System.Drawing.Point(72, 24);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(185, 21);
            this.lblAmount.TabIndex = 61;
            this.lblAmount.Text = "0 registos encontrados";
            // 
            // pnlLineBottom
            // 
            this.pnlLineBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.pnlLineBottom.Location = new System.Drawing.Point(0, -10);
            this.pnlLineBottom.Name = "pnlLineBottom";
            this.pnlLineBottom.Size = new System.Drawing.Size(1104, 12);
            this.pnlLineBottom.TabIndex = 60;
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
            // bttPrintDate
            // 
            this.bttPrintDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.bttPrintDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttPrintDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttPrintDate.BorderRadius = 5;
            this.bttPrintDate.BorderSize = 0;
            this.bttPrintDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttPrintDate.FlatAppearance.BorderSize = 0;
            this.bttPrintDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttPrintDate.ForeColor = System.Drawing.Color.White;
            this.bttPrintDate.Image = global::BIBLIOTECA_PROJETO.Properties.Resources.icon_download;
            this.bttPrintDate.Location = new System.Drawing.Point(16, 16);
            this.bttPrintDate.Margin = new System.Windows.Forms.Padding(0);
            this.bttPrintDate.Name = "bttPrintDate";
            this.bttPrintDate.Size = new System.Drawing.Size(35, 35);
            this.bttPrintDate.TabIndex = 45;
            this.bttPrintDate.UseVisualStyleBackColor = false;
            this.bttPrintDate.Click += new System.EventHandler(this.bttPrintDate_Click);
            // 
            // bttPreviousPage
            // 
            this.bttPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.bttPreviousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttPreviousPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttPreviousPage.BorderRadius = 5;
            this.bttPreviousPage.BorderSize = 0;
            this.bttPreviousPage.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.bttPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // bttNextPage
            // 
            this.bttNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.bttNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttNextPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttNextPage.BorderRadius = 5;
            this.bttNextPage.BorderSize = 0;
            this.bttNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.bttNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.pnlFormHeader.Controls.Add(this.dtpUntil);
            this.pnlFormHeader.Controls.Add(this.dtpFrom);
            this.pnlFormHeader.Controls.Add(this.pnlLineTop);
            this.pnlFormHeader.Controls.Add(this.lblUntil);
            this.pnlFormHeader.Controls.Add(this.lblFrom);
            this.pnlFormHeader.Controls.Add(this.bttFilterDate);
            this.pnlFormHeader.Controls.Add(this.lblTitle);
            this.pnlFormHeader.CornerRadius = 10;
            this.pnlFormHeader.Location = new System.Drawing.Point(40, 32);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(1104, 64);
            this.pnlFormHeader.TabIndex = 47;
            // 
            // dtpUntil
            // 
            this.dtpUntil.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUntil.Location = new System.Drawing.Point(816, 19);
            this.dtpUntil.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpUntil.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpUntil.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpUntil.Name = "dtpUntil";
            this.dtpUntil.Size = new System.Drawing.Size(192, 29);
            this.dtpUntil.Style = MetroFramework.MetroColorStyle.Blue;
            this.dtpUntil.TabIndex = 62;
            this.dtpUntil.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(544, 19);
            this.dtpFrom.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(192, 29);
            this.dtpFrom.Style = MetroFramework.MetroColorStyle.Blue;
            this.dtpFrom.TabIndex = 61;
            this.dtpFrom.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pnlLineTop
            // 
            this.pnlLineTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.pnlLineTop.Location = new System.Drawing.Point(0, 62);
            this.pnlLineTop.Name = "pnlLineTop";
            this.pnlLineTop.Size = new System.Drawing.Size(1104, 12);
            this.pnlLineTop.TabIndex = 60;
            // 
            // lblUntil
            // 
            this.lblUntil.AutoSize = true;
            this.lblUntil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUntil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.lblUntil.Location = new System.Drawing.Point(768, 24);
            this.lblUntil.Name = "lblUntil";
            this.lblUntil.Size = new System.Drawing.Size(44, 22);
            this.lblUntil.TabIndex = 46;
            this.lblUntil.Text = "Até";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.lblFrom.Location = new System.Drawing.Point(504, 24);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(36, 22);
            this.lblFrom.TabIndex = 45;
            this.lblFrom.Text = "De";
            // 
            // bttFilterDate
            // 
            this.bttFilterDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.bttFilterDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttFilterDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttFilterDate.BorderRadius = 5;
            this.bttFilterDate.BorderSize = 0;
            this.bttFilterDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttFilterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttFilterDate.ForeColor = System.Drawing.Color.White;
            this.bttFilterDate.Image = global::BIBLIOTECA_PROJETO.Properties.Resources.icon_bttsearchdate;
            this.bttFilterDate.Location = new System.Drawing.Point(1048, 16);
            this.bttFilterDate.Margin = new System.Windows.Forms.Padding(0);
            this.bttFilterDate.Name = "bttFilterDate";
            this.bttFilterDate.Size = new System.Drawing.Size(35, 35);
            this.bttFilterDate.TabIndex = 10;
            this.bttFilterDate.UseVisualStyleBackColor = false;
            this.bttFilterDate.Click += new System.EventHandler(this.bttFilterDate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(374, 26);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Listagem de Exemplares por Data";
            // 
            // frmDateFromUntil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 685);
            this.Controls.Add(this.pnlFormFooter);
            this.Controls.Add(this.pnlFormHeader);
            this.Controls.Add(this.dgvDateListing);
            this.Name = "frmDateFromUntil";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDateListing)).EndInit();
            this.pnlFormFooter.ResumeLayout(false);
            this.pnlFormFooter.PerformLayout();
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDateListing;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUntil;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblPagination;
        private controls.RoundedButton bttFilterDate;
        private controls.RoundedButton bttPrintDate;
        private controls.RoundedButton bttPreviousPage;
        private controls.RoundedButton bttNextPage;
        private controls.RoundedPanel pnlFormHeader;
        private controls.RoundedPanelBottom pnlFormFooter;
        private System.Windows.Forms.Panel pnlLineTop;
        private System.Windows.Forms.Panel pnlLineBottom;
        private System.Windows.Forms.Label lblAmount;
        private MetroFramework.Controls.MetroDateTime dtpFrom;
        private MetroFramework.Controls.MetroDateTime dtpUntil;
    }
}