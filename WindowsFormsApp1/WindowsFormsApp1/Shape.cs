using System.Drawing;

namespace WindowsFormsApp1
{
    internal class Shape
    {
        public Color color { get; set; }
        public int thickness { get; set; }
        public int startx { get; set; }
        public int starty { get; set; }

        public virtual void Draw(Graphics g)
        {
        }
    }
}