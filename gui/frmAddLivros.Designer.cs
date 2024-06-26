﻿namespace BIBLIOTECA_PROJETO.gui
{
    partial class frmAddLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddLivros));
            this.pnlAddLivros = new System.Windows.Forms.Panel();
            this.pnlFormFooter = new RoundedPanelBottom();
            this.pnlFormHeader = new RoundedPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblListagem = new System.Windows.Forms.Label();
            this.pnlFormBody = new System.Windows.Forms.Panel();
            this.groupBox1 = new RoundedGroupBox();
            this.nRegistoAdd = new System.Windows.Forms.Label();
            this.txtNRegisto = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtDataEntrega = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.pnlLineBottom = new System.Windows.Forms.Panel();
            this.groupBox2 = new RoundedGroupBox();
            this.cbxAquisicao = new MetroFramework.Controls.MetroComboBox();
            this.lblAquisicao = new System.Windows.Forms.Label();
            this.lblEditoraAdd = new System.Windows.Forms.Label();
            this.txtEditora = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtAutor = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtTitulo = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTituloAdd = new System.Windows.Forms.Label();
            this.groupBox3 = new RoundedGroupBox();
            this.bttClear_Edit = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.cbxEstado = new MetroFramework.Controls.MetroComboBox();
            this.bttSave = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.lblEstadoAdd = new System.Windows.Forms.Label();
            this.txtCota = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblCotaAdd = new System.Windows.Forms.Label();
            this.lblNVolAdd = new System.Windows.Forms.Label();
            this.txtNVolume = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblObservAdd = new System.Windows.Forms.Label();
            this.txtObservacoes = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.pnlAddLivros.SuspendLayout();
            this.pnlFormHeader.SuspendLayout();
            this.pnlFormBody.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddLivros
            // 
            this.pnlAddLivros.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAddLivros.Controls.Add(this.pnlFormFooter);
            this.pnlAddLivros.Controls.Add(this.pnlFormHeader);
            this.pnlAddLivros.Controls.Add(this.pnlFormBody);
            this.pnlAddLivros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddLivros.Location = new System.Drawing.Point(0, 0);
            this.pnlAddLivros.Name = "pnlAddLivros";
            this.pnlAddLivros.Size = new System.Drawing.Size(1064, 749);
            this.pnlAddLivros.TabIndex = 0;
            this.pnlAddLivros.Resize += new System.EventHandler(this.pnlAddLivros_Resize);
            // 
            // pnlFormFooter
            // 
            this.pnlFormFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.pnlFormFooter.CornerRadius = 10;
            this.pnlFormFooter.Location = new System.Drawing.Point(80, 552);
            this.pnlFormFooter.Name = "pnlFormFooter";
            this.pnlFormFooter.Size = new System.Drawing.Size(992, 48);
            this.pnlFormFooter.TabIndex = 61;
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.pnlFormHeader.Controls.Add(this.panel1);
            this.pnlFormHeader.Controls.Add(this.lblListagem);
            this.pnlFormHeader.CornerRadius = 10;
            this.pnlFormHeader.Location = new System.Drawing.Point(80, 80);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(992, 56);
            this.pnlFormHeader.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 12);
            this.panel1.TabIndex = 59;
            // 
            // lblListagem
            // 
            this.lblListagem.AutoSize = true;
            this.lblListagem.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.lblListagem.Location = new System.Drawing.Point(20, 16);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(152, 26);
            this.lblListagem.TabIndex = 12;
            this.lblListagem.Text = "Novo Registo";
            // 
            // pnlFormBody
            // 
            this.pnlFormBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.pnlFormBody.Controls.Add(this.groupBox1);
            this.pnlFormBody.Controls.Add(this.pnlLineBottom);
            this.pnlFormBody.Controls.Add(this.groupBox2);
            this.pnlFormBody.Controls.Add(this.groupBox3);
            this.pnlFormBody.Location = new System.Drawing.Point(80, 136);
            this.pnlFormBody.Name = "pnlFormBody";
            this.pnlFormBody.Size = new System.Drawing.Size(992, 416);
            this.pnlFormBody.TabIndex = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.groupBox1.BorderRadius = 5;
            this.groupBox1.Controls.Add(this.nRegistoAdd);
            this.groupBox1.Controls.Add(this.txtNRegisto);
            this.groupBox1.Controls.Add(this.txtDataEntrega);
            this.groupBox1.Controls.Add(this.lblDataEntrada);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.groupBox1.Location = new System.Drawing.Point(24, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 80);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // nRegistoAdd
            // 
            this.nRegistoAdd.AutoSize = true;
            this.nRegistoAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRegistoAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.nRegistoAdd.Location = new System.Drawing.Point(16, 32);
            this.nRegistoAdd.Name = "nRegistoAdd";
            this.nRegistoAdd.Size = new System.Drawing.Size(99, 17);
            this.nRegistoAdd.TabIndex = 30;
            this.nRegistoAdd.Text = "Nº. de Registo";
            // 
            // txtNRegisto
            // 
            this.txtNRegisto.BackColor = System.Drawing.SystemColors.Window;
            this.txtNRegisto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtNRegisto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtNRegisto.BorderSize = 2;
            this.txtNRegisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNRegisto.ForeColor = System.Drawing.Color.DimGray;
            this.txtNRegisto.Location = new System.Drawing.Point(120, 24);
            this.txtNRegisto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNRegisto.Multiline = false;
            this.txtNRegisto.Name = "txtNRegisto";
            this.txtNRegisto.Padding = new System.Windows.Forms.Padding(7);
            this.txtNRegisto.PasswordChar = false;
            this.txtNRegisto.Size = new System.Drawing.Size(72, 31);
            this.txtNRegisto.TabIndex = 27;
            this.txtNRegisto.Texts = "";
            this.txtNRegisto.UnderlinedStyle = true;
            this.txtNRegisto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNRegisto_KeyPress_1);
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataEntrega.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtDataEntrega.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtDataEntrega.BorderSize = 2;
            this.txtDataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEntrega.ForeColor = System.Drawing.Color.DimGray;
            this.txtDataEntrega.Location = new System.Drawing.Point(360, 24);
            this.txtDataEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataEntrega.Multiline = false;
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Padding = new System.Windows.Forms.Padding(7);
            this.txtDataEntrega.PasswordChar = false;
            this.txtDataEntrega.Size = new System.Drawing.Size(80, 31);
            this.txtDataEntrega.TabIndex = 28;
            this.txtDataEntrega.Texts = "";
            this.txtDataEntrega.UnderlinedStyle = true;
            this.txtDataEntrega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataEntrega_KeyPress);
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblDataEntrada.Location = new System.Drawing.Point(232, 32);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(117, 17);
            this.lblDataEntrada.TabIndex = 31;
            this.lblDataEntrada.Text = "Data de Entrada";
            // 
            // pnlLineBottom
            // 
            this.pnlLineBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.pnlLineBottom.Location = new System.Drawing.Point(0, 414);
            this.pnlLineBottom.Name = "pnlLineBottom";
            this.pnlLineBottom.Size = new System.Drawing.Size(992, 12);
            this.pnlLineBottom.TabIndex = 58;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.groupBox2.BorderRadius = 5;
            this.groupBox2.Controls.Add(this.cbxAquisicao);
            this.groupBox2.Controls.Add(this.lblAquisicao);
            this.groupBox2.Controls.Add(this.lblEditoraAdd);
            this.groupBox2.Controls.Add(this.txtEditora);
            this.groupBox2.Controls.Add(this.txtAutor);
            this.groupBox2.Controls.Add(this.txtTitulo);
            this.groupBox2.Controls.Add(this.lblAutor);
            this.groupBox2.Controls.Add(this.lblTituloAdd);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.groupBox2.Location = new System.Drawing.Point(24, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 248);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            // 
            // cbxAquisicao
            // 
            this.cbxAquisicao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxAquisicao.ForeColor = System.Drawing.Color.DimGray;
            this.cbxAquisicao.FormattingEnabled = true;
            this.cbxAquisicao.ItemHeight = 23;
            this.cbxAquisicao.Items.AddRange(new object[] {
            "Compra",
            "Oferta"});
            this.cbxAquisicao.Location = new System.Drawing.Point(120, 136);
            this.cbxAquisicao.Name = "cbxAquisicao";
            this.cbxAquisicao.Size = new System.Drawing.Size(192, 29);
            this.cbxAquisicao.TabIndex = 61;
            this.cbxAquisicao.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbxAquisicao.UseSelectable = true;
            // 
            // lblAquisicao
            // 
            this.lblAquisicao.AutoSize = true;
            this.lblAquisicao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAquisicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblAquisicao.Location = new System.Drawing.Point(37, 144);
            this.lblAquisicao.Name = "lblAquisicao";
            this.lblAquisicao.Size = new System.Drawing.Size(71, 17);
            this.lblAquisicao.TabIndex = 47;
            this.lblAquisicao.Text = "Aquisição";
            // 
            // lblEditoraAdd
            // 
            this.lblEditoraAdd.AutoSize = true;
            this.lblEditoraAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditoraAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblEditoraAdd.Location = new System.Drawing.Point(54, 200);
            this.lblEditoraAdd.Name = "lblEditoraAdd";
            this.lblEditoraAdd.Size = new System.Drawing.Size(54, 17);
            this.lblEditoraAdd.TabIndex = 48;
            this.lblEditoraAdd.Text = "Editora";
            // 
            // txtEditora
            // 
            this.txtEditora.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditora.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtEditora.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtEditora.BorderSize = 2;
            this.txtEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditora.Location = new System.Drawing.Point(120, 192);
            this.txtEditora.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditora.Multiline = false;
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Padding = new System.Windows.Forms.Padding(7);
            this.txtEditora.PasswordChar = false;
            this.txtEditora.Size = new System.Drawing.Size(320, 31);
            this.txtEditora.TabIndex = 49;
            this.txtEditora.Texts = "";
            this.txtEditora.UnderlinedStyle = true;
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.SystemColors.Window;
            this.txtAutor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtAutor.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtAutor.BorderSize = 2;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.ForeColor = System.Drawing.Color.DimGray;
            this.txtAutor.Location = new System.Drawing.Point(120, 80);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Multiline = false;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Padding = new System.Windows.Forms.Padding(7);
            this.txtAutor.PasswordChar = false;
            this.txtAutor.Size = new System.Drawing.Size(320, 31);
            this.txtAutor.TabIndex = 34;
            this.txtAutor.Texts = "";
            this.txtAutor.UnderlinedStyle = true;
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitulo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtTitulo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtTitulo.BorderSize = 2;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.txtTitulo.Location = new System.Drawing.Point(120, 24);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Multiline = false;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Padding = new System.Windows.Forms.Padding(7);
            this.txtTitulo.PasswordChar = false;
            this.txtTitulo.Size = new System.Drawing.Size(320, 31);
            this.txtTitulo.TabIndex = 29;
            this.txtTitulo.Texts = "";
            this.txtTitulo.UnderlinedStyle = true;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblAutor.Location = new System.Drawing.Point(65, 88);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(43, 17);
            this.lblAutor.TabIndex = 32;
            this.lblAutor.Text = "Autor";
            // 
            // lblTituloAdd
            // 
            this.lblTituloAdd.AutoSize = true;
            this.lblTituloAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblTituloAdd.Location = new System.Drawing.Point(64, 32);
            this.lblTituloAdd.Name = "lblTituloAdd";
            this.lblTituloAdd.Size = new System.Drawing.Size(41, 17);
            this.lblTituloAdd.TabIndex = 33;
            this.lblTituloAdd.Text = "Título";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.groupBox3.BorderRadius = 5;
            this.groupBox3.Controls.Add(this.bttClear_Edit);
            this.groupBox3.Controls.Add(this.cbxEstado);
            this.groupBox3.Controls.Add(this.bttSave);
            this.groupBox3.Controls.Add(this.lblEstadoAdd);
            this.groupBox3.Controls.Add(this.txtCota);
            this.groupBox3.Controls.Add(this.lblCotaAdd);
            this.groupBox3.Controls.Add(this.lblNVolAdd);
            this.groupBox3.Controls.Add(this.txtNVolume);
            this.groupBox3.Controls.Add(this.lblObservAdd);
            this.groupBox3.Controls.Add(this.txtObservacoes);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.groupBox3.Location = new System.Drawing.Point(504, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 264);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            // 
            // bttClear_Edit
            // 
            this.bttClear_Edit.BackColor = System.Drawing.Color.DimGray;
            this.bttClear_Edit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttClear_Edit.BorderRadius = 5;
            this.bttClear_Edit.BorderSize = 0;
            this.bttClear_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttClear_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttClear_Edit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttClear_Edit.ForeColor = System.Drawing.Color.Transparent;
            this.bttClear_Edit.Image = ((System.Drawing.Image)(resources.GetObject("bttClear_Edit.Image")));
            this.bttClear_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttClear_Edit.Location = new System.Drawing.Point(120, 208);
            this.bttClear_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.bttClear_Edit.Name = "bttClear_Edit";
            this.bttClear_Edit.Padding = new System.Windows.Forms.Padding(4, 0, 7, 0);
            this.bttClear_Edit.Size = new System.Drawing.Size(104, 40);
            this.bttClear_Edit.TabIndex = 59;
            this.bttClear_Edit.Text = "Limpar";
            this.bttClear_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttClear_Edit.UseVisualStyleBackColor = false;
            this.bttClear_Edit.Click += new System.EventHandler(this.bttClear_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxEstado.ForeColor = System.Drawing.Color.DimGray;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.ItemHeight = 23;
            this.cbxEstado.Items.AddRange(new object[] {
            "Disponível",
            "Indisponível",
            "Abatido",
            "Perdido",
            "Consulta local",
            "Exposição",
            "Depósito"});
            this.cbxEstado.Location = new System.Drawing.Point(120, 80);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(192, 29);
            this.cbxEstado.TabIndex = 62;
            this.cbxEstado.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbxEstado.UseSelectable = true;
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.bttSave.BorderColor = System.Drawing.Color.White;
            this.bttSave.BorderRadius = 5;
            this.bttSave.BorderSize = 0;
            this.bttSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttSave.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.bttSave.FlatAppearance.BorderSize = 0;
            this.bttSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSave.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttSave.Image = global::BIBLIOTECA_PROJETO.Properties.Resources.icon_newbook;
            this.bttSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttSave.Location = new System.Drawing.Point(240, 208);
            this.bttSave.Margin = new System.Windows.Forms.Padding(0);
            this.bttSave.Name = "bttSave";
            this.bttSave.Padding = new System.Windows.Forms.Padding(10, 0, 9, 0);
            this.bttSave.Size = new System.Drawing.Size(200, 40);
            this.bttSave.TabIndex = 53;
            this.bttSave.Text = "Adicionar Exemplar";
            this.bttSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttSave.UseVisualStyleBackColor = false;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // lblEstadoAdd
            // 
            this.lblEstadoAdd.AutoSize = true;
            this.lblEstadoAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblEstadoAdd.Location = new System.Drawing.Point(61, 88);
            this.lblEstadoAdd.Name = "lblEstadoAdd";
            this.lblEstadoAdd.Size = new System.Drawing.Size(52, 17);
            this.lblEstadoAdd.TabIndex = 48;
            this.lblEstadoAdd.Text = "Estado";
            // 
            // txtCota
            // 
            this.txtCota.BackColor = System.Drawing.SystemColors.Window;
            this.txtCota.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtCota.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtCota.BorderSize = 2;
            this.txtCota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCota.ForeColor = System.Drawing.Color.DimGray;
            this.txtCota.Location = new System.Drawing.Point(120, 24);
            this.txtCota.Margin = new System.Windows.Forms.Padding(4);
            this.txtCota.Multiline = false;
            this.txtCota.Name = "txtCota";
            this.txtCota.Padding = new System.Windows.Forms.Padding(7);
            this.txtCota.PasswordChar = false;
            this.txtCota.Size = new System.Drawing.Size(128, 31);
            this.txtCota.TabIndex = 41;
            this.txtCota.Texts = "";
            this.txtCota.UnderlinedStyle = true;
            // 
            // lblCotaAdd
            // 
            this.lblCotaAdd.AutoSize = true;
            this.lblCotaAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotaAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblCotaAdd.Location = new System.Drawing.Point(16, 32);
            this.lblCotaAdd.Name = "lblCotaAdd";
            this.lblCotaAdd.Size = new System.Drawing.Size(97, 17);
            this.lblCotaAdd.TabIndex = 38;
            this.lblCotaAdd.Text = "Cota da CDU";
            // 
            // lblNVolAdd
            // 
            this.lblNVolAdd.AutoSize = true;
            this.lblNVolAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNVolAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblNVolAdd.Location = new System.Drawing.Point(272, 32);
            this.lblNVolAdd.Name = "lblNVolAdd";
            this.lblNVolAdd.Size = new System.Drawing.Size(77, 17);
            this.lblNVolAdd.TabIndex = 39;
            this.lblNVolAdd.Text = "Nº Volume";
            // 
            // txtNVolume
            // 
            this.txtNVolume.BackColor = System.Drawing.SystemColors.Window;
            this.txtNVolume.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtNVolume.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtNVolume.BorderSize = 2;
            this.txtNVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNVolume.ForeColor = System.Drawing.Color.DimGray;
            this.txtNVolume.Location = new System.Drawing.Point(360, 24);
            this.txtNVolume.Margin = new System.Windows.Forms.Padding(4);
            this.txtNVolume.Multiline = false;
            this.txtNVolume.Name = "txtNVolume";
            this.txtNVolume.Padding = new System.Windows.Forms.Padding(7);
            this.txtNVolume.PasswordChar = false;
            this.txtNVolume.Size = new System.Drawing.Size(80, 31);
            this.txtNVolume.TabIndex = 40;
            this.txtNVolume.Texts = "";
            this.txtNVolume.UnderlinedStyle = true;
            // 
            // lblObservAdd
            // 
            this.lblObservAdd.AutoSize = true;
            this.lblObservAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblObservAdd.Location = new System.Drawing.Point(21, 136);
            this.lblObservAdd.Name = "lblObservAdd";
            this.lblObservAdd.Size = new System.Drawing.Size(92, 17);
            this.lblObservAdd.TabIndex = 42;
            this.lblObservAdd.Text = "Observações";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservacoes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtObservacoes.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtObservacoes.BorderSize = 2;
            this.txtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.ForeColor = System.Drawing.Color.DimGray;
            this.txtObservacoes.Location = new System.Drawing.Point(120, 136);
            this.txtObservacoes.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Padding = new System.Windows.Forms.Padding(7);
            this.txtObservacoes.PasswordChar = false;
            this.txtObservacoes.Size = new System.Drawing.Size(320, 48);
            this.txtObservacoes.TabIndex = 44;
            this.txtObservacoes.Texts = "";
            this.txtObservacoes.UnderlinedStyle = true;
            // 
            // frmAddLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 749);
            this.Controls.Add(this.pnlAddLivros);
            this.Name = "frmAddLivros";
            this.Load += new System.EventHandler(this.frmAddLivros_Load);
            this.pnlAddLivros.ResumeLayout(false);
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.pnlFormBody.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddLivros;
        private controls.UC_textbox txtCota;
        private System.Windows.Forms.Label lblCotaAdd;
        private System.Windows.Forms.Label lblNVolAdd;
        private controls.UC_textbox txtNVolume;
        private System.Windows.Forms.Label lblObservAdd;
        private controls.UC_textbox txtObservacoes;
        private controls.UC_textbox txtAutor;
        private controls.UC_textbox txtTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTituloAdd;
        private System.Windows.Forms.Label nRegistoAdd;
        private controls.UC_textbox txtNRegisto;
        private controls.UC_textbox txtDataEntrega;
        private System.Windows.Forms.Label lblDataEntrada;
        private RoundedGroupBox groupBox3;
        private RoundedGroupBox groupBox2;
        private RoundedGroupBox groupBox1;
        private controls.RoundedButton bttSave;
        private System.Windows.Forms.Label lblListagem;
        private System.Windows.Forms.Label lblAquisicao;
        private System.Windows.Forms.Label lblEditoraAdd;
        private controls.UC_textbox txtEditora;
        private System.Windows.Forms.Label lblEstadoAdd;
        private System.Windows.Forms.Panel pnlFormBody;
        private RoundedPanel pnlFormHeader;
        private MetroFramework.Controls.MetroComboBox cbxAquisicao;
        private MetroFramework.Controls.MetroComboBox cbxEstado;
        private RoundedPanelBottom pnlFormFooter;
        private System.Windows.Forms.Panel pnlLineBottom;
        private System.Windows.Forms.Panel panel1;
        private controls.RoundedButton bttClear_Edit;
    }
}