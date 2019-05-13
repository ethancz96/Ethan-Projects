using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        List<Point> points = new List<Point>();
        List<Point> Rpoints = new List<Point>();
        List<Shape> shapes = new List<Shape>();
        
        Graphics g;
        Random rand = new Random();

        private void drawRectangle()
        {
            rectangle rectangle = new rectangle();
            rectangle.startx = 50;
            rectangle.starty = 50;
            rectangle.width = 400;
            rectangle.length = 200;
            Graphics g = panel1.CreateGraphics();
            foreach (Shape s in shapes)          // Assuming shapes is List<shape>
                s.Draw(g);
        }


        public Form1()
        {
            InitializeComponent();
            this.Width = 675;
            this.Height = 500;

            drawRectangle();

        }

  

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(e.Location);
            Rpoints.Add(e.Location);
            panel1.Invalidate();

            

            foreach (Point pts in points)
            {
                // propertyGrid1.SelectedObject = pts;
                rectangle rectangle = new rectangle();
                rectangle.startx = pts.X;
                rectangle.starty = pts.Y;
                rectangle.width = 200;
                rectangle.length = 100;
                shapes.Add(rectangle);
            }

            foreach (Shape shape in shapes)
            {
                propertyGrid1.SelectedObject = shape;
            }


        }

        private SolidBrush randomRGB()
        {
            int r = rand.Next(0, 256); // Random number between 0 - 255
            int g = rand.Next(0, 256);
            int b = rand.Next(0, 256);

            SolidBrush randomBrush = new SolidBrush(Color.FromArgb(r, g, b));

            return randomBrush;
        }

        private int randomSize()
        {
            int randomNumber = rand.Next(50, 176);
            return randomNumber;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            foreach (Shape s in shapes)
            {
                s.Draw(g);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            points.Clear();
        }
    }
}
