using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BouncingBallsPBox
{
    public partial class PBoxBall : PictureBox
    {
        private Color color;
        private int shiftX;
        private int shiftY;
        public Color Color { get => color; }

        private void setRandomColor()
        {
            Random rnd = new Random();
            color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void setRandomShift()
        {
            Random rnd = new Random();
            shiftX = rnd.Next(-6, 6);
            shiftY = rnd.Next(-6, 6);
        }

        public PBoxBall(Point position)
        {
            InitializeComponent();
            Click += PBoxBall_Click;
            setRandomColor();
            setRandomShift();
            Size = new Size(50, 50);
            BackColor = Color.Transparent;
            Location = position;
            Refresh();
            Paint += PBoxBall_Paint;
        }

        private void PBoxBall_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(Color);
            e.Graphics.FillEllipse(brush, 0, 0, Width, Height);
        }

        private void PBoxBall_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void Shift()
        {
            int X = Location.X;
            int Y = Location.Y;

            Control parent = this.Parent;

            if (X < 0 || X + Width > parent.Width)
                shiftX = -shiftX;
            if (Y < 0 || Y + Height > parent.Height)
                shiftY = -shiftY;

            X += shiftX;
            Y += shiftY;

            Location = new Point(X, Y);
        }
    }
}
