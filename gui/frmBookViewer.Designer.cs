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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookViewer));
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlFormBody = new RoundedPanelBottom();
            this.lblPagination = new System.Windows.Forms.Label();
            this.bttPrint_DGV = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.bttPreviousPage = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.bttNextPage = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.pnlFormHeader = new RoundedPanel();
            this.txtSearch_DGV = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.cbxFilter_DGV = new BIBLIOTECA_PROJETO.controls.UC_ComboBox();
            this.lblListagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.pnlFormBody.SuspendLayout();
            this.pnlFormHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvBook.Location = new System.Drawing.Point(40, 96);
            this.dgvBook.MultiSelect = false;
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersVisible = false;
            this.dgvBook.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(1104, 488);
            this.dgvBook.TabIndex = 45;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // pnlFormBody
            // 
            this.pnlFormBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.pnlFormBody.Controls.Add(this.lblPagination);
            this.pnlFormBody.Controls.Add(this.bttPrint_DGV);
            this.pnlFormBody.Controls.Add(this.bttPreviousPage);
            this.pnlFormBody.Controls.Add(this.bttNextPage);
            this.pnlFormBody.CornerRadius = 10;
            this.pnlFormBody.Location = new System.Drawing.Point(40, 584);
            this.pnlFormBody.Name = "pnlFormBody";
            this.pnlFormBody.Size = new System.Drawing.Size(1104, 64);
            this.pnlFormBody.TabIndex = 44;
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
            // bttPrint_DGV
            // 
            this.bttPrint_DGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttPrint_DGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttPrint_DGV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttPrint_DGV.BorderRadius = 5;
            this.bttPrint_DGV.BorderSize = 0;
            this.bttPrint_DGV.FlatAppearance.BorderSize = 0;
            this.bttPrint_DGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttPrint_DGV.ForeColor = System.Drawing.Color.White;
            this.bttPrint_DGV.Image = ((System.Drawing.Image)(resources.GetObject("bttPrint_DGV.Image")));
            this.bttPrint_DGV.Location = new System.Drawing.Point(16, 16);
            this.bttPrint_DGV.Margin = new System.Windows.Forms.Padding(0);
            this.bttPrint_DGV.Name = "bttPrint_DGV";
            this.bttPrint_DGV.Size = new System.Drawing.Size(35, 35);
            this.bttPrint_DGV.TabIndex = 45;
            this.bttPrint_DGV.UseVisualStyleBackColor = false;
            this.bttPrint_DGV.Click += new System.EventHandler(this.bttPrint_Search_Click);
            // 
            // bttPreviousPage
            // 
            this.bttPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttPreviousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttPreviousPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttPreviousPage.BorderRadius = 5;
            this.bttPreviousPage.BorderSize = 0;
            this.bttPreviousPage.FlatAppearance.BorderSize = 0;
            this.bttPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.bttNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttNextPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttNextPage.BorderRadius = 5;
            this.bttNextPage.BorderSize = 0;
            this.bttNextPage.FlatAppearance.BorderSize = 0;
            this.bttNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.pnlFormHeader.Controls.Add(this.txtSearch_DGV);
            this.pnlFormHeader.Controls.Add(this.cbxFilter_DGV);
            this.pnlFormHeader.Controls.Add(this.lblListagem);
            this.pnlFormHeader.CornerRadius = 10;
            this.pnlFormHeader.Location = new System.Drawing.Point(40, 32);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(1104, 64);
            this.pnlFormHeader.TabIndex = 2;
            // 
            // txtSearch_DGV
            // 
            this.txtSearch_DGV.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch_DGV.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSearch_DGV.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
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
            this.txtSearch_DGV.TextChanged += new System.EventHandler(this.txtSearch_DGV_TextChanged);
            this.txtSearch_DGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_DGV_KeyPress);
            // 
            // cbxFilter_DGV
            // 
            this.cbxFilter_DGV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxFilter_DGV.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxFilter_DGV.BorderSize = 1;
            this.cbxFilter_DGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxFilter_DGV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilter_DGV.ForeColor = System.Drawing.Color.DimGray;
            this.cbxFilter_DGV.HoverColor = System.Drawing.Color.MediumPurple;
            this.cbxFilter_DGV.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxFilter_DGV.Items.AddRange(new object[] {
            "Todos",
            "Número de Registo",
            "Título",
            "Autor",
            "Cota"});
            this.cbxFilter_DGV.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxFilter_DGV.ListFontSize = 10F;
            this.cbxFilter_DGV.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxFilter_DGV.Location = new System.Drawing.Point(608, 24);
            this.cbxFilter_DGV.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxFilter_DGV.Name = "cbxFilter_DGV";
            this.cbxFilter_DGV.Padding = new System.Windows.Forms.Padding(1);
            this.cbxFilter_DGV.Size = new System.Drawing.Size(200, 30);
            this.cbxFilter_DGV.TabIndex = 12;
            this.cbxFilter_DGV.Texts = "Todos";
            this.cbxFilter_DGV.OnSelectedIndexChanged += new System.EventHandler(this.cbxFilter_DGV_OnSelectedIndexChanged);
            // 
            // lblListagem
            // 
            this.lblListagem.AutoSize = true;
            this.lblListagem.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.lblListagem.Location = new System.Drawing.Point(24, 24);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(271, 26);
            this.lblListagem.TabIndex = 11;
            this.lblListagem.Text = "Pesquisa de Exemplares";
            // 
            // frmBookViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 685);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.pnlFormBody);
            this.Controls.Add(this.pnlFormHeader);
            this.Name = "frmBookViewer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.pnlFormBody.ResumeLayout(false);
            this.pnlFormBody.PerformLayout();
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblListagem;
        private controls.UC_ComboBox cbxFilter_DGV;
        private controls.UC_textbox txtSearch_DGV;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label lblPagination;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private controls.RoundedButton bttPreviousPage;
        private controls.RoundedButton bttPrint_DGV;
        private controls.RoundedButton bttNextPage;
        private RoundedPanel pnlFormHeader;
        private RoundedPanelBottom pnlFormBody;
    }
}