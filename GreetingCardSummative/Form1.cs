using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

// Devon Subject, November 22, 2024
//Greeting Card made with Graphics in Visual Studio

namespace GreetingCardSummative
{
    public partial class Form1 : Form
    {
        //global variable
        int counter = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            g.Clear(Color.Green);

            Font textFont = new Font("Microsoft Sans Serif", 50, FontStyle.Bold);
            SolidBrush textBrush = new SolidBrush(Color.White);

            g.DrawString("Merry", textFont, textBrush, 145, 20);
            g.DrawString("Christmas", textFont, textBrush, 80, 300);
            //Text

            SolidBrush eyeBrush = new SolidBrush(Color.Gold);
            Pen eyePen = new Pen(Color.Gold, 4);
            SolidBrush ornamentBrush = new SolidBrush(Color.Red);

            g.FillRectangle(eyeBrush, 230, 130, 30, 20);
            g.DrawRectangle(eyePen, 235, 122, 20, 10);
            g.FillEllipse(ornamentBrush, 170, 138, 149, 149);
            //Ornament Drawing
            //All Pens and Brushes are named in accordance with relations to the parts of a Christmas ornament
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            g.Clear(Color.Firebrick);

            Font textFont = new Font("Microsoft Sans Serif", 30, FontStyle.Bold);
            SolidBrush textBrush = new SolidBrush(Color.White);

            g.DrawString("and a Happy New Year!", textFont, textBrush, 15, 15);
            //Text

            SolidBrush trunkBrush = new SolidBrush(Color.SaddleBrown);
            SolidBrush leavesBrush = new SolidBrush(Color.DarkGreen);

                g.FillRectangle(trunkBrush, 225, 315, 31, 80);
                g.FillPie(leavesBrush, 115, 115, 250, 250, 45, 90);
                g.FillPie(leavesBrush, 127, 65, 225, 225, 45, 90);
                g.FillPie(leavesBrush, 140, 25, 200, 200, 45, 90);
            //Christmas Tree Drawing

            SoundPlayer christmasPlayer = new SoundPlayer(Properties.Resources.Christmas_Music);
            christmasPlayer.Play();
            //Music found on FreeSound.org

            for (int i = 0; i < 35; i++)
            {
                if (counter == 1)
                {
                    SolidBrush lightsBrush1 = new SolidBrush(Color.Red);
                    SolidBrush lightsBrush2 = new SolidBrush(Color.DarkOrange);
                    SolidBrush lightsBrush3 = new SolidBrush(Color.Yellow);
                    SolidBrush lightsBrush4 = new SolidBrush(Color.RoyalBlue);

                    g.FillEllipse(lightsBrush1, 190, 190, 15, 15);
                    g.FillEllipse(lightsBrush2, 180, 250, 15, 15);
                    g.FillEllipse(lightsBrush1, 170, 320, 15, 15);
                    g.FillEllipse(lightsBrush2, 270, 190, 15, 15);
                    g.FillEllipse(lightsBrush1, 280, 250, 15, 15);
                    g.FillEllipse(lightsBrush2, 290, 320, 15, 15);
                    g.FillEllipse(lightsBrush3, 210, 160, 15, 15);
                    g.FillEllipse(lightsBrush4, 250, 160, 15, 15);
                    g.FillEllipse(lightsBrush4, 210, 220, 15, 15);
                    g.FillEllipse(lightsBrush3, 250, 220, 15, 15);
                    g.FillEllipse(lightsBrush3, 210, 300, 15, 15);
                    g.FillEllipse(lightsBrush4, 250, 300, 15, 15);
                    counter = 2;

                    Thread.Sleep(1000);
                }
                else if (counter == 2)
                {
                    SolidBrush lightsBrush1 = new SolidBrush(Color.OrangeRed);
                    SolidBrush lightsBrush2 = new SolidBrush(Color.Gold);
                    SolidBrush lightsBrush3 = new SolidBrush(Color.Turquoise);
                    SolidBrush lightsBrush4 = new SolidBrush(Color.DarkViolet);

                    g.FillEllipse(lightsBrush1, 190, 190, 15, 15);
                    g.FillEllipse(lightsBrush2, 180, 250, 15, 15);
                    g.FillEllipse(lightsBrush1, 170, 320, 15, 15);
                    g.FillEllipse(lightsBrush2, 270, 190, 15, 15);
                    g.FillEllipse(lightsBrush1, 280, 250, 15, 15);
                    g.FillEllipse(lightsBrush2, 290, 320, 15, 15);
                    g.FillEllipse(lightsBrush3, 210, 160, 15, 15);
                    g.FillEllipse(lightsBrush4, 250, 160, 15, 15);
                    g.FillEllipse(lightsBrush4, 210, 220, 15, 15);
                    g.FillEllipse(lightsBrush3, 250, 220, 15, 15);
                    g.FillEllipse(lightsBrush3, 210, 300, 15, 15);
                    g.FillEllipse(lightsBrush4, 250, 300, 15, 15);
                    counter = 1;

                    Thread.Sleep(1000);
                }
                //Loop for Christmas Tree Lights

                Application.Exit();
            }
        }
    }
}