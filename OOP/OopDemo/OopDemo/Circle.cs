using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemo
{
    public class Circle
    {
        public void Draw(Graphics g)
        {
            float x = Center.X - Radius;
            float y = Center.Y - Radius;
            float width = 2 * Radius;
            float height = width;

            g.DrawEllipse(Pens.Black, x, y, width, height);
        }

        private float radius = 0;
        public float Radius
        {
            get { return radius; }
            set
            {
                if (value < 0) return;
                radius = value;
            }
        }

        public Point Center { get; set; }
    }
}
