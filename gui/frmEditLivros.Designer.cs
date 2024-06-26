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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditLivros));
            this.pnlEditLivros = new System.Windows.Forms.Panel();
            this.pnlFormFooter = new RoundedPanelBottom();
            this.pnlFormHeader = new RoundedPanel();
            this.lblListagem = new System.Windows.Forms.Label();
            this.pnlFormBody = new System.Windows.Forms.Panel();
            this.gpbCota_Edit = new RoundedGroupBox();
            this.cbxEstado_Edit = new MetroFramework.Controls.MetroComboBox();
            this.txtObservacoes_Edit = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblEstadoAdd = new System.Windows.Forms.Label();
            this.txtNVolume_Edit = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtCota_Edit = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttSave_Edit = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.gpbN_Edit = new RoundedGroupBox();
            this.bttFilterDate = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.txtDataEntrega_Edit = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtNRegisto_Edit = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttDel = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.bttClear_Edit = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.gpbAutor_Edit = new RoundedGroupBox();
            this.cbxAquisicao_Edit = new MetroFramework.Controls.MetroComboBox();
            this.txtEditora_Edit = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAutor_Edit = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtTitulo_Edit = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlLineTop = new System.Windows.Forms.Panel();
            this.pnlLineBottom = new System.Windows.Forms.Panel();
            this.pnlEditLivros.SuspendLayout();
            this.pnlFormHeader.SuspendLayout();
            this.pnlFormBody.SuspendLayout();
            this.gpbCota_Edit.SuspendLayout();
            this.gpbN_Edit.SuspendLayout();
            this.gpbAutor_Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEditLivros
            // 
            this.pnlEditLivros.BackColor = System.Drawing.SystemColors.Control;
            this.pnlEditLivros.Controls.Add(this.pnlFormFooter);
            this.pnlEditLivros.Controls.Add(this.pnlFormHeader);
            this.pnlEditLivros.Controls.Add(this.pnlFormBody);
            this.pnlEditLivros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditLivros.Location = new System.Drawing.Point(0, 0);
            this.pnlEditLivros.Name = "pnlEditLivros";
            this.pnlEditLivros.Size = new System.Drawing.Size(1155, 685);
            this.pnlEditLivros.TabIndex = 0;
            // 
            // pnlFormFooter
            // 
            this.pnlFormFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.pnlFormFooter.CornerRadius = 10;
            this.pnlFormFooter.Location = new System.Drawing.Point(224, 624);
            this.pnlFormFooter.Name = "pnlFormFooter";
            this.pnlFormFooter.Size = new System.Drawing.Size(688, 32);
            this.pnlFormFooter.TabIndex = 62;
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.pnlFormHeader.Controls.Add(this.pnlLineTop);
            this.pnlFormHeader.Controls.Add(this.lblListagem);
            this.pnlFormHeader.CornerRadius = 10;
            this.pnlFormHeader.Location = new System.Drawing.Point(224, 16);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(688, 48);
            this.pnlFormHeader.TabIndex = 60;
            // 
            // lblListagem
            // 
            this.lblListagem.AutoSize = true;
            this.lblListagem.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.lblListagem.Location = new System.Drawing.Point(20, 12);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(156, 26);
            this.lblListagem.TabIndex = 12;
            this.lblListagem.Text = "Editar Registo";
            // 
            // pnlFormBody
            // 
            this.pnlFormBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.pnlFormBody.Controls.Add(this.pnlLineBottom);
            this.pnlFormBody.Controls.Add(this.gpbCota_Edit);
            this.pnlFormBody.Controls.Add(this.bttSave_Edit);
            this.pnlFormBody.Controls.Add(this.gpbN_Edit);
            this.pnlFormBody.Controls.Add(this.bttDel);
            this.pnlFormBody.Controls.Add(this.bttClear_Edit);
            this.pnlFormBody.Controls.Add(this.gpbAutor_Edit);
            this.pnlFormBody.Location = new System.Drawing.Point(224, 64);
            this.pnlFormBody.Name = "pnlFormBody";
            this.pnlFormBody.Size = new System.Drawing.Size(688, 560);
            this.pnlFormBody.TabIndex = 61;
            this.pnlFormBody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFormBody_Paint);
            // 
            // gpbCota_Edit
            // 
            this.gpbCota_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.gpbCota_Edit.BorderRadius = 8;
            this.gpbCota_Edit.Controls.Add(this.cbxEstado_Edit);
            this.gpbCota_Edit.Controls.Add(this.txtObservacoes_Edit);
            this.gpbCota_Edit.Controls.Add(this.lblEstadoAdd);
            this.gpbCota_Edit.Controls.Add(this.txtNVolume_Edit);
            this.gpbCota_Edit.Controls.Add(this.txtCota_Edit);
            this.gpbCota_Edit.Controls.Add(this.label6);
            this.gpbCota_Edit.Controls.Add(this.label7);
            this.gpbCota_Edit.Controls.Add(this.label4);
            this.gpbCota_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.gpbCota_Edit.Location = new System.Drawing.Point(24, 336);
            this.gpbCota_Edit.Name = "gpbCota_Edit";
            this.gpbCota_Edit.Size = new System.Drawing.Size(528, 200);
            this.gpbCota_Edit.TabIndex = 36;
            this.gpbCota_Edit.TabStop = false;
            // 
            // cbxEstado_Edit
            // 
            this.cbxEstado_Edit.FormattingEnabled = true;
            this.cbxEstado_Edit.ItemHeight = 23;
            this.cbxEstado_Edit.Items.AddRange(new object[] {
            "Disponível",
            "Indisponível",
            "Abatido",
            "Perdido",
            "Consulta local",
            "Exposição",
            "Depósito"});
            this.cbxEstado_Edit.Location = new System.Drawing.Point(128, 64);
            this.cbxEstado_Edit.Name = "cbxEstado_Edit";
            this.cbxEstado_Edit.Size = new System.Drawing.Size(176, 29);
            this.cbxEstado_Edit.TabIndex = 62;
            this.cbxEstado_Edit.UseSelectable = true;
            // 
            // txtObservacoes_Edit
            // 
            this.txtObservacoes_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservacoes_Edit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.txtObservacoes_Edit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtObservacoes_Edit.BorderSize = 2;
            this.txtObservacoes_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtObservacoes_Edit.Location = new System.Drawing.Point(128, 120);
            this.txtObservacoes_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacoes_Edit.Multiline = true;
            this.txtObservacoes_Edit.Name = "txtObservacoes_Edit";
            this.txtObservacoes_Edit.Padding = new System.Windows.Forms.Padding(7);
            this.txtObservacoes_Edit.PasswordChar = false;
            this.txtObservacoes_Edit.Size = new System.Drawing.Size(368, 48);
            this.txtObservacoes_Edit.TabIndex = 45;
            this.txtObservacoes_Edit.Texts = "";
            this.txtObservacoes_Edit.UnderlinedStyle = true;
            // 
            // lblEstadoAdd
            // 
            this.lblEstadoAdd.AutoSize = true;
            this.lblEstadoAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblEstadoAdd.Location = new System.Drawing.Point(59, 72);
            this.lblEstadoAdd.Name = "lblEstadoAdd";
            this.lblEstadoAdd.Size = new System.Drawing.Size(52, 17);
            this.lblEstadoAdd.TabIndex = 50;
            this.lblEstadoAdd.Text = "Estado";
            // 
            // txtNVolume_Edit
            // 
            this.txtNVolume_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtNVolume_Edit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.txtNVolume_Edit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtNVolume_Edit.BorderSize = 2;
            this.txtNVolume_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNVolume_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtNVolume_Edit.Location = new System.Drawing.Point(368, 16);
            this.txtNVolume_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtNVolume_Edit.Multiline = false;
            this.txtNVolume_Edit.Name = "txtNVolume_Edit";
            this.txtNVolume_Edit.Padding = new System.Windows.Forms.Padding(7);
            this.txtNVolume_Edit.PasswordChar = false;
            this.txtNVolume_Edit.Size = new System.Drawing.Size(48, 31);
            this.txtNVolume_Edit.TabIndex = 43;
            this.txtNVolume_Edit.Texts = "";
            this.txtNVolume_Edit.UnderlinedStyle = true;
            // 
            // txtCota_Edit
            // 
            this.txtCota_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtCota_Edit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.txtCota_Edit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtCota_Edit.BorderSize = 2;
            this.txtCota_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCota_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtCota_Edit.Location = new System.Drawing.Point(128, 16);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.label6.Location = new System.Drawing.Point(19, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Observações";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.label7.Location = new System.Drawing.Point(14, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cota da CDU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(280, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nº Volume";
            // 
            // bttSave_Edit
            // 
            this.bttSave_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.bttSave_Edit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttSave_Edit.BorderRadius = 5;
            this.bttSave_Edit.BorderSize = 0;
            this.bttSave_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttSave_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSave_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSave_Edit.ForeColor = System.Drawing.Color.Transparent;
            this.bttSave_Edit.Image = global::BIBLIOTECA_PROJETO.Properties.Resources.icon_bttsaveedit;
            this.bttSave_Edit.Location = new System.Drawing.Point(600, 144);
            this.bttSave_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.bttSave_Edit.Name = "bttSave_Edit";
            this.bttSave_Edit.Size = new System.Drawing.Size(40, 40);
            this.bttSave_Edit.TabIndex = 29;
            this.bttSave_Edit.UseVisualStyleBackColor = false;
            this.bttSave_Edit.Click += new System.EventHandler(this.bttSave_Edit_Click);
            // 
            // gpbN_Edit
            // 
            this.gpbN_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.gpbN_Edit.BorderRadius = 8;
            this.gpbN_Edit.Controls.Add(this.bttFilterDate);
            this.gpbN_Edit.Controls.Add(this.txtDataEntrega_Edit);
            this.gpbN_Edit.Controls.Add(this.txtNRegisto_Edit);
            this.gpbN_Edit.Controls.Add(this.label2);
            this.gpbN_Edit.Controls.Add(this.label1);
            this.gpbN_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.gpbN_Edit.Location = new System.Drawing.Point(24, 24);
            this.gpbN_Edit.Name = "gpbN_Edit";
            this.gpbN_Edit.Size = new System.Drawing.Size(528, 64);
            this.gpbN_Edit.TabIndex = 34;
            this.gpbN_Edit.TabStop = false;
            // 
            // bttFilterDate
            // 
            this.bttFilterDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.bttFilterDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttFilterDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttFilterDate.BorderRadius = 5;
            this.bttFilterDate.BorderSize = 0;
            this.bttFilterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttFilterDate.ForeColor = System.Drawing.Color.White;
            this.bttFilterDate.Image = global::BIBLIOTECA_PROJETO.Properties.Resources.icon_bttsearchdate;
            this.bttFilterDate.Location = new System.Drawing.Point(216, 18);
            this.bttFilterDate.Margin = new System.Windows.Forms.Padding(0);
            this.bttFilterDate.Name = "bttFilterDate";
            this.bttFilterDate.Size = new System.Drawing.Size(35, 35);
            this.bttFilterDate.TabIndex = 37;
            this.bttFilterDate.UseVisualStyleBackColor = false;
            this.bttFilterDate.Click += new System.EventHandler(this.bttFilterDate_Click);
            // 
            // txtDataEntrega_Edit
            // 
            this.txtDataEntrega_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataEntrega_Edit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.txtDataEntrega_Edit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtDataEntrega_Edit.BorderSize = 2;
            this.txtDataEntrega_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEntrega_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtDataEntrega_Edit.Location = new System.Drawing.Point(416, 20);
            this.txtDataEntrega_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataEntrega_Edit.Multiline = false;
            this.txtDataEntrega_Edit.Name = "txtDataEntrega_Edit";
            this.txtDataEntrega_Edit.Padding = new System.Windows.Forms.Padding(7);
            this.txtDataEntrega_Edit.PasswordChar = false;
            this.txtDataEntrega_Edit.Size = new System.Drawing.Size(80, 31);
            this.txtDataEntrega_Edit.TabIndex = 29;
            this.txtDataEntrega_Edit.Texts = "";
            this.txtDataEntrega_Edit.UnderlinedStyle = true;
            this.txtDataEntrega_Edit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataEntrega_Edit_KeyPress);
            // 
            // txtNRegisto_Edit
            // 
            this.txtNRegisto_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtNRegisto_Edit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.txtNRegisto_Edit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtNRegisto_Edit.BorderSize = 2;
            this.txtNRegisto_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNRegisto_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtNRegisto_Edit.Location = new System.Drawing.Point(128, 20);
            this.txtNRegisto_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtNRegisto_Edit.Multiline = false;
            this.txtNRegisto_Edit.Name = "txtNRegisto_Edit";
            this.txtNRegisto_Edit.Padding = new System.Windows.Forms.Padding(7);
            this.txtNRegisto_Edit.PasswordChar = false;
            this.txtNRegisto_Edit.Size = new System.Drawing.Size(72, 31);
            this.txtNRegisto_Edit.TabIndex = 28;
            this.txtNRegisto_Edit.Texts = "";
            this.txtNRegisto_Edit.UnderlinedStyle = true;
            this.txtNRegisto_Edit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNRegisto_Edit_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(288, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Entrega";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº de Registo";
            // 
            // bttDel
            // 
            this.bttDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(55)))), ((int)(((byte)(54)))));
            this.bttDel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttDel.BorderRadius = 5;
            this.bttDel.BorderSize = 0;
            this.bttDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDel.ForeColor = System.Drawing.Color.Transparent;
            this.bttDel.Image = ((System.Drawing.Image)(resources.GetObject("bttDel.Image")));
            this.bttDel.Location = new System.Drawing.Point(600, 32);
            this.bttDel.Margin = new System.Windows.Forms.Padding(0);
            this.bttDel.Name = "bttDel";
            this.bttDel.Size = new System.Drawing.Size(40, 40);
            this.bttDel.TabIndex = 36;
            this.bttDel.UseVisualStyleBackColor = false;
            this.bttDel.Click += new System.EventHandler(this.bttDel_Click);
            // 
            // bttClear_Edit
            // 
            this.bttClear_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.bttClear_Edit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttClear_Edit.BorderRadius = 5;
            this.bttClear_Edit.BorderSize = 0;
            this.bttClear_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttClear_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttClear_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttClear_Edit.ForeColor = System.Drawing.Color.Transparent;
            this.bttClear_Edit.Image = ((System.Drawing.Image)(resources.GetObject("bttClear_Edit.Image")));
            this.bttClear_Edit.Location = new System.Drawing.Point(600, 88);
            this.bttClear_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.bttClear_Edit.Name = "bttClear_Edit";
            this.bttClear_Edit.Size = new System.Drawing.Size(40, 40);
            this.bttClear_Edit.TabIndex = 30;
            this.bttClear_Edit.UseVisualStyleBackColor = false;
            this.bttClear_Edit.Click += new System.EventHandler(this.bttClear_Edit_Click);
            // 
            // gpbAutor_Edit
            // 
            this.gpbAutor_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.gpbAutor_Edit.BorderRadius = 8;
            this.gpbAutor_Edit.Controls.Add(this.cbxAquisicao_Edit);
            this.gpbAutor_Edit.Controls.Add(this.txtEditora_Edit);
            this.gpbAutor_Edit.Controls.Add(this.label8);
            this.gpbAutor_Edit.Controls.Add(this.label9);
            this.gpbAutor_Edit.Controls.Add(this.txtAutor_Edit);
            this.gpbAutor_Edit.Controls.Add(this.txtTitulo_Edit);
            this.gpbAutor_Edit.Controls.Add(this.label5);
            this.gpbAutor_Edit.Controls.Add(this.label3);
            this.gpbAutor_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.gpbAutor_Edit.Location = new System.Drawing.Point(24, 96);
            this.gpbAutor_Edit.Name = "gpbAutor_Edit";
            this.gpbAutor_Edit.Size = new System.Drawing.Size(528, 232);
            this.gpbAutor_Edit.TabIndex = 31;
            this.gpbAutor_Edit.TabStop = false;
            this.gpbAutor_Edit.Enter += new System.EventHandler(this.gpbAutor_Edit_Enter);
            // 
            // cbxAquisicao_Edit
            // 
            this.cbxAquisicao_Edit.FormattingEnabled = true;
            this.cbxAquisicao_Edit.ItemHeight = 23;
            this.cbxAquisicao_Edit.Items.AddRange(new object[] {
            "Compra",
            "Oferta"});
            this.cbxAquisicao_Edit.Location = new System.Drawing.Point(128, 136);
            this.cbxAquisicao_Edit.Name = "cbxAquisicao_Edit";
            this.cbxAquisicao_Edit.Size = new System.Drawing.Size(176, 29);
            this.cbxAquisicao_Edit.TabIndex = 53;
            this.cbxAquisicao_Edit.UseSelectable = true;
            // 
            // txtEditora_Edit
            // 
            this.txtEditora_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditora_Edit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.txtEditora_Edit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtEditora_Edit.BorderSize = 2;
            this.txtEditora_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditora_Edit.Location = new System.Drawing.Point(128, 184);
            this.txtEditora_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditora_Edit.Multiline = false;
            this.txtEditora_Edit.Name = "txtEditora_Edit";
            this.txtEditora_Edit.Padding = new System.Windows.Forms.Padding(7);
            this.txtEditora_Edit.PasswordChar = false;
            this.txtEditora_Edit.Size = new System.Drawing.Size(371, 31);
            this.txtEditora_Edit.TabIndex = 52;
            this.txtEditora_Edit.Texts = "";
            this.txtEditora_Edit.UnderlinedStyle = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.label8.Location = new System.Drawing.Point(57, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "Editora";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.label9.Location = new System.Drawing.Point(40, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 49;
            this.label9.Text = "Aquisição";
            // 
            // txtAutor_Edit
            // 
            this.txtAutor_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtAutor_Edit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.txtAutor_Edit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtAutor_Edit.BorderSize = 2;
            this.txtAutor_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtAutor_Edit.Location = new System.Drawing.Point(128, 80);
            this.txtAutor_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor_Edit.Multiline = false;
            this.txtAutor_Edit.Name = "txtAutor_Edit";
            this.txtAutor_Edit.Padding = new System.Windows.Forms.Padding(7);
            this.txtAutor_Edit.PasswordChar = false;
            this.txtAutor_Edit.Size = new System.Drawing.Size(369, 31);
            this.txtAutor_Edit.TabIndex = 35;
            this.txtAutor_Edit.Texts = "";
            this.txtAutor_Edit.UnderlinedStyle = true;
            // 
            // txtTitulo_Edit
            // 
            this.txtTitulo_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitulo_Edit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.txtTitulo_Edit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtTitulo_Edit.BorderSize = 2;
            this.txtTitulo_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtTitulo_Edit.Location = new System.Drawing.Point(128, 24);
            this.txtTitulo_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo_Edit.Multiline = false;
            this.txtTitulo_Edit.Name = "txtTitulo_Edit";
            this.txtTitulo_Edit.Padding = new System.Windows.Forms.Padding(7);
            this.txtTitulo_Edit.PasswordChar = false;
            this.txtTitulo_Edit.Size = new System.Drawing.Size(369, 31);
            this.txtTitulo_Edit.TabIndex = 30;
            this.txtTitulo_Edit.Texts = "";
            this.txtTitulo_Edit.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.label5.Location = new System.Drawing.Point(70, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(68, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autor";
            // 
            // pnlLineTop
            // 
            this.pnlLineTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.pnlLineTop.Location = new System.Drawing.Point(0, 46);
            this.pnlLineTop.Name = "pnlLineTop";
            this.pnlLineTop.Size = new System.Drawing.Size(688, 12);
            this.pnlLineTop.TabIndex = 63;
            // 
            // pnlLineBottom
            // 
            this.pnlLineBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.pnlLineBottom.Location = new System.Drawing.Point(0, 557);
            this.pnlLineBottom.Name = "pnlLineBottom";
            this.pnlLineBottom.Size = new System.Drawing.Size(688, 12);
            this.pnlLineBottom.TabIndex = 64;
            // 
            // frmEditLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 685);
            this.Controls.Add(this.pnlEditLivros);
            this.Name = "frmEditLivros";
            this.Text = "frmEditLivros";
            this.pnlEditLivros.ResumeLayout(false);
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.pnlFormBody.ResumeLayout(false);
            this.gpbCota_Edit.ResumeLayout(false);
            this.gpbCota_Edit.PerformLayout();
            this.gpbN_Edit.ResumeLayout(false);
            this.gpbN_Edit.PerformLayout();
            this.gpbAutor_Edit.ResumeLayout(false);
            this.gpbAutor_Edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEditLivros;
        private controls.UC_textbox txtDataEntrega_Edit;
        private System.Windows.Forms.Label label2;
        private controls.UC_textbox txtNRegisto_Edit;
        private System.Windows.Forms.Label label1;
        private controls.UC_textbox txtAutor_Edit;
        private controls.UC_textbox txtTitulo_Edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private controls.RoundedButton bttSave_Edit;
        private controls.RoundedButton bttClear_Edit;
        private controls.RoundedButton bttDel;
        private RoundedGroupBox gpbN_Edit;
        private RoundedGroupBox gpbAutor_Edit;
        private RoundedPanel pnlFormHeader;
        private System.Windows.Forms.Label lblListagem;
        private System.Windows.Forms.Panel pnlFormBody;
        private RoundedGroupBox gpbCota_Edit;
        private controls.UC_textbox txtObservacoes_Edit;
        private controls.UC_textbox txtNVolume_Edit;
        private controls.UC_textbox txtCota_Edit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private controls.UC_textbox txtEditora_Edit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private controls.RoundedButton bttFilterDate;
        private System.Windows.Forms.Label lblEstadoAdd;
        private MetroFramework.Controls.MetroComboBox cbxEstado_Edit;
        private MetroFramework.Controls.MetroComboBox cbxAquisicao_Edit;
        private RoundedPanelBottom pnlFormFooter;
        private System.Windows.Forms.Panel pnlLineTop;
        private System.Windows.Forms.Panel pnlLineBottom;
    }
}