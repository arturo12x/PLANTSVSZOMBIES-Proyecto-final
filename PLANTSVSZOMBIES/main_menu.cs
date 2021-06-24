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
    public partial class main_menu : Form
    {
        WindowsMediaPlayer backgroundsound = new WindowsMediaPlayer();
        bool user = false;
        public main_menu()
        {
            InitializeComponent();

        }

        private void main_menu_Load(object sender, EventArgs e)
        {
            backgroundsound.URL = "mainmenu.mp3";
            backgroundsound.controls.play();
            backgroundsound.settings.setMode("Loop", true);



        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

           
        }

        private void panel1_Click(object sender, EventArgs e)
        {
     

            if (user == false)
            {
                MessageBox.Show("Welcome to Plants vs Zombies." +
                                " To start to play,first write your name on the textbox!", "PLANTS VS ZOMBIES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtname.BackColor = Color.FromArgb(171, 66, 62);
            }
            if (user == true)
            {
                backgroundsound.controls.stop();
                game game = new game();
                game.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string usuario;
            usuario = txtname.Text;
            if (!string.IsNullOrEmpty(usuario))
            {
                user = true;
            }
        }
    }
}
