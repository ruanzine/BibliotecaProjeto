namespace BIBLIOTECA_PROJETO.gui
{
    partial class frmBookViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookViewer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFormFooter = new BIBLIOTECA_PROJETO.controls.RoundedPanelBottom();
            this.pnlLineBottom = new System.Windows.Forms.Panel();
            this.lblPagination = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnPrint_Search = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.btnPreviousPage = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.btnNextPage = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.pnlFormHeader = new BIBLIOTECA_PROJETO.controls.RoundedPanel();
            this.pnlLineTop = new System.Windows.Forms.Panel();
            this.txtSearch_DGV = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblSubTitle_2 = new System.Windows.Forms.Label();
            this.lblSubTitle_1 = new System.Windows.Forms.Label();
            this.cbxFilter_DGV = new MetroFramework.Controls.MetroComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.pnlFormFooter.SuspendLayout();
            this.pnlFormHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormFooter
            // 
            this.pnlFormFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.pnlFormFooter.Controls.Add(this.pnlLineBottom);
            this.pnlFormFooter.Controls.Add(this.lblPagination);
            this.pnlFormFooter.Controls.Add(this.lblAmount);
            this.pnlFormFooter.Controls.Add(this.btnPrint_Search);
            this.pnlFormFooter.Controls.Add(this.btnPreviousPage);
            this.pnlFormFooter.Controls.Add(this.btnNextPage);
            this.pnlFormFooter.CornerRadius = 10;
            this.pnlFormFooter.Location = new System.Drawing.Point(12, 580);
            this.pnlFormFooter.Name = "pnlFormFooter";
            this.pnlFormFooter.Size = new System.Drawing.Size(1131, 64);
            this.pnlFormFooter.TabIndex = 44;
            // 
            // pnlLineBottom
            // 
            this.pnlLineBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLineBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.pnlLineBottom.Location = new System.Drawing.Point(0, -10);
            this.pnlLineBottom.Name = "pnlLineBottom";
            this.pnlLineBottom.Size = new System.Drawing.Size(1131, 12);
            this.pnlLineBottom.TabIndex = 52;
            // 
            // lblPagination
            // 
            this.lblPagination.AutoSize = true;
            this.lblPagination.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.lblPagination.Location = new System.Drawing.Point(860, 24);
            this.lblPagination.Name = "lblPagination";
            this.lblPagination.Size = new System.Drawing.Size(0, 21);
            this.lblPagination.TabIndex = 47;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.lblAmount.Location = new System.Drawing.Point(72, 24);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(185, 21);
            this.lblAmount.TabIndex = 53;
            this.lblAmount.Text = "0 registos encontrados";
            // 
            // btnPrint_Search
            // 
            this.btnPrint_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnPrint_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint_Search.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrint_Search.BorderRadius = 5;
            this.btnPrint_Search.BorderSize = 0;
            this.btnPrint_Search.FlatAppearance.BorderSize = 0;
            this.btnPrint_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint_Search.ForeColor = System.Drawing.Color.White;
            this.btnPrint_Search.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint_Search.Image")));
            this.btnPrint_Search.Location = new System.Drawing.Point(16, 16);
            this.btnPrint_Search.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrint_Search.Name = "btnPrint_Search";
            this.btnPrint_Search.Size = new System.Drawing.Size(35, 35);
            this.btnPrint_Search.TabIndex = 45;
            this.btnPrint_Search.UseVisualStyleBackColor = false;
            this.btnPrint_Search.Click += new System.EventHandler(this.bttPrint_Search_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnPreviousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPreviousPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPreviousPage.BorderRadius = 5;
            this.btnPreviousPage.BorderSize = 0;
            this.btnPreviousPage.FlatAppearance.BorderSize = 0;
            this.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviousPage.Image")));
            this.btnPreviousPage.Location = new System.Drawing.Point(1024, 16);
            this.btnPreviousPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(35, 35);
            this.btnPreviousPage.TabIndex = 44;
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            this.btnPreviousPage.Click += new System.EventHandler(this.bttPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNextPage.BorderRadius = 5;
            this.btnNextPage.BorderSize = 0;
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnNextPage.Image")));
            this.btnNextPage.Location = new System.Drawing.Point(1072, 16);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(35, 35);
            this.btnNextPage.TabIndex = 10;
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.bttNextPage_Click);
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.pnlFormHeader.Controls.Add(this.pnlLineTop);
            this.pnlFormHeader.Controls.Add(this.txtSearch_DGV);
            this.pnlFormHeader.Controls.Add(this.lblSubTitle_2);
            this.pnlFormHeader.Controls.Add(this.lblSubTitle_1);
            this.pnlFormHeader.Controls.Add(this.cbxFilter_DGV);
            this.pnlFormHeader.Controls.Add(this.lblTitle);
            this.pnlFormHeader.CornerRadius = 10;
            this.pnlFormHeader.Location = new System.Drawing.Point(12, 16);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(1131, 64);
            this.pnlFormHeader.TabIndex = 2;
            // 
            // pnlLineTop
            // 
            this.pnlLineTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLineTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.pnlLineTop.Location = new System.Drawing.Point(0, 62);
            this.pnlLineTop.Name = "pnlLineTop";
            this.pnlLineTop.Size = new System.Drawing.Size(1131, 12);
            this.pnlLineTop.TabIndex = 52;
            // 
            // txtSearch_DGV
            // 
            this.txtSearch_DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch_DGV.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch_DGV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtSearch_DGV.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtSearch_DGV.BorderSize = 2;
            this.txtSearch_DGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch_DGV.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch_DGV.Location = new System.Drawing.Point(840, 18);
            this.txtSearch_DGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch_DGV.Multiline = false;
            this.txtSearch_DGV.Name = "txtSearch_DGV";
            this.txtSearch_DGV.Padding = new System.Windows.Forms.Padding(7);
            this.txtSearch_DGV.PasswordChar = false;
            this.txtSearch_DGV.Size = new System.Drawing.Size(248, 31);
            this.txtSearch_DGV.TabIndex = 43;
            this.txtSearch_DGV.Texts = "";
            this.txtSearch_DGV.UnderlinedStyle = true;
            this.txtSearch_DGV._TextChanged += new System.EventHandler(this.txtSearch_DGV_TextChanged);
            // 
            // lblSubTitle_2
            // 
            this.lblSubTitle_2.AutoSize = true;
            this.lblSubTitle_2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.lblSubTitle_2.Location = new System.Drawing.Point(748, 21);
            this.lblSubTitle_2.Name = "lblSubTitle_2";
            this.lblSubTitle_2.Size = new System.Drawing.Size(92, 23);
            this.lblSubTitle_2.TabIndex = 47;
            this.lblSubTitle_2.Text = "Procurar ";
            // 
            // lblSubTitle_1
            // 
            this.lblSubTitle_1.AutoSize = true;
            this.lblSubTitle_1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.lblSubTitle_1.Location = new System.Drawing.Point(480, 22);
            this.lblSubTitle_1.Name = "lblSubTitle_1";
            this.lblSubTitle_1.Size = new System.Drawing.Size(53, 23);
            this.lblSubTitle_1.TabIndex = 46;
            this.lblSubTitle_1.Text = "Filtro";
            // 
            // cbxFilter_DGV
            // 
            this.cbxFilter_DGV.FormattingEnabled = true;
            this.cbxFilter_DGV.ItemHeight = 23;
            this.cbxFilter_DGV.Items.AddRange(new object[] {
            "Número de Registo",
            "Título",
            "Autor",
            "Cota",
            "Estado"});
            this.cbxFilter_DGV.Location = new System.Drawing.Point(536, 19);
            this.cbxFilter_DGV.Name = "cbxFilter_DGV";
            this.cbxFilter_DGV.Size = new System.Drawing.Size(184, 29);
            this.cbxFilter_DGV.TabIndex = 44;
            this.cbxFilter_DGV.UseSelectable = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 26);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Pesquisa de Exemplares";
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.dgvBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBook.ColumnHeadersHeight = 40;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBook.GridColor = System.Drawing.Color.Silver;
            this.dgvBook.Location = new System.Drawing.Point(12, 80);
            this.dgvBook.MultiSelect = false;
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersVisible = false;
            this.dgvBook.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(1131, 500);
            this.dgvBook.TabIndex = 50;
            // 
            // frmBookViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 660);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.pnlFormFooter);
            this.Controls.Add(this.pnlFormHeader);
            this.Name = "frmBookViewer";
            this.Text = "Book Viewer";
            this.pnlFormFooter.ResumeLayout(false);
            this.pnlFormFooter.PerformLayout();
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private controls.UC_textbox txtSearch_DGV;
        private System.Windows.Forms.Label lblPagination;
        private controls.RoundedButton btnPreviousPage;
        private controls.RoundedButton btnNextPage;
        private controls.RoundedPanel pnlFormHeader;
        private controls.RoundedPanelBottom pnlFormFooter;
        private MetroFramework.Controls.MetroComboBox cbxFilter_DGV;
        private System.Windows.Forms.Label lblSubTitle_1;
        private System.Windows.Forms.Label lblSubTitle_2;
        private System.Windows.Forms.Panel pnlLineBottom;
        private System.Windows.Forms.Panel pnlLineTop;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.DataGridView dgvBook;
        private controls.RoundedButton btnPrint_Search;
    }
}
