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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilteredListing));
            this.dgvFilteredListing = new System.Windows.Forms.DataGridView();
            this.pnlFormBody = new RoundedPanelBottom();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPagination = new System.Windows.Forms.Label();
            this.bttPrint = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.bttPreviousPage = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.bttNextPage = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.pnlFormHeader = new RoundedPanel();
            this.cbxFilter = new BIBLIOTECA_PROJETO.controls.UC_ComboBox();
            this.lblListagem = new System.Windows.Forms.Label();
            this.cbxSecondaryFilter = new BIBLIOTECA_PROJETO.controls.UC_ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilteredListing)).BeginInit();
            this.pnlFormBody.SuspendLayout();
            this.pnlFormHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFilteredListing
            // 
            this.dgvFilteredListing.AllowUserToAddRows = false;
            this.dgvFilteredListing.AllowUserToDeleteRows = false;
            this.dgvFilteredListing.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFilteredListing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFilteredListing.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.dgvFilteredListing.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvFilteredListing.Location = new System.Drawing.Point(40, 96);
            this.dgvFilteredListing.MultiSelect = false;
            this.dgvFilteredListing.Name = "dgvFilteredListing";
            this.dgvFilteredListing.RowHeadersVisible = false;
            this.dgvFilteredListing.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvFilteredListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilteredListing.Size = new System.Drawing.Size(1104, 480);
            this.dgvFilteredListing.TabIndex = 49;
            this.dgvFilteredListing.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvFilteredListing_DataBindingComplete);
            // 
            // pnlFormBody
            // 
            this.pnlFormBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.pnlFormBody.Controls.Add(this.label1);
            this.pnlFormBody.Controls.Add(this.lblPagination);
            this.pnlFormBody.Controls.Add(this.bttPrint);
            this.pnlFormBody.Controls.Add(this.bttPreviousPage);
            this.pnlFormBody.Controls.Add(this.bttNextPage);
            this.pnlFormBody.CornerRadius = 10;
            this.pnlFormBody.Location = new System.Drawing.Point(40, 576);
            this.pnlFormBody.Name = "pnlFormBody";
            this.pnlFormBody.Size = new System.Drawing.Size(1104, 64);
            this.pnlFormBody.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(840, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 47;
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
            this.bttPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttPrint.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttPrint.BorderRadius = 5;
            this.bttPrint.BorderSize = 0;
            this.bttPrint.FlatAppearance.BorderSize = 0;
            this.bttPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttPrint.ForeColor = System.Drawing.Color.White;
            this.bttPrint.Image = ((System.Drawing.Image)(resources.GetObject("bttPrint.Image")));
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
            this.bttPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
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
            this.bttNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
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
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.pnlFormHeader.Controls.Add(this.cbxSecondaryFilter);
            this.pnlFormHeader.Controls.Add(this.cbxFilter);
            this.pnlFormHeader.Controls.Add(this.lblListagem);
            this.pnlFormHeader.CornerRadius = 10;
            this.pnlFormHeader.Location = new System.Drawing.Point(40, 32);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(1104, 64);
            this.pnlFormHeader.TabIndex = 48;
            // 
            // cbxFilter
            // 
            this.cbxFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxFilter.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxFilter.BorderSize = 1;
            this.cbxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxFilter.ForeColor = System.Drawing.Color.DimGray;
            this.cbxFilter.HoverColor = System.Drawing.Color.MediumPurple;
            this.cbxFilter.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxFilter.Items.AddRange(new object[] {
            "Número de Registo",
            "Título",
            "Autor",
            "Cota"});
            this.cbxFilter.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxFilter.ListFontSize = 10F;
            this.cbxFilter.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxFilter.Location = new System.Drawing.Point(640, 16);
            this.cbxFilter.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Padding = new System.Windows.Forms.Padding(1);
            this.cbxFilter.Size = new System.Drawing.Size(200, 30);
            this.cbxFilter.TabIndex = 47;
            this.cbxFilter.Texts = "Filtro";
            this.cbxFilter.OnSelectedIndexChanged += new System.EventHandler(this.cbxFilter_OnSelectedIndexChanged);
            // 
            // lblListagem
            // 
            this.lblListagem.AutoSize = true;
            this.lblListagem.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.lblListagem.Location = new System.Drawing.Point(24, 24);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(109, 26);
            this.lblListagem.TabIndex = 11;
            this.lblListagem.Text = "Listagem";
            // 
            // cbxSecondaryFilter
            // 
            this.cbxSecondaryFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxSecondaryFilter.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxSecondaryFilter.BorderSize = 1;
            this.cbxSecondaryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxSecondaryFilter.ForeColor = System.Drawing.Color.DimGray;
            this.cbxSecondaryFilter.HoverColor = System.Drawing.Color.MediumPurple;
            this.cbxSecondaryFilter.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxSecondaryFilter.Items.AddRange(new object[] {
            "Número de Registo",
            "Título",
            "Autor",
            "Cota"});
            this.cbxSecondaryFilter.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxSecondaryFilter.ListFontSize = 10F;
            this.cbxSecondaryFilter.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxSecondaryFilter.Location = new System.Drawing.Point(880, 16);
            this.cbxSecondaryFilter.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxSecondaryFilter.Name = "cbxSecondaryFilter";
            this.cbxSecondaryFilter.Padding = new System.Windows.Forms.Padding(1);
            this.cbxSecondaryFilter.Size = new System.Drawing.Size(200, 30);
            this.cbxSecondaryFilter.TabIndex = 48;
            this.cbxSecondaryFilter.Texts = "Filtro Secundário";
            // 
            // frmFilteredListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 685);
            this.Controls.Add(this.pnlFormBody);
            this.Controls.Add(this.dgvFilteredListing);
            this.Controls.Add(this.pnlFormHeader);
            this.Name = "frmFilteredListing";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilteredListing)).EndInit();
            this.pnlFormBody.ResumeLayout(false);
            this.pnlFormBody.PerformLayout();
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblListagem;
        private System.Windows.Forms.DataGridView dgvFilteredListing;
        private System.Windows.Forms.Label lblPagination;
        private controls.UC_ComboBox cbxFilter;
        private System.Windows.Forms.Label label1;
        private controls.RoundedButton bttPrint;
        private controls.RoundedButton bttPreviousPage;
        private controls.RoundedButton bttNextPage;
        private RoundedPanel pnlFormHeader;
        private RoundedPanelBottom pnlFormBody;
        private controls.UC_ComboBox cbxSecondaryFilter;
    }
}