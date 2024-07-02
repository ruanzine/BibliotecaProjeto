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
            this.pnlFormBody = new System.Windows.Forms.Panel();
            this.pnlLineBottom = new System.Windows.Forms.Panel();
            this.gpbRight = new RoundedGroupBox();
            this.lblPerdido = new System.Windows.Forms.Label();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.lblExposicao = new System.Windows.Forms.Label();
            this.lblConsultaLocal = new System.Windows.Forms.Label();
            this.lblAbatido = new System.Windows.Forms.Label();
            this.lblIndisponivel = new System.Windows.Forms.Label();
            this.lblDisponivel = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.gpbLeft = new RoundedGroupBox();
            this.lblTotalCotas = new System.Windows.Forms.Label();
            this.lblTotalAuthors = new System.Windows.Forms.Label();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.lblTotalTitles = new System.Windows.Forms.Label();
            this.pnlLineTop = new System.Windows.Forms.Panel();
            this.pnlFormFooter = new RoundedPanelBottom();
            this.pnlFormHeader = new RoundedPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFormBody.SuspendLayout();
            this.gpbRight.SuspendLayout();
            this.gpbLeft.SuspendLayout();
            this.pnlFormHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormBody
            // 
            this.pnlFormBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.pnlFormBody.Controls.Add(this.pnlLineBottom);
            this.pnlFormBody.Controls.Add(this.gpbRight);
            this.pnlFormBody.Controls.Add(this.gpbLeft);
            this.pnlFormBody.Location = new System.Drawing.Point(128, 184);
            this.pnlFormBody.Name = "pnlFormBody";
            this.pnlFormBody.Size = new System.Drawing.Size(904, 296);
            this.pnlFormBody.TabIndex = 5;
            // 
            // pnlLineBottom
            // 
            this.pnlLineBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.pnlLineBottom.Location = new System.Drawing.Point(0, 294);
            this.pnlLineBottom.Name = "pnlLineBottom";
            this.pnlLineBottom.Size = new System.Drawing.Size(904, 12);
            this.pnlLineBottom.TabIndex = 65;
            // 
            // gpbRight
            // 
            this.gpbRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.gpbRight.BorderRadius = 5;
            this.gpbRight.Controls.Add(this.lblPerdido);
            this.gpbRight.Controls.Add(this.lblDeposito);
            this.gpbRight.Controls.Add(this.lblExposicao);
            this.gpbRight.Controls.Add(this.lblConsultaLocal);
            this.gpbRight.Controls.Add(this.lblAbatido);
            this.gpbRight.Controls.Add(this.lblIndisponivel);
            this.gpbRight.Controls.Add(this.lblDisponivel);
            this.gpbRight.Controls.Add(this.lblCondition);
            this.gpbRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.gpbRight.Location = new System.Drawing.Point(384, 16);
            this.gpbRight.Name = "gpbRight";
            this.gpbRight.Size = new System.Drawing.Size(504, 256);
            this.gpbRight.TabIndex = 56;
            this.gpbRight.TabStop = false;
            // 
            // lblPerdido
            // 
            this.lblPerdido.AutoSize = true;
            this.lblPerdido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
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
            this.lblDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
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
            this.lblExposicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
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
            this.lblConsultaLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
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
            this.lblAbatido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
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
            this.lblIndisponivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
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
            this.lblDisponivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.lblDisponivel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDisponivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblDisponivel.Location = new System.Drawing.Point(40, 56);
            this.lblDisponivel.Name = "lblDisponivel";
            this.lblDisponivel.Size = new System.Drawing.Size(135, 21);
            this.lblDisponivel.TabIndex = 6;
            this.lblDisponivel.Text = "Total Disponível:";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.lblCondition.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblCondition.Location = new System.Drawing.Point(16, 16);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(59, 19);
            this.lblCondition.TabIndex = 5;
            this.lblCondition.Text = "Estado";
            // 
            // gpbLeft
            // 
            this.gpbLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.gpbLeft.BorderRadius = 5;
            this.gpbLeft.Controls.Add(this.lblTotalCotas);
            this.gpbLeft.Controls.Add(this.lblTotalAuthors);
            this.gpbLeft.Controls.Add(this.lblTotalBooks);
            this.gpbLeft.Controls.Add(this.lblTotalTitles);
            this.gpbLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.gpbLeft.Location = new System.Drawing.Point(16, 16);
            this.gpbLeft.Name = "gpbLeft";
            this.gpbLeft.Size = new System.Drawing.Size(344, 256);
            this.gpbLeft.TabIndex = 55;
            this.gpbLeft.TabStop = false;
            // 
            // lblTotalCotas
            // 
            this.lblTotalCotas.AutoSize = true;
            this.lblTotalCotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
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
            this.lblTotalAuthors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
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
            this.lblTotalBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
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
            this.lblTotalTitles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.lblTotalTitles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalTitles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblTotalTitles.Location = new System.Drawing.Point(16, 88);
            this.lblTotalTitles.Name = "lblTotalTitles";
            this.lblTotalTitles.Size = new System.Drawing.Size(127, 19);
            this.lblTotalTitles.TabIndex = 2;
            this.lblTotalTitles.Text = "Total de Títulos: ";
            // 
            // pnlLineTop
            // 
            this.pnlLineTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.pnlLineTop.Location = new System.Drawing.Point(128, 182);
            this.pnlLineTop.Name = "pnlLineTop";
            this.pnlLineTop.Size = new System.Drawing.Size(904, 12);
            this.pnlLineTop.TabIndex = 64;
            // 
            // pnlFormFooter
            // 
            this.pnlFormFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.pnlFormFooter.CornerRadius = 10;
            this.pnlFormFooter.Location = new System.Drawing.Point(128, 472);
            this.pnlFormFooter.Name = "pnlFormFooter";
            this.pnlFormFooter.Size = new System.Drawing.Size(904, 48);
            this.pnlFormFooter.TabIndex = 62;
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.pnlFormHeader.Controls.Add(this.lblTitle);
            this.pnlFormHeader.CornerRadius = 10;
            this.pnlFormHeader.Location = new System.Drawing.Point(128, 136);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(904, 48);
            this.pnlFormHeader.TabIndex = 60;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 26);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Estatísticas";
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 518);
            this.Controls.Add(this.pnlFormBody);
            this.Controls.Add(this.pnlLineTop);
            this.Controls.Add(this.pnlFormFooter);
            this.Controls.Add(this.pnlFormHeader);
            this.Name = "frmStatistics";
            this.Text = "Estatísticas";
            this.pnlFormBody.ResumeLayout(false);
            this.gpbRight.ResumeLayout(false);
            this.gpbRight.PerformLayout();
            this.gpbLeft.ResumeLayout(false);
            this.gpbLeft.PerformLayout();
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblTotalTitles;
        private System.Windows.Forms.Label lblTotalAuthors;
        private System.Windows.Forms.Label lblTotalCotas;
        #endregion
        private RoundedGroupBox gpbLeft;
        private RoundedPanel pnlFormHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFormBody;
        private RoundedGroupBox gpbRight;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblConsultaLocal;
        private System.Windows.Forms.Label lblAbatido;
        private System.Windows.Forms.Label lblIndisponivel;
        private System.Windows.Forms.Label lblDisponivel;
        private System.Windows.Forms.Label lblExposicao;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Label lblPerdido;
        private RoundedPanelBottom pnlFormFooter;
        private System.Windows.Forms.Panel pnlLineBottom;
        private System.Windows.Forms.Panel pnlLineTop;
    }
}