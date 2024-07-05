using System;
using System.Drawing;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.controls
{
    public class Toast : Form
    {
        private Label lblMessage;
        private Timer timer;
        private int duration;

        public Toast(string message, int duration = 3000)
        {
            this.duration = duration;
            InitializeComponents();
            lblMessage.Text = message;
            timer.Start();
        }

        private void InitializeComponents()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;
            this.BackColor = Color.Black;
            this.Opacity = 0.8;
            this.ShowInTaskbar = false;
            this.Size = new Size(200, 50); // Set the size of the toast

            lblMessage = new Label();
            lblMessage.ForeColor = Color.White;
            lblMessage.Font = new Font("Arial", 12); // Reduced font size
            lblMessage.TextAlign = ContentAlignment.MiddleCenter; // Center text
            lblMessage.Dock = DockStyle.Fill; // Fill the form
            this.Controls.Add(lblMessage);

            this.Padding = new Padding(5); // Reduced padding

            timer = new Timer();
            timer.Interval = duration;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
        }

        public static void ShowToast(string message, int duration = 3000)
        {
            Toast toast = new Toast(message, duration);
            toast.SetToastLocation();
            toast.Show();
        }

        private void SetToastLocation()
        {
            Screen screen = Screen.PrimaryScreen;
            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point((workingArea.Width - this.Width) / 2, 20); // Center horizontally at the top, 20 pixels from the top edge
        }
    }
}
