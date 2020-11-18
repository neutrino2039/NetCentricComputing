using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopDemo
{
    public partial class MainForm : Form
    {
        private Circle circle = new Circle();

        public MainForm()
        {
            InitializeComponent();

            circle.Radius = 50;
            circle.Radius = -10;
            circle.Center = new Point(50, 50);

            radiusTrackBar.Maximum = panel.Width / 2;
            radiusTrackBar.Value = 50;

            xTrackBar.Maximum = panel.Width;
            xTrackBar.Value = 50;

            yTrackBar.Maximum = panel.Height;
            yTrackBar.Value = 50;
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            circle.Draw(g);
        }

        private void XTrackBar_Scroll(object sender, EventArgs e)
        {
            circle.Center = new Point(xTrackBar.Value, circle.Center.Y);
            panel.Invalidate();
        }

        private void YTrackBar_Scroll(object sender, EventArgs e)
        {
            circle.Center = new Point(circle.Center.X, yTrackBar.Value);
            panel.Invalidate();
        }

        private void RadiusTrackBar_Scroll(object sender, EventArgs e)
        {
            circle.Radius = radiusTrackBar.Value;
            panel.Invalidate();
        }
    }
}
