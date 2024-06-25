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
        private Button _selectedButton;

        public MainForm()
        {
            InitializeComponent();
            formOriginalSize = this.Size;
        }

        public void AddControlBounds(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                originalControlsBounds[childControl] = new Rectangle(childControl.Location, childControl.Size);
                AddControlBounds(childControl);
            }
        }

        public void ResizeControls(Control container)
        {
            if (formOriginalSize.Width == 0 || formOriginalSize.Height == 0) return;

            float xRatio = (float)this.Width / formOriginalSize.Width;
            float yRatio = (float)this.Height / formOriginalSize.Height;
            foreach (Control control in container.Controls)
            {
                if (originalControlsBounds.TryGetValue(control, out Rectangle originalBounds))
                {
                    int newX = (int)(originalBounds.X * xRatio);
                    int newY = (int)(originalBounds.Y * yRatio);
                    int newWidth = (int)(originalBounds.Width * xRatio);
                    int newHeight = (int)(originalBounds.Height * yRatio);
                    control.Location = new Point(newX, newY);
                    control.Size = new Size(newWidth, newHeight);
                }
                ResizeControls(control);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ResizeControls(this);
        }

        public void LoadForms(Form form)
        {
            _loadForms?.Close();
            _loadForms = form;
            _loadForms.TopLevel = false;
            _loadForms.FormBorderStyle = FormBorderStyle.None;
            _loadForms.Dock = DockStyle.Fill;
            pnlLoadForms.Controls.Add(_loadForms);
            _loadForms.Show();
            AddControlBounds(_loadForms);
        }

        private void SetSelectedButton(Button button)
        {
            if (_selectedButton != null)
            {
                _selectedButton.BackColor = Color.FromArgb(51, 58, 94); // Original color
            }
            _selectedButton = button;
            _selectedButton.BackColor = Color.FromArgb(23, 23, 55); // Color to show it's been selected
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            SetSelectedButton(bttNew);
            LoadAddLivros();
        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            SetSelectedButton(bttEdit);
            LoadEditLivros();
        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            SetSelectedButton(bttSearch);
            LoadViewLivros();
        }

        private void bttListing_Click(object sender, EventArgs e)
        {
            SetSelectedButton(bttListing);
            LoadListing();
        }

        private void bttDateListing_Click(object sender, EventArgs e)
        {
            SetSelectedButton(bttDateListing);
            LoadDateLivros();
        }
        private void bttStatistics_Click(object sender, EventArgs e)
        {
             SetSelectedButton(bttStatistics);
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetSelectedButton(bttSearch);
            LoadViewLivros();
        }

        public void LoadAddLivros() => LoadForms(new gui.frmAddLivros());

        public void LoadEditLivros() => LoadForms(new gui.frmEditLivros());

        public void LoadViewLivros() => LoadForms(new gui.frmBookViewer());

        public void LoadDateLivros() => LoadForms(new gui.frmDateFromUntil());

        public void LoadListing() => LoadForms(new gui.frmFilteredListing());

        public void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceitar apenas números e teclas de controle (Backspace, Delete, etc.)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        
    }
}
