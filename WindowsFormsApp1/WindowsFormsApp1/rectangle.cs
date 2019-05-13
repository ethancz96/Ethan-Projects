using System;
using System.Drawing;

namespace WindowsFormsApp1
{
    internal class rectangle : Shape
    {
        public int length { get; set; }
        public int width { get; set; }

        Random rand = new Random();
        Rectangle newRectangle;

        private SolidBrush randomRGB()
        {
            int r = rand.Next(0, 256); // Random number between 0 - 255
            int g = rand.Next(0, 256);
            int b = rand.Next(0, 256);

            SolidBrush randomBrush = new SolidBrush(Color.FromArgb(r, g, b));

            return randomBrush;
        }

        public override Rectangle GetRectangle()
        {
            return this.newRectangle;
        }

        private Rectangle makeRectangle(int startx, int starty, int width, int length)
        {
            newRectangle = new Rectangle(startx, starty, width, length);
            return newRectangle;
        }

        public override void Draw(Graphics g)
        {
            using (SolidBrush brush = randomRGB())
            {
                //g.DrawRectangle(brush, new Rectangle(startx, starty, width, length));
                g.FillRectangle(brush, makeRectangle(startx, starty, width, length));
            }
        }
    }
}