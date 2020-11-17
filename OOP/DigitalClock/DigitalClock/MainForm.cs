using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetCustomFont();
            UpdateTime();
        }

        private void SetCustomFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("Fonts/Digital7Mono.ttf");
            timeLabel.Font = new Font(pfc.Families[0], timeLabel.Font.Size);
        }

        private void UpdateTime()
        {
            DateTime now = DateTime.Now;
            timeLabel.Text = $"{now.Hour:D2}:{now.Minute:D2}:{now.Second:D2}";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }
    }
}
