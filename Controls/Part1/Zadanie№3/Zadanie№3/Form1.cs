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

namespace Zadanie_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            this.BackColor = Color.White;

            Pen pen1 = new Pen(Color.Black, 5);
            g.DrawLine(pen1, 50, 50, 200, 50);

            Pen pen2 = new Pen(Color.Red, 2);
            Rectangle rect1 = new Rectangle(50, 100, 100, 50);
            g.DrawRectangle(pen2, rect1);

            SolidBrush brush1 = new SolidBrush(Color.Blue);
            Rectangle rect2 = new Rectangle(200, 100, 100, 50);
            g.FillRectangle(brush1, rect2);

            Pen pen3 = new Pen(Color.Green, 2);
            Rectangle rect3 = new Rectangle(50, 200, 100, 50);
            g.DrawEllipse(pen3, rect3);

            SolidBrush brush2 = new SolidBrush(Color.Yellow);
            Rectangle rect4 = new Rectangle(200, 200, 100, 50);
            g.FillEllipse(brush2, rect4);

            Pen pen4 = new Pen(Color.Purple, 2);
            Point[] points1 = { new Point(50, 300), new Point(100, 350), new Point(150, 300), new Point(100, 250) };
            g.DrawPolygon(pen4, points1);

            SolidBrush brush3 = new SolidBrush(Color.Orange);
            Point[] points2 = { new Point(200, 300), new Point(250, 350), new Point(300, 300), new Point(250, 250) };
            g.FillPolygon(brush3, points2);

            Pen pen5 = new Pen(Color.Black, 2);
            pen5.DashStyle = DashStyle.Dash;
            g.DrawLine(pen5, 50, 400, 200, 400);

            Pen pen6 = new Pen(Color.Black, 2);
            pen6.DashStyle = DashStyle.Dot;
            g.DrawLine(pen6, 50, 450, 200, 450);

            Pen pen7 = new Pen(Color.Black, 2);
            pen7.DashStyle = DashStyle.DashDot;
            g.DrawLine(pen7, 50, 500, 200, 500);
        }
    }
}