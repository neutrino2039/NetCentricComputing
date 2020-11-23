using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class Rectangle : Drawing
    {
        public Rectangle(Point location, float length, float breadth)
        {
            Location = location;
            Length = length;
            Breadth = breadth;
        }

        public Point Location { get; set; }

        public float Length { get; set; }

        public float Breadth { get; set; }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(
                Pens.Black,
                Location.X,
                Location.Y,
                Length,
                Breadth);
        }
    }
}
