using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.controls
{
    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 10;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath path = new GraphicsPath())
            {
                // Top rounded corners
                path.AddArc(new Rectangle(0, 0, CornerRadius, CornerRadius), 180, 90);
                path.AddArc(new Rectangle(Width - CornerRadius, 0, CornerRadius, CornerRadius), 270, 90);

                // Bottom corners (normal, not rounded)
                path.AddLine(new Point(Width, CornerRadius), new Point(Width, Height));
                path.AddLine(new Point(Width, Height), new Point(0, Height));
                path.AddLine(new Point(0, Height), new Point(0, CornerRadius));

                this.Region = new Region(path);
                using (Pen pen = new Pen(this.BackColor, 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }

    public class RoundedPanelBottom : Panel
    {
        public int CornerRadius { get; set; } = 10;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath path = new GraphicsPath())
            {
                // Top corners (normal, not rounded)
                path.AddLine(new Point(0, 0), new Point(Width, 0));

                // Bottom rounded corners
                path.AddArc(new Rectangle(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius), 0, 90);
                path.AddArc(new Rectangle(0, Height - CornerRadius, CornerRadius, CornerRadius), 90, 90);

                path.AddLine(new Point(0, Height - CornerRadius), new Point(0, 0));

                this.Region = new Region(path);
                using (Pen pen = new Pen(this.BackColor, 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }

}