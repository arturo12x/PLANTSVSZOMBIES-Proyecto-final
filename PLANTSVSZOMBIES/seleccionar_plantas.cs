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
    public partial class seleccionar_plantas : Form
    {
        int conta = 0;
        public static seleccionar_plantas instance = null;
        int contaplanta = 0;
        public seleccionar_plantas()
        {
            InitializeComponent();
            instance = this;

        }
      
     
        private void button1_Click(object sender, EventArgs e)
        {
            if (conta < 3)
            {
                MessageBox.Show("You have to select 3 characters", "PLANTS VS ZOMBIES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (conta>= 3)
            {
                game.instance.tletrero.Start();
                game.instance.pnl_plantas.Visible = false;
                this.Close();
            }
        }

        private void reset()
        {

        }
        private void kirby_Click(object sender, EventArgs e)
        {
            conta ++;
            if (contaplanta == 0 && game.instance.planta1.Tag != kirby.Tag
                && game.instance.planta2.Tag != kirby.Tag
                && game.instance.planta3.Tag != kirby.Tag)
            {
                if (game.instance.planta1.Tag == kirby.Tag)
                {
                    return;
                }
                game.instance.planta1.Image = Properties.Resources.k0;
                game.instance.planta1.Tag = kirby.Tag;
                contaplanta++;
                return;
            }


            if (contaplanta == 1 && game.instance.planta2.Tag != kirby.Tag
                && game.instance.planta1.Tag != kirby.Tag
                && game.instance.planta3.Tag != kirby.Tag)
            {
                if (game.instance.planta2.Tag == kirby.Tag)
                {
                    return;
                }
                game.instance.planta2.Image = Properties.Resources.k0;
                game.instance.planta2.Tag = kirby.Tag;
                contaplanta++;
                return;
            }
            if (contaplanta == 2 && game.instance.planta3.Tag != kirby.Tag
                && game.instance.planta1.Tag != kirby.Tag
                && game.instance.planta2.Tag != kirby.Tag)
            {
                if (game.instance.planta3.Tag == kirby.Tag)
                {
                    return;
                }
                game.instance.planta3.Image = Properties.Resources.k0;
                game.instance.planta3.Tag = kirby.Tag;
                contaplanta=0;
            }
        }

        private void mario_Click(object sender, EventArgs e)
        {
            conta++;

            if (contaplanta == 0 && game.instance.planta1.Tag != mario.Tag
                && game.instance.planta2.Tag != mario.Tag
                && game.instance.planta3.Tag != mario.Tag)
            {
                if (game.instance.planta1.Tag == mario.Tag)
                {
                    return;
                }
                game.instance.planta1.Image = Properties.Resources.m0;
                game.instance.planta1.Tag = mario.Tag;
                contaplanta++;
                return;
            }


            if (contaplanta == 1 && game.instance.planta2.Tag != mario.Tag
                && game.instance.planta3.Tag != mario.Tag
                && game.instance.planta1.Tag != mario.Tag)
            {
                if (game.instance.planta2.Tag == mario.Tag)
                {
                    return;
                }
                game.instance.planta2.Image = Properties.Resources.m0;
                game.instance.planta2.Tag = mario.Tag;
                contaplanta++;
                return;
            }
            if (contaplanta == 2 && game.instance.planta3.Tag != mario.Tag
                && game.instance.planta1.Tag != mario.Tag
                && game.instance.planta2.Tag != mario.Tag)
            {
                if (game.instance.planta3.Tag == mario.Tag)
                {
                    return;
                }
                game.instance.planta3.Image = Properties.Resources.m0;
                game.instance.planta3.Tag = mario.Tag;
                contaplanta = 0;
            }
        }

        private void sonic_Click(object sender, EventArgs e)
        {
            conta++;

            if (contaplanta == 0 && game.instance.planta1.Tag != sonic.Tag
                 && game.instance.planta2.Tag != sonic.Tag
                  && game.instance.planta3.Tag != sonic.Tag)
            {
                if (game.instance.planta1.Tag == sonic.Tag)
                {
                    return;
                }
                game.instance.planta1.Image = Properties.Resources.s0;
                game.instance.planta1.Tag = sonic.Tag;
                contaplanta++;
                return;
            }


            if (contaplanta == 1 && game.instance.planta2.Tag != sonic.Tag
                 && game.instance.planta1.Tag != sonic.Tag
                  && game.instance.planta3.Tag != sonic.Tag)
            {
                if (game.instance.planta2.Tag == sonic.Tag)
                {
                    return;
                }
                game.instance.planta2.Image = Properties.Resources.s0;
                game.instance.planta2.Tag = sonic.Tag;
                contaplanta++;
                return;
            }
            if (contaplanta == 2 && game.instance.planta3.Tag != sonic.Tag
                 && game.instance.planta1.Tag != sonic.Tag
                  && game.instance.planta2.Tag != sonic.Tag)
            {
                if (game.instance.planta3.Tag == sonic.Tag)
                {
                    return;
                }
                game.instance.planta3.Image = Properties.Resources.s0;
                game.instance.planta3.Tag = sonic.Tag;
                contaplanta = 0;
            }
        }

        private void pikachu_Click(object sender, EventArgs e)
        {
            conta++;

            if (contaplanta == 0 && game.instance.planta1.Tag != pikachu.Tag
                && game.instance.planta2.Tag != pikachu.Tag
                && game.instance.planta3.Tag != pikachu.Tag)
            {
                if (game.instance.planta1.Tag == pikachu.Tag)
                {
                    return;
                }
                game.instance.planta1.Image = Properties.Resources.p0;
                game.instance.planta1.Tag = pikachu.Tag;
                contaplanta++;
                return;
            }


            if (contaplanta == 1 && game.instance.planta2.Tag != pikachu.Tag
                && game.instance.planta1.Tag != pikachu.Tag
                && game.instance.planta3.Tag != pikachu.Tag)
            {
                if (game.instance.planta2.Tag == pikachu.Tag)
                {
                    return;
                }
                game.instance.planta2.Image = Properties.Resources.p0;
                game.instance.planta2.Tag = pikachu.Tag;
                contaplanta++;
                return;
            }
            if (contaplanta == 2 && game.instance.planta3.Tag != pikachu.Tag
                && game.instance.planta2.Tag != pikachu.Tag
                && game.instance.planta1.Tag != pikachu.Tag)
            {
                if (game.instance.planta3.Tag == pikachu.Tag)
                {
                    return;
                }
                game.instance.planta3.Image = Properties.Resources.p0;
                game.instance.planta3.Tag = pikachu.Tag;
                contaplanta = 0;
            }
        }

        private void megaman_Click(object sender, EventArgs e)
        {
  

            conta++;

            if (contaplanta == 0 && game.instance.planta1.Tag!=megaman.Tag
                 && game.instance.planta2.Tag != megaman.Tag
                  && game.instance.planta3.Tag != megaman.Tag)
            {
                if (game.instance.planta1.Tag == megaman.Tag)
                {
                    return;
                }
                game.instance.planta1.Image = Properties.Resources.mm0;
                game.instance.planta1.Tag = megaman.Tag;
                contaplanta++;
                return;
            }


            if (contaplanta == 1 && game.instance.planta2.Tag != megaman.Tag
                 && game.instance.planta1.Tag != megaman.Tag
                  && game.instance.planta3.Tag != megaman.Tag)
            {
                if (game.instance.planta2.Tag == megaman.Tag)
                {
                    return;
                }
                game.instance.planta2.Image = Properties.Resources.mm0;
                game.instance.planta2.Tag = megaman.Tag;
                contaplanta++;
                return;
            }
            if (contaplanta == 2 && game.instance.planta3.Tag != megaman.Tag
                 && game.instance.planta2.Tag != megaman.Tag
                  && game.instance.planta1.Tag != megaman.Tag)
            {
                if (game.instance.planta3.Tag == megaman.Tag)
                {
                    return;
                }
                game.instance.planta3.Image = Properties.Resources.mm0;
                game.instance.planta3.Tag = megaman.Tag;
                contaplanta = 0;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
