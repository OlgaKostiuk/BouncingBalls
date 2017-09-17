using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBallsPBox
{
    public partial class BDraw : UserControl
    {
        public BDraw()
        {
            InitializeComponent();
            pictureBox1.Dock = DockStyle.Fill;
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            pictureBox1.MouseClick += PictureBox1_MouseClick;
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point pos = new Point(e.X, e.Y);
            pictureBox1.Controls.Add(new PBoxBall(pos));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Controls.OfType<PBoxBall>().Select(x => x).ToList().ForEach(x => x.Shift());
        }
    }
}
