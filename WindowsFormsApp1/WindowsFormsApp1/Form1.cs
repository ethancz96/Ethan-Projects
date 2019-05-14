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
        Point currentPoints;
        
        Graphics g;
        Random rand = new Random();
        Object objectType;


        public Form1()
        {
            InitializeComponent();
            this.Width = 675;
            this.Height = 500;
        }

  

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(e.Location);
            currentPoints = e.Location;
            Rpoints.Add(e.Location);
            panel1.Invalidate();

            

            foreach (Point pts in points)
            {
                // propertyGrid1.SelectedObject = pts;
                if (listBox1.SelectedIndex == 0)
                {
                    rectangle rectangle = new rectangle();
                    rectangle.startx = pts.X;
                    rectangle.starty = pts.Y;
                    rectangle.width = 200;
                    rectangle.length = 100;
                    shapes.Add(rectangle);
                }

                //if (listBox1.SelectedIndex == 1)
                //{
                //    circle circle = new circle();
                //}
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
            // Check if current points intersect or is contained in rectangle
            Boolean isRectangle = false;
            foreach (Shape shape in shapes)
            {
                if (shape.GetRectangle().Contains(currentPoints))
                {
                    isRectangle = true;
                    propertyGrid1.SelectedObject = shape;
                    objectType = shape.GetType();
                }
            }

            if (isRectangle)
            {
                MessageBox.Show("This is a " + objectType);
                propertyGrid1.Show();
                
            }

            // Check if current points intersect or is contained in Circle
            foreach (Shape shape in shapes)
            {
                
            }

            Graphics g = panel1.CreateGraphics();
            foreach (Shape s in shapes)
            {
                s.Draw(g);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // How to generate random color ONLY for new instances of rectangles?

            panel1.Controls.Clear();
            points.Clear();
        }
    }
}
