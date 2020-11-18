using System.Drawing;
using System.Windows.Forms;

namespace CustomControl
{
    public class Rectangle : Control
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            Pen pen = new Pen(StrokeColor, StrokeWidth);
            g.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
        }

        private Color strokeColor = Color.Black;
        public Color StrokeColor
        {
            get { return strokeColor; }
            set
            {
                strokeColor = value;
                Invalidate();
            }
        }

        private float strokeWidth = 1;
        public float StrokeWidth
        {
            get { return strokeWidth; }
            set
            {
                strokeWidth = value;
                Invalidate();
            }
        }
    }
}
