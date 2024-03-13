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
            this.pnlControls_DVG = new System.Windows.Forms.Panel();
            this.txtUntil = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.bttFilterList = new System.Windows.Forms.Button();
            this.lblListagem = new System.Windows.Forms.Label();
            this.dgvFilteredListing = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPagination = new System.Windows.Forms.Label();
            this.bttPrintDate = new System.Windows.Forms.Button();
            this.bttPreviousPage = new System.Windows.Forms.Button();
            this.bttNextPage = new System.Windows.Forms.Button();
            this.cbxFilter = new BIBLIOTECA_PROJETO.controls.UC_ComboBox();
            this.pnlControls_DVG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilteredListing)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls_DVG
            // 
            this.pnlControls_DVG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.pnlControls_DVG.Controls.Add(this.cbxFilter);
            this.pnlControls_DVG.Controls.Add(this.txtUntil);
            this.pnlControls_DVG.Controls.Add(this.bttFilterList);
            this.pnlControls_DVG.Controls.Add(this.lblListagem);
            this.pnlControls_DVG.Location = new System.Drawing.Point(40, 32);
            this.pnlControls_DVG.Name = "pnlControls_DVG";
            this.pnlControls_DVG.Size = new System.Drawing.Size(1104, 64);
            this.pnlControls_DVG.TabIndex = 48;
            // 
            // txtUntil
            // 
            this.txtUntil.BackColor = System.Drawing.SystemColors.Window;
            this.txtUntil.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUntil.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtUntil.BorderSize = 2;
            this.txtUntil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUntil.ForeColor = System.Drawing.Color.DimGray;
            this.txtUntil.Location = new System.Drawing.Point(824, 16);
            this.txtUntil.Margin = new System.Windows.Forms.Padding(4);
            this.txtUntil.Multiline = false;
            this.txtUntil.Name = "txtUntil";
            this.txtUntil.Padding = new System.Windows.Forms.Padding(7);
            this.txtUntil.PasswordChar = false;
            this.txtUntil.Size = new System.Drawing.Size(208, 31);
            this.txtUntil.TabIndex = 44;
            this.txtUntil.Texts = "";
            this.txtUntil.UnderlinedStyle = true;
            // 
            // bttFilterList
            // 
            this.bttFilterList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttFilterList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttFilterList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttFilterList.Location = new System.Drawing.Point(1048, 15);
            this.bttFilterList.Margin = new System.Windows.Forms.Padding(0);
            this.bttFilterList.Name = "bttFilterList";
            this.bttFilterList.Size = new System.Drawing.Size(35, 35);
            this.bttFilterList.TabIndex = 10;
            this.bttFilterList.UseVisualStyleBackColor = false;
            // 
            // lblListagem
            // 
            this.lblListagem.AutoSize = true;
            this.lblListagem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.lblListagem.Location = new System.Drawing.Point(24, 24);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(168, 23);
            this.lblListagem.TabIndex = 11;
            this.lblListagem.Text = "Listagem Filtrada";
            // 
            // dgvFilteredListing
            // 
            this.dgvFilteredListing.AllowUserToAddRows = false;
            this.dgvFilteredListing.AllowUserToDeleteRows = false;
            this.dgvFilteredListing.AllowUserToResizeRows = false;
            this.dgvFilteredListing.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvFilteredListing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFilteredListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilteredListing.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFilteredListing.Location = new System.Drawing.Point(40, 96);
            this.dgvFilteredListing.MultiSelect = false;
            this.dgvFilteredListing.Name = "dgvFilteredListing";
            this.dgvFilteredListing.RowHeadersVisible = false;
            this.dgvFilteredListing.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvFilteredListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilteredListing.Size = new System.Drawing.Size(1104, 488);
            this.dgvFilteredListing.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblPagination);
            this.panel1.Controls.Add(this.bttPrintDate);
            this.panel1.Controls.Add(this.bttPreviousPage);
            this.panel1.Controls.Add(this.bttNextPage);
            this.panel1.Location = new System.Drawing.Point(40, 584);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 64);
            this.panel1.TabIndex = 50;
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
            this.bttPrintDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttPrintDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttPrintDate.FlatAppearance.BorderSize = 0;
            this.bttPrintDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttPrintDate.ForeColor = System.Drawing.Color.White;
            this.bttPrintDate.Location = new System.Drawing.Point(16, 16);
            this.bttPrintDate.Margin = new System.Windows.Forms.Padding(0);
            this.bttPrintDate.Name = "bttPrintDate";
            this.bttPrintDate.Size = new System.Drawing.Size(35, 35);
            this.bttPrintDate.TabIndex = 45;
            this.bttPrintDate.Text = "P";
            this.bttPrintDate.UseVisualStyleBackColor = false;
            // 
            // bttPreviousPage
            // 
            this.bttPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttPreviousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttPreviousPage.FlatAppearance.BorderSize = 0;
            this.bttPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttPreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPreviousPage.ForeColor = System.Drawing.Color.White;
            this.bttPreviousPage.Location = new System.Drawing.Point(984, 16);
            this.bttPreviousPage.Margin = new System.Windows.Forms.Padding(0);
            this.bttPreviousPage.Name = "bttPreviousPage";
            this.bttPreviousPage.Size = new System.Drawing.Size(35, 35);
            this.bttPreviousPage.TabIndex = 44;
            this.bttPreviousPage.Text = "<";
            this.bttPreviousPage.UseVisualStyleBackColor = false;
            // 
            // bttNextPage
            // 
            this.bttNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttNextPage.FlatAppearance.BorderSize = 0;
            this.bttNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNextPage.ForeColor = System.Drawing.Color.White;
            this.bttNextPage.Location = new System.Drawing.Point(1040, 16);
            this.bttNextPage.Margin = new System.Windows.Forms.Padding(0);
            this.bttNextPage.Name = "bttNextPage";
            this.bttNextPage.Size = new System.Drawing.Size(35, 35);
            this.bttNextPage.TabIndex = 10;
            this.bttNextPage.Text = ">";
            this.bttNextPage.UseVisualStyleBackColor = false;
            // 
            // cbxFilter
            // 
            this.cbxFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxFilter.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxFilter.BorderSize = 1;
            this.cbxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxFilter.ForeColor = System.Drawing.Color.DimGray;
            this.cbxFilter.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxFilter.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxFilter.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxFilter.Location = new System.Drawing.Point(608, 18);
            this.cbxFilter.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Padding = new System.Windows.Forms.Padding(1);
            this.cbxFilter.Size = new System.Drawing.Size(200, 30);
            this.cbxFilter.TabIndex = 47;
            this.cbxFilter.Texts = "";
            // 
            // frmFilteredListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 685);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvFilteredListing);
            this.Controls.Add(this.pnlControls_DVG);
            this.Name = "frmFilteredListing";
            this.pnlControls_DVG.ResumeLayout(false);
            this.pnlControls_DVG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilteredListing)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls_DVG;
        private controls.UC_textbox txtUntil;
        private System.Windows.Forms.Button bttFilterList;
        private System.Windows.Forms.Label lblListagem;
        private System.Windows.Forms.DataGridView dgvFilteredListing;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPagination;
        private System.Windows.Forms.Button bttPrintDate;
        private System.Windows.Forms.Button bttPreviousPage;
        private System.Windows.Forms.Button bttNextPage;
        private controls.UC_ComboBox cbxFilter;
    }
}