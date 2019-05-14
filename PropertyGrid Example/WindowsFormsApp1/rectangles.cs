using System;
using System.Drawing;

namespace WindowsFormsApp1
{
    internal class rectangle : Shape
    {
        public int length { get; set; }
        public int width { get; set; }
        public Color color { get; set; }

        Random rand = new Random();
        Rectangle newRectangle;

        public override Rectangle GetRectangle()
        {
            return this.newRectangle;
        }

        private Color randomColor()
        {
            int r = rand.Next(0, 256); // Random number between 0 - 255
            int g = rand.Next(0, 256);
            int b = rand.Next(0, 256);

            Color color = Color.FromArgb(r, g, b);
            this.color = color;
            return color;
        }

        public Color getColor()
        {
            return this.color;
        }

        private Rectangle makeRectangle(int startx, int starty, int width, int length)
        {
            newRectangle = new Rectangle(startx, starty, width, length);
            return newRectangle;
        }

        public override void Draw(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(this.color))
            {
                g.FillRectangle(brush, makeRectangle(startx, starty, width, length));
            }
        }
    }
}