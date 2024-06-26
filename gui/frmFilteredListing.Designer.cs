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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilteredListing));
            this.dgvFilteredListing = new System.Windows.Forms.DataGridView();
            this.pnlFormBody = new RoundedPanelBottom();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPagination = new System.Windows.Forms.Label();
            this.bttPrint = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.bttPreviousPage = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.bttNextPage = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.pnlFormHeader = new RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSecondaryFilter = new MetroFramework.Controls.MetroComboBox();
            this.cbxFilter = new MetroFramework.Controls.MetroComboBox();
            this.lblListagem = new System.Windows.Forms.Label();
            this.pnlLineTop = new System.Windows.Forms.Panel();
            this.pnlLineBottom = new System.Windows.Forms.Panel();
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
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFilteredListing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvFilteredListing.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.dgvFilteredListing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFilteredListing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvFilteredListing.ColumnHeadersHeight = 40;
            this.dgvFilteredListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFilteredListing.DefaultCellStyle = dataGridViewCellStyle15;
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
            this.pnlFormBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
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
            this.bttPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
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
            this.pnlFormHeader.Controls.Add(this.pnlLineTop);
            this.pnlFormHeader.Controls.Add(this.label3);
            this.pnlFormHeader.Controls.Add(this.label2);
            this.pnlFormHeader.Controls.Add(this.cbxSecondaryFilter);
            this.pnlFormHeader.Controls.Add(this.cbxFilter);
            this.pnlFormHeader.Controls.Add(this.lblListagem);
            this.pnlFormHeader.CornerRadius = 10;
            this.pnlFormHeader.Location = new System.Drawing.Point(40, 32);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(1104, 64);
            this.pnlFormHeader.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.label3.Location = new System.Drawing.Point(744, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "Avançado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(448, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Filtro";
            // 
            // cbxSecondaryFilter
            // 
            this.cbxSecondaryFilter.FormattingEnabled = true;
            this.cbxSecondaryFilter.ItemHeight = 23;
            this.cbxSecondaryFilter.Location = new System.Drawing.Point(864, 18);
            this.cbxSecondaryFilter.Name = "cbxSecondaryFilter";
            this.cbxSecondaryFilter.Size = new System.Drawing.Size(216, 29);
            this.cbxSecondaryFilter.TabIndex = 51;
            this.cbxSecondaryFilter.UseSelectable = true;
            this.cbxSecondaryFilter.SelectedIndexChanged += new System.EventHandler(this.cbxSecondaryFilter_OnSelectedIndexChanged);
            // 
            // cbxFilter
            // 
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.ItemHeight = 23;
            this.cbxFilter.Items.AddRange(new object[] {
            "Número de Registo",
            "Título",
            "Autor",
            "Cota"});
            this.cbxFilter.Location = new System.Drawing.Point(512, 18);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(192, 29);
            this.cbxFilter.TabIndex = 49;
            this.cbxFilter.UseSelectable = true;
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_OnSelectedIndexChanged);
            // 
            // lblListagem
            // 
            this.lblListagem.AutoSize = true;
            this.lblListagem.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.lblListagem.Location = new System.Drawing.Point(24, 24);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(109, 26);
            this.lblListagem.TabIndex = 11;
            this.lblListagem.Text = "Listagem";
            // 
            // pnlLineTop
            // 
            this.pnlLineTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.pnlLineTop.Location = new System.Drawing.Point(0, 62);
            this.pnlLineTop.Name = "pnlLineTop";
            this.pnlLineTop.Size = new System.Drawing.Size(1104, 12);
            this.pnlLineTop.TabIndex = 51;
            // 
            // pnlLineBottom
            // 
            this.pnlLineBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.pnlLineBottom.Location = new System.Drawing.Point(40, 574);
            this.pnlLineBottom.Name = "pnlLineBottom";
            this.pnlLineBottom.Size = new System.Drawing.Size(1104, 12);
            this.pnlLineBottom.TabIndex = 52;
            // 
            // frmFilteredListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 685);
            this.Controls.Add(this.pnlFormBody);
            this.Controls.Add(this.pnlLineBottom);
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
        private System.Windows.Forms.Label label1;
        private controls.RoundedButton bttPrint;
        private controls.RoundedButton bttPreviousPage;
        private controls.RoundedButton bttNextPage;
        private RoundedPanel pnlFormHeader;
        private RoundedPanelBottom pnlFormBody;
        private MetroFramework.Controls.MetroComboBox cbxFilter;
        private MetroFramework.Controls.MetroComboBox cbxSecondaryFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlLineTop;
        private System.Windows.Forms.Panel pnlLineBottom;
    }
}