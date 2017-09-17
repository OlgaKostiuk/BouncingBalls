using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BouncingBallsPBox
{
    public partial class BDraw : UserControl
    {
        public BDraw()
        {
            InitializeComponent();
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.MouseClick += PictureBox1_MouseClick;
            Load += BDraw_Load;
        }

        private void BDraw_Load(object sender, EventArgs e)
        {
            Thread move = new Thread(threadMove);
            move.Start();

        }

        private void threadMove()
        {
            while (true)
            {
                Thread.CurrentThread.IsBackground = true;
                pictureBox1.Controls.OfType<PBoxBall>().Select(x => x).ToList().ForEach(x => x.Shift());
                Thread.Sleep(50);
            }
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point pos = new Point(e.X, e.Y);
            pictureBox1.Controls.Add(new PBoxBall(pos));
        }
    }
}
