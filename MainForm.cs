using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO
{
    public partial class MainForm : Form
    {
        private Dictionary<Control, Rectangle> originalControlsBounds = new Dictionary<Control, Rectangle>();
        private Size formOriginalSize;
        private Form _loadForms;

        public MainForm()
        {
            InitializeComponent();

        }

        public void AddControlBounds(Control control, Form form)
        {
            formOriginalSize = ((Form)form).Size;
            foreach (Control childControl in control.Controls)
            {
                originalControlsBounds.Add(childControl, childControl.Bounds);
                AddControlBounds(childControl, form);
            }

            //foreach (var container in this.Controls.OfType<Panel>())
            //{
            //    AddControlBounds((Control)Container, this
            //}
        }

        public void ResizeControls(Control container)
        {
            float fontSizeRatio = (float)this.Width / 125;
            if (fontSizeRatio < 8) fontSizeRatio = 8;
            foreach (Control control in container.Controls)
            {
                float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
                float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
                int newX = (int)(originalControlsBounds[control].X * xRatio);
                int newY = (int)(originalControlsBounds[control].Y * yRatio);
                int newWidth = (int)(originalControlsBounds[control].Width * xRatio);
                int newHeight = (int)(originalControlsBounds[control].Height * yRatio);
                control.Location = new Point(newX, newY);
                control.Size = new Size(newWidth, newHeight);
                control.Font = new Font(control.Font.FontFamily, fontSizeRatio, control.Font.Style);
                ResizeControls(control);

            }

        }

        public void LoadForms(Form form)
        {
            _loadForms?.Close();
            _loadForms = (Form)form;
            _loadForms.TopLevel = false;
            _loadForms.FormBorderStyle = FormBorderStyle.None;
            _loadForms.Dock = DockStyle.Fill;
            pnlLoadForms.Controls.Add(_loadForms);
            _loadForms.Show();
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            LoadAddLivros();
        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            LoadEditLivros();
        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            LoadViewLivros();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadAddLivros() => LoadForms(new gui.frmAddLivros());

        public void LoadEditLivros() => LoadForms(new gui.frmEditLivros());

        public void LoadViewLivros() => LoadForms(new gui.frmBookViewer());


        public void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceitar apenas números e teclas de controle (Backspace, Delete, etc.)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        
    }
}
