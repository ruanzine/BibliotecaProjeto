using BIBLIOTECA_PROJETO.gui;
using BIBLIOTECA_PROJETO.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO
{
    public partial class MainForm : Form
    {
        private Dictionary<Control, Rectangle> originalControlsBounds = new Dictionary<Control, Rectangle>();
        private Size formOriginalSize;
        private Form _loadForms;
        private Button _selectedButton;
        private int selectedLibraryID;
        private ThemeColors currentThemeColors;

        private readonly Dictionary<int, ThemeColors> themeColors = new Dictionary<int, ThemeColors>
        {
            { 1, new ThemeColors(Color.FromArgb(121, 57, 59), Color.FromArgb(255, 102, 106), Color.FromArgb(121, 57, 59), Color.FromArgb(100, 12, 3), Color.FromArgb(243, 239, 240), Color.FromArgb(100, 12, 3)) },
            { 2, new ThemeColors(Color.FromArgb(18, 96, 68), Color.FromArgb(40, 190, 124), Color.FromArgb(18, 96, 68), Color.FromArgb(6, 64, 49), Color.FromArgb(243, 239, 240), Color.FromArgb(6, 54, 49)) },
            { 3, new ThemeColors(Color.FromArgb(58, 84, 115), Color.FromArgb(108, 166, 224), Color.FromArgb(58, 84, 115), Color.FromArgb(33, 50, 88), Color.FromArgb(243, 239, 240), Color.FromArgb(33, 50, 88)) }
        };

        public MainForm()
        {
            InitializeComponent();
            formOriginalSize = this.Size;

            // Subscribe to the Click event of picLogo
            picLogo.Click += PicLogo_Click;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load the saved library ID
            selectedLibraryID = Properties.Settings.Default.SelectedLibraryID;

            // If no library ID is saved, prompt the user to select one
            if (selectedLibraryID == 0)
            {
                SelectLibrary();
            }

            if (selectedLibraryID > 0) // Ensure a library is selected before proceeding
            {
                SetThemeColors();
                SetSelectedButton(bttSearch);
                SetLibraryInfo(selectedLibraryID);
                LoadViewLivros();
            }
        }

        private void SetLibraryInfo(int libraryID)
        {
            if (libraryID == 1)
            {
                lblLibraryName.Text = "BIBLIOTECA ESCOLAR EB1 PROFESSOR ROMEU GIL";
                lblLibraryName.Location = new Point(690, 13);
                picLogo.Image = Resources.logoBasicSchool_transparent;

            }
            else if (libraryID == 2)
            {
                lblLibraryName.Text = "BIBLIOTECA ESCOLAR EB23 PADRE JOSÉ ROTA";
                lblLibraryName.Location = new Point(728, 13);
                picLogo.Image = Resources.logo_eb23_transparent;

            }
            else
            {
                lblLibraryName.Text = "BIBLIOTECA DA ESCOLA SECUNDÁRIA";
                lblLibraryName.Location = new Point(800, 13);
                picLogo.Image = Resources.logoSecondarySchool_transparent2;
            }
        }

        private void SelectLibrary()
        {
            using (var selectLibraryForm = new frmSelectLibrary())
            {
                if (selectLibraryForm.ShowDialog() == DialogResult.OK)
                {
                    selectedLibraryID = selectLibraryForm.SelectedLibraryID;
                    SetThemeColors();
                    SetLibraryInfo(selectedLibraryID);
                    LoadViewLivros();
                }
            }
        }

        private void SetThemeColors()
        {
            if (themeColors.TryGetValue(selectedLibraryID, out currentThemeColors))
            {
                foreach (Button button in pnlMenu.Controls.OfType<Button>())
                {
                    button.BackColor = currentThemeColors.ButtonColor;
                    button.FlatAppearance.MouseOverBackColor = ControlPaint.Light(currentThemeColors.ButtonColor);
                    button.FlatAppearance.MouseDownBackColor = ControlPaint.Dark(currentThemeColors.ButtonColor);
                }

                pnlMenu.BackColor = currentThemeColors.PanelColor;
                picLogo.BackColor = currentThemeColors.PanelColor;
                pnlHeader.BackColor = currentThemeColors.PanelHeaderColor;
                lblLibraryName.ForeColor = currentThemeColors.LabelLibraryColor;
                lblTitle.ForeColor = currentThemeColors.LabelTitleColor;

                if (_selectedButton != null)
                {
                    _selectedButton.BackColor = currentThemeColors.SelectedButtonColor;
                }
            }
        }

        private void PicLogo_Click(object sender, EventArgs e)
        {
            using (var selectLibraryForm = new frmSelectLibrary())
            {
                if (selectLibraryForm.ShowDialog() == DialogResult.OK)
                {
                    selectedLibraryID = selectLibraryForm.SelectedLibraryID;
                    SetThemeColors();
                    SetLibraryInfo(selectedLibraryID);
                    LoadViewLivros();
                }
            }
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
                _selectedButton.BackColor = currentThemeColors?.ButtonColor ?? Color.Gray;
            }
            _selectedButton = button;
            _selectedButton.BackColor = currentThemeColors?.SelectedButtonColor ?? Color.Gray; // Color to show it's been selected
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
            LoadStatistics();
        }

        public void LoadAddLivros() => LoadForms(new gui.frmAddLivros(selectedLibraryID)); // Pass the library ID

        public void LoadEditLivros() => LoadForms(new gui.frmEditLivros(selectedLibraryID)); // Pass the library ID

        public void LoadViewLivros() => LoadForms(new gui.frmBookViewer(selectedLibraryID)); // Pass the library ID

        public void LoadDateLivros() => LoadForms(new gui.frmDateFromUntil(selectedLibraryID)); // Pass the library ID

        public void LoadListing() => LoadForms(new gui.frmFilteredListing(selectedLibraryID)); // Pass the library ID

        public void LoadStatistics() => LoadForms(new gui.frmStatistics(selectedLibraryID)); // Pass the library ID

        public void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceitar apenas números e teclas de controle (Backspace, Delete, etc.)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private class ThemeColors
        {
            public Color ButtonColor { get; }
            public Color PanelHeaderColor { get; }
            public Color PanelColor { get; }
            public Color LabelLibraryColor { get; }
            public Color LabelTitleColor { get; }
            public Color SelectedButtonColor { get; }

            public ThemeColors(Color buttonColor, Color panelHeaderColor, Color panelColor, Color labelLibraryColor, Color labelTitleColor, Color selectedButtonColor)
            {
                ButtonColor = buttonColor;
                PanelHeaderColor = panelHeaderColor;
                PanelColor = panelColor;
                LabelLibraryColor = labelLibraryColor;
                LabelTitleColor = labelTitleColor;
                SelectedButtonColor = selectedButtonColor;
            }
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
