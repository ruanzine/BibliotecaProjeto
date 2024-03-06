using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.classes
{
    internal class ResizerClass : MainForm
    {
        private Dictionary<Control, Rectangle> originalControlsBounds = new Dictionary<Control, Rectangle>();
        private Size formOriginalSize;


        private void AddControlBounds(Control control, Form form)
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

        private void ResizeControls(Control container)
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
    }
}
