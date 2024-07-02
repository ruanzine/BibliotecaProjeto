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
            this.pnlFormFooter = new RoundedPanelBottom();
            this.pnlFormHeader = new RoundedPanel();
            this.pnlLineTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFormBody = new System.Windows.Forms.Panel();
            this.gpbTop = new RoundedGroupBox();
            this.lblRegNum = new System.Windows.Forms.Label();
            this.txtNRegisto = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.pnlLineBottom = new System.Windows.Forms.Panel();
            this.gpbBottom = new RoundedGroupBox();
            this.cbxAquisicao = new MetroFramework.Controls.MetroComboBox();
            this.lblAcquisition = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtEditora = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtAutor = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtTitulo = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitleBody = new System.Windows.Forms.Label();
            this.gpbRight = new RoundedGroupBox();
            this.bttClear = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.cbxEstado = new MetroFramework.Controls.MetroComboBox();
            this.bttSave = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.lblCondition = new System.Windows.Forms.Label();
            this.txtCota = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblClassification = new System.Windows.Forms.Label();
            this.lblVolNum = new System.Windows.Forms.Label();
            this.txtNVolume = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblObservations = new System.Windows.Forms.Label();
            this.txtObservacoes = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.dtpArrivalDate = new MetroFramework.Controls.MetroDateTime();
            this.pnlAddLivros.SuspendLayout();
            this.pnlFormHeader.SuspendLayout();
            this.pnlFormBody.SuspendLayout();
            this.gpbTop.SuspendLayout();
            this.gpbBottom.SuspendLayout();
            this.gpbRight.SuspendLayout();
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
            this.pnlFormHeader.Controls.Add(this.pnlLineTop);
            this.pnlFormHeader.Controls.Add(this.lblTitle);
            this.pnlFormHeader.CornerRadius = 10;
            this.pnlFormHeader.Location = new System.Drawing.Point(80, 80);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(992, 56);
            this.pnlFormHeader.TabIndex = 59;
            // 
            // pnlLineTop
            // 
            this.pnlLineTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.pnlLineTop.Location = new System.Drawing.Point(0, 54);
            this.pnlLineTop.Name = "pnlLineTop";
            this.pnlLineTop.Size = new System.Drawing.Size(992, 12);
            this.pnlLineTop.TabIndex = 59;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(152, 26);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Novo Registo";
            // 
            // pnlFormBody
            // 
            this.pnlFormBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.pnlFormBody.Controls.Add(this.gpbTop);
            this.pnlFormBody.Controls.Add(this.pnlLineBottom);
            this.pnlFormBody.Controls.Add(this.gpbBottom);
            this.pnlFormBody.Controls.Add(this.gpbRight);
            this.pnlFormBody.Location = new System.Drawing.Point(80, 136);
            this.pnlFormBody.Name = "pnlFormBody";
            this.pnlFormBody.Size = new System.Drawing.Size(992, 416);
            this.pnlFormBody.TabIndex = 60;
            // 
            // gpbTop
            // 
            this.gpbTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.gpbTop.BorderRadius = 5;
            this.gpbTop.Controls.Add(this.dtpArrivalDate);
            this.gpbTop.Controls.Add(this.lblRegNum);
            this.gpbTop.Controls.Add(this.txtNRegisto);
            this.gpbTop.Controls.Add(this.lblArrivalDate);
            this.gpbTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.gpbTop.Location = new System.Drawing.Point(24, 40);
            this.gpbTop.Name = "gpbTop";
            this.gpbTop.Size = new System.Drawing.Size(464, 80);
            this.gpbTop.TabIndex = 54;
            this.gpbTop.TabStop = false;
            // 
            // lblRegNum
            // 
            this.lblRegNum.AutoSize = true;
            this.lblRegNum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblRegNum.Location = new System.Drawing.Point(16, 32);
            this.lblRegNum.Name = "lblRegNum";
            this.lblRegNum.Size = new System.Drawing.Size(82, 17);
            this.lblRegNum.TabIndex = 30;
            this.lblRegNum.Text = "Nº.  Registo";
            // 
            // txtNRegisto
            // 
            this.txtNRegisto.BackColor = System.Drawing.SystemColors.Window;
            this.txtNRegisto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtNRegisto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtNRegisto.BorderSize = 2;
            this.txtNRegisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNRegisto.ForeColor = System.Drawing.Color.DimGray;
            this.txtNRegisto.Location = new System.Drawing.Point(112, 24);
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
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblArrivalDate.Location = new System.Drawing.Point(192, 32);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(117, 17);
            this.lblArrivalDate.TabIndex = 31;
            this.lblArrivalDate.Text = "Data de Entrada";
            // 
            // pnlLineBottom
            // 
            this.pnlLineBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.pnlLineBottom.Location = new System.Drawing.Point(0, 414);
            this.pnlLineBottom.Name = "pnlLineBottom";
            this.pnlLineBottom.Size = new System.Drawing.Size(992, 12);
            this.pnlLineBottom.TabIndex = 58;
            // 
            // gpbBottom
            // 
            this.gpbBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.gpbBottom.BorderRadius = 5;
            this.gpbBottom.Controls.Add(this.cbxAquisicao);
            this.gpbBottom.Controls.Add(this.lblAcquisition);
            this.gpbBottom.Controls.Add(this.lblPublisher);
            this.gpbBottom.Controls.Add(this.txtEditora);
            this.gpbBottom.Controls.Add(this.txtAutor);
            this.gpbBottom.Controls.Add(this.txtTitulo);
            this.gpbBottom.Controls.Add(this.lblAuthor);
            this.gpbBottom.Controls.Add(this.lblTitleBody);
            this.gpbBottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.gpbBottom.Location = new System.Drawing.Point(24, 128);
            this.gpbBottom.Name = "gpbBottom";
            this.gpbBottom.Size = new System.Drawing.Size(464, 248);
            this.gpbBottom.TabIndex = 55;
            this.gpbBottom.TabStop = false;
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
            this.cbxAquisicao.Location = new System.Drawing.Point(112, 136);
            this.cbxAquisicao.Name = "cbxAquisicao";
            this.cbxAquisicao.Size = new System.Drawing.Size(192, 29);
            this.cbxAquisicao.TabIndex = 61;
            this.cbxAquisicao.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbxAquisicao.UseSelectable = true;
            // 
            // lblAcquisition
            // 
            this.lblAcquisition.AutoSize = true;
            this.lblAcquisition.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcquisition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblAcquisition.Location = new System.Drawing.Point(32, 144);
            this.lblAcquisition.Name = "lblAcquisition";
            this.lblAcquisition.Size = new System.Drawing.Size(71, 17);
            this.lblAcquisition.TabIndex = 47;
            this.lblAcquisition.Text = "Aquisição";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblPublisher.Location = new System.Drawing.Point(48, 200);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(54, 17);
            this.lblPublisher.TabIndex = 48;
            this.lblPublisher.Text = "Editora";
            // 
            // txtEditora
            // 
            this.txtEditora.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditora.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtEditora.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtEditora.BorderSize = 2;
            this.txtEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditora.Location = new System.Drawing.Point(112, 192);
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
            this.txtAutor.Location = new System.Drawing.Point(112, 80);
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
            this.txtTitulo.Location = new System.Drawing.Point(112, 24);
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
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblAuthor.Location = new System.Drawing.Point(56, 88);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(43, 17);
            this.lblAuthor.TabIndex = 32;
            this.lblAuthor.Text = "Autor";
            // 
            // lblTitleBody
            // 
            this.lblTitleBody.AutoSize = true;
            this.lblTitleBody.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblTitleBody.Location = new System.Drawing.Point(56, 32);
            this.lblTitleBody.Name = "lblTitleBody";
            this.lblTitleBody.Size = new System.Drawing.Size(41, 17);
            this.lblTitleBody.TabIndex = 33;
            this.lblTitleBody.Text = "Título";
            // 
            // gpbRight
            // 
            this.gpbRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.gpbRight.BorderRadius = 5;
            this.gpbRight.Controls.Add(this.bttClear);
            this.gpbRight.Controls.Add(this.cbxEstado);
            this.gpbRight.Controls.Add(this.bttSave);
            this.gpbRight.Controls.Add(this.lblCondition);
            this.gpbRight.Controls.Add(this.txtCota);
            this.gpbRight.Controls.Add(this.lblClassification);
            this.gpbRight.Controls.Add(this.lblVolNum);
            this.gpbRight.Controls.Add(this.txtNVolume);
            this.gpbRight.Controls.Add(this.lblObservations);
            this.gpbRight.Controls.Add(this.txtObservacoes);
            this.gpbRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.gpbRight.Location = new System.Drawing.Point(504, 40);
            this.gpbRight.Name = "gpbRight";
            this.gpbRight.Size = new System.Drawing.Size(464, 264);
            this.gpbRight.TabIndex = 57;
            this.gpbRight.TabStop = false;
            // 
            // bttClear
            // 
            this.bttClear.BackColor = System.Drawing.Color.DimGray;
            this.bttClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttClear.BorderRadius = 5;
            this.bttClear.BorderSize = 0;
            this.bttClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttClear.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttClear.ForeColor = System.Drawing.Color.Transparent;
            this.bttClear.Image = ((System.Drawing.Image)(resources.GetObject("bttClear.Image")));
            this.bttClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttClear.Location = new System.Drawing.Point(120, 208);
            this.bttClear.Margin = new System.Windows.Forms.Padding(0);
            this.bttClear.Name = "bttClear";
            this.bttClear.Padding = new System.Windows.Forms.Padding(4, 0, 7, 0);
            this.bttClear.Size = new System.Drawing.Size(104, 40);
            this.bttClear.TabIndex = 59;
            this.bttClear.Text = "Limpar";
            this.bttClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttClear.UseVisualStyleBackColor = false;
            this.bttClear.Click += new System.EventHandler(this.bttClear_Click);
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
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblCondition.Location = new System.Drawing.Point(61, 88);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(52, 17);
            this.lblCondition.TabIndex = 48;
            this.lblCondition.Text = "Estado";
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
            // lblClassification
            // 
            this.lblClassification.AutoSize = true;
            this.lblClassification.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblClassification.Location = new System.Drawing.Point(16, 32);
            this.lblClassification.Name = "lblClassification";
            this.lblClassification.Size = new System.Drawing.Size(97, 17);
            this.lblClassification.TabIndex = 38;
            this.lblClassification.Text = "Cota da CDU";
            // 
            // lblVolNum
            // 
            this.lblVolNum.AutoSize = true;
            this.lblVolNum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblVolNum.Location = new System.Drawing.Point(272, 32);
            this.lblVolNum.Name = "lblVolNum";
            this.lblVolNum.Size = new System.Drawing.Size(77, 17);
            this.lblVolNum.TabIndex = 39;
            this.lblVolNum.Text = "Nº Volume";
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
            // lblObservations
            // 
            this.lblObservations.AutoSize = true;
            this.lblObservations.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblObservations.Location = new System.Drawing.Point(21, 136);
            this.lblObservations.Name = "lblObservations";
            this.lblObservations.Size = new System.Drawing.Size(92, 17);
            this.lblObservations.TabIndex = 42;
            this.lblObservations.Text = "Observações";
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
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpArrivalDate.Location = new System.Drawing.Point(312, 24);
            this.dtpArrivalDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpArrivalDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpArrivalDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(120, 29);
            this.dtpArrivalDate.Style = MetroFramework.MetroColorStyle.Blue;
            this.dtpArrivalDate.TabIndex = 62;
            this.dtpArrivalDate.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.gpbTop.ResumeLayout(false);
            this.gpbTop.PerformLayout();
            this.gpbBottom.ResumeLayout(false);
            this.gpbBottom.PerformLayout();
            this.gpbRight.ResumeLayout(false);
            this.gpbRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddLivros;
        private controls.UC_textbox txtCota;
        private System.Windows.Forms.Label lblClassification;
        private System.Windows.Forms.Label lblVolNum;
        private controls.UC_textbox txtNVolume;
        private System.Windows.Forms.Label lblObservations;
        private controls.UC_textbox txtObservacoes;
        private controls.UC_textbox txtAutor;
        private controls.UC_textbox txtTitulo;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitleBody;
        private System.Windows.Forms.Label lblRegNum;
        private controls.UC_textbox txtNRegisto;
        private System.Windows.Forms.Label lblArrivalDate;
        private RoundedGroupBox gpbRight;
        private RoundedGroupBox gpbBottom;
        private RoundedGroupBox gpbTop;
        private controls.RoundedButton bttSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAcquisition;
        private System.Windows.Forms.Label lblPublisher;
        private controls.UC_textbox txtEditora;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Panel pnlFormBody;
        private RoundedPanel pnlFormHeader;
        private MetroFramework.Controls.MetroComboBox cbxAquisicao;
        private MetroFramework.Controls.MetroComboBox cbxEstado;
        private RoundedPanelBottom pnlFormFooter;
        private System.Windows.Forms.Panel pnlLineBottom;
        private System.Windows.Forms.Panel pnlLineTop;
        private controls.RoundedButton bttClear;
        private MetroFramework.Controls.MetroDateTime dtpArrivalDate;
    }
}