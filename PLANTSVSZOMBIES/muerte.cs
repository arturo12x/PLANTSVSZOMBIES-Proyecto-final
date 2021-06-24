using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLANTSVSZOMBIES
{
    public partial class muerte : Form
    {
        public muerte()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the game?", "Plants vs zombies", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
                
              
            }
            else if (result == DialogResult.No)
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go to main menu?", "Plants vs zombies", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                main_menu main_Menu = new main_menu();
                main_Menu.Show();
                this.Close();
               
            }
            else if (result == DialogResult.No)
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game game = new game();
            game.Show();
            this.Close();
        }
    }
}
