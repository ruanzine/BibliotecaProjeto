using BIBLIOTECA_PROJETO.classes.services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.gui
{
    public partial class frmSelectLibrary : Form
    {
        public int SelectedLibraryID { get; private set; }
        private LibraryService libraryService;

        public frmSelectLibrary()
        {
            InitializeComponent();
            libraryService = new LibraryService();
            LoadLibraries();
        }

        private void LoadLibraries()
        {
            try
            {
                var libraries = libraryService.GetLibraries();

                if (libraries.Count > 0)
                {
                    comboBoxLibraries.DataSource = new BindingSource(libraries, null);
                    comboBoxLibraries.DisplayMember = "Key";
                    comboBoxLibraries.ValueMember = "Value";
                }
                else
                {
                    MessageBox.Show("No libraries found in the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading libraries: " + ex.Message);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (comboBoxLibraries.SelectedItem != null)
            {
                SelectedLibraryID = ((KeyValuePair<string, int>)comboBoxLibraries.SelectedItem).Value;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a library.");
            }
        }

       
    }
}
