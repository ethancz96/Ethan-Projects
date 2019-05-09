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
        }

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
        //    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        //    e.Graphics.FillEllipse(Brushes.Red, new Rectangle(10, 10, 32, 32));
        //}

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
        //    // Create graphics class
        //    Graphics g = panel1.CreateGraphics();
        //    // Set painting quality to high
        //    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        //    // Create a new pen class
        //    Pen p = new Pen(Color.Black);

        //    // If Circle is selected
        //    if (listBox1.SelectedIndex == 0)
        //    {
        //        SolidBrush sb = new SolidBrush(Color.Red);
        //        g.DrawEllipse(p, x - 50, y - 50, 100, 100);
        //        g.FillEllipse(sb, x - 50, y - 50, 100, 100);
        //    }

        //    // If rectangle is selected
        //    if (listBox1.SelectedIndex == 1)
        //    {
        //        SolidBrush sb = new SolidBrush(Color.Blue);
        //        g.DrawRectangle(p, x - 50, y - 50, 100, 100);
        //        g.FillRectangle(sb, x - 50, y - 50, 100, 100);

        //    }
        //}


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;    // only ever use this one for persistent graphics!!

            if (listBox1.SelectedIndex == 0)
            {
                foreach (Point pt in points)
                    g.FillEllipse(Brushes.Blue, pt.X, pt.Y, 50, 50);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            points.Clear();
        }
    }
}
