using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        
        Graphics g;

        SoundPlayer Laugh = new SoundPlayer(Properties.Resources.Laugh);

        Pen yellowPen = new Pen(Color.Yellow, 10);
        Pen blackPen = new Pen(Color.Black, 10);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        Pen skele = new Pen(Color.DarkGray, 10);
        Pen whitePen = new Pen(Color.White, 10);
        Pen scold = new Pen(Color.DarkGray, 5);
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Clear();
            //draws the feet
            g.DrawLine(skele, 250, 300, 250, 370);
            g.DrawLine(skele, 255, 370, 220, 370);
            g.DrawLine(skele, 410, 300, 410, 370);
            g.DrawLine(skele, 405, 370, 435, 370);
            //draws hip of skele
            g.DrawLine(skele, 250, 300, 415, 300);
            //draws the 2 side lines of skele
            g.DrawLine(skele, 250, 300, 250, 220);
            g.DrawLine(skele, 410, 300, 410, 220);
            //draws the upper line of skele
            g.DrawLine(skele, 245, 225, 410, 225);
            //draws the ribs of the skele
            g.DrawLine(skele, 245, 240, 315, 240);
            g.DrawLine(skele, 410, 240, 340, 240);
            g.DrawLine(skele, 410, 255, 340, 255);
            g.DrawLine(skele, 245, 255, 315, 255);
            g.DrawLine(skele, 245, 270, 315, 270);
            g.DrawLine(skele, 410, 270, 340, 270);
            g.DrawLine(skele, 245, 285, 315, 285);
            g.DrawLine(skele, 410, 285, 340, 285);
            //draws the head of the skele
            g.DrawLine(skele, 250, 225, 250, 145);
            g.DrawLine(skele, 245, 145, 405, 145);
            g.DrawLine(skele, 410, 140, 410, 245);
            //draws the eye of the skele
            g.DrawLine(whitePen, 285, 180, 300, 180);
            g.DrawLine(whitePen, 375, 180, 360, 180);

        }

        public void Skele()
        {

            //draws the feet
            g.DrawLine(scold, 250, 300, 250, 370);
            g.DrawLine(scold, 255, 370, 220, 370);
            g.DrawLine(scold, 410, 300, 410, 370);
            g.DrawLine(scold, 405, 370, 435, 370);
            //draws hip of skele
            g.DrawLine(scold, 250, 300, 415, 300);
            //draws the 2 side lines of skele
            g.DrawLine(scold, 250, 300, 250, 220);
            g.DrawLine(scold, 410, 300, 410, 220);
            //draws the upper line of skele
            g.DrawLine(scold, 245, 225, 410, 225);
            //draws the ribs of the skele
            g.DrawLine(scold, 245, 240, 315, 240);
            g.DrawLine(scold, 410, 240, 340, 240);
            g.DrawLine(scold, 410, 255, 340, 255);
            g.DrawLine(scold, 245, 255, 315, 255);
            g.DrawLine(scold, 245, 270, 315, 270);
            g.DrawLine(scold, 410, 270, 340, 270);
            g.DrawLine(scold, 245, 285, 315, 285);
            g.DrawLine(scold, 410, 285, 340, 285);
            //draws the head of the skele
            g.DrawLine(scold, 250, 225, 250, 145);
            g.DrawLine(scold, 245, 145, 405, 145);
            g.DrawLine(scold, 410, 140, 410, 245);
            //draws the eye of the skele
            g.DrawLine(whitePen, 285, 180, 300, 180);
            g.DrawLine(whitePen, 375, 180, 360, 180);
        }
            private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            int i = 10;
            while (i >=0)
            {
                i--;
                Thread.Sleep(1000);
                scold = new Pen(Color.DarkGray, i);
                Clear();
                if (i >= 0)
                {
                    Skele();
                }
                else if (i == -1)
                {
                    Halloween();
                }

            }
        }
        public void Clear()
        {
            //this clears the screen and makes the background black
            g.Clear(Color.Black) ;
            g.DrawLine(yellowPen, 400, 0, 270, 350);
            g.DrawLine(yellowPen, 400, 0, 480, 350);
            g.FillEllipse(yellowBrush, 255, 260, 250, 260);
        }
        public void Halloween()
        {
            Font drawFont = new Font("Arial", 24, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);

            g.TranslateTransform(200, 50);
            g.RotateTransform(90);
            g.DrawString("HAPPY HALLOWEEN", drawFont, drawBrush, 0, 0);
            g.ResetTransform();
            Laugh.Play();
        }
    }
}
    


