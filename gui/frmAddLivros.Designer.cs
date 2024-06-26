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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddLivros));
            this.pnlAddLivros = new System.Windows.Forms.Panel();
            this.pnlFormHeader = new RoundedPanel();
            this.lblListagem = new System.Windows.Forms.Label();
            this.pnlFormBody = new RoundedPanelBottom();
            this.groupBox1 = new RoundedGroupBox();
            this.nRegistoAdd = new System.Windows.Forms.Label();
            this.txtNRegisto = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtDataEntrega = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.groupBox2 = new RoundedGroupBox();
            this.lblAquisicao = new System.Windows.Forms.Label();
            this.lblEditoraAdd = new System.Windows.Forms.Label();
            this.txtEditora = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtAutor = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtTitulo = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTituloAdd = new System.Windows.Forms.Label();
            this.groupBox3 = new RoundedGroupBox();
            this.bttClear = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.cbxEstado = new BIBLIOTECA_PROJETO.controls.UC_ComboBox();
            this.bttSave = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.lblEstadoAdd = new System.Windows.Forms.Label();
            this.txtCota = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblCotaAdd = new System.Windows.Forms.Label();
            this.lblNVolAdd = new System.Windows.Forms.Label();
            this.txtNVolume = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblObservAdd = new System.Windows.Forms.Label();
            this.txtObservacoes = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.cbxAquisicao = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
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
            this.pnlAddLivros.Controls.Add(this.metroTextBox1);
            this.pnlAddLivros.Controls.Add(this.pnlFormHeader);
            this.pnlAddLivros.Controls.Add(this.pnlFormBody);
            this.pnlAddLivros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddLivros.Location = new System.Drawing.Point(0, 0);
            this.pnlAddLivros.Name = "pnlAddLivros";
            this.pnlAddLivros.Size = new System.Drawing.Size(1018, 749);
            this.pnlAddLivros.TabIndex = 0;
            this.pnlAddLivros.Resize += new System.EventHandler(this.pnlAddLivros_Resize);
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.pnlFormHeader.Controls.Add(this.lblListagem);
            this.pnlFormHeader.CornerRadius = 10;
            this.pnlFormHeader.Location = new System.Drawing.Point(80, 88);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(992, 48);
            this.pnlFormHeader.TabIndex = 59;
            // 
            // lblListagem
            // 
            this.lblListagem.AutoSize = true;
            this.lblListagem.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.lblListagem.Location = new System.Drawing.Point(20, 16);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(152, 26);
            this.lblListagem.TabIndex = 12;
            this.lblListagem.Text = "Novo Registo";
            // 
            // pnlFormBody
            // 
            this.pnlFormBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlFormBody.Controls.Add(this.groupBox1);
            this.pnlFormBody.Controls.Add(this.groupBox2);
            this.pnlFormBody.Controls.Add(this.groupBox3);
            this.pnlFormBody.CornerRadius = 10;
            this.pnlFormBody.Location = new System.Drawing.Point(80, 136);
            this.pnlFormBody.Name = "pnlFormBody";
            this.pnlFormBody.Size = new System.Drawing.Size(992, 448);
            this.pnlFormBody.TabIndex = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.nRegistoAdd.Location = new System.Drawing.Point(22, 32);
            this.nRegistoAdd.Name = "nRegistoAdd";
            this.nRegistoAdd.Size = new System.Drawing.Size(95, 17);
            this.nRegistoAdd.TabIndex = 30;
            this.nRegistoAdd.Text = "Nº de Registo";
            // 
            // txtNRegisto
            // 
            this.txtNRegisto.BackColor = System.Drawing.SystemColors.Window;
            this.txtNRegisto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
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
            this.txtDataEntrega.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
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
            this.lblDataEntrada.Location = new System.Drawing.Point(240, 32);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(117, 17);
            this.lblDataEntrada.TabIndex = 31;
            this.lblDataEntrada.Text = "Data de Entrada";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            // lblAquisicao
            // 
            this.lblAquisicao.AutoSize = true;
            this.lblAquisicao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAquisicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblAquisicao.Location = new System.Drawing.Point(40, 144);
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
            this.lblEditoraAdd.Location = new System.Drawing.Point(56, 200);
            this.lblEditoraAdd.Name = "lblEditoraAdd";
            this.lblEditoraAdd.Size = new System.Drawing.Size(54, 17);
            this.lblEditoraAdd.TabIndex = 48;
            this.lblEditoraAdd.Text = "Editora";
            // 
            // txtEditora
            // 
            this.txtEditora.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditora.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
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
            this.txtAutor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
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
            this.txtTitulo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
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
            this.lblAutor.Location = new System.Drawing.Point(65, 32);
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
            this.lblTituloAdd.Location = new System.Drawing.Point(65, 88);
            this.lblTituloAdd.Name = "lblTituloAdd";
            this.lblTituloAdd.Size = new System.Drawing.Size(41, 17);
            this.lblTituloAdd.TabIndex = 33;
            this.lblTituloAdd.Text = "Título";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox3.BorderRadius = 5;
            this.groupBox3.Controls.Add(this.bttClear);
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
            // bttClear
            // 
            this.bttClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttClear.BorderRadius = 5;
            this.bttClear.BorderSize = 0;
            this.bttClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttClear.ForeColor = System.Drawing.Color.Transparent;
            this.bttClear.Image = ((System.Drawing.Image)(resources.GetObject("bttClear.Image")));
            this.bttClear.Location = new System.Drawing.Point(40, 208);
            this.bttClear.Margin = new System.Windows.Forms.Padding(0);
            this.bttClear.Name = "bttClear";
            this.bttClear.Size = new System.Drawing.Size(40, 40);
            this.bttClear.TabIndex = 54;
            this.bttClear.UseVisualStyleBackColor = false;
            this.bttClear.Click += new System.EventHandler(this.bttClear_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.cbxEstado.BorderSize = 1;
            this.cbxEstado.DataSource = null;
            this.cbxEstado.DisplayMember = "";
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxEstado.ForeColor = System.Drawing.Color.DimGray;
            this.cbxEstado.HoverColor = System.Drawing.Color.MediumPurple;
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
            this.cbxEstado.ListFontSize = 10F;
            this.cbxEstado.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxEstado.Location = new System.Drawing.Point(120, 80);
            this.cbxEstado.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Padding = new System.Windows.Forms.Padding(1);
            this.cbxEstado.Size = new System.Drawing.Size(200, 30);
            this.cbxEstado.TabIndex = 49;
            this.cbxEstado.Texts = "<Estado>";
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttSave.BorderColor = System.Drawing.Color.White;
            this.bttSave.BorderRadius = 5;
            this.bttSave.BorderSize = 0;
            this.bttSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttSave.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.bttSave.FlatAppearance.BorderSize = 0;
            this.bttSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttSave.Location = new System.Drawing.Point(120, 208);
            this.bttSave.Margin = new System.Windows.Forms.Padding(0);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(320, 40);
            this.bttSave.TabIndex = 53;
            this.bttSave.Text = "Adicionar Exemplar";
            this.bttSave.UseVisualStyleBackColor = false;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // lblEstadoAdd
            // 
            this.lblEstadoAdd.AutoSize = true;
            this.lblEstadoAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblEstadoAdd.Location = new System.Drawing.Point(56, 88);
            this.lblEstadoAdd.Name = "lblEstadoAdd";
            this.lblEstadoAdd.Size = new System.Drawing.Size(52, 17);
            this.lblEstadoAdd.TabIndex = 48;
            this.lblEstadoAdd.Text = "Estado";
            // 
            // txtCota
            // 
            this.txtCota.BackColor = System.Drawing.SystemColors.Window;
            this.txtCota.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
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
            this.lblNVolAdd.Location = new System.Drawing.Point(280, 32);
            this.lblNVolAdd.Name = "lblNVolAdd";
            this.lblNVolAdd.Size = new System.Drawing.Size(77, 17);
            this.lblNVolAdd.TabIndex = 39;
            this.lblNVolAdd.Text = "Nº Volume";
            // 
            // txtNVolume
            // 
            this.txtNVolume.BackColor = System.Drawing.SystemColors.Window;
            this.txtNVolume.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
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
            this.lblObservAdd.Location = new System.Drawing.Point(16, 136);
            this.lblObservAdd.Name = "lblObservAdd";
            this.lblObservAdd.Size = new System.Drawing.Size(92, 17);
            this.lblObservAdd.TabIndex = 42;
            this.lblObservAdd.Text = "Observações";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservacoes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
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
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Lines = new string[] {
        "Jorge da Silva nunes"};
            this.metroTextBox1.Location = new System.Drawing.Point(416, 40);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(192, 29);
            this.metroTextBox1.TabIndex = 62;
            this.metroTextBox1.Text = "Jorge da Silva nunes";
            this.metroTextBox1.UseCustomBackColor = true;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmAddLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 749);
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
        private controls.UC_ComboBox cbxEstado;
        private System.Windows.Forms.Label lblEstadoAdd;
        private RoundedPanelBottom pnlFormBody;
        private RoundedPanel pnlFormHeader;
        private controls.RoundedButton bttClear;
        private MetroFramework.Controls.MetroComboBox cbxAquisicao;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}