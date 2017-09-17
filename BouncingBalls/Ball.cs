using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBalls
{
    public class Ball
    {
        public readonly int Width = 50;
        public readonly int Height = 50;
        private Color color;
        private Point position;
        private int shiftX;
        private int shiftY;


        public Ball(Point position)
        {
            this.position = position;
            setRandomColor();
            setRandomShift();
        }

        public Color Color { get => color; }
        public Point Position { get => position; }

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

        public void Shift(Size containerSize)
        {
            position.X += shiftX;
            if (position.X < 0)
            {
                shiftX = -shiftX;
            }
            else if (position.X + Width > containerSize.Width)
            {
                shiftX = -shiftX;
            }

            position.Y += shiftY;
            if (position.Y < 0)
            {
                shiftY = -shiftY;
            }
            else if (position.Y + Height > containerSize.Height)
            {
                shiftY = -shiftY;
            }
        }
    }
}
