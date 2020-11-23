using System.Drawing;
using System.Windows.Forms;

namespace PolymorphismDemo
{
    public partial class MainForm : Form
    {
        private Drawing[] drawings;

        public MainForm()
        {
            InitializeComponent();
            drawings = new Drawing[]
            {
                new Circle(new Point(50, 50), 40),
                new Circle(new Point(100, 100), 80),
                new Circle(new Point(80, 90), 100),
                new Rectangle(new Point(20, 30), 200, 100),
                new Rectangle(new Point(70, 90), 150, 200),
                new Circle(new Point(200, 200), 100),
                new Rectangle(new Point(250, 200), 100, 100)
            };
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (Drawing d in drawings)
                d.Draw(g);
        }
    }
}
