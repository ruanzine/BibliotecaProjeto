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
            this.dgvDateListing = new System.Windows.Forms.DataGridView();
            this.pnlControls_DVG = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttFilterDate = new System.Windows.Forms.Button();
            this.lblListagem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttPrintDate = new System.Windows.Forms.Button();
            this.bttPreviousPage = new System.Windows.Forms.Button();
            this.bttNextPage = new System.Windows.Forms.Button();
            this.lblPagination = new System.Windows.Forms.Label();
            this.txtUntil = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtFrom = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDateListing)).BeginInit();
            this.pnlControls_DVG.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDateListing
            // 
            this.dgvDateListing.AllowUserToAddRows = false;
            this.dgvDateListing.AllowUserToDeleteRows = false;
            this.dgvDateListing.AllowUserToResizeRows = false;
            this.dgvDateListing.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvDateListing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDateListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDateListing.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDateListing.Location = new System.Drawing.Point(40, 96);
            this.dgvDateListing.MultiSelect = false;
            this.dgvDateListing.Name = "dgvDateListing";
            this.dgvDateListing.RowHeadersVisible = false;
            this.dgvDateListing.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvDateListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDateListing.Size = new System.Drawing.Size(1104, 488);
            this.dgvDateListing.TabIndex = 46;
            // 
            // pnlControls_DVG
            // 
            this.pnlControls_DVG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.pnlControls_DVG.Controls.Add(this.label2);
            this.pnlControls_DVG.Controls.Add(this.label1);
            this.pnlControls_DVG.Controls.Add(this.txtUntil);
            this.pnlControls_DVG.Controls.Add(this.bttFilterDate);
            this.pnlControls_DVG.Controls.Add(this.txtFrom);
            this.pnlControls_DVG.Controls.Add(this.lblListagem);
            this.pnlControls_DVG.Location = new System.Drawing.Point(40, 32);
            this.pnlControls_DVG.Name = "pnlControls_DVG";
            this.pnlControls_DVG.Size = new System.Drawing.Size(1104, 64);
            this.pnlControls_DVG.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(864, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "Até";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(688, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 23);
            this.label1.TabIndex = 45;
            this.label1.Text = "De";
            // 
            // bttFilterDate
            // 
            this.bttFilterDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttFilterDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttFilterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttFilterDate.Location = new System.Drawing.Point(1048, 16);
            this.bttFilterDate.Margin = new System.Windows.Forms.Padding(0);
            this.bttFilterDate.Name = "bttFilterDate";
            this.bttFilterDate.Size = new System.Drawing.Size(35, 35);
            this.bttFilterDate.TabIndex = 10;
            this.bttFilterDate.UseVisualStyleBackColor = false;
            this.bttFilterDate.Click += new System.EventHandler(this.bttFilterDate_Click);
            // 
            // lblListagem
            // 
            this.lblListagem.AutoSize = true;
            this.lblListagem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.lblListagem.Location = new System.Drawing.Point(24, 24);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(322, 23);
            this.lblListagem.TabIndex = 11;
            this.lblListagem.Text = "Listagem de Exemplares por Data";
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
            this.panel1.TabIndex = 48;
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
            this.bttPrintDate.Click += new System.EventHandler(this.bttPrintDate_Click);
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
            this.bttPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
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
            this.bttNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
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
            // txtUntil
            // 
            this.txtUntil.BackColor = System.Drawing.SystemColors.Window;
            this.txtUntil.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUntil.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtUntil.BorderSize = 2;
            this.txtUntil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUntil.ForeColor = System.Drawing.Color.DimGray;
            this.txtUntil.Location = new System.Drawing.Point(912, 19);
            this.txtUntil.Margin = new System.Windows.Forms.Padding(4);
            this.txtUntil.Multiline = false;
            this.txtUntil.Name = "txtUntil";
            this.txtUntil.Padding = new System.Windows.Forms.Padding(7);
            this.txtUntil.PasswordChar = false;
            this.txtUntil.Size = new System.Drawing.Size(112, 31);
            this.txtUntil.TabIndex = 44;
            this.txtUntil.Texts = "12/12/2020";
            this.txtUntil.UnderlinedStyle = true;
            this.txtUntil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromUntil_KeyPress);
            // 
            // txtFrom
            // 
            this.txtFrom.BackColor = System.Drawing.SystemColors.Window;
            this.txtFrom.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFrom.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtFrom.BorderSize = 2;
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.ForeColor = System.Drawing.Color.DimGray;
            this.txtFrom.Location = new System.Drawing.Point(728, 19);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Multiline = false;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Padding = new System.Windows.Forms.Padding(7);
            this.txtFrom.PasswordChar = false;
            this.txtFrom.Size = new System.Drawing.Size(112, 31);
            this.txtFrom.TabIndex = 43;
            this.txtFrom.Texts = "05/01/2003";
            this.txtFrom.UnderlinedStyle = true;
            this.txtFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromUntil_KeyPress);
            // 
            // frmDateFromUntil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 685);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlControls_DVG);
            this.Controls.Add(this.dgvDateListing);
            this.Name = "frmDateFromUntil";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDateListing)).EndInit();
            this.pnlControls_DVG.ResumeLayout(false);
            this.pnlControls_DVG.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDateListing;
        private System.Windows.Forms.Panel pnlControls_DVG;
        private System.Windows.Forms.Button bttFilterDate;
        private controls.UC_textbox txtFrom;
        private System.Windows.Forms.Label lblListagem;
        private controls.UC_textbox txtUntil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttPrintDate;
        private System.Windows.Forms.Button bttPreviousPage;
        private System.Windows.Forms.Button bttNextPage;
        private System.Windows.Forms.Label lblPagination;
    }
}