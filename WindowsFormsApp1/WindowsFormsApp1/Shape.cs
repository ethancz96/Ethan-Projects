using System.Drawing;

namespace WindowsFormsApp1
{
    internal abstract class Shape
    {
        public Color color { get; set; }
        public int thickness { get; set; }
        public int startx { get; set; }
        public int starty { get; set; }

        public abstract Rectangle GetRectangle();
        // Make a method that returns object type instead of hard coded rectangle
        public virtual void Draw(Graphics g)
        {
        }
    }
}