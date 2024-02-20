namespace BIBLIOTECA_PROJETO
{
    partial class Form1
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.bttListing = new System.Windows.Forms.Button();
            this.bttStatistics = new System.Windows.Forms.Button();
            this.bttPesquisar = new System.Windows.Forms.Button();
            this.bttEdidBook = new System.Windows.Forms.Button();
            this.bttNew = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlAddLivros1 = new BIBLIOTECA_PROJETO.pnlAddLivros();
            this.pnlMainFrame.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainFrame
            // 
            this.pnlMainFrame.Controls.Add(this.pnlAddLivros1);
            this.pnlMainFrame.Controls.Add(this.pnlMenu);
            this.pnlMainFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainFrame.Location = new System.Drawing.Point(0, 0);
            this.pnlMainFrame.Name = "pnlMainFrame";
            this.pnlMainFrame.Size = new System.Drawing.Size(1370, 669);
            this.pnlMainFrame.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.pnlMenu.Controls.Add(this.bttListing);
            this.pnlMenu.Controls.Add(this.bttStatistics);
            this.pnlMenu.Controls.Add(this.bttPesquisar);
            this.pnlMenu.Controls.Add(this.bttEdidBook);
            this.pnlMenu.Controls.Add(this.bttNew);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(203, 669);
            this.pnlMenu.TabIndex = 2;
            // 
            // bttListing
            // 
            this.bttListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttListing.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttListing.FlatAppearance.BorderSize = 0;
            this.bttListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttListing.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttListing.Location = new System.Drawing.Point(0, 544);
            this.bttListing.Name = "bttListing";
            this.bttListing.Size = new System.Drawing.Size(203, 98);
            this.bttListing.TabIndex = 12;
            this.bttListing.Text = "Listas";
            this.bttListing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttListing.UseVisualStyleBackColor = true;
            // 
            // bttStatistics
            // 
            this.bttStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttStatistics.FlatAppearance.BorderSize = 0;
            this.bttStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttStatistics.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttStatistics.Location = new System.Drawing.Point(0, 446);
            this.bttStatistics.Name = "bttStatistics";
            this.bttStatistics.Size = new System.Drawing.Size(203, 98);
            this.bttStatistics.TabIndex = 11;
            this.bttStatistics.Text = "     Relatórios      ";
            this.bttStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttStatistics.UseVisualStyleBackColor = true;
            // 
            // bttPesquisar
            // 
            this.bttPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttPesquisar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttPesquisar.FlatAppearance.BorderSize = 0;
            this.bttPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPesquisar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttPesquisar.Location = new System.Drawing.Point(0, 348);
            this.bttPesquisar.Name = "bttPesquisar";
            this.bttPesquisar.Size = new System.Drawing.Size(203, 98);
            this.bttPesquisar.TabIndex = 10;
            this.bttPesquisar.Text = "    Pesquisar         ";
            this.bttPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttPesquisar.UseVisualStyleBackColor = true;
            // 
            // bttEdidBook
            // 
            this.bttEdidBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttEdidBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttEdidBook.FlatAppearance.BorderSize = 0;
            this.bttEdidBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttEdidBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEdidBook.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttEdidBook.Location = new System.Drawing.Point(0, 250);
            this.bttEdidBook.Name = "bttEdidBook";
            this.bttEdidBook.Size = new System.Drawing.Size(203, 98);
            this.bttEdidBook.TabIndex = 9;
            this.bttEdidBook.Text = "    Editar Exemplar";
            this.bttEdidBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttEdidBook.UseVisualStyleBackColor = true;
            // 
            // bttNew
            // 
            this.bttNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttNew.FlatAppearance.BorderSize = 0;
            this.bttNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNew.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttNew.Location = new System.Drawing.Point(0, 152);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(203, 98);
            this.bttNew.TabIndex = 8;
            this.bttNew.Text = "    Novo Exemplar   ";
            this.bttNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttNew.UseVisualStyleBackColor = true;
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
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(203, 152);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlAddLivros1
            // 
            this.pnlAddLivros1.BackColor = System.Drawing.SystemColors.Window;
            this.pnlAddLivros1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddLivros1.Location = new System.Drawing.Point(203, 0);
            this.pnlAddLivros1.Name = "pnlAddLivros1";
            this.pnlAddLivros1.Size = new System.Drawing.Size(1167, 669);
            this.pnlAddLivros1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 669);
            this.Controls.Add(this.pnlMainFrame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlMainFrame.ResumeLayout(false);
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
        private System.Windows.Forms.Button bttPesquisar;
        private System.Windows.Forms.Button bttEdidBook;
        private System.Windows.Forms.Button bttNew;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private pnlAddLivros pnlAddLivros1;
    }
}

