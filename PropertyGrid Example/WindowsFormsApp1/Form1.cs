using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        List<Shape> shapes = new List<Shape>();
        Random rand = new Random();
        Object objectType;

        public Form1()
        {
            InitializeComponent();
            this.Width = 600;
            this.Height = 500;
        }

        private Color randomColor()
        {
            int r = rand.Next(0, 256); // Random number between 0 - 255
            int g = rand.Next(0, 256);
            int b = rand.Next(0, 256);

            Color color = Color.FromArgb(r, g, b);
            return color;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();




            // Rectangle 1 
            rectangle rectangle = new rectangle();
            rectangle.color = randomColor();
            rectangle.startx = 100;
            rectangle.starty = 200;
            rectangle.width = 200;
            rectangle.length = 100;
            shapes.Add(rectangle);

            //// Rectangle 2
            //rectangle rectangle2 = new rectangle();
            //rectangle2.startx = 50;
            //rectangle2.starty = 100;
            //rectangle2.width = 100;
            //rectangle2.length = 50;
            //shapes.Add(rectangle2);

            rectangle.Draw(g);
            //rectangle2.Draw(g);

            //foreach (Shape s in shapes)
            //{
            //    s.Draw(g);
            //}
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            var currentPoints = e.Location;
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
                //MessageBox.Show("This is a " + objectType);
                propertyGrid1.Show();

            }
        }
    }


}
