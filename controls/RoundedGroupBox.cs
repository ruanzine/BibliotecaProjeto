using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.controls
{
    public class RoundedGroupBox : GroupBox
    {
        public int BorderRadius { get; set; } = 8; // Default border radius

        public RoundedGroupBox()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw rounded border
            using (GraphicsPath path = GetRoundedRectanglePath(this.ClientRectangle, BorderRadius))
            using (Pen pen = new Pen(this.ForeColor, 1.75f))
            {
                e.Graphics.DrawPath(pen, path);
            }

            // Draw GroupBox text
            Size textSize = TextRenderer.MeasureText(this.Text, this.Font);
            Rectangle textRect = new Rectangle(8, 0, textSize.Width, textSize.Height);
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, textRect.Location, this.ForeColor);

            // Draw child controls
            foreach (Control ctrl in this.Controls)
            {
                using (Bitmap bmp = new Bitmap(ctrl.Width, ctrl.Height))
                {
                    ctrl.DrawToBitmap(bmp, new Rectangle(0, 0, ctrl.Width, ctrl.Height));
                    e.Graphics.DrawImage(bmp, ctrl.Location);
                }
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter - 1, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter - 1, rect.Bottom - diameter - 1, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter - 1, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }
    }

}