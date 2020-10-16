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

        public float Radius { get; set; }

        public Point Center { get; set; }
    }
}
