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
            this.pnlFormFooter = new BIBLIOTECA_PROJETO.controls.RoundedPanelBottom();
            this.pnlFormHeader = new BIBLIOTECA_PROJETO.controls.RoundedPanel();
            this.pnlLineTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFormBody = new System.Windows.Forms.Panel();
            this.pnlLineBottom = new System.Windows.Forms.Panel();
            this.gpbBottom = new BIBLIOTECA_PROJETO.controls.RoundedGroupBox();
            this.cbxCondition = new MetroFramework.Controls.MetroComboBox();
            this.txtObservations = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.txtVolNum = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtClassification = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblObservations = new System.Windows.Forms.Label();
            this.lblClassification = new System.Windows.Forms.Label();
            this.lblVolNum = new System.Windows.Forms.Label();
            this.bttSave_Edit = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.gpbTop = new BIBLIOTECA_PROJETO.controls.RoundedGroupBox();
            this.dtpArrivalDate = new MetroFramework.Controls.MetroDateTime();
            this.bttSearchEdit = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.txtNRegisto_Edit = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.lblRegNum = new System.Windows.Forms.Label();
            this.bttDel = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.bttClear_Edit = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.gpbMid = new BIBLIOTECA_PROJETO.controls.RoundedGroupBox();
            this.cbxAcquisition = new MetroFramework.Controls.MetroComboBox();
            this.txtPublisher = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblAcquisition = new System.Windows.Forms.Label();
            this.txtAuthor = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.txtTitle = new BIBLIOTECA_PROJETO.controls.UC_textbox();
            this.lblTitleBody = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.pnlEditLivros.SuspendLayout();
            this.pnlFormHeader.SuspendLayout();
            this.pnlFormBody.SuspendLayout();
            this.gpbBottom.SuspendLayout();
            this.gpbTop.SuspendLayout();
            this.gpbMid.SuspendLayout();
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
            this.pnlFormFooter.Location = new System.Drawing.Point(224, 616);
            this.pnlFormFooter.Name = "pnlFormFooter";
            this.pnlFormFooter.Size = new System.Drawing.Size(688, 32);
            this.pnlFormFooter.TabIndex = 62;
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.pnlFormHeader.Controls.Add(this.pnlLineTop);
            this.pnlFormHeader.Controls.Add(this.lblTitle);
            this.pnlFormHeader.CornerRadius = 10;
            this.pnlFormHeader.Location = new System.Drawing.Point(224, 16);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(688, 48);
            this.pnlFormHeader.TabIndex = 60;
            // 
            // pnlLineTop
            // 
            this.pnlLineTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.pnlLineTop.Location = new System.Drawing.Point(0, 46);
            this.pnlLineTop.Name = "pnlLineTop";
            this.pnlLineTop.Size = new System.Drawing.Size(688, 12);
            this.pnlLineTop.TabIndex = 63;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 26);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Editar Registo";
            // 
            // pnlFormBody
            // 
            this.pnlFormBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.pnlFormBody.Controls.Add(this.pnlLineBottom);
            this.pnlFormBody.Controls.Add(this.gpbBottom);
            this.pnlFormBody.Controls.Add(this.bttSave_Edit);
            this.pnlFormBody.Controls.Add(this.gpbTop);
            this.pnlFormBody.Controls.Add(this.bttDel);
            this.pnlFormBody.Controls.Add(this.bttClear_Edit);
            this.pnlFormBody.Controls.Add(this.gpbMid);
            this.pnlFormBody.Location = new System.Drawing.Point(224, 64);
            this.pnlFormBody.Name = "pnlFormBody";
            this.pnlFormBody.Size = new System.Drawing.Size(688, 552);
            this.pnlFormBody.TabIndex = 61;
            // 
            // pnlLineBottom
            // 
            this.pnlLineBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.pnlLineBottom.Location = new System.Drawing.Point(0, 558);
            this.pnlLineBottom.Name = "pnlLineBottom";
            this.pnlLineBottom.Size = new System.Drawing.Size(688, 12);
            this.pnlLineBottom.TabIndex = 64;
            // 
            // gpbBottom
            // 
            this.gpbBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.gpbBottom.BorderRadius = 8;
            this.gpbBottom.Controls.Add(this.cbxCondition);
            this.gpbBottom.Controls.Add(this.txtObservations);
            this.gpbBottom.Controls.Add(this.lblCondition);
            this.gpbBottom.Controls.Add(this.txtVolNum);
            this.gpbBottom.Controls.Add(this.txtClassification);
            this.gpbBottom.Controls.Add(this.lblObservations);
            this.gpbBottom.Controls.Add(this.lblClassification);
            this.gpbBottom.Controls.Add(this.lblVolNum);
            this.gpbBottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.gpbBottom.Location = new System.Drawing.Point(24, 336);
            this.gpbBottom.Name = "gpbBottom";
            this.gpbBottom.Size = new System.Drawing.Size(528, 192);
            this.gpbBottom.TabIndex = 36;
            this.gpbBottom.TabStop = false;
            // 
            // cbxCondition
            // 
            this.cbxCondition.Enabled = false;
            this.cbxCondition.FormattingEnabled = true;
            this.cbxCondition.ItemHeight = 23;
            this.cbxCondition.Items.AddRange(new object[] {
            "Disponível",
            "Indisponível",
            "Abatido",
            "Perdido",
            "Consulta local",
            "Exposição",
            "Depósito"});
            this.cbxCondition.Location = new System.Drawing.Point(128, 64);
            this.cbxCondition.Name = "cbxCondition";
            this.cbxCondition.Size = new System.Drawing.Size(176, 29);
            this.cbxCondition.TabIndex = 62;
            this.cbxCondition.UseSelectable = true;
            // 
            // txtObservations
            // 
            this.txtObservations.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservations.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.txtObservations.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtObservations.BorderSize = 2;
            this.txtObservations.Enabled = false;
            this.txtObservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservations.ForeColor = System.Drawing.Color.DimGray;
            this.txtObservations.Location = new System.Drawing.Point(128, 120);
            this.txtObservations.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Padding = new System.Windows.Forms.Padding(7);
            this.txtObservations.PasswordChar = false;
            this.txtObservations.Size = new System.Drawing.Size(368, 48);
            this.txtObservations.TabIndex = 45;
            this.txtObservations.Texts = "";
            this.txtObservations.UnderlinedStyle = true;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblCondition.Location = new System.Drawing.Point(59, 72);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(52, 17);
            this.lblCondition.TabIndex = 50;
            this.lblCondition.Text = "Estado";
            // 
            // txtVolNum
            // 
            this.txtVolNum.BackColor = System.Drawing.SystemColors.Window;
            this.txtVolNum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.txtVolNum.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtVolNum.BorderSize = 2;
            this.txtVolNum.Enabled = false;
            this.txtVolNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolNum.ForeColor = System.Drawing.Color.DimGray;
            this.txtVolNum.Location = new System.Drawing.Point(368, 16);
            this.txtVolNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtVolNum.Multiline = false;
            this.txtVolNum.Name = "txtVolNum";
            this.txtVolNum.Padding = new System.Windows.Forms.Padding(7);
            this.txtVolNum.PasswordChar = false;
            this.txtVolNum.Size = new System.Drawing.Size(48, 31);
            this.txtVolNum.TabIndex = 43;
            this.txtVolNum.Texts = "";
            this.txtVolNum.UnderlinedStyle = true;
            // 
            // txtClassification
            // 
            this.txtClassification.BackColor = System.Drawing.SystemColors.Window;
            this.txtClassification.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.txtClassification.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtClassification.BorderSize = 2;
            this.txtClassification.Enabled = false;
            this.txtClassification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassification.ForeColor = System.Drawing.Color.DimGray;
            this.txtClassification.Location = new System.Drawing.Point(128, 16);
            this.txtClassification.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassification.Multiline = false;
            this.txtClassification.Name = "txtClassification";
            this.txtClassification.Padding = new System.Windows.Forms.Padding(7);
            this.txtClassification.PasswordChar = false;
            this.txtClassification.Size = new System.Drawing.Size(112, 31);
            this.txtClassification.TabIndex = 42;
            this.txtClassification.Texts = "";
            this.txtClassification.UnderlinedStyle = true;
            // 
            // lblObservations
            // 
            this.lblObservations.AutoSize = true;
            this.lblObservations.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblObservations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblObservations.Location = new System.Drawing.Point(19, 120);
            this.lblObservations.Name = "lblObservations";
            this.lblObservations.Size = new System.Drawing.Size(92, 17);
            this.lblObservations.TabIndex = 13;
            this.lblObservations.Text = "Observações";
            // 
            // lblClassification
            // 
            this.lblClassification.AutoSize = true;
            this.lblClassification.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblClassification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblClassification.Location = new System.Drawing.Point(14, 26);
            this.lblClassification.Name = "lblClassification";
            this.lblClassification.Size = new System.Drawing.Size(97, 17);
            this.lblClassification.TabIndex = 11;
            this.lblClassification.Text = "Cota da CDU";
            // 
            // lblVolNum
            // 
            this.lblVolNum.AutoSize = true;
            this.lblVolNum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblVolNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblVolNum.Location = new System.Drawing.Point(280, 26);
            this.lblVolNum.Name = "lblVolNum";
            this.lblVolNum.Size = new System.Drawing.Size(77, 17);
            this.lblVolNum.TabIndex = 9;
            this.lblVolNum.Text = "Nº Volume";
            // 
            // bttSave_Edit
            // 
            this.bttSave_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.bttSave_Edit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttSave_Edit.BorderRadius = 5;
            this.bttSave_Edit.BorderSize = 0;
            this.bttSave_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttSave_Edit.Enabled = false;
            this.bttSave_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSave_Edit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSave_Edit.ForeColor = System.Drawing.Color.Transparent;
            this.bttSave_Edit.Image = global::BIBLIOTECA_PROJETO.Properties.Resources.icon_bttsaveedit;
            this.bttSave_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttSave_Edit.Location = new System.Drawing.Point(568, 136);
            this.bttSave_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.bttSave_Edit.Name = "bttSave_Edit";
            this.bttSave_Edit.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bttSave_Edit.Size = new System.Drawing.Size(104, 40);
            this.bttSave_Edit.TabIndex = 29;
            this.bttSave_Edit.Text = "Guardar";
            this.bttSave_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttSave_Edit.UseVisualStyleBackColor = false;
            this.bttSave_Edit.Click += new System.EventHandler(this.bttSave_Edit_Click);
            // 
            // gpbTop
            // 
            this.gpbTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.gpbTop.BorderRadius = 8;
            this.gpbTop.Controls.Add(this.dtpArrivalDate);
            this.gpbTop.Controls.Add(this.bttSearchEdit);
            this.gpbTop.Controls.Add(this.txtNRegisto_Edit);
            this.gpbTop.Controls.Add(this.lblArrivalDate);
            this.gpbTop.Controls.Add(this.lblRegNum);
            this.gpbTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.gpbTop.Location = new System.Drawing.Point(24, 24);
            this.gpbTop.Name = "gpbTop";
            this.gpbTop.Size = new System.Drawing.Size(528, 64);
            this.gpbTop.TabIndex = 34;
            this.gpbTop.TabStop = false;
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.Enabled = false;
            this.dtpArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpArrivalDate.Location = new System.Drawing.Point(384, 20);
            this.dtpArrivalDate.MaxDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpArrivalDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpArrivalDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(112, 29);
            this.dtpArrivalDate.Style = MetroFramework.MetroColorStyle.Green;
            this.dtpArrivalDate.TabIndex = 63;
            this.dtpArrivalDate.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dtpArrivalDate.UseCustomBackColor = true;
            this.dtpArrivalDate.UseCustomForeColor = true;
            this.dtpArrivalDate.UseStyleColors = true;
            this.dtpArrivalDate.Value = new System.DateTime(2024, 7, 3, 0, 0, 0, 0);
            // 
            // bttSearchEdit
            // 
            this.bttSearchEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.bttSearchEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttSearchEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttSearchEdit.BorderRadius = 5;
            this.bttSearchEdit.BorderSize = 0;
            this.bttSearchEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSearchEdit.ForeColor = System.Drawing.Color.White;
            this.bttSearchEdit.Image = global::BIBLIOTECA_PROJETO.Properties.Resources.icon_bttsearchdate;
            this.bttSearchEdit.Location = new System.Drawing.Point(216, 18);
            this.bttSearchEdit.Margin = new System.Windows.Forms.Padding(0);
            this.bttSearchEdit.Name = "bttSearchEdit";
            this.bttSearchEdit.Size = new System.Drawing.Size(35, 35);
            this.bttSearchEdit.TabIndex = 37;
            this.bttSearchEdit.UseVisualStyleBackColor = false;
            this.bttSearchEdit.Click += new System.EventHandler(this.bttSearchEdit_Click);
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
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblArrivalDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblArrivalDate.Location = new System.Drawing.Point(264, 28);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(117, 17);
            this.lblArrivalDate.TabIndex = 1;
            this.lblArrivalDate.Text = "Data de Entrada";
            // 
            // lblRegNum
            // 
            this.lblRegNum.AutoSize = true;
            this.lblRegNum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblRegNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblRegNum.Location = new System.Drawing.Point(33, 28);
            this.lblRegNum.Name = "lblRegNum";
            this.lblRegNum.Size = new System.Drawing.Size(78, 17);
            this.lblRegNum.TabIndex = 1;
            this.lblRegNum.Text = "Nº. Registo";
            // 
            // bttDel
            // 
            this.bttDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(55)))), ((int)(((byte)(54)))));
            this.bttDel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttDel.BorderRadius = 5;
            this.bttDel.BorderSize = 0;
            this.bttDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttDel.Enabled = false;
            this.bttDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDel.ForeColor = System.Drawing.Color.Transparent;
            this.bttDel.Image = ((System.Drawing.Image)(resources.GetObject("bttDel.Image")));
            this.bttDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttDel.Location = new System.Drawing.Point(568, 80);
            this.bttDel.Margin = new System.Windows.Forms.Padding(0);
            this.bttDel.Name = "bttDel";
            this.bttDel.Padding = new System.Windows.Forms.Padding(4, 0, 6, 0);
            this.bttDel.Size = new System.Drawing.Size(104, 40);
            this.bttDel.TabIndex = 36;
            this.bttDel.Text = "Eliminar";
            this.bttDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttDel.UseVisualStyleBackColor = false;
            this.bttDel.Click += new System.EventHandler(this.bttDel_Click);
            // 
            // bttClear_Edit
            // 
            this.bttClear_Edit.BackColor = System.Drawing.Color.DimGray;
            this.bttClear_Edit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttClear_Edit.BorderRadius = 5;
            this.bttClear_Edit.BorderSize = 0;
            this.bttClear_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttClear_Edit.Enabled = false;
            this.bttClear_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttClear_Edit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttClear_Edit.ForeColor = System.Drawing.Color.Transparent;
            this.bttClear_Edit.Image = ((System.Drawing.Image)(resources.GetObject("bttClear_Edit.Image")));
            this.bttClear_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttClear_Edit.Location = new System.Drawing.Point(568, 24);
            this.bttClear_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.bttClear_Edit.Name = "bttClear_Edit";
            this.bttClear_Edit.Padding = new System.Windows.Forms.Padding(4, 0, 7, 0);
            this.bttClear_Edit.Size = new System.Drawing.Size(104, 40);
            this.bttClear_Edit.TabIndex = 30;
            this.bttClear_Edit.Text = "Limpar";
            this.bttClear_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttClear_Edit.UseVisualStyleBackColor = false;
            this.bttClear_Edit.Click += new System.EventHandler(this.bttClear_Edit_Click);
            // 
            // gpbMid
            // 
            this.gpbMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.gpbMid.BorderRadius = 8;
            this.gpbMid.Controls.Add(this.cbxAcquisition);
            this.gpbMid.Controls.Add(this.txtPublisher);
            this.gpbMid.Controls.Add(this.lblPublisher);
            this.gpbMid.Controls.Add(this.lblAcquisition);
            this.gpbMid.Controls.Add(this.txtAuthor);
            this.gpbMid.Controls.Add(this.txtTitle);
            this.gpbMid.Controls.Add(this.lblTitleBody);
            this.gpbMid.Controls.Add(this.lblAuthor);
            this.gpbMid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.gpbMid.Location = new System.Drawing.Point(24, 96);
            this.gpbMid.Name = "gpbMid";
            this.gpbMid.Size = new System.Drawing.Size(528, 232);
            this.gpbMid.TabIndex = 31;
            this.gpbMid.TabStop = false;
            // 
            // cbxAcquisition
            // 
            this.cbxAcquisition.Enabled = false;
            this.cbxAcquisition.FormattingEnabled = true;
            this.cbxAcquisition.ItemHeight = 23;
            this.cbxAcquisition.Items.AddRange(new object[] {
            "Compra",
            "Oferta"});
            this.cbxAcquisition.Location = new System.Drawing.Point(128, 136);
            this.cbxAcquisition.Name = "cbxAcquisition";
            this.cbxAcquisition.Size = new System.Drawing.Size(176, 29);
            this.cbxAcquisition.TabIndex = 53;
            this.cbxAcquisition.UseSelectable = true;
            // 
            // txtPublisher
            // 
            this.txtPublisher.BackColor = System.Drawing.SystemColors.Window;
            this.txtPublisher.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.txtPublisher.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtPublisher.BorderSize = 2;
            this.txtPublisher.Enabled = false;
            this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.ForeColor = System.Drawing.Color.DimGray;
            this.txtPublisher.Location = new System.Drawing.Point(128, 184);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublisher.Multiline = false;
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Padding = new System.Windows.Forms.Padding(7);
            this.txtPublisher.PasswordChar = false;
            this.txtPublisher.Size = new System.Drawing.Size(371, 31);
            this.txtPublisher.TabIndex = 52;
            this.txtPublisher.Texts = "";
            this.txtPublisher.UnderlinedStyle = true;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblPublisher.Location = new System.Drawing.Point(57, 194);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(54, 17);
            this.lblPublisher.TabIndex = 50;
            this.lblPublisher.Text = "Editora";
            // 
            // lblAcquisition
            // 
            this.lblAcquisition.AutoSize = true;
            this.lblAcquisition.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblAcquisition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblAcquisition.Location = new System.Drawing.Point(40, 144);
            this.lblAcquisition.Name = "lblAcquisition";
            this.lblAcquisition.Size = new System.Drawing.Size(71, 17);
            this.lblAcquisition.TabIndex = 49;
            this.lblAcquisition.Text = "Aquisição";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.SystemColors.Window;
            this.txtAuthor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.txtAuthor.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtAuthor.BorderSize = 2;
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.ForeColor = System.Drawing.Color.DimGray;
            this.txtAuthor.Location = new System.Drawing.Point(128, 80);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Multiline = false;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Padding = new System.Windows.Forms.Padding(7);
            this.txtAuthor.PasswordChar = false;
            this.txtAuthor.Size = new System.Drawing.Size(369, 31);
            this.txtAuthor.TabIndex = 35;
            this.txtAuthor.Texts = "";
            this.txtAuthor.UnderlinedStyle = true;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.txtTitle.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(183)))), ((int)(((byte)(81)))));
            this.txtTitle.BorderSize = 2;
            this.txtTitle.Enabled = false;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.DimGray;
            this.txtTitle.Location = new System.Drawing.Point(128, 24);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Multiline = false;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Padding = new System.Windows.Forms.Padding(7);
            this.txtTitle.PasswordChar = false;
            this.txtTitle.Size = new System.Drawing.Size(369, 31);
            this.txtTitle.TabIndex = 30;
            this.txtTitle.Texts = "";
            this.txtTitle.UnderlinedStyle = true;
            // 
            // lblTitleBody
            // 
            this.lblTitleBody.AutoSize = true;
            this.lblTitleBody.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblTitleBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblTitleBody.Location = new System.Drawing.Point(70, 32);
            this.lblTitleBody.Name = "lblTitleBody";
            this.lblTitleBody.Size = new System.Drawing.Size(41, 17);
            this.lblTitleBody.TabIndex = 7;
            this.lblTitleBody.Text = "Título";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblAuthor.Location = new System.Drawing.Point(68, 88);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(43, 17);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Autor";
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
            this.gpbBottom.ResumeLayout(false);
            this.gpbBottom.PerformLayout();
            this.gpbTop.ResumeLayout(false);
            this.gpbTop.PerformLayout();
            this.gpbMid.ResumeLayout(false);
            this.gpbMid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEditLivros;
        private System.Windows.Forms.Label lblArrivalDate;
        private controls.UC_textbox txtNRegisto_Edit;
        private System.Windows.Forms.Label lblRegNum;
        private controls.UC_textbox txtAuthor;
        private controls.UC_textbox txtTitle;
        private System.Windows.Forms.Label lblTitleBody;
        private System.Windows.Forms.Label lblAuthor;
        private controls.RoundedButton bttSave_Edit;
        private controls.RoundedButton bttClear_Edit;
        private controls.RoundedButton bttDel;
        private controls.RoundedGroupBox gpbTop;
        private controls.RoundedGroupBox gpbMid;
        private controls.RoundedPanel pnlFormHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFormBody;
        private controls.RoundedGroupBox gpbBottom;
        private controls.UC_textbox txtObservations;
        private controls.UC_textbox txtVolNum;
        private controls.UC_textbox txtClassification;
        private System.Windows.Forms.Label lblObservations;
        private System.Windows.Forms.Label lblClassification;
        private System.Windows.Forms.Label lblVolNum;
        private controls.UC_textbox txtPublisher;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblAcquisition;
        private controls.RoundedButton bttSearchEdit;
        private System.Windows.Forms.Label lblCondition;
        private MetroFramework.Controls.MetroComboBox cbxCondition;
        private MetroFramework.Controls.MetroComboBox cbxAcquisition;
        private controls.RoundedPanelBottom pnlFormFooter;
        private System.Windows.Forms.Panel pnlLineTop;
        private System.Windows.Forms.Panel pnlLineBottom;
        private MetroFramework.Controls.MetroDateTime dtpArrivalDate;
    }
}