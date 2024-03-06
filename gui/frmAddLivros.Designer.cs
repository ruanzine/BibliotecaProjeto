namespace BIBLIOTECA_PROJETO.gui
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
            this.pnlAddLivros = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new BIBLIOTECA_PROJETO.controls.UC_ComboBox();
            this.lblEstadoAdd = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCota = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblCotaAdd = new System.Windows.Forms.Label();
            this.lblNVolAdd = new System.Windows.Forms.Label();
            this.txtNVolume = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblObservAdd = new System.Windows.Forms.Label();
            this.txtObservacoes = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbxAquisicao = new BIBLIOTECA_PROJETO.controls.UC_ComboBox();
            this.lblAquisicao = new System.Windows.Forms.Label();
            this.lblEditoraAdd = new System.Windows.Forms.Label();
            this.txtEditora = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAutor = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtTitulo = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTituloAdd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nRegistoAdd = new System.Windows.Forms.Label();
            this.txtNRegisto = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtDataEntrega = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.bttSave = new System.Windows.Forms.Button();
            this.pnlAddLivros.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddLivros
            // 
            this.pnlAddLivros.BackColor = System.Drawing.Color.White;
            this.pnlAddLivros.Controls.Add(this.groupBox5);
            this.pnlAddLivros.Controls.Add(this.groupBox3);
            this.pnlAddLivros.Controls.Add(this.groupBox4);
            this.pnlAddLivros.Controls.Add(this.groupBox2);
            this.pnlAddLivros.Controls.Add(this.groupBox1);
            this.pnlAddLivros.Controls.Add(this.bttSave);
            this.pnlAddLivros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddLivros.Location = new System.Drawing.Point(0, 0);
            this.pnlAddLivros.Name = "pnlAddLivros";
            this.pnlAddLivros.Size = new System.Drawing.Size(906, 685);
            this.pnlAddLivros.TabIndex = 0;
            this.pnlAddLivros.Resize += new System.EventHandler(this.pnlAddLivros_Resize);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbxEstado);
            this.groupBox5.Controls.Add(this.lblEstadoAdd);
            this.groupBox5.Location = new System.Drawing.Point(181, 536);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(544, 78);
            this.groupBox5.TabIndex = 58;
            this.groupBox5.TabStop = false;
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
            this.cbxEstado.Location = new System.Drawing.Point(160, 24);
            this.cbxEstado.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Padding = new System.Windows.Forms.Padding(1);
            this.cbxEstado.Size = new System.Drawing.Size(200, 30);
            this.cbxEstado.TabIndex = 47;
            this.cbxEstado.Texts = "<selecione o estado>";
            // 
            // lblEstadoAdd
            // 
            this.lblEstadoAdd.AutoSize = true;
            this.lblEstadoAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoAdd.ForeColor = System.Drawing.Color.DimGray;
            this.lblEstadoAdd.Location = new System.Drawing.Point(107, 32);
            this.lblEstadoAdd.Name = "lblEstadoAdd";
            this.lblEstadoAdd.Size = new System.Drawing.Size(52, 17);
            this.lblEstadoAdd.TabIndex = 43;
            this.lblEstadoAdd.Text = "Estado";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCota);
            this.groupBox3.Controls.Add(this.lblCotaAdd);
            this.groupBox3.Controls.Add(this.lblNVolAdd);
            this.groupBox3.Controls.Add(this.txtNVolume);
            this.groupBox3.Controls.Add(this.lblObservAdd);
            this.groupBox3.Controls.Add(this.txtObservacoes);
            this.groupBox3.Location = new System.Drawing.Point(181, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 136);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            // 
            // txtCota
            // 
            this.txtCota.BackColor = System.Drawing.SystemColors.Window;
            this.txtCota.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCota.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtCota.BorderSize = 2;
            this.txtCota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCota.ForeColor = System.Drawing.Color.DimGray;
            this.txtCota.Location = new System.Drawing.Point(160, 32);
            this.txtCota.Margin = new System.Windows.Forms.Padding(4);
            this.txtCota.Multiline = false;
            this.txtCota.Name = "txtCota";
            this.txtCota.Padding = new System.Windows.Forms.Padding(7);
            this.txtCota.PasswordChar = false;
            this.txtCota.Size = new System.Drawing.Size(128, 31);
            this.txtCota.TabIndex = 41;
            this.txtCota.Texts = "sim 123";
            this.txtCota.UnderlinedStyle = true;
            // 
            // lblCotaAdd
            // 
            this.lblCotaAdd.AutoSize = true;
            this.lblCotaAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotaAdd.ForeColor = System.Drawing.Color.DimGray;
            this.lblCotaAdd.Location = new System.Drawing.Point(62, 40);
            this.lblCotaAdd.Name = "lblCotaAdd";
            this.lblCotaAdd.Size = new System.Drawing.Size(97, 17);
            this.lblCotaAdd.TabIndex = 38;
            this.lblCotaAdd.Text = "Cota da CDU";
            // 
            // lblNVolAdd
            // 
            this.lblNVolAdd.AutoSize = true;
            this.lblNVolAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNVolAdd.ForeColor = System.Drawing.Color.DimGray;
            this.lblNVolAdd.Location = new System.Drawing.Point(312, 40);
            this.lblNVolAdd.Name = "lblNVolAdd";
            this.lblNVolAdd.Size = new System.Drawing.Size(77, 17);
            this.lblNVolAdd.TabIndex = 39;
            this.lblNVolAdd.Text = "Nº Volume";
            // 
            // txtNVolume
            // 
            this.txtNVolume.BackColor = System.Drawing.SystemColors.Window;
            this.txtNVolume.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNVolume.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtNVolume.BorderSize = 2;
            this.txtNVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNVolume.ForeColor = System.Drawing.Color.DimGray;
            this.txtNVolume.Location = new System.Drawing.Point(400, 32);
            this.txtNVolume.Margin = new System.Windows.Forms.Padding(4);
            this.txtNVolume.Multiline = false;
            this.txtNVolume.Name = "txtNVolume";
            this.txtNVolume.Padding = new System.Windows.Forms.Padding(7);
            this.txtNVolume.PasswordChar = false;
            this.txtNVolume.Size = new System.Drawing.Size(80, 31);
            this.txtNVolume.TabIndex = 40;
            this.txtNVolume.Texts = "1";
            this.txtNVolume.UnderlinedStyle = true;
            // 
            // lblObservAdd
            // 
            this.lblObservAdd.AutoSize = true;
            this.lblObservAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservAdd.ForeColor = System.Drawing.Color.DimGray;
            this.lblObservAdd.Location = new System.Drawing.Point(67, 88);
            this.lblObservAdd.Name = "lblObservAdd";
            this.lblObservAdd.Size = new System.Drawing.Size(92, 17);
            this.lblObservAdd.TabIndex = 42;
            this.lblObservAdd.Text = "Observações";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservacoes.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtObservacoes.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtObservacoes.BorderSize = 2;
            this.txtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.ForeColor = System.Drawing.Color.DimGray;
            this.txtObservacoes.Location = new System.Drawing.Point(160, 88);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbxAquisicao);
            this.groupBox4.Controls.Add(this.lblAquisicao);
            this.groupBox4.Controls.Add(this.lblEditoraAdd);
            this.groupBox4.Controls.Add(this.txtEditora);
            this.groupBox4.Location = new System.Drawing.Point(181, 264);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(544, 128);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
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
            this.cbxAquisicao.Location = new System.Drawing.Point(168, 24);
            this.cbxAquisicao.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxAquisicao.Name = "cbxAquisicao";
            this.cbxAquisicao.Padding = new System.Windows.Forms.Padding(1);
            this.cbxAquisicao.Size = new System.Drawing.Size(200, 30);
            this.cbxAquisicao.TabIndex = 46;
            this.cbxAquisicao.Texts = "<selecione o método>";
            // 
            // lblAquisicao
            // 
            this.lblAquisicao.AutoSize = true;
            this.lblAquisicao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAquisicao.ForeColor = System.Drawing.Color.DimGray;
            this.lblAquisicao.Location = new System.Drawing.Point(88, 32);
            this.lblAquisicao.Name = "lblAquisicao";
            this.lblAquisicao.Size = new System.Drawing.Size(71, 17);
            this.lblAquisicao.TabIndex = 35;
            this.lblAquisicao.Text = "Aquisição";
            // 
            // lblEditoraAdd
            // 
            this.lblEditoraAdd.AutoSize = true;
            this.lblEditoraAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditoraAdd.ForeColor = System.Drawing.Color.DimGray;
            this.lblEditoraAdd.Location = new System.Drawing.Point(105, 88);
            this.lblEditoraAdd.Name = "lblEditoraAdd";
            this.lblEditoraAdd.Size = new System.Drawing.Size(54, 17);
            this.lblEditoraAdd.TabIndex = 36;
            this.lblEditoraAdd.Text = "Editora";
            // 
            // txtEditora
            // 
            this.txtEditora.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditora.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEditora.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtEditora.BorderSize = 2;
            this.txtEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditora.Location = new System.Drawing.Point(169, 80);
            this.txtEditora.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditora.Multiline = false;
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Padding = new System.Windows.Forms.Padding(7);
            this.txtEditora.PasswordChar = false;
            this.txtEditora.Size = new System.Drawing.Size(320, 31);
            this.txtEditora.TabIndex = 37;
            this.txtEditora.Texts = "Jorge";
            this.txtEditora.UnderlinedStyle = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAutor);
            this.groupBox2.Controls.Add(this.txtTitulo);
            this.groupBox2.Controls.Add(this.lblAutor);
            this.groupBox2.Controls.Add(this.lblTituloAdd);
            this.groupBox2.Location = new System.Drawing.Point(181, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 128);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.SystemColors.Window;
            this.txtAutor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAutor.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtAutor.BorderSize = 2;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.ForeColor = System.Drawing.Color.DimGray;
            this.txtAutor.Location = new System.Drawing.Point(168, 80);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Multiline = false;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Padding = new System.Windows.Forms.Padding(7);
            this.txtAutor.PasswordChar = false;
            this.txtAutor.Size = new System.Drawing.Size(328, 31);
            this.txtAutor.TabIndex = 34;
            this.txtAutor.Texts = "Amado";
            this.txtAutor.UnderlinedStyle = true;
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitulo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTitulo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtTitulo.BorderSize = 2;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.txtTitulo.Location = new System.Drawing.Point(168, 24);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Multiline = false;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Padding = new System.Windows.Forms.Padding(7);
            this.txtTitulo.PasswordChar = false;
            this.txtTitulo.Size = new System.Drawing.Size(328, 31);
            this.txtTitulo.TabIndex = 29;
            this.txtTitulo.Texts = "Jorge";
            this.txtTitulo.UnderlinedStyle = true;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.Color.DimGray;
            this.lblAutor.Location = new System.Drawing.Point(116, 32);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(43, 17);
            this.lblAutor.TabIndex = 32;
            this.lblAutor.Text = "Autor";
            // 
            // lblTituloAdd
            // 
            this.lblTituloAdd.AutoSize = true;
            this.lblTituloAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAdd.ForeColor = System.Drawing.Color.DimGray;
            this.lblTituloAdd.Location = new System.Drawing.Point(118, 88);
            this.lblTituloAdd.Name = "lblTituloAdd";
            this.lblTituloAdd.Size = new System.Drawing.Size(41, 17);
            this.lblTituloAdd.TabIndex = 33;
            this.lblTituloAdd.Text = "Título";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nRegistoAdd);
            this.groupBox1.Controls.Add(this.txtNRegisto);
            this.groupBox1.Controls.Add(this.txtDataEntrega);
            this.groupBox1.Controls.Add(this.lblDataEntrada);
            this.groupBox1.Location = new System.Drawing.Point(181, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 80);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // nRegistoAdd
            // 
            this.nRegistoAdd.AutoSize = true;
            this.nRegistoAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRegistoAdd.ForeColor = System.Drawing.Color.DimGray;
            this.nRegistoAdd.Location = new System.Drawing.Point(80, 40);
            this.nRegistoAdd.Name = "nRegistoAdd";
            this.nRegistoAdd.Size = new System.Drawing.Size(95, 17);
            this.nRegistoAdd.TabIndex = 30;
            this.nRegistoAdd.Text = "Nº de Registo";
            // 
            // txtNRegisto
            // 
            this.txtNRegisto.BackColor = System.Drawing.SystemColors.Window;
            this.txtNRegisto.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNRegisto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtNRegisto.BorderSize = 2;
            this.txtNRegisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNRegisto.ForeColor = System.Drawing.Color.DimGray;
            this.txtNRegisto.Location = new System.Drawing.Point(168, 32);
            this.txtNRegisto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNRegisto.Multiline = false;
            this.txtNRegisto.Name = "txtNRegisto";
            this.txtNRegisto.Padding = new System.Windows.Forms.Padding(7);
            this.txtNRegisto.PasswordChar = false;
            this.txtNRegisto.Size = new System.Drawing.Size(72, 31);
            this.txtNRegisto.TabIndex = 27;
            this.txtNRegisto.Texts = "";
            this.txtNRegisto.UnderlinedStyle = true;
            this.txtNRegisto._TextChanged += new System.EventHandler(this.txtNRegisto__TextChanged);
            this.txtNRegisto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNRegisto_KeyPress_1);
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataEntrega.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDataEntrega.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtDataEntrega.BorderSize = 2;
            this.txtDataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEntrega.ForeColor = System.Drawing.Color.DimGray;
            this.txtDataEntrega.Location = new System.Drawing.Point(416, 32);
            this.txtDataEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataEntrega.Multiline = false;
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Padding = new System.Windows.Forms.Padding(7);
            this.txtDataEntrega.PasswordChar = false;
            this.txtDataEntrega.Size = new System.Drawing.Size(80, 31);
            this.txtDataEntrega.TabIndex = 28;
            this.txtDataEntrega.Texts = "05/01/2003";
            this.txtDataEntrega.UnderlinedStyle = true;
            this.txtDataEntrega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataEntrega_KeyPress);
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.ForeColor = System.Drawing.Color.DimGray;
            this.lblDataEntrada.Location = new System.Drawing.Point(304, 40);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(117, 17);
            this.lblDataEntrada.TabIndex = 31;
            this.lblDataEntrada.Text = "Data de Entrada";
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttSave.Location = new System.Drawing.Point(333, 624);
            this.bttSave.Margin = new System.Windows.Forms.Padding(0);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(328, 32);
            this.bttSave.TabIndex = 53;
            this.bttSave.Text = "Adicionar exemplar";
            this.bttSave.UseVisualStyleBackColor = false;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // frmAddLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 685);
            this.Controls.Add(this.pnlAddLivros);
            this.Name = "frmAddLivros";
            this.Load += new System.EventHandler(this.frmAddLivros_Load);
            this.pnlAddLivros.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddLivros;
        private System.Windows.Forms.GroupBox groupBox5;
        private controls.UC_ComboBox cbxEstado;
        private System.Windows.Forms.Label lblEstadoAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private controls.UC_textbox txtCota;
        private System.Windows.Forms.Label lblCotaAdd;
        private System.Windows.Forms.Label lblNVolAdd;
        private controls.UC_textbox txtNVolume;
        private System.Windows.Forms.Label lblObservAdd;
        private controls.UC_textbox txtObservacoes;
        private System.Windows.Forms.GroupBox groupBox4;
        private controls.UC_ComboBox cbxAquisicao;
        private System.Windows.Forms.Label lblAquisicao;
        private System.Windows.Forms.Label lblEditoraAdd;
        private controls.UC_textbox txtEditora;
        private System.Windows.Forms.GroupBox groupBox2;
        private controls.UC_textbox txtAutor;
        private controls.UC_textbox txtTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTituloAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label nRegistoAdd;
        private controls.UC_textbox txtNRegisto;
        private controls.UC_textbox txtDataEntrega;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Button bttSave;
    }
}