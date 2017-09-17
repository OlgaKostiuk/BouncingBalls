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

namespace BouncingBalls
{
    public partial class BDraw : UserControl
    {
        public List<Ball> Balls = new List<Ball>();

        public BDraw()
        {
            InitializeComponent();
            pictureBox1.LoadCompleted += ControlLoad;
            pictureBox1.Paint += ControlPaint;
            pictureBox1.MouseClick += ControlClick;
            timer1.Tick += timer1_Tick;
            timer1.Enabled = true;
            SizeChanged += resize;
            pictureBox1.Dock = DockStyle.Fill;
        }

        private void ControlLoad(object sender, EventArgs e)
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
            UpdateStyles();
        }

        private void ControlPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            foreach (var item in Balls)
            {
                drawBall(item, e.Graphics);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var item in Balls)
            {
                item.Shift(this.pictureBox1.Size);
            }
            Refresh();
        }

        private void ControlClick(object sender, MouseEventArgs e)
        {
            int i;
            for (i = 0; i < Balls.Count; i++)
            {
                Ball current = Balls[i];
                if (e.X >= current.Position.X - current.Width / 2  && e.X <= current.Position.X + current.Width / 2 &&
                    e.Y >= current.Position.Y - current.Height / 2 && e.Y <= current.Position.Y + current.Height / 2)
                {
                    Balls.RemoveAt(i);
                    return;
                }
            }

                Point p = new Point(e.X, e.Y);
                Ball ball = new Ball(p);
                Graphics graphics = this.CreateGraphics();
                drawBall(ball, graphics);
                Balls.Add(ball);

        }

        private void drawBall(Ball ball, Graphics graphics)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(ball.Color);
            graphics.FillEllipse(brush, ball.Position.X - ball.Width/2, ball.Position.Y - ball.Height/2, ball.Width, ball.Height);
        }

        private void resize(object sender, EventArgs e)
        {
            pictureBox1.Size = Size;
        }
    }
}
