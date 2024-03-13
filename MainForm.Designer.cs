namespace BIBLIOTECA_PROJETO
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMainFrame = new System.Windows.Forms.Panel();
            this.pnlLoadForms = new System.Windows.Forms.Panel();
            this.jorge = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.bttStatistics = new System.Windows.Forms.Button();
            this.bttListing = new System.Windows.Forms.Button();
            this.bttEdit = new System.Windows.Forms.Button();
            this.bttNew = new System.Windows.Forms.Button();
            this.bttSearch = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlMainFrame.SuspendLayout();
            this.jorge.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainFrame
            // 
            this.pnlMainFrame.Controls.Add(this.pnlLoadForms);
            this.pnlMainFrame.Controls.Add(this.jorge);
            this.pnlMainFrame.Controls.Add(this.pnlMenu);
            this.pnlMainFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainFrame.Location = new System.Drawing.Point(0, 0);
            this.pnlMainFrame.Name = "pnlMainFrame";
            this.pnlMainFrame.Size = new System.Drawing.Size(1226, 580);
            this.pnlMainFrame.TabIndex = 2;
            // 
            // pnlLoadForms
            // 
            this.pnlLoadForms.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLoadForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoadForms.Location = new System.Drawing.Point(203, 48);
            this.pnlLoadForms.Name = "pnlLoadForms";
            this.pnlLoadForms.Size = new System.Drawing.Size(1023, 532);
            this.pnlLoadForms.TabIndex = 4;
            // 
            // jorge
            // 
            this.jorge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.jorge.Controls.Add(this.label1);
            this.jorge.Controls.Add(this.lblTitle);
            this.jorge.Dock = System.Windows.Forms.DockStyle.Top;
            this.jorge.Location = new System.Drawing.Point(203, 0);
            this.jorge.Name = "jorge";
            this.jorge.Size = new System.Drawing.Size(1023, 48);
            this.jorge.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(592, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIBLIOTECA ESCOLAR EB23 PADRE JOSÉ ROTA";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(32, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LIVRO DE REGISTO";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.pnlMenu.Controls.Add(this.bttStatistics);
            this.pnlMenu.Controls.Add(this.bttListing);
            this.pnlMenu.Controls.Add(this.bttEdit);
            this.pnlMenu.Controls.Add(this.bttNew);
            this.pnlMenu.Controls.Add(this.bttSearch);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(203, 580);
            this.pnlMenu.TabIndex = 2;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(203, 152);
            this.pnlLogo.TabIndex = 1;
            // 
            // bttStatistics
            // 
            this.bttStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttStatistics.FlatAppearance.BorderSize = 0;
            this.bttStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttStatistics.Font = new System.Drawing.Font("Arial Nova Cond", 12F, System.Drawing.FontStyle.Bold);
            this.bttStatistics.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttStatistics.Image = global::BIBLIOTECA_PROJETO.Properties.Resources.icon_statistics;
            this.bttStatistics.Location = new System.Drawing.Point(0, 472);
            this.bttStatistics.Name = "bttStatistics";
            this.bttStatistics.Size = new System.Drawing.Size(203, 80);
            this.bttStatistics.TabIndex = 11;
            this.bttStatistics.Text = "  Relatórios           \r\n";
            this.bttStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttStatistics.UseVisualStyleBackColor = true;
            // 
            // bttListing
            // 
            this.bttListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttListing.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttListing.FlatAppearance.BorderSize = 0;
            this.bttListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttListing.Font = new System.Drawing.Font("Arial Nova Cond", 12F, System.Drawing.FontStyle.Bold);
            this.bttListing.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttListing.Image = global::BIBLIOTECA_PROJETO.Properties.Resources.icon_list;
            this.bttListing.Location = new System.Drawing.Point(0, 392);
            this.bttListing.Name = "bttListing";
            this.bttListing.Size = new System.Drawing.Size(203, 80);
            this.bttListing.TabIndex = 12;
            this.bttListing.Text = "  Listar Pela Data";
            this.bttListing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttListing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttListing.UseVisualStyleBackColor = true;
            this.bttListing.Click += new System.EventHandler(this.bttListing_Click);
            // 
            // bttEdit
            // 
            this.bttEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttEdit.FlatAppearance.BorderSize = 0;
            this.bttEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttEdit.Font = new System.Drawing.Font("Arial Nova Cond", 12F, System.Drawing.FontStyle.Bold);
            this.bttEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttEdit.Image = global::BIBLIOTECA_PROJETO.Properties.Resources.icon_editbook;
            this.bttEdit.Location = new System.Drawing.Point(0, 312);
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(203, 80);
            this.bttEdit.TabIndex = 9;
            this.bttEdit.Text = "   Editar Exemplar ";
            this.bttEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttEdit.UseVisualStyleBackColor = true;
            this.bttEdit.Click += new System.EventHandler(this.bttEdit_Click);
            // 
            // bttNew
            // 
            this.bttNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttNew.FlatAppearance.BorderSize = 0;
            this.bttNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttNew.Font = new System.Drawing.Font("Arial Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNew.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttNew.Image = global::BIBLIOTECA_PROJETO.Properties.Resources.icon_newbook;
            this.bttNew.Location = new System.Drawing.Point(0, 232);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(203, 80);
            this.bttNew.TabIndex = 8;
            this.bttNew.Text = "   Novo Exemplar   ";
            this.bttNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttNew.UseVisualStyleBackColor = true;
            this.bttNew.Click += new System.EventHandler(this.bttNew_Click);
            // 
            // bttSearch
            // 
            this.bttSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttSearch.FlatAppearance.BorderSize = 0;
            this.bttSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSearch.Font = new System.Drawing.Font("Arial Nova Cond", 12F, System.Drawing.FontStyle.Bold);
            this.bttSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttSearch.Image = global::BIBLIOTECA_PROJETO.Properties.Resources.icon_searchbook;
            this.bttSearch.Location = new System.Drawing.Point(0, 152);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(203, 80);
            this.bttSearch.TabIndex = 10;
            this.bttSearch.Text = "   Pesquisar           ";
            this.bttSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttSearch.UseVisualStyleBackColor = true;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = global::BIBLIOTECA_PROJETO.Properties.Resources.eb2_3logo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(203, 152);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 580);
            this.Controls.Add(this.pnlMainFrame);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlMainFrame.ResumeLayout(false);
            this.jorge.ResumeLayout(false);
            this.jorge.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMainFrame;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button bttListing;
        private System.Windows.Forms.Button bttStatistics;
        private System.Windows.Forms.Button bttSearch;
        private System.Windows.Forms.Button bttEdit;
        private System.Windows.Forms.Button bttNew;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel jorge;
        private System.Windows.Forms.Panel pnlLoadForms;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
    }
}

