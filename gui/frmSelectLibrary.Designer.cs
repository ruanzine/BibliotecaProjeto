namespace BIBLIOTECA_PROJETO.gui
{
    partial class frmSelectLibrary
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
            this.bttOk = new BIBLIOTECA_PROJETO.controls.RoundedButton();
            this.comboBoxLibraries = new MetroFramework.Controls.MetroComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRegNum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttOk
            // 
            this.bttOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.bttOk.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttOk.BorderRadius = 5;
            this.bttOk.BorderSize = 0;
            this.bttOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttOk.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttOk.ForeColor = System.Drawing.Color.White;
            this.bttOk.Location = new System.Drawing.Point(376, 272);
            this.bttOk.Name = "bttOk";
            this.bttOk.Size = new System.Drawing.Size(123, 32);
            this.bttOk.TabIndex = 1;
            this.bttOk.Text = "Confirmar";
            this.bttOk.UseVisualStyleBackColor = false;
            this.bttOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // comboBoxLibraries
            // 
            this.comboBoxLibraries.FormattingEnabled = true;
            this.comboBoxLibraries.ItemHeight = 23;
            this.comboBoxLibraries.Location = new System.Drawing.Point(80, 224);
            this.comboBoxLibraries.Name = "comboBoxLibraries";
            this.comboBoxLibraries.Size = new System.Drawing.Size(416, 29);
            this.comboBoxLibraries.TabIndex = 2;
            this.comboBoxLibraries.UseSelectable = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.lblTitle.Location = new System.Drawing.Point(72, 152);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(163, 32);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Bem-vindo!";
            // 
            // lblRegNum
            // 
            this.lblRegNum.AutoSize = true;
            this.lblRegNum.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.lblRegNum.Location = new System.Drawing.Point(76, 192);
            this.lblRegNum.Name = "lblRegNum";
            this.lblRegNum.Size = new System.Drawing.Size(281, 20);
            this.lblRegNum.TabIndex = 31;
            this.lblRegNum.Text = "Seleciona uma escola para começar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BIBLIOTECA_PROJETO.Properties.Resources.logoLibraries;
            this.pictureBox1.Location = new System.Drawing.Point(36, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 37);
            this.panel1.TabIndex = 33;
            // 
            // frmSelectLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 349);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRegNum);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.comboBoxLibraries);
            this.Controls.Add(this.bttOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private controls.RoundedButton bttOk;
        private MetroFramework.Controls.MetroComboBox comboBoxLibraries;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRegNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}