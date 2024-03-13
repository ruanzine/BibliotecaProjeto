namespace BIBLIOTECA_PROJETO.gui
{
    partial class frmEditLivros
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
            this.pnlEditLivros = new System.Windows.Forms.Panel();
            this.bttDel = new System.Windows.Forms.Button();
            this.bttClear_Edit = new System.Windows.Forms.Button();
            this.gpbData_Edit = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbN_Edit = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bttEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbEstado_Edit = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gpbAqi_Edit = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gpbCota_Edit = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbAutor_Edit = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttSave_Edit = new System.Windows.Forms.Button();
            this.txtDataEntrega_Edit = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtNRegisto_Edit = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.cbxEstado_Edit = new BIBLIOTECA_PROJETO.controls.UC_ComboBox();
            this.txtEditora_Edit = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.cbxAquisicao_Edit = new BIBLIOTECA_PROJETO.controls.UC_ComboBox();
            this.txtObservacoes_Edit = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtNVolume_Edit = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtCota_Edit = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtAutor_Edit = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtTitulo_Edit = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.pnlEditLivros.SuspendLayout();
            this.gpbData_Edit.SuspendLayout();
            this.gpbN_Edit.SuspendLayout();
            this.gpbEstado_Edit.SuspendLayout();
            this.gpbAqi_Edit.SuspendLayout();
            this.gpbCota_Edit.SuspendLayout();
            this.gpbAutor_Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEditLivros
            // 
            this.pnlEditLivros.BackColor = System.Drawing.SystemColors.Control;
            this.pnlEditLivros.Controls.Add(this.button1);
            this.pnlEditLivros.Controls.Add(this.bttDel);
            this.pnlEditLivros.Controls.Add(this.bttClear_Edit);
            this.pnlEditLivros.Controls.Add(this.gpbData_Edit);
            this.pnlEditLivros.Controls.Add(this.gpbN_Edit);
            this.pnlEditLivros.Controls.Add(this.gpbEstado_Edit);
            this.pnlEditLivros.Controls.Add(this.gpbAqi_Edit);
            this.pnlEditLivros.Controls.Add(this.gpbCota_Edit);
            this.pnlEditLivros.Controls.Add(this.gpbAutor_Edit);
            this.pnlEditLivros.Controls.Add(this.bttSave_Edit);
            this.pnlEditLivros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditLivros.Location = new System.Drawing.Point(0, 0);
            this.pnlEditLivros.Name = "pnlEditLivros";
            this.pnlEditLivros.Size = new System.Drawing.Size(906, 685);
            this.pnlEditLivros.TabIndex = 0;
            this.pnlEditLivros.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEditLivros_Paint);
            // 
            // bttDel
            // 
            this.bttDel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttDel.Location = new System.Drawing.Point(888, 104);
            this.bttDel.Margin = new System.Windows.Forms.Padding(0);
            this.bttDel.Name = "bttDel";
            this.bttDel.Size = new System.Drawing.Size(40, 32);
            this.bttDel.TabIndex = 36;
            this.bttDel.UseVisualStyleBackColor = false;
            this.bttDel.Click += new System.EventHandler(this.bttDel_Click);
            // 
            // bttClear_Edit
            // 
            this.bttClear_Edit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttClear_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttClear_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttClear_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttClear_Edit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttClear_Edit.Location = new System.Drawing.Point(888, 48);
            this.bttClear_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.bttClear_Edit.Name = "bttClear_Edit";
            this.bttClear_Edit.Size = new System.Drawing.Size(40, 32);
            this.bttClear_Edit.TabIndex = 30;
            this.bttClear_Edit.UseVisualStyleBackColor = false;
            this.bttClear_Edit.Click += new System.EventHandler(this.bttClear_Edit_Click);
            // 
            // gpbData_Edit
            // 
            this.gpbData_Edit.Controls.Add(this.txtDataEntrega_Edit);
            this.gpbData_Edit.Controls.Add(this.label2);
            this.gpbData_Edit.Location = new System.Drawing.Point(544, 32);
            this.gpbData_Edit.Name = "gpbData_Edit";
            this.gpbData_Edit.Size = new System.Drawing.Size(328, 64);
            this.gpbData_Edit.TabIndex = 35;
            this.gpbData_Edit.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(35, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Entrega";
            // 
            // gpbN_Edit
            // 
            this.gpbN_Edit.Controls.Add(this.txtNRegisto_Edit);
            this.gpbN_Edit.Controls.Add(this.bttEdit);
            this.gpbN_Edit.Controls.Add(this.label1);
            this.gpbN_Edit.Location = new System.Drawing.Point(216, 32);
            this.gpbN_Edit.Name = "gpbN_Edit";
            this.gpbN_Edit.Size = new System.Drawing.Size(320, 64);
            this.gpbN_Edit.TabIndex = 34;
            this.gpbN_Edit.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(888, 152);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 32);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bttEdit
            // 
            this.bttEdit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttEdit.Location = new System.Drawing.Point(240, 24);
            this.bttEdit.Margin = new System.Windows.Forms.Padding(0);
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(40, 32);
            this.bttEdit.TabIndex = 17;
            this.bttEdit.Text = "E";
            this.bttEdit.UseVisualStyleBackColor = false;
            this.bttEdit.Click += new System.EventHandler(this.bttEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº de Registo";
            // 
            // gpbEstado_Edit
            // 
            this.gpbEstado_Edit.Controls.Add(this.cbxEstado_Edit);
            this.gpbEstado_Edit.Controls.Add(this.label11);
            this.gpbEstado_Edit.Location = new System.Drawing.Point(216, 494);
            this.gpbEstado_Edit.Name = "gpbEstado_Edit";
            this.gpbEstado_Edit.Size = new System.Drawing.Size(656, 64);
            this.gpbEstado_Edit.TabIndex = 30;
            this.gpbEstado_Edit.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(80, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Estado";
            // 
            // gpbAqi_Edit
            // 
            this.gpbAqi_Edit.Controls.Add(this.txtEditora_Edit);
            this.gpbAqi_Edit.Controls.Add(this.cbxAquisicao_Edit);
            this.gpbAqi_Edit.Controls.Add(this.label8);
            this.gpbAqi_Edit.Controls.Add(this.label9);
            this.gpbAqi_Edit.Location = new System.Drawing.Point(216, 230);
            this.gpbAqi_Edit.Name = "gpbAqi_Edit";
            this.gpbAqi_Edit.Size = new System.Drawing.Size(656, 128);
            this.gpbAqi_Edit.TabIndex = 32;
            this.gpbAqi_Edit.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(72, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Editora";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(58, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Aquisição";
            // 
            // gpbCota_Edit
            // 
            this.gpbCota_Edit.Controls.Add(this.txtObservacoes_Edit);
            this.gpbCota_Edit.Controls.Add(this.txtNVolume_Edit);
            this.gpbCota_Edit.Controls.Add(this.txtCota_Edit);
            this.gpbCota_Edit.Controls.Add(this.label6);
            this.gpbCota_Edit.Controls.Add(this.label7);
            this.gpbCota_Edit.Controls.Add(this.label4);
            this.gpbCota_Edit.Location = new System.Drawing.Point(216, 358);
            this.gpbCota_Edit.Name = "gpbCota_Edit";
            this.gpbCota_Edit.Size = new System.Drawing.Size(656, 136);
            this.gpbCota_Edit.TabIndex = 33;
            this.gpbCota_Edit.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(32, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Observações";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(35, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cota da CDU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(296, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nº Volume";
            // 
            // gpbAutor_Edit
            // 
            this.gpbAutor_Edit.Controls.Add(this.txtAutor_Edit);
            this.gpbAutor_Edit.Controls.Add(this.txtTitulo_Edit);
            this.gpbAutor_Edit.Controls.Add(this.label5);
            this.gpbAutor_Edit.Controls.Add(this.label3);
            this.gpbAutor_Edit.Location = new System.Drawing.Point(216, 102);
            this.gpbAutor_Edit.Name = "gpbAutor_Edit";
            this.gpbAutor_Edit.Size = new System.Drawing.Size(656, 128);
            this.gpbAutor_Edit.TabIndex = 31;
            this.gpbAutor_Edit.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(89, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(89, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autor";
            // 
            // bttSave_Edit
            // 
            this.bttSave_Edit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttSave_Edit.Enabled = false;
            this.bttSave_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttSave_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSave_Edit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttSave_Edit.Location = new System.Drawing.Point(368, 576);
            this.bttSave_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.bttSave_Edit.Name = "bttSave_Edit";
            this.bttSave_Edit.Size = new System.Drawing.Size(408, 32);
            this.bttSave_Edit.TabIndex = 29;
            this.bttSave_Edit.Text = "Guardar";
            this.bttSave_Edit.UseVisualStyleBackColor = false;
            this.bttSave_Edit.Click += new System.EventHandler(this.bttSave_Edit_Click);
            // 
            // txtDataEntrega_Edit
            // 
            this.txtDataEntrega_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataEntrega_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDataEntrega_Edit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtDataEntrega_Edit.BorderSize = 2;
            this.txtDataEntrega_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEntrega_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtDataEntrega_Edit.Location = new System.Drawing.Point(160, 19);
            this.txtDataEntrega_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataEntrega_Edit.Multiline = false;
            this.txtDataEntrega_Edit.Name = "txtDataEntrega_Edit";
            this.txtDataEntrega_Edit.Padding = new System.Windows.Forms.Padding(7);
            this.txtDataEntrega_Edit.PasswordChar = false;
            this.txtDataEntrega_Edit.Size = new System.Drawing.Size(80, 31);
            this.txtDataEntrega_Edit.TabIndex = 29;
            this.txtDataEntrega_Edit.Texts = "";
            this.txtDataEntrega_Edit.UnderlinedStyle = true;
            // 
            // txtNRegisto_Edit
            // 
            this.txtNRegisto_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtNRegisto_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNRegisto_Edit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtNRegisto_Edit.BorderSize = 2;
            this.txtNRegisto_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNRegisto_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtNRegisto_Edit.Location = new System.Drawing.Point(152, 19);
            this.txtNRegisto_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtNRegisto_Edit.Multiline = false;
            this.txtNRegisto_Edit.Name = "txtNRegisto_Edit";
            this.txtNRegisto_Edit.Padding = new System.Windows.Forms.Padding(7);
            this.txtNRegisto_Edit.PasswordChar = false;
            this.txtNRegisto_Edit.Size = new System.Drawing.Size(72, 31);
            this.txtNRegisto_Edit.TabIndex = 28;
            this.txtNRegisto_Edit.Texts = "";
            this.txtNRegisto_Edit.UnderlinedStyle = true;
            // 
            // cbxEstado_Edit
            // 
            this.cbxEstado_Edit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxEstado_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxEstado_Edit.BorderSize = 1;
            this.cbxEstado_Edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxEstado_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.cbxEstado_Edit.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxEstado_Edit.Items.AddRange(new object[] {
            "Disponível",
            "Indisponível",
            "Abatido",
            "Perdido",
            "Consulta local",
            "Exposição",
            "Depósito"});
            this.cbxEstado_Edit.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxEstado_Edit.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxEstado_Edit.Location = new System.Drawing.Point(152, 16);
            this.cbxEstado_Edit.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxEstado_Edit.Name = "cbxEstado_Edit";
            this.cbxEstado_Edit.Padding = new System.Windows.Forms.Padding(1);
            this.cbxEstado_Edit.Size = new System.Drawing.Size(200, 30);
            this.cbxEstado_Edit.TabIndex = 48;
            this.cbxEstado_Edit.Texts = "<selecione o estado>";
            // 
            // txtEditora_Edit
            // 
            this.txtEditora_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditora_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEditora_Edit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtEditora_Edit.BorderSize = 2;
            this.txtEditora_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditora_Edit.Location = new System.Drawing.Point(152, 80);
            this.txtEditora_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditora_Edit.Multiline = false;
            this.txtEditora_Edit.Name = "txtEditora_Edit";
            this.txtEditora_Edit.Padding = new System.Windows.Forms.Padding(7);
            this.txtEditora_Edit.PasswordChar = false;
            this.txtEditora_Edit.Size = new System.Drawing.Size(408, 31);
            this.txtEditora_Edit.TabIndex = 48;
            this.txtEditora_Edit.Texts = "";
            this.txtEditora_Edit.UnderlinedStyle = true;
            // 
            // cbxAquisicao_Edit
            // 
            this.cbxAquisicao_Edit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxAquisicao_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxAquisicao_Edit.BorderSize = 1;
            this.cbxAquisicao_Edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxAquisicao_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.cbxAquisicao_Edit.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxAquisicao_Edit.Items.AddRange(new object[] {
            "Compra",
            "Oferta"});
            this.cbxAquisicao_Edit.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxAquisicao_Edit.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxAquisicao_Edit.Location = new System.Drawing.Point(152, 24);
            this.cbxAquisicao_Edit.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxAquisicao_Edit.Name = "cbxAquisicao_Edit";
            this.cbxAquisicao_Edit.Padding = new System.Windows.Forms.Padding(1);
            this.cbxAquisicao_Edit.Size = new System.Drawing.Size(200, 30);
            this.cbxAquisicao_Edit.TabIndex = 47;
            this.cbxAquisicao_Edit.Texts = "<selecione o método>";
            // 
            // txtObservacoes_Edit
            // 
            this.txtObservacoes_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservacoes_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtObservacoes_Edit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtObservacoes_Edit.BorderSize = 2;
            this.txtObservacoes_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtObservacoes_Edit.Location = new System.Drawing.Point(152, 72);
            this.txtObservacoes_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacoes_Edit.Multiline = true;
            this.txtObservacoes_Edit.Name = "txtObservacoes_Edit";
            this.txtObservacoes_Edit.Padding = new System.Windows.Forms.Padding(7);
            this.txtObservacoes_Edit.PasswordChar = false;
            this.txtObservacoes_Edit.Size = new System.Drawing.Size(408, 48);
            this.txtObservacoes_Edit.TabIndex = 45;
            this.txtObservacoes_Edit.Texts = "";
            this.txtObservacoes_Edit.UnderlinedStyle = true;
            // 
            // txtNVolume_Edit
            // 
            this.txtNVolume_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtNVolume_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNVolume_Edit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtNVolume_Edit.BorderSize = 2;
            this.txtNVolume_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNVolume_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtNVolume_Edit.Location = new System.Drawing.Point(384, 16);
            this.txtNVolume_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtNVolume_Edit.Multiline = false;
            this.txtNVolume_Edit.Name = "txtNVolume_Edit";
            this.txtNVolume_Edit.Padding = new System.Windows.Forms.Padding(7);
            this.txtNVolume_Edit.PasswordChar = false;
            this.txtNVolume_Edit.Size = new System.Drawing.Size(56, 31);
            this.txtNVolume_Edit.TabIndex = 43;
            this.txtNVolume_Edit.Texts = "";
            this.txtNVolume_Edit.UnderlinedStyle = true;
            // 
            // txtCota_Edit
            // 
            this.txtCota_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtCota_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCota_Edit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtCota_Edit.BorderSize = 2;
            this.txtCota_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCota_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtCota_Edit.Location = new System.Drawing.Point(152, 16);
            this.txtCota_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtCota_Edit.Multiline = false;
            this.txtCota_Edit.Name = "txtCota_Edit";
            this.txtCota_Edit.Padding = new System.Windows.Forms.Padding(7);
            this.txtCota_Edit.PasswordChar = false;
            this.txtCota_Edit.Size = new System.Drawing.Size(112, 31);
            this.txtCota_Edit.TabIndex = 42;
            this.txtCota_Edit.Texts = "";
            this.txtCota_Edit.UnderlinedStyle = true;
            // 
            // txtAutor_Edit
            // 
            this.txtAutor_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtAutor_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAutor_Edit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtAutor_Edit.BorderSize = 2;
            this.txtAutor_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtAutor_Edit.Location = new System.Drawing.Point(152, 80);
            this.txtAutor_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor_Edit.Multiline = false;
            this.txtAutor_Edit.Name = "txtAutor_Edit";
            this.txtAutor_Edit.Padding = new System.Windows.Forms.Padding(7);
            this.txtAutor_Edit.PasswordChar = false;
            this.txtAutor_Edit.Size = new System.Drawing.Size(416, 31);
            this.txtAutor_Edit.TabIndex = 35;
            this.txtAutor_Edit.Texts = "";
            this.txtAutor_Edit.UnderlinedStyle = true;
            // 
            // txtTitulo_Edit
            // 
            this.txtTitulo_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitulo_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTitulo_Edit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtTitulo_Edit.BorderSize = 2;
            this.txtTitulo_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtTitulo_Edit.Location = new System.Drawing.Point(152, 24);
            this.txtTitulo_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo_Edit.Multiline = false;
            this.txtTitulo_Edit.Name = "txtTitulo_Edit";
            this.txtTitulo_Edit.Padding = new System.Windows.Forms.Padding(7);
            this.txtTitulo_Edit.PasswordChar = false;
            this.txtTitulo_Edit.Size = new System.Drawing.Size(416, 31);
            this.txtTitulo_Edit.TabIndex = 30;
            this.txtTitulo_Edit.Texts = "";
            this.txtTitulo_Edit.UnderlinedStyle = true;
            this.txtTitulo_Edit.TextChanged += new System.EventHandler(this.txtTitulo_Edit_TextChanged);
            // 
            // frmEditLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 685);
            this.Controls.Add(this.pnlEditLivros);
            this.Name = "frmEditLivros";
            this.Text = "frmEditLivros";
            this.pnlEditLivros.ResumeLayout(false);
            this.gpbData_Edit.ResumeLayout(false);
            this.gpbData_Edit.PerformLayout();
            this.gpbN_Edit.ResumeLayout(false);
            this.gpbN_Edit.PerformLayout();
            this.gpbEstado_Edit.ResumeLayout(false);
            this.gpbEstado_Edit.PerformLayout();
            this.gpbAqi_Edit.ResumeLayout(false);
            this.gpbAqi_Edit.PerformLayout();
            this.gpbCota_Edit.ResumeLayout(false);
            this.gpbCota_Edit.PerformLayout();
            this.gpbAutor_Edit.ResumeLayout(false);
            this.gpbAutor_Edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEditLivros;
        private System.Windows.Forms.GroupBox gpbData_Edit;
        private controls.UC_textbox txtDataEntrega_Edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbN_Edit;
        private System.Windows.Forms.Button button1;
        private controls.UC_textbox txtNRegisto_Edit;
        private System.Windows.Forms.Button bttEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbEstado_Edit;
        private controls.UC_ComboBox cbxEstado_Edit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gpbAqi_Edit;
        private controls.UC_textbox txtEditora_Edit;
        private controls.UC_ComboBox cbxAquisicao_Edit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gpbCota_Edit;
        private controls.UC_textbox txtObservacoes_Edit;
        private controls.UC_textbox txtNVolume_Edit;
        private controls.UC_textbox txtCota_Edit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpbAutor_Edit;
        private controls.UC_textbox txtAutor_Edit;
        private controls.UC_textbox txtTitulo_Edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttSave_Edit;
        private System.Windows.Forms.Button bttClear_Edit;
        private System.Windows.Forms.Button bttDel;
    }
}