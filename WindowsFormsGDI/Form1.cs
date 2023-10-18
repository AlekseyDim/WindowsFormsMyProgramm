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

namespace WindowsFormsGDI
{
    public partial class Form1 : Form
    {
        List<Point> points = new List<Point>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Point p in points)
            {
                //g.FillEllipse(Brushes.Red, p.X, p.Y, 10F, 10F); // Окружность
                //g.FillRectangle(Brushes.Red, p.X, p.Y, 30F, 30F); // квадрат
                Font f = new Font("Verdana", 30, FontStyle.Italic);
                g.DrawString("Hello World!", f, Brushes.Blue, 100, 100);


            }

            //Pen bluePen = new Pen(Color.Blue, 6);

            //Color pink = Color.FromArgb(241, 105, 190);
            //Pen bluePen = new Pen(pink, 10);

            //bluePen.StartCap = LineCap.SquareAnchor;
            //bluePen.EndCap = LineCap.ArrowAnchor;
            //bluePen.DashStyle = DashStyle.Dash;
            //bluePen.DashCap = DashCap.Round;
            
            //g.DrawLine(bluePen, 20, 100, 270, 100);
        
            TextureBrush tBrush = new TextureBrush(Image.FromFile(@"C:\Users\Student\Desktop\iRxfnBQPVqMLhuxZ_KWvxw.png"));
            g.FillRectangle(tBrush, new Rectangle(10, 10, 500, 500));

            //for(int i = 0; i < points.Count; i++)
            //{
            //    Point pPrev = new Point(0, 0);
            //    if(i!= 0)
            //    {
            //        pPrev = points[i-1];
            //    }

            //}// не доделано
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X, e.Y));
            Invalidate();
        }
    }
}
