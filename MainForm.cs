using BIBLIOTECA_PROJETO.gui;
using BIBLIOTECA_PROJETO.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO
{
    /// <summary>
    /// Main form of the library project application.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Fields

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

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            formOriginalSize = this.Size;

            // Subscribe to the Click event of picLogo
            picLogo.Click += PicLogo_Click;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles the Load event of the MainForm.
        /// </summary>
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

        /// <summary>
        /// Handles the Click event of the picLogo control.
        /// </summary>
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
                    SetSelectedButton(bttSearch); // Ensure the search button is selected
                }
            }
        }

        /// <summary>
        /// Handles the Resize event of the MainForm.
        /// </summary>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ResizeControls(this);
        }

        /// <summary>
        /// Handles the KeyPress event of the MainForm.
        /// </summary>
        public void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Accept only numbers and control keys (Backspace, Delete, etc.)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Sets the information for the selected library.
        /// </summary>
        /// <param name="libraryID">The ID of the selected library.</param>
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

        /// <summary>
        /// Prompts the user to select a library.
        /// </summary>
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
                    SetSelectedButton(bttSearch); // Ensure the search button is selected
                }
            }
        }

        /// <summary>
        /// Sets the theme colors for the application.
        /// </summary>
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

        /// <summary>
        /// Adds the bounds of the specified control and its child controls to the dictionary.
        /// </summary>
        /// <param name="control">The control to add bounds for.</param>
        public void AddControlBounds(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                originalControlsBounds[childControl] = new Rectangle(childControl.Location, childControl.Size);
                AddControlBounds(childControl);
            }
        }

        /// <summary>
        /// Resizes the controls within the specified container based on the form's original size.
        /// </summary>
        /// <param name="container">The container control to resize.</param>
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

        /// <summary>
        /// Loads the specified form into the pnlLoadForms panel.
        /// </summary>
        /// <param name="form">The form to load.</param>
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

        /// <summary>
        /// Sets the specified button as the selected button.
        /// </summary>
        /// <param name="button">The button to select.</param>
        private void SetSelectedButton(Button button)
        {
            if (_selectedButton != null)
            {
                _selectedButton.BackColor = currentThemeColors?.ButtonColor ?? Color.Gray;
            }
            _selectedButton = button;
            _selectedButton.BackColor = currentThemeColors?.SelectedButtonColor ?? Color.Gray; // Color to show it's been selected
        }

        #endregion

        #region Button Click Event Handlers

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

        #endregion

        #region Form Loading Methods

        /// <summary>
        /// Loads the Add Livros form.
        /// </summary>
        public void LoadAddLivros() => LoadForms(new gui.frmAddLivros(selectedLibraryID)); // Pass the library ID

        /// <summary>
        /// Loads the Edit Livros form.
        /// </summary>
        public void LoadEditLivros() => LoadForms(new gui.frmEditLivros(selectedLibraryID)); // Pass the library ID

        /// <summary>
        /// Loads the View Livros form.
        /// </summary>
        public void LoadViewLivros() => LoadForms(new gui.frmBookViewer(selectedLibraryID)); // Pass the library ID

        /// <summary>
        /// Loads the Date Livros form.
        /// </summary>
        public void LoadDateLivros() => LoadForms(new gui.frmDateFromUntil(selectedLibraryID)); // Pass the library ID

        /// <summary>
        /// Loads the Listing form.
        /// </summary>
        public void LoadListing() => LoadForms(new gui.frmFilteredListing(selectedLibraryID)); // Pass the library ID

        /// <summary>
        /// Loads the Statistics form.
        /// </summary>
        public void LoadStatistics() => LoadForms(new gui.frmStatistics(selectedLibraryID)); // Pass the library ID

        #endregion

        #region Nested Class: ThemeColors

        /// <summary>
        /// Represents the theme colors for the application.
        /// </summary>
        private class ThemeColors
        {
            /// <summary>
            /// Gets the button color.
            /// </summary>
            public Color ButtonColor { get; }

            /// <summary>
            /// Gets the panel header color.
            /// </summary>
            public Color PanelHeaderColor { get; }

            /// <summary>
            /// Gets the panel color.
            /// </summary>
            public Color PanelColor { get; }

            /// <summary>
            /// Gets the library label color.
            /// </summary>
            public Color LabelLibraryColor { get; }

            /// <summary>
            /// Gets the title label color.
            /// </summary>
            public Color LabelTitleColor { get; }

            /// <summary>
            /// Gets the selected button color.
            /// </summary>
            public Color SelectedButtonColor { get; }

            /// <summary>
            /// Initializes a new instance of the <see cref="ThemeColors"/> class.
            /// </summary>
            /// <param name="buttonColor">The button color.</param>
            /// <param name="panelHeaderColor">The panel header color.</param>
            /// <param name="panelColor">The panel color.</param>
            /// <param name="labelLibraryColor">The library label color.</param>
            /// <param name="labelTitleColor">The title label color.</param>
            /// <param name="selectedButtonColor">The selected button color.</param>
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

        #endregion
    }
}
