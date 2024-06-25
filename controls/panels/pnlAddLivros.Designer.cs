namespace BIBLIOTECA_PROJETO
{
    partial class pnlAddLivros
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nRegistoAdd = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTituloAdd = new System.Windows.Forms.Label();
            this.lblAquisicao = new System.Windows.Forms.Label();
            this.lblEditoraAdd = new System.Windows.Forms.Label();
            this.lblCotaAdd = new System.Windows.Forms.Label();
            this.lblNVolAdd = new System.Windows.Forms.Label();
            this.lblObservAdd = new System.Windows.Forms.Label();
            this.lblEstadoAdd = new System.Windows.Forms.Label();
            this.bttSave = new System.Windows.Forms.Button();
            this.cbxEstado = new BIBLIOTECA_PROJETO.controls.UC_ComboBox();
            this.cbxAquisicao = new BIBLIOTECA_PROJETO.controls.UC_ComboBox();
            this.txtObservacoes = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtCota = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtNVolume = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtEditora = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtAutor = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtTitulo = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtDataEntrega = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtNRegisto = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.SuspendLayout();
            // 
            // nRegistoAdd
            // 
            this.nRegistoAdd.AutoSize = true;
            this.nRegistoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRegistoAdd.ForeColor = System.Drawing.Color.DimGray;
            this.nRegistoAdd.Location = new System.Drawing.Point(365, 48);
            this.nRegistoAdd.Name = "nRegistoAdd";
            this.nRegistoAdd.Size = new System.Drawing.Size(104, 16);
            this.nRegistoAdd.TabIndex = 3;
            this.nRegistoAdd.Text = "Nº de Registo";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.ForeColor = System.Drawing.Color.DimGray;
            this.lblDataEntrada.Location = new System.Drawing.Point(593, 48);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(120, 16);
            this.lblDataEntrada.TabIndex = 4;
            this.lblDataEntrada.Text = "Data de Entrada";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.Color.DimGray;
            this.lblAutor.Location = new System.Drawing.Point(426, 120);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(43, 16);
            this.lblAutor.TabIndex = 5;
            this.lblAutor.Text = "Autor";
            // 
            // lblTituloAdd
            // 
            this.lblTituloAdd.AutoSize = true;
            this.lblTituloAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAdd.ForeColor = System.Drawing.Color.DimGray;
            this.lblTituloAdd.Location = new System.Drawing.Point(423, 192);
            this.lblTituloAdd.Name = "lblTituloAdd";
            this.lblTituloAdd.Size = new System.Drawing.Size(46, 16);
            this.lblTituloAdd.TabIndex = 6;
            this.lblTituloAdd.Text = "Título";
            // 
            // lblAquisicao
            // 
            this.lblAquisicao.AutoSize = true;
            this.lblAquisicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAquisicao.ForeColor = System.Drawing.Color.DimGray;
            this.lblAquisicao.Location = new System.Drawing.Point(393, 264);
            this.lblAquisicao.Name = "lblAquisicao";
            this.lblAquisicao.Size = new System.Drawing.Size(76, 16);
            this.lblAquisicao.TabIndex = 8;
            this.lblAquisicao.Text = "Aquisição";
            // 
            // lblEditoraAdd
            // 
            this.lblEditoraAdd.AutoSize = true;
            this.lblEditoraAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditoraAdd.ForeColor = System.Drawing.Color.DimGray;
            this.lblEditoraAdd.Location = new System.Drawing.Point(412, 328);
            this.lblEditoraAdd.Name = "lblEditoraAdd";
            this.lblEditoraAdd.Size = new System.Drawing.Size(57, 16);
            this.lblEditoraAdd.TabIndex = 9;
            this.lblEditoraAdd.Text = "Editora";
            // 
            // lblCotaAdd
            // 
            this.lblCotaAdd.AutoSize = true;
            this.lblCotaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotaAdd.ForeColor = System.Drawing.Color.DimGray;
            this.lblCotaAdd.Location = new System.Drawing.Point(372, 392);
            this.lblCotaAdd.Name = "lblCotaAdd";
            this.lblCotaAdd.Size = new System.Drawing.Size(97, 16);
            this.lblCotaAdd.TabIndex = 12;
            this.lblCotaAdd.Text = "Cota da CDU";
            // 
            // lblNVolAdd
            // 
            this.lblNVolAdd.AutoSize = true;
            this.lblNVolAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNVolAdd.ForeColor = System.Drawing.Color.DimGray;
            this.lblNVolAdd.Location = new System.Drawing.Point(633, 392);
            this.lblNVolAdd.Name = "lblNVolAdd";
            this.lblNVolAdd.Size = new System.Drawing.Size(80, 16);
            this.lblNVolAdd.TabIndex = 13;
            this.lblNVolAdd.Text = "Nº Volume";
            // 
            // lblObservAdd
            // 
            this.lblObservAdd.AutoSize = true;
            this.lblObservAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservAdd.ForeColor = System.Drawing.Color.DimGray;
            this.lblObservAdd.Location = new System.Drawing.Point(369, 440);
            this.lblObservAdd.Name = "lblObservAdd";
            this.lblObservAdd.Size = new System.Drawing.Size(100, 16);
            this.lblObservAdd.TabIndex = 17;
            this.lblObservAdd.Text = "Observações";
            // 
            // lblEstadoAdd
            // 
            this.lblEstadoAdd.AutoSize = true;
            this.lblEstadoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoAdd.ForeColor = System.Drawing.Color.DimGray;
            this.lblEstadoAdd.Location = new System.Drawing.Point(401, 512);
            this.lblEstadoAdd.Name = "lblEstadoAdd";
            this.lblEstadoAdd.Size = new System.Drawing.Size(56, 16);
            this.lblEstadoAdd.TabIndex = 18;
            this.lblEstadoAdd.Text = "Estado";
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttSave.Location = new System.Drawing.Point(480, 560);
            this.bttSave.Margin = new System.Windows.Forms.Padding(0);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(328, 32);
            this.bttSave.TabIndex = 22;
            this.bttSave.Text = "Adicionar exemplar";
            this.bttSave.UseVisualStyleBackColor = false;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxEstado.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxEstado.BorderSize = 1;
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxEstado.ForeColor = System.Drawing.Color.DimGray;
            this.cbxEstado.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxEstado.Items.AddRange(new object[] {
            "Disponível",
            "Indisponível",
            "Abatido",
            "Perdido",
            "Consulta local",
            "Exposição",
            "Depósito"});
            this.cbxEstado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxEstado.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxEstado.Location = new System.Drawing.Point(480, 504);
            this.cbxEstado.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Padding = new System.Windows.Forms.Padding(1);
            this.cbxEstado.Size = new System.Drawing.Size(200, 30);
            this.cbxEstado.TabIndex = 26;
            this.cbxEstado.Texts = "";
            // 
            // cbxAquisicao
            // 
            this.cbxAquisicao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxAquisicao.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxAquisicao.BorderSize = 1;
            this.cbxAquisicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxAquisicao.ForeColor = System.Drawing.Color.DimGray;
            this.cbxAquisicao.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxAquisicao.Items.AddRange(new object[] {
            "Compra",
            "Oferta"});
            this.cbxAquisicao.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxAquisicao.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxAquisicao.Location = new System.Drawing.Point(480, 256);
            this.cbxAquisicao.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxAquisicao.Name = "cbxAquisicao";
            this.cbxAquisicao.Padding = new System.Windows.Forms.Padding(1);
            this.cbxAquisicao.Size = new System.Drawing.Size(200, 30);
            this.cbxAquisicao.TabIndex = 25;
            this.cbxAquisicao.Texts = "<selecione o método>";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservacoes.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtObservacoes.BorderSize = 2;
            this.txtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.ForeColor = System.Drawing.Color.DimGray;
            this.txtObservacoes.Location = new System.Drawing.Point(481, 432);
            this.txtObservacoes.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Padding = new System.Windows.Forms.Padding(7);
            this.txtObservacoes.PasswordChar = false;
            this.txtObservacoes.Size = new System.Drawing.Size(320, 48);
            this.txtObservacoes.TabIndex = 19;
            this.txtObservacoes.Texts = "";
            this.txtObservacoes.UnderlinedStyle = true;
            // 
            // txtCota
            // 
            this.txtCota.BackColor = System.Drawing.SystemColors.Window;
            this.txtCota.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCota.BorderSize = 2;
            this.txtCota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCota.ForeColor = System.Drawing.Color.DimGray;
            this.txtCota.Location = new System.Drawing.Point(481, 376);
            this.txtCota.Margin = new System.Windows.Forms.Padding(4);
            this.txtCota.Multiline = false;
            this.txtCota.Name = "txtCota";
            this.txtCota.Padding = new System.Windows.Forms.Padding(7);
            this.txtCota.PasswordChar = false;
            this.txtCota.Size = new System.Drawing.Size(128, 31);
            this.txtCota.TabIndex = 15;
            this.txtCota.Texts = "";
            this.txtCota.UnderlinedStyle = true;
            // 
            // txtNVolume
            // 
            this.txtNVolume.BackColor = System.Drawing.SystemColors.Window;
            this.txtNVolume.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNVolume.BorderSize = 2;
            this.txtNVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNVolume.ForeColor = System.Drawing.Color.DimGray;
            this.txtNVolume.Location = new System.Drawing.Point(721, 376);
            this.txtNVolume.Margin = new System.Windows.Forms.Padding(4);
            this.txtNVolume.Multiline = false;
            this.txtNVolume.Name = "txtNVolume";
            this.txtNVolume.Padding = new System.Windows.Forms.Padding(7);
            this.txtNVolume.PasswordChar = false;
            this.txtNVolume.Size = new System.Drawing.Size(80, 31);
            this.txtNVolume.TabIndex = 14;
            this.txtNVolume.Texts = "";
            this.txtNVolume.UnderlinedStyle = true;
            // 
            // txtEditora
            // 
            this.txtEditora.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditora.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEditora.BorderSize = 2;
            this.txtEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditora.Location = new System.Drawing.Point(481, 312);
            this.txtEditora.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditora.Multiline = false;
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Padding = new System.Windows.Forms.Padding(7);
            this.txtEditora.PasswordChar = false;
            this.txtEditora.Size = new System.Drawing.Size(320, 31);
            this.txtEditora.TabIndex = 10;
            this.txtEditora.Texts = "";
            this.txtEditora.UnderlinedStyle = true;
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.SystemColors.Window;
            this.txtAutor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAutor.BorderSize = 2;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.ForeColor = System.Drawing.Color.DimGray;
            this.txtAutor.Location = new System.Drawing.Point(481, 176);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Multiline = false;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Padding = new System.Windows.Forms.Padding(7);
            this.txtAutor.PasswordChar = false;
            this.txtAutor.Size = new System.Drawing.Size(320, 31);
            this.txtAutor.TabIndex = 7;
            this.txtAutor.Texts = "";
            this.txtAutor.UnderlinedStyle = true;
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitulo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTitulo.BorderSize = 2;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.txtTitulo.Location = new System.Drawing.Point(481, 104);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Multiline = false;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Padding = new System.Windows.Forms.Padding(7);
            this.txtTitulo.PasswordChar = false;
            this.txtTitulo.Size = new System.Drawing.Size(320, 31);
            this.txtTitulo.TabIndex = 2;
            this.txtTitulo.Texts = "";
            this.txtTitulo.UnderlinedStyle = true;
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataEntrega.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDataEntrega.BorderSize = 2;
            this.txtDataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEntrega.ForeColor = System.Drawing.Color.DimGray;
            this.txtDataEntrega.Location = new System.Drawing.Point(721, 32);
            this.txtDataEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataEntrega.Multiline = false;
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Padding = new System.Windows.Forms.Padding(7);
            this.txtDataEntrega.PasswordChar = false;
            this.txtDataEntrega.Size = new System.Drawing.Size(80, 31);
            this.txtDataEntrega.TabIndex = 1;
            this.txtDataEntrega.Texts = "";
            this.txtDataEntrega.UnderlinedStyle = true;
            this.txtDataEntrega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataEntrega_KeyPress);
            // 
            // txtNRegisto
            // 
            this.txtNRegisto.BackColor = System.Drawing.SystemColors.Window;
            this.txtNRegisto.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNRegisto.BorderSize = 2;
            this.txtNRegisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNRegisto.ForeColor = System.Drawing.Color.DimGray;
            this.txtNRegisto.Location = new System.Drawing.Point(481, 32);
            this.txtNRegisto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNRegisto.Multiline = false;
            this.txtNRegisto.Name = "txtNRegisto";
            this.txtNRegisto.Padding = new System.Windows.Forms.Padding(7);
            this.txtNRegisto.PasswordChar = false;
            this.txtNRegisto.Size = new System.Drawing.Size(72, 31);
            this.txtNRegisto.TabIndex = 0;
            this.txtNRegisto.Texts = "";
            this.txtNRegisto.UnderlinedStyle = true;
            this.txtNRegisto.Click += new System.EventHandler(this.txtNRegisto_Click);
            this.txtNRegisto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNRegisto_KeyPress);
            // 
            // pnlAddLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.cbxAquisicao);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.lblEstadoAdd);
            this.Controls.Add(this.lblObservAdd);
            this.Controls.Add(this.txtCota);
            this.Controls.Add(this.txtNVolume);
            this.Controls.Add(this.lblNVolAdd);
            this.Controls.Add(this.lblCotaAdd);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.lblEditoraAdd);
            this.Controls.Add(this.lblAquisicao);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblTituloAdd);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.nRegistoAdd);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtDataEntrega);
            this.Controls.Add(this.txtNRegisto);
            this.Name = "pnlAddLivros";
            this.Size = new System.Drawing.Size(1167, 616);
            this.Load += new System.EventHandler(this.pnlAddLivros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.UC_textbox txtNRegisto;
        private controls.UC_textbox txtDataEntrega;
        private controls.UC_textbox txtTitulo;
        private System.Windows.Forms.Label nRegistoAdd;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTituloAdd;
        private controls.UC_textbox txtAutor;
        private System.Windows.Forms.Label lblAquisicao;
        private System.Windows.Forms.Label lblEditoraAdd;
        private controls.UC_textbox txtEditora;
        private System.Windows.Forms.Label lblCotaAdd;
        private System.Windows.Forms.Label lblNVolAdd;
        private controls.UC_textbox txtNVolume;
        private controls.UC_textbox txtCota;
        private System.Windows.Forms.Label lblObservAdd;
        private System.Windows.Forms.Label lblEstadoAdd;
        private controls.UC_textbox txtObservacoes;
        private System.Windows.Forms.Button bttSave;
        private controls.UC_ComboBox cbxAquisicao;
        private controls.UC_ComboBox cbxEstado;
    }
}
