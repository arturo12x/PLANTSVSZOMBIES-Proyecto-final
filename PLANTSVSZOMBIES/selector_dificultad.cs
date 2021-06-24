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
 
    public partial class selector_dificultad : Form
    {
    
        public selector_dificultad()
        {
            InitializeComponent();
        }

        private void selector_dificultad_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.FromArgb(0xAA, 0x00, 0xFF);
            this.BackColor = Color.FromArgb(0xAA, 0x00, 0xFF);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.dificultad = "normal";
   
          
            game.instance.pnl_plantas.Visible = true;

            seleccionar_plantas seleccionar_Plantas = new seleccionar_plantas();
            seleccionar_Plantas.ShowDialog();
            this.Close();

            
        }

 

        private void button3_Click(object sender, EventArgs e)
        {
            game.dificultad = "xtreme";



            game.instance.pnl_plantas.Visible = true;
            
            seleccionar_plantas seleccionar_Plantas = new seleccionar_plantas();
            seleccionar_Plantas.ShowDialog();
            this.Close();

        }
    }
}
