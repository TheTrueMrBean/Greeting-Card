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
// Daniel Bean Decemeber 2024 this is  a animation of a skele the skeleton Ascending to the sky 
namespace WindowsFormsApp5
{
    
    public partial class Form1 : Form
    {
        // creates a lot of variables, pens and brushs
        int leftFeetUp;
        int leftFeetLeft;
        int hipUp;
        int sideLineUp;
        int upperLineUp;
        int rib1;
        int rib2;
        int rib3;
        int rib4;
        int head;
        int headOff;
        int headLeftDown;
        int eye;

        Graphics g;

        SoundPlayer Laugh = new SoundPlayer(Properties.Resources.Laugh);
        SoundPlayer Bones = new SoundPlayer(Properties.Resources.bones);

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
            g.DrawLine(scold, 250, leftFeetUp, 250, leftFeetLeft);
            g.DrawLine(scold, 255, leftFeetLeft, 220, leftFeetLeft);
            g.DrawLine(scold, 410, leftFeetUp, 410, leftFeetLeft);
            g.DrawLine(scold, 405, leftFeetLeft, 435, leftFeetLeft);
            //draws hip of skele
            g.DrawLine(scold, 250, hipUp, 415, hipUp);
            //draws the 2 side lines of skele
            g.DrawLine(scold, 250, hipUp, 250, sideLineUp);
            g.DrawLine(scold, 410, hipUp, 410, sideLineUp);
            //draws the upper line of skele
            g.DrawLine(scold, 245, upperLineUp, 410, upperLineUp);
            //draws the ribs of the skele
            g.DrawLine(scold, 245, rib1, 315, rib1);
            g.DrawLine(scold, 410, rib1, 340, rib1);
            g.DrawLine(scold, 410, rib2, 340, rib2);
            g.DrawLine(scold, 245, rib2, 315, rib2);
            g.DrawLine(scold, 245, rib3, 315, rib3);
            g.DrawLine(scold, 410, rib3, 340, rib3);
            g.DrawLine(scold, 245, rib4, 315, rib4);
            g.DrawLine(scold, 410, rib4, 340, rib4);
            //draws the head of the skele
            g.DrawLine(scold, 250, upperLineUp, 250, head);
            g.DrawLine(scold, 245, head, 405, head);
            g.DrawLine(scold, 410, headOff, 410, headLeftDown);
            //draws the eye of the skele
            g.DrawLine(whitePen, 285, eye, 300, eye);
            g.DrawLine(whitePen, 375, eye, 360, eye);
        }
            private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //creates a lot of variables for the skele to ascend
            int i = 15;
            int bones = 0;
             leftFeetUp = 300;
             leftFeetLeft = 370;
            hipUp = 300;
            upperLineUp = 225;
            sideLineUp = 220;
            rib1 = 240;
            rib2 = 255;
            rib3 = 270;
            rib4 = 285;
            head = 145;
            headOff = 140;
            headLeftDown = 245;
            eye = 180;
            while (i >=0)
            {
                // this create a useless pen now it also check to see if the skeleton is off screen
                i--;
                bones++;
                Thread.Sleep(1000);
                scold = new Pen(Color.DarkGray, 10);
                Clear();
                Minus();
                if (i >= 0)
                {
                    Skele();
                }
                else if (i == -1)
                {
                    Halloween();
                }
                //this makes the laugh now play thoughout the code 
                if (bones == 5)
                {
                    bones = 0;
                    Bones.Play();
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
            // draws the halloween message 
            Font drawFont = new Font("Arial", 24, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);

            g.TranslateTransform(200, 50);
            g.RotateTransform(90);
            g.DrawString("HAPPY HALLOWEEN", drawFont, drawBrush, 0, 0);
            g.ResetTransform();
            Laugh.Play();
        }
        public void Minus()
        {
            // minus 25 from all the height so it slowly goes up
             leftFeetUp = leftFeetUp - 25;
             leftFeetLeft =  leftFeetLeft - 25;
            hipUp = hipUp - 25;
            sideLineUp = sideLineUp - 25;
            upperLineUp = upperLineUp - 25;
            rib4 = rib4 - 25;
            rib3 = rib3 - 25;
            rib2 = rib2 - 25;
            rib1 = rib1 - 25;
            head = head - 25;
            headOff = headOff - 25;
            headLeftDown = headLeftDown - 25;
            eye = eye - 25;
        }
        
    }
}
    


