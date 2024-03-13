namespace BIBLIOTECA_PROJETO.gui
{
    partial class frmBookViewer
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
            this.components = new System.ComponentModel.Container();
            this.pnlControls_DVG = new System.Windows.Forms.Panel();
            this.txtSearch_DGV = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.cbxFilter_DGV = new BIBLIOTECA_PROJETO.controls.UC_ComboBox();
            this.lblListagem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttPrint_DGV = new System.Windows.Forms.Button();
            this.bttPreviousPage = new System.Windows.Forms.Button();
            this.bttNextPage = new System.Windows.Forms.Button();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.lblPagination = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlControls_DVG.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls_DVG
            // 
            this.pnlControls_DVG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.pnlControls_DVG.Controls.Add(this.txtSearch_DGV);
            this.pnlControls_DVG.Controls.Add(this.cbxFilter_DGV);
            this.pnlControls_DVG.Controls.Add(this.lblListagem);
            this.pnlControls_DVG.Location = new System.Drawing.Point(40, 32);
            this.pnlControls_DVG.Name = "pnlControls_DVG";
            this.pnlControls_DVG.Size = new System.Drawing.Size(1104, 64);
            this.pnlControls_DVG.TabIndex = 2;
            // 
            // txtSearch_DGV
            // 
            this.txtSearch_DGV.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch_DGV.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSearch_DGV.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSearch_DGV.BorderSize = 2;
            this.txtSearch_DGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch_DGV.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch_DGV.Location = new System.Drawing.Point(824, 24);
            this.txtSearch_DGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch_DGV.Multiline = false;
            this.txtSearch_DGV.Name = "txtSearch_DGV";
            this.txtSearch_DGV.Padding = new System.Windows.Forms.Padding(7);
            this.txtSearch_DGV.PasswordChar = false;
            this.txtSearch_DGV.Size = new System.Drawing.Size(248, 31);
            this.txtSearch_DGV.TabIndex = 43;
            this.txtSearch_DGV.Texts = "";
            this.txtSearch_DGV.UnderlinedStyle = true;
            this.txtSearch_DGV._TextChanged += new System.EventHandler(this.txtSearch_DGV__TextChanged);
            // 
            // cbxFilter_DGV
            // 
            this.cbxFilter_DGV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxFilter_DGV.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxFilter_DGV.BorderSize = 1;
            this.cbxFilter_DGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxFilter_DGV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilter_DGV.ForeColor = System.Drawing.Color.DimGray;
            this.cbxFilter_DGV.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxFilter_DGV.Items.AddRange(new object[] {
            "Todos",
            "Número de Registo",
            "Título",
            "Autor",
            "Cota",
            "Estado"});
            this.cbxFilter_DGV.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxFilter_DGV.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxFilter_DGV.Location = new System.Drawing.Point(608, 24);
            this.cbxFilter_DGV.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxFilter_DGV.Name = "cbxFilter_DGV";
            this.cbxFilter_DGV.Padding = new System.Windows.Forms.Padding(1);
            this.cbxFilter_DGV.Size = new System.Drawing.Size(200, 30);
            this.cbxFilter_DGV.TabIndex = 12;
            this.cbxFilter_DGV.Texts = "Todos";
            // 
            // lblListagem
            // 
            this.lblListagem.AutoSize = true;
            this.lblListagem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.lblListagem.Location = new System.Drawing.Point(24, 24);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(234, 23);
            this.lblListagem.TabIndex = 11;
            this.lblListagem.Text = "Pesquisa de Exemplares";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblPagination);
            this.panel1.Controls.Add(this.bttPrint_DGV);
            this.panel1.Controls.Add(this.bttPreviousPage);
            this.panel1.Controls.Add(this.bttNextPage);
            this.panel1.Location = new System.Drawing.Point(40, 584);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 64);
            this.panel1.TabIndex = 44;
            // 
            // bttPrint_DGV
            // 
            this.bttPrint_DGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttPrint_DGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttPrint_DGV.FlatAppearance.BorderSize = 0;
            this.bttPrint_DGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttPrint_DGV.Location = new System.Drawing.Point(16, 16);
            this.bttPrint_DGV.Margin = new System.Windows.Forms.Padding(0);
            this.bttPrint_DGV.Name = "bttPrint_DGV";
            this.bttPrint_DGV.Size = new System.Drawing.Size(35, 35);
            this.bttPrint_DGV.TabIndex = 45;
            this.bttPrint_DGV.Text = "P";
            this.bttPrint_DGV.UseVisualStyleBackColor = false;
            this.bttPrint_DGV.Click += new System.EventHandler(this.bttPrint_Search_Click);
            // 
            // bttPreviousPage
            // 
            this.bttPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttPreviousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttPreviousPage.FlatAppearance.BorderSize = 0;
            this.bttPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.bttNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttNextPage.FlatAppearance.BorderSize = 0;
            this.bttNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttNextPage.Location = new System.Drawing.Point(1040, 16);
            this.bttNextPage.Margin = new System.Windows.Forms.Padding(0);
            this.bttNextPage.Name = "bttNextPage";
            this.bttNextPage.Size = new System.Drawing.Size(35, 35);
            this.bttNextPage.TabIndex = 10;
            this.bttNextPage.UseVisualStyleBackColor = false;
            this.bttNextPage.Click += new System.EventHandler(this.bttNextPage_Click);
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AllowUserToResizeRows = false;
            this.dgvBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBook.Location = new System.Drawing.Point(40, 96);
            this.dgvBook.MultiSelect = false;
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersVisible = false;
            this.dgvBook.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(1104, 488);
            this.dgvBook.TabIndex = 45;
            // 
            // lblPagination
            // 
            this.lblPagination.AutoSize = true;
            this.lblPagination.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.lblPagination.Location = new System.Drawing.Point(808, 24);
            this.lblPagination.Name = "lblPagination";
            this.lblPagination.Size = new System.Drawing.Size(0, 21);
            this.lblPagination.TabIndex = 47;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmBookViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 685);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlControls_DVG);
            this.Name = "frmBookViewer";
            this.pnlControls_DVG.ResumeLayout(false);
            this.pnlControls_DVG.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls_DVG;
        private System.Windows.Forms.Label lblListagem;
        private controls.UC_ComboBox cbxFilter_DGV;
        private controls.UC_textbox txtSearch_DGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttPreviousPage;
        private System.Windows.Forms.Button bttNextPage;
        private System.Windows.Forms.Button bttPrint_DGV;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label lblPagination;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}