using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CodeProject_B1
{
    internal class txt_radius
    {

public class RoundedTextBox : TextBox
    {
        private int borderRadius = 10;

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (borderRadius != value)
                {
                    borderRadius = value;
                    Invalidate(); // Invalidate the control to trigger a repaint
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a GraphicsPath with rounded rectangle shape
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90); // Top-left corner
            path.AddArc(Width - borderRadius, 0, borderRadius, borderRadius, 270, 90); // Top-right corner
            path.AddArc(Width - borderRadius, Height - borderRadius, borderRadius, borderRadius, 0, 90); // Bottom-right corner
            path.AddArc(0, Height - borderRadius, borderRadius, borderRadius, 90, 90); // Bottom-left corner
            path.CloseAllFigures();

            // Set the region of the control to the rounded rectangle shape
            Region = new Region(path);

                // Draw the border
                /*
                using (Pen pen = new Pen(BorderColor, BorderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
                */
        }
    }
}
}
