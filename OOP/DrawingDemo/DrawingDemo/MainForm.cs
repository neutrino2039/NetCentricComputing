using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.Green, 10, 10, 100, 100);
            g.DrawRectangle(Pens.Red, 10, 10, 100, 100);

            g.FillEllipse(Brushes.Gray, 10, 10, 100, 100);
            g.DrawEllipse(Pens.Black, 10, 10, 100, 100);
        }
    }
}
