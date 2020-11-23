using System.Drawing;

namespace PolymorphismDemo
{
    public class Circle : Drawing
    {
        public Circle(Point center, float radius)
        {
            Center = center;
            Radius = radius;
        }

        public Point Center { get; set; }

        public float Radius { get; set; }

        public void Draw(Graphics g)
        {
            float x = Center.X - Radius;
            float y = Center.Y - Radius;
            float width = 2 * Radius;
            float height = width;

            g.DrawEllipse(Pens.Black, x, y, width, height);
        }
    }
}
