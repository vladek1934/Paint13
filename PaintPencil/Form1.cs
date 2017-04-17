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

 

namespace PaintPencil
{
    
    public partial class Form1 : Form
    {
        Color prevColor = Color.Red;
        Point prevPoint;
        Point currentPoint;
        Shapes currentShape = Shapes.Free;
        GraphicsPath gp = new GraphicsPath();
        Random rx = new Random();
        Random ry = new Random();
        Graphics g;
        Bitmap bmp;
       
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(pictureBox1.Image);
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentShape == Shapes.Spray) { timer1.Start(); }
            prevPoint = e.Location;
            
        }

    
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                switch (currentShape)
                {
                    case Shapes.Fill:
                        currentPoint = e.Location;
                        bool n = true;
                        int counter=0;
                        int d = 1;
                        Color now = bmp.GetPixel(currentPoint.X, currentPoint.Y);
                        bmp.SetPixel(currentPoint.X, currentPoint.Y,prevColor);
                       while(n)
                       {
                           counter = 0;
                           if (bmp.GetPixel(currentPoint.X + d, currentPoint.Y) == now) { bmp.SetPixel(currentPoint.X + 1, currentPoint.Y, prevColor); counter++; }
                           if (bmp.GetPixel(currentPoint.X , currentPoint.Y + d) == now) { bmp.SetPixel(currentPoint.X + 1, currentPoint.Y, prevColor); counter++; }
                           if (bmp.GetPixel(currentPoint.X - d, currentPoint.Y) == now) { bmp.SetPixel(currentPoint.X + 1, currentPoint.Y, prevColor); counter++; }
                           if (bmp.GetPixel(currentPoint.X , currentPoint.Y - d) == now) { bmp.SetPixel(currentPoint.X + 1, currentPoint.Y, prevColor); counter++; }
                           if (counter == 0) { n=false; }
                           d++;
                       }
                        break;
                    case Shapes.Free:
                        currentPoint = e.Location;
                        g.DrawLine(new Pen(prevColor,Scroll.Value), prevPoint, currentPoint);
                        prevPoint = currentPoint;
                        break;
                    case Shapes.Line:
                        currentPoint = e.Location;
                        gp.Reset();
                        gp.AddLine(prevPoint, currentPoint);
                        break;
                    case Shapes.Ellipse:
                      
                        currentPoint = e.Location;
                        gp.Reset();
                        gp.AddEllipse(prevPoint.X, prevPoint.Y, currentPoint.X - prevPoint.X, currentPoint.Y - prevPoint.Y);
                        break;
                    case Shapes.Spray:
                        currentPoint = e.Location;
                        gp.Reset();
                        int j = rx.Next(-Scroll.Value/2, Scroll.Value/2);
                        int k = rx.Next(-Scroll.Value/2, Scroll.Value/2);
                        bmp.SetPixel(currentPoint.X + j, currentPoint.Y + k, prevColor);
                        prevPoint = currentPoint;
                        break;
                    case Shapes.Rectangle:
                        int x, y;
                         currentPoint = e.Location;
                         if (prevPoint.X > currentPoint.X) { x = currentPoint.X; }
                         else { x = prevPoint.X; }
                         if (prevPoint.Y> currentPoint.Y) { y = currentPoint.Y; }
                         else { y = prevPoint.Y; }
                        gp.Reset();
                        gp.AddRectangle(new Rectangle(x, y, Math.Abs(currentPoint.X - prevPoint.X), Math.Abs(currentPoint.Y - prevPoint.Y)));
                        break;
                    case Shapes.Triangle:
                        int x2, y2;
                         currentPoint = e.Location;
                         if (prevPoint.X > currentPoint.X) { x2 = currentPoint.X; }
                         else { x2 = prevPoint.X; }
                         if (prevPoint.Y> currentPoint.Y) { y2 = currentPoint.Y; }
                         else { y2 = prevPoint.Y; }
                        gp.Reset();
                        Point[] myArray =
             {
                 new Point(prevPoint.X,currentPoint.Y),
                 new Point((prevPoint.X+currentPoint.X)/2,prevPoint.Y),
                 new Point(currentPoint.X,currentPoint.Y)};
                        gp.AddPolygon(myArray);
                        break;
                    default:
                        break;
                }
            }
            mouseLocationLabel.Text = string.Format("X = {0}; Y = {1}", e.X, e.Y);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            g.DrawPath(new Pen(prevColor, Scroll.Value), gp);
            timer1.Stop();
        }


        private void colorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                prevColor = c.Color;
            }
        }
        

        private void lineBtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Line;
        }
  
        private void freeBtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Free;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(new Pen(prevColor), gp);
        }

        private void Rectbtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Rectangle;
        }

        private void Ellipsebtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Ellipse;
        }

        private void Fillbtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void saToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
            
                pictureBox1.Image.Save(sfd.FileName);
            }
        }

        private void saToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap newimage = new Bitmap(ofd.FileName);
                Bitmap cloneimage = newimage.Clone() as Bitmap;
                newimage.Dispose();
                pictureBox1.Image = cloneimage;
                g = Graphics.FromImage(pictureBox1.Image);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Size1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Size_ValueChanged(object sender, EventArgs e)
        {
            Size1.Text = "Size = " + Scroll.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Triangle;
        }

        private void spraybtn_Click_1(object sender, EventArgs e)
        {
            currentShape = Shapes.Spray;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           Beginrun:
            gp.Reset();
           for (int i = 1; i <= Scroll.Value/5; i++)
           {
               int j = rx.Next(-Scroll.Value / 2, Scroll.Value / 2);
               int k = rx.Next(-Scroll.Value / 2, Scroll.Value / 2);
               if ((Math.Pow(j, 2) + Math.Pow(k, 2)) <= Scroll.Value / 4 * Scroll.Value)
               {
                   bmp.SetPixel(prevPoint.X + j, prevPoint.Y + k, prevColor);

               }
               else goto Beginrun;
               pictureBox1.Refresh();
           }
            
        }
    }


    public enum Shapes
    {
        Free,
        Line,
        Ellipse,
        Rectangle,
        Triangle,Fill,Spray
    }
}
