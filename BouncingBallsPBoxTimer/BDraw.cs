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
            pictureBox1.MouseClick += PictureBox1_MouseClick;
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point pos = new Point(e.X, e.Y);
            pictureBox1.Controls.Add(new PBoxBall(pos));
        }
    }
}
