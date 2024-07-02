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
            this.SuspendLayout();
            // 
            // bttOk
            // 
            this.bttOk.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttOk.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttOk.BorderRadius = 5;
            this.bttOk.BorderSize = 0;
            this.bttOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttOk.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttOk.ForeColor = System.Drawing.Color.White;
            this.bttOk.Location = new System.Drawing.Point(320, 104);
            this.bttOk.Name = "bttOk";
            this.bttOk.Size = new System.Drawing.Size(107, 32);
            this.bttOk.TabIndex = 1;
            this.bttOk.Text = "Confirmar";
            this.bttOk.UseVisualStyleBackColor = true;
            this.bttOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // comboBoxLibraries
            // 
            this.comboBoxLibraries.FormattingEnabled = true;
            this.comboBoxLibraries.ItemHeight = 23;
            this.comboBoxLibraries.Location = new System.Drawing.Point(16, 56);
            this.comboBoxLibraries.Name = "comboBoxLibraries";
            this.comboBoxLibraries.Size = new System.Drawing.Size(408, 29);
            this.comboBoxLibraries.TabIndex = 2;
            this.comboBoxLibraries.UseSelectable = true;
            // 
            // frmSelectLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 158);
            this.Controls.Add(this.comboBoxLibraries);
            this.Controls.Add(this.bttOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion
        private controls.RoundedButton bttOk;
        private MetroFramework.Controls.MetroComboBox comboBoxLibraries;
    }
}