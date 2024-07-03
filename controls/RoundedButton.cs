using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.controls
{
    public class RoundedButton : Button
    {
        // Propriedades para definir o raio dos cantos arredondados
        public int BorderRadius { get; set; } = 5;
        public Color BorderColor { get; set; } = Color.PaleVioletRed;
        public int BorderSize { get; set; } = 0;

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.MediumSlateBlue;
            ForeColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -BorderSize, -BorderSize);
            int smoothSize = BorderSize > 0 ? BorderSize : 2;

            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRadius - BorderSize))
            using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
            using (Pen penBorder = new Pen(BorderColor, BorderSize))
            {
                this.Region = new Region(pathSurface);
                pevent.Graphics.DrawPath(penSurface, pathSurface);

                if (BorderSize >= 1)
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
