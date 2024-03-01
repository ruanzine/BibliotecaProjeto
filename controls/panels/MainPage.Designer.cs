namespace BIBLIOTECA_PROJETO
{
    partial class MainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.uC_textbox1 = new BIBLIOTECA_PROJETO.UC_textbox();
            this.uC_ComboBox1 = new BIBLIOTECA_PROJETO.controls.UC_ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAIN";
            // 
            // uC_textbox1
            // 
            this.uC_textbox1.BackColor = System.Drawing.SystemColors.Window;
            this.uC_textbox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.uC_textbox1.BorderSize = 2;
            this.uC_textbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_textbox1.ForeColor = System.Drawing.Color.DimGray;
            this.uC_textbox1.Location = new System.Drawing.Point(224, 72);
            this.uC_textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_textbox1.Multiline = false;
            this.uC_textbox1.Name = "uC_textbox1";
            this.uC_textbox1.Padding = new System.Windows.Forms.Padding(7);
            this.uC_textbox1.PasswordChar = false;
            this.uC_textbox1.Size = new System.Drawing.Size(250, 31);
            this.uC_textbox1.TabIndex = 1;
            this.uC_textbox1.Texts = "";
            this.uC_textbox1.UnderlinedStyle = true;
            // 
            // uC_ComboBox1
            // 
            this.uC_ComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uC_ComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.uC_ComboBox1.BorderSize = 1;
            this.uC_ComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.uC_ComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.uC_ComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.uC_ComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.uC_ComboBox1.Location = new System.Drawing.Point(224, 160);
            this.uC_ComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.uC_ComboBox1.Name = "uC_ComboBox1";
            this.uC_ComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.uC_ComboBox1.Size = new System.Drawing.Size(200, 30);
            this.uC_ComboBox1.TabIndex = 2;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.uC_ComboBox1);
            this.Controls.Add(this.uC_textbox1);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(1167, 616);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private UC_textbox uC_textbox1;
        private controls.UC_ComboBox uC_ComboBox1;
    }
}
