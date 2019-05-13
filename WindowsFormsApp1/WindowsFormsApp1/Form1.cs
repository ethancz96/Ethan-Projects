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
        Graphics g;
        Random rand = new Random();
        

        public Form1()
        {
            InitializeComponent();
            
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
                propertyGrid1.SelectedObject = pts;
            }
             
            // If X and Y coordinates touch a graphic

            // Update property grid
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
            g = e.Graphics;    // only ever use this one for persistent graphics!!
            //SolidBrush RGBbrush = new SolidBrush(Color.FromArgb());
            SolidBrush rBrush = randomRGB();
            int x = randomSize();
            int y = x; 
            if (listBox1.SelectedIndex == 0)
            {
                foreach (Point pt in points)
                    g.FillEllipse(rBrush, pt.X, pt.Y, x, y);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            points.Clear();
        }
    }
}
