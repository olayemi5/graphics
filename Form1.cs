using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Width = 1030;
            Height = 645;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);    //will paint the exterior
            Brush blueBrush = new SolidBrush(Color.CornflowerBlue);  //will paint the interior
            Brush redBrush = new SolidBrush(Color.Red);  //will paint the interior
            Brush greenBrush = new SolidBrush(Color.Green);  //will paint the interior
            Brush whiteBrush = new SolidBrush(Color.WhiteSmoke);  //will paint the interior
            Brush yellowBrush = new SolidBrush(Color.Yellow);  //will paint the interior
            Brush yelloGreen = new SolidBrush(Color.YellowGreen);  //will paint the interior
            Brush blackBrush = new SolidBrush(Color.Black);  //will paint the interior
            Brush brownBrush = new SolidBrush(Color.SandyBrown);  //will paint the interior

            //draw background color
            Rectangle topRectangle = new Rectangle(5, 0, 1000, 500);
            Rectangle bottomRectangle = new Rectangle(5, 500, 1000, 100);

            g.FillRectangle(blueBrush, topRectangle);
            g.FillRectangle(greenBrush, bottomRectangle);

            //drawing sting
            Font drawFont = new Font("Arial", 16);
            PointF drawPoint = new PointF(420.0F, 40.0F);
            g.DrawString("LOCAL MAN'S HOUSE", drawFont, greenBrush, drawPoint);

            //draw right hand side sun
            //smily face
            g.FillEllipse(yellowBrush, 900, 80, 50, 50);
            g.FillEllipse(yelloGreen, 905, 89, 15, 15);
            g.FillEllipse(yelloGreen, 930, 89, 15, 15);
            g.DrawArc(myPen, 914, 99,23,20, 0, 180);

            //first sun point
            Point point1 = new Point(850,80);
            Point point2 = new Point(910, 85);
            Point point3 = new Point(900, 100);
            Point[] curvePoints = { point1, point2, point3};
            // Draw polygon to screen.
            g.FillPolygon(yellowBrush, curvePoints);

            //second sun point
            Point point1S = new Point(940, 85);
            Point point2S= new Point(970, 55);
            Point point3S = new Point(946, 100);
            Point[] curvePointsS = { point1S, point2S, point3S};
            // Draw polygon to screen.
            g.FillPolygon(yellowBrush, curvePointsS);

            //third sun point
            Point point1T = new Point(850, 125);
            Point point2T = new Point(900, 110);
            Point point3T = new Point(910, 125);
            Point[] curvePointsT = { point1T, point2T, point3T };
            // Draw polygon to screen.
            g.FillPolygon(yellowBrush, curvePointsT);

            //fourth sun point
            Point point1F = new Point(950, 100);
            Point point2F = new Point(970, 175);
            Point point3F = new Point(940, 125);
            Point[] curvePointsF = { point1F, point2F, point3F };
            // Draw polygon to screen.
            g.FillPolygon(yellowBrush, curvePointsF);

            //fifth sun point
            Point point1Fi = new Point(925, 30);
            Point point2Fi = new Point(935, 85);
            Point point3Fi = new Point(915, 85);
            Point[] curvePointsFi = { point1Fi, point2Fi, point3Fi };
            // Draw polygon to screen.
            g.FillPolygon(yellowBrush, curvePointsFi);

            //sixth sun point
            Point point1Si = new Point(925, 30);
            Point point2Si = new Point(935, 85);
            Point point3Si = new Point(915, 85);
            Point[] curvePointSi = { point1Si, point2Si, point3Si };
            // Draw polygon to screen.
            g.FillPolygon(yellowBrush, curvePointSi);

            //seventh sun point
            Point point1Se = new Point(925, 200);
            Point point2Se = new Point(935, 128);
            Point point3Se = new Point(915, 128);
            Point[] curvePointSe = { point1Se, point2Se, point3Se };
            // Draw polygon to screen.
            g.FillPolygon(yellowBrush, curvePointSe);

            //draw house 
            Point point1R = new Point(530, 90);
            Point point2R = new Point(900, 258);
            Point point3R = new Point(160, 258);
            Point[] curvePointR = { point1R, point2R, point3R };

            // Draw polygon to screen.
            g.FillPolygon(brownBrush, curvePointR);

            //recatngle  body
            g.FillRectangle(redBrush,180,258,700,258);

            //windows
            g.FillRectangle(whiteBrush, 200, 308,150, 70);
            g.FillRectangle(whiteBrush, 710, 308,150, 70);

            //door
            g.FillRectangle(blackBrush, 435, 308, 200, 208);
        }
    }
}
