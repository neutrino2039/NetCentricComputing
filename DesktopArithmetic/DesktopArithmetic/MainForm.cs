using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopArithmetic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0;

            errorProvider.Clear();

            try
            {
                a = double.Parse(aTextBox.Text);
            }
            catch
            {
                errorProvider.SetError(aTextBox, "Please enter a valid number");
            }

            try
            {
                b = double.Parse(bTextBox.Text);
            }
            catch
            {
                errorProvider.SetError(bTextBox, "Please enter a valid number");
            }

            double sum = a + b;
            sumTextBox.Text = sum.ToString();
        }
    }
}
