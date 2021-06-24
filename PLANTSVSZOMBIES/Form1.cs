using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace PLANTSVSZOMBIES
{
    public partial class SPLASH_SCREEEN : Form
    {
        int ticktimer = 0;
        WindowsMediaPlayer backgroundsound = new WindowsMediaPlayer();

        public SPLASH_SCREEEN()
        {
            InitializeComponent();
  
        }



        private void IMG_SPLASH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SPLASH_SCREEEN_Load(object sender, EventArgs e)
        {
       
            timer_splash.Start();

            backgroundsound.URL = "splashscreen.mp3";
            backgroundsound.controls.play();

        }

        private void timer_splash_Tick(object sender, EventArgs e)
        {
            ticktimer ++;
            pbcarga.Value = ticktimer;


            switch (ticktimer)
            {
                case 0:
                    lblsplash.Text = "LOADING.";
                    break;
                case 5:
                    lblsplash.Text = "LOADING..";
                    break;
                case 10:
                    lblsplash.Text = "LOADING...";
                    break;
                case 15:
                    lblsplash.Text = "LOADING.";
                    break;
                case 20:
                    lblsplash.Text = "LOADING..";
                    break;
                case 25:
                    lblsplash.Text = "LOADING...";
                    break;
                case 30:
                    lblsplash.Text = "LOADING ZOMBIES.";
                    break;
                case 35:
                    lblsplash.Text = "LOADING ZOMBIES..";
                    break;
                case 40:
                    lblsplash.Text = "LOADING ZOMBIES...";
                    break;
                case 45:
                    lblsplash.Text = "LOADING ZOMBIES.";
                    break;
                case 55:
                    lblsplash.Text = "LOADING ZOMBIES..";
                    break;
                case 60:
                    lblsplash.Text = "LOADING ZOMBIES...";
                    break;
                case 65:
                    lblsplash.Text = "FORMATTING YOUR HARD DISK C:.";
                 
                    break;
                case 70:
                    lblsplash.Text = "FORMATTING YOUR HARD DISK C:..";
                    break;
                case 75:
                    lblsplash.Text = "FORMATTING YOUR HARD DISK C:...";

                    break;

                case 80:
                    lblsplash.Text = "ALMOST READY.";
                    break;
                case 85:
                    lblsplash.Text = "ALMOST READY..";
                    break;
                case 90:
                    lblsplash.Text = "ALMOST READY...";
                    break;
                case 100:
                    lblsplash.Text = "ALMOST READY.";
                    timer_splash.Stop();
                    backgroundsound.controls.stop();
              
                    main_menu mainmenu = new main_menu();
                    mainmenu.Show();
            this.Hide();
                    break;

            }
                





             


            }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
                    }
    }
    
}
