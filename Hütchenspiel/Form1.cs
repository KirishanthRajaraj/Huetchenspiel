using Hütchenspiel.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hütchenspiel
{
    public partial class frmHütchenspiel : Form
    {
        //VALIDIERUNG 
        private int zahl;
        Image Auf = Resources.BecherAuf;
        Image Zu = Resources.Becher;
        Image AufLose = Resources.BecherAufLose;
        Image Weiss = Resources.BecherWeiss;
        private int ticks;



        public frmHütchenspiel()
        {
            InitializeComponent();
            Random zufallzahl = new Random();           
            
            zahl = zufallzahl.Next(1, 4);

            picBecher1.Image = Zu;
            picBecher2.Image = Zu;
            picBecher3.Image = Zu;
            
        }

        private void hall(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(ticks == 0)
            {
                tmr1.Start();


                if (zahl == 1)
                {
                    picBecher1.Image = Auf;
                    lblAusgang.Text = "GEWONNEN! (+5 CHF)";
                    int stand = Convert.ToInt32(lblKontostand.Text);
                    lblKontostand.Text = Convert.ToString(stand + 5);
  


                }
                if (zahl != 1)
                {
                    picBecher1.Image = AufLose;
                    lblAusgang.Text = "VERLOREN! (-5 CHF)";
                    int stand = Convert.ToInt32(lblKontostand.Text);
                    lblKontostand.Text = Convert.ToString(stand - 5);




                }
                Random zufallzahl = new Random();
                zahl = zufallzahl.Next(1, 4);
            }
            

        }

        private void picBecher2_Click(object sender, EventArgs e)
        {
            if(ticks == 0)
            {
                tmr1.Start();

                if (zahl == 2)
                {

                    picBecher2.Image = Auf;
                    lblAusgang.Text = "GEWONNEN! (+5 CHF)";
                    int stand = Convert.ToInt32(lblKontostand.Text);
                    lblKontostand.Text = Convert.ToString(stand + 5);
                 


                }
                if (zahl != 2)
                {
                    picBecher2.Image = AufLose;
                    lblAusgang.Text = "VERLOREN! (-5 CHF)";
                    int stand = Convert.ToInt32(lblKontostand.Text);
                    lblKontostand.Text = Convert.ToString(stand - 5);




                }
                Random zufallzahl = new Random();
                zahl = zufallzahl.Next(1, 4);
            }
            
        }

        private void picBecher3_Click(object sender, EventArgs e)
        {
            if(ticks == 0)
            {
                tmr1.Start();

                if (zahl == 3)
                {

                    picBecher3.Image = Auf;
                    lblAusgang.Text = "GEWONNEN! (+5 CHF)";
                    int stand = Convert.ToInt32(lblKontostand.Text);
                    lblKontostand.Text = Convert.ToString(stand + 5);
                    



                }
                if (zahl != 3)
                {
                    picBecher3.Image = AufLose;
                    lblAusgang.Text = "VERLOREN! (-5 CHF)";
                    int stand = Convert.ToInt32(lblKontostand.Text);
                    lblKontostand.Text = Convert.ToString(stand - 5);


                    
                }
                Random zufallzahl = new Random();
                zahl = zufallzahl.Next(1, 4);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            lblZeit.Text = Convert.ToString(ticks);

            if(ticks == 4)
            {
                lblZeit.Text = "GO!";
                tmr1.Stop();
                ticks = 0;

                picBecher1.Image = Zu;
                picBecher2.Image = Zu;
                picBecher3.Image = Zu;
            }
                
        }

        //Für Maus Hover -> Weisser Becher
        #region becherweiss


            private void picBecher1_MouseEnter(object sender, EventArgs e)
            {
                if (picBecher1.Image == Zu)
                {
                picBecher1.Image = Weiss;
                }
            }

            private void picBecher1_MouseLeave(object sender, EventArgs e)
            {
                if (picBecher1.Image == Weiss)
                {
                    picBecher1.Image = Zu;
                }
            }

            private void picBecher2_MouseEnter(object sender, EventArgs e)
            {
                if (picBecher2.Image == Zu)
                {
                    picBecher2.Image = Weiss;
                }
            }

            private void picBecher2_MouseLeave(object sender, EventArgs e)
            {
                if (picBecher2.Image == Weiss)
                {
                    picBecher2.Image = Zu;
                }
            }

            private void picBecher3_MouseEnter(object sender, EventArgs e)
            {
                if (picBecher3.Image == Zu)
                {
                    picBecher3.Image = Weiss;
                }
            }

            private void picBecher3_MouseLeave(object sender, EventArgs e)
            {
                if (picBecher3.Image == Weiss)
                {
                    picBecher3.Image = Zu;
                }
            }
        
        #endregion
    }
}
                                                       