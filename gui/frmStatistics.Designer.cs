namespace BIBLIOTECA_PROJETO.gui
{
    partial class frmStatistics
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
            this.pnlFormHeader = new RoundedPanel();
            this.lblListagem = new System.Windows.Forms.Label();
            this.pnlFormBody = new RoundedPanelBottom();
            this.roundedGroupBox1 = new RoundedGroupBox();
            this.lblPerdido = new System.Windows.Forms.Label();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.lblExposicao = new System.Windows.Forms.Label();
            this.lblConsultaLocal = new System.Windows.Forms.Label();
            this.lblAbatido = new System.Windows.Forms.Label();
            this.lblIndisponivel = new System.Windows.Forms.Label();
            this.lblDisponivel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new RoundedGroupBox();
            this.lblTotalCotas = new System.Windows.Forms.Label();
            this.lblTotalAuthors = new System.Windows.Forms.Label();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.lblTotalTitles = new System.Windows.Forms.Label();
            this.pnlFormHeader.SuspendLayout();
            this.pnlFormBody.SuspendLayout();
            this.roundedGroupBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.pnlFormHeader.Controls.Add(this.lblListagem);
            this.pnlFormHeader.CornerRadius = 10;
            this.pnlFormHeader.Location = new System.Drawing.Point(128, 136);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(904, 48);
            this.pnlFormHeader.TabIndex = 60;
            // 
            // lblListagem
            // 
            this.lblListagem.AutoSize = true;
            this.lblListagem.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.lblListagem.Location = new System.Drawing.Point(20, 16);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(128, 26);
            this.lblListagem.TabIndex = 12;
            this.lblListagem.Text = "Estatísticas";
            // 
            // pnlFormBody
            // 
            this.pnlFormBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlFormBody.Controls.Add(this.roundedGroupBox1);
            this.pnlFormBody.Controls.Add(this.groupBox1);
            this.pnlFormBody.CornerRadius = 10;
            this.pnlFormBody.Location = new System.Drawing.Point(128, 184);
            this.pnlFormBody.Name = "pnlFormBody";
            this.pnlFormBody.Size = new System.Drawing.Size(904, 296);
            this.pnlFormBody.TabIndex = 5;
            // 
            // roundedGroupBox1
            // 
            this.roundedGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundedGroupBox1.BorderRadius = 5;
            this.roundedGroupBox1.Controls.Add(this.lblPerdido);
            this.roundedGroupBox1.Controls.Add(this.lblDeposito);
            this.roundedGroupBox1.Controls.Add(this.lblExposicao);
            this.roundedGroupBox1.Controls.Add(this.lblConsultaLocal);
            this.roundedGroupBox1.Controls.Add(this.lblAbatido);
            this.roundedGroupBox1.Controls.Add(this.lblIndisponivel);
            this.roundedGroupBox1.Controls.Add(this.lblDisponivel);
            this.roundedGroupBox1.Controls.Add(this.label1);
            this.roundedGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.roundedGroupBox1.Location = new System.Drawing.Point(416, 16);
            this.roundedGroupBox1.Name = "roundedGroupBox1";
            this.roundedGroupBox1.Size = new System.Drawing.Size(472, 256);
            this.roundedGroupBox1.TabIndex = 56;
            this.roundedGroupBox1.TabStop = false;
            // 
            // lblPerdido
            // 
            this.lblPerdido.AutoSize = true;
            this.lblPerdido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPerdido.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPerdido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblPerdido.Location = new System.Drawing.Point(248, 56);
            this.lblPerdido.Name = "lblPerdido";
            this.lblPerdido.Size = new System.Drawing.Size(116, 21);
            this.lblPerdido.TabIndex = 12;
            this.lblPerdido.Text = "Total Perdido:";
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblDeposito.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDeposito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblDeposito.Location = new System.Drawing.Point(248, 152);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(155, 21);
            this.lblDeposito.TabIndex = 11;
            this.lblDeposito.Text = "Total em Depósito:";
            // 
            // lblExposicao
            // 
            this.lblExposicao.AutoSize = true;
            this.lblExposicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblExposicao.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblExposicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblExposicao.Location = new System.Drawing.Point(248, 104);
            this.lblExposicao.Name = "lblExposicao";
            this.lblExposicao.Size = new System.Drawing.Size(164, 21);
            this.lblExposicao.TabIndex = 10;
            this.lblExposicao.Text = "Total em Exposição:";
            // 
            // lblConsultaLocal
            // 
            this.lblConsultaLocal.AutoSize = true;
            this.lblConsultaLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblConsultaLocal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblConsultaLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblConsultaLocal.Location = new System.Drawing.Point(40, 200);
            this.lblConsultaLocal.Name = "lblConsultaLocal";
            this.lblConsultaLocal.Size = new System.Drawing.Size(172, 21);
            this.lblConsultaLocal.TabIndex = 9;
            this.lblConsultaLocal.Text = "Total Consulta Local:";
            this.lblConsultaLocal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAbatido
            // 
            this.lblAbatido.AutoSize = true;
            this.lblAbatido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAbatido.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblAbatido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblAbatido.Location = new System.Drawing.Point(40, 152);
            this.lblAbatido.Name = "lblAbatido";
            this.lblAbatido.Size = new System.Drawing.Size(123, 21);
            this.lblAbatido.TabIndex = 8;
            this.lblAbatido.Text = "Total Abatido:";
            this.lblAbatido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIndisponivel
            // 
            this.lblIndisponivel.AutoSize = true;
            this.lblIndisponivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblIndisponivel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblIndisponivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblIndisponivel.Location = new System.Drawing.Point(40, 104);
            this.lblIndisponivel.Name = "lblIndisponivel";
            this.lblIndisponivel.Size = new System.Drawing.Size(149, 21);
            this.lblIndisponivel.TabIndex = 7;
            this.lblIndisponivel.Text = "Total Indisponível:";
            // 
            // lblDisponivel
            // 
            this.lblDisponivel.AutoSize = true;
            this.lblDisponivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblDisponivel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDisponivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblDisponivel.Location = new System.Drawing.Point(40, 56);
            this.lblDisponivel.Name = "lblDisponivel";
            this.lblDisponivel.Size = new System.Drawing.Size(135, 21);
            this.lblDisponivel.TabIndex = 6;
            this.lblDisponivel.Text = "Total Disponível:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estado";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.BorderRadius = 5;
            this.groupBox1.Controls.Add(this.lblTotalCotas);
            this.groupBox1.Controls.Add(this.lblTotalAuthors);
            this.groupBox1.Controls.Add(this.lblTotalBooks);
            this.groupBox1.Controls.Add(this.lblTotalTitles);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 256);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // lblTotalCotas
            // 
            this.lblTotalCotas.AutoSize = true;
            this.lblTotalCotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotalCotas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalCotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblTotalCotas.Location = new System.Drawing.Point(16, 216);
            this.lblTotalCotas.Name = "lblTotalCotas";
            this.lblTotalCotas.Size = new System.Drawing.Size(125, 19);
            this.lblTotalCotas.TabIndex = 4;
            this.lblTotalCotas.Text = "Total de Cotas: ";
            // 
            // lblTotalAuthors
            // 
            this.lblTotalAuthors.AutoSize = true;
            this.lblTotalAuthors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotalAuthors.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAuthors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblTotalAuthors.Location = new System.Drawing.Point(16, 152);
            this.lblTotalAuthors.Name = "lblTotalAuthors";
            this.lblTotalAuthors.Size = new System.Drawing.Size(139, 19);
            this.lblTotalAuthors.TabIndex = 3;
            this.lblTotalAuthors.Text = "Total de Autores: ";
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotalBooks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblTotalBooks.Location = new System.Drawing.Point(16, 24);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(172, 19);
            this.lblTotalBooks.TabIndex = 0;
            this.lblTotalBooks.Text = "Total de Exemplares: ";
            // 
            // lblTotalTitles
            // 
            this.lblTotalTitles.AutoSize = true;
            this.lblTotalTitles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotalTitles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalTitles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblTotalTitles.Location = new System.Drawing.Point(16, 88);
            this.lblTotalTitles.Name = "lblTotalTitles";
            this.lblTotalTitles.Size = new System.Drawing.Size(127, 19);
            this.lblTotalTitles.TabIndex = 2;
            this.lblTotalTitles.Text = "Total de Títulos: ";
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 450);
            this.Controls.Add(this.pnlFormHeader);
            this.Controls.Add(this.pnlFormBody);
            this.Name = "frmStatistics";
            this.Text = "Estatísticas";
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.pnlFormBody.ResumeLayout(false);
            this.roundedGroupBox1.ResumeLayout(false);
            this.roundedGroupBox1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblTotalTitles;
        private System.Windows.Forms.Label lblTotalAuthors;
        private System.Windows.Forms.Label lblTotalCotas;
        #endregion
        private RoundedGroupBox groupBox1;
        private RoundedPanel pnlFormHeader;
        private System.Windows.Forms.Label lblListagem;
        private RoundedPanelBottom pnlFormBody;
        private RoundedGroupBox roundedGroupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConsultaLocal;
        private System.Windows.Forms.Label lblAbatido;
        private System.Windows.Forms.Label lblIndisponivel;
        private System.Windows.Forms.Label lblDisponivel;
        private System.Windows.Forms.Label lblExposicao;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Label lblPerdido;
    }
}