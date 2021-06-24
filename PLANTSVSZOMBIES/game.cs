using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WMPLib;


namespace PLANTSVSZOMBIES
{
    public partial class game : Form
    {

        public static game instance = null;
        int time_letrero = 0;
        int timeloco = 0;
        int nZombiesANDtimer = 0;

        PictureBox[] zombies = new PictureBox[30];
        bool der = false;
        bool izq = false;
        bool arriba = false;
        bool abajo = false;
        bool disparo = false;
        bool bossarriba = false;
        bool bosslado = false;
        bool letrero = false;
        bool pausa1 = false;
        bool pausa2 = false;
        bool pausa3 = false;
        bool pausa4 = false;
        int contabalas = 0;
      

        

        Image[] sprites_sonic = new Image[12];
        Image[] sprites_kirby = new Image[3];
        Image[] sprites_mario = new Image[3];
        Image[] sprites_mega = new Image[6];
        Image[] sprites_pikachu = new Image[4];

public static  string dificultad="";
            
        public static bool imgplant1 = false;
        public static bool imgplant2 = false;
        public static bool imgplant3 = false;
        public static bool solecito = false;
        bool actboss = false;
        int muerte = 0;
        int contaprogreso = 0;
        int contmov = 0;
        int contadanoboss = 0;
        int contatimer = 0;
     Point posicion_inicio =new Point(318, 198);
        bool rotar = false;
        bool primeravez = true;
        Button imagesol = new Button();

        WindowsMediaPlayer loco = new WindowsMediaPlayer();
        WindowsMediaPlayer efecto_sonido = new WindowsMediaPlayer();
        WindowsMediaPlayer efecto2_sonido = new WindowsMediaPlayer();
        WindowsMediaPlayer efecto3_sonido = new WindowsMediaPlayer();
        WindowsMediaPlayer background = new WindowsMediaPlayer();
        public game()
        {
            InitializeComponent();

            Application.EnableVisualStyles();

     

            sprites_sonic[0] = Properties.Resources.s0;
            sprites_sonic[1] = Properties.Resources.s1;
            sprites_sonic[2] = Properties.Resources.s2;
            sprites_sonic[3] = Properties.Resources.s3;
            sprites_sonic[4] = Properties.Resources.s4;
            sprites_sonic[5] = Properties.Resources.s5;
            sprites_sonic[6] = Properties.Resources.s6;
            sprites_sonic[7] = Properties.Resources.s7;
            sprites_sonic[8] = Properties.Resources.s8;
            sprites_sonic[9] = Properties.Resources.s9;
            sprites_sonic[10] = Properties.Resources.s10;
            sprites_sonic[11] = Properties.Resources.s11;

            sprites_kirby[0] = Properties.Resources.k0;
            sprites_kirby[1] = Properties.Resources.k1;
            sprites_kirby[2] = Properties.Resources.k2;

            sprites_mario[0] = Properties.Resources.m0;
            sprites_mario[1] = Properties.Resources.m1;
            sprites_mario[2] = Properties.Resources.m2;

            sprites_mega[0] = Properties.Resources.mm0;
            sprites_mega[1] = Properties.Resources.mm1;
            sprites_mega[2] = Properties.Resources.mm2;
            sprites_mega[3] = Properties.Resources.mm3;
            sprites_mega[4] = Properties.Resources.mm4;
            sprites_mega[5] = Properties.Resources.mm5;

            sprites_pikachu[0] = Properties.Resources.p0;
            sprites_pikachu[1] = Properties.Resources.p1;
            sprites_pikachu[2] = Properties.Resources.p2;
            sprites_pikachu[3] = Properties.Resources.p3;


            instance = this;
            progressBar1.Maximum =zombies.Length;
            progressBar1.Step =1;

        }

        //codigo de int para que no se trabe tanto...
        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion*/


        #region .. code for Flucuring ..

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
   
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void game_Load(object sender, EventArgs e)
        {
            tloco_dave.Start();

            pnl_pausa.BackColor = Color.FromArgb(125, Color.Black);
            pnl_ganar.BackColor = Color.FromArgb(125, Color.LightGreen);
        }
       
        private void tloco_dave_Tick(object sender, EventArgs e)
        {

            timeloco++;



            if (timeloco == 1)
            {
                loco.URL = @"C:\Users\jazhi\OneDrive\Escritorio\TRABAJOS\PLANTSVSZOMBIES\PLANTSVSZOMBIES\bin\Debug\voz_locodave.mp3";

                loco.controls.play();
                //mostrar dave
                pnl_dave.Left = -11;
                pnl_dave.Top = 241;
                pnl_dave.Visible = true;

            }

            if (timeloco == 16)
            {
                background.URL = "espera.mp3";
                background.controls.play();
                loco.controls.stop();
                tloco_dave.Stop();
                //ocultar dave
                pnl_dave.Dispose();
                selector_dificultad selector_Dificultad = new selector_dificultad();
                selector_Dificultad.ShowDialog();

             
            }
        }

        private void tdialog_Tick(object sender, EventArgs e)
        {

        }

        private void tletrero_Tick(object sender, EventArgs e)
        {
            background.controls.stop();

            time_letrero++;
            if (letrero == false)
            {
                if (time_letrero == 2)
                {


                    pnlletrero.Left = 304;
                    pnlletrero.Top = 170;
                    pnlletrero.Visible = true;

                }
                if (time_letrero == 4)
                {
                    pnlletrero.BackgroundImage = PLANTSVSZOMBIES.Properties.Resources.StartReady;

                }
                if (time_letrero == 6)
                {
                    pnlletrero.BackgroundImage = PLANTSVSZOMBIES.Properties.Resources.StartPlant;

                }

                if (time_letrero == 8)
                {
                    tletrero.Stop();
                    pnlletrero.Visible = false;
                    pnlletrero.Left = 1000;
                    pnlletrero.Top = 1000;
                    pnl_plantas.Visible = true;
                    tzombie.Start();
                    tmovimizombie.Start();
                    pnl_plantas.Visible = true;
                    time_letrero = 0;
                    letrero = true;
                    background.URL = "background1.mp3";
                    background.controls.play();
                    background.settings.setMode("Loop", true);

                    //zombie1.Visible = true;
                }
            }
            if (letrero == true)
            {
                if (time_letrero == 2)
                {
                    background.controls.stop();
                    efecto_sonido.URL = "boss.mp3";
                    efecto_sonido.controls.play();
                    pnlletrero.Left = 304;
                    pnlletrero.Top = 170;
                    pnlletrero.Visible = true;
                    pnlletrero.BackgroundImage = PLANTSVSZOMBIES.Properties.Resources.FinalWave;
                    planta.Visible = false;
                    pnl_plantas.Visible = false;
                }

                if (time_letrero == 30)
                {
                    tletrero.Stop();
                    pnlletrero.Visible = false;
                    pnlletrero.Left = 1000;
                    pnlletrero.Top = 1000;
                    zomboss.Location = new Point(630, 168);
                    zomboss.SendToBack();
                    na.SendToBack();
                    na2.SendToBack();
                    na3.SendToBack();
                    na4.SendToBack();
                    na5.SendToBack();
                    na6.SendToBack();
                    na7.SendToBack();
                    na8.SendToBack();
                    planta.Location = posicion_inicio;
                    actboss = true;
                    planta.Visible = true;
                    pnl_plantas.Visible = true;
                    ProgressBoss.Visible = true;
                    progressBar1.Visible = false;
                    background.URL = "background2.mp3";
                    background.controls.play();
                    tboss.Start();
                    tboss.Start();
                    nZombiesANDtimer = 0;
                    //zombie1.Visible = true;
                }
            }



        }

        private void tzombie_Tick(object sender, EventArgs e)
        {
            if (dificultad == "normal")
            {
                tzombie.Interval = 1500;
            }
            if (dificultad == "xtreme")
            {
                tzombie.Interval = 1500;
            }



            Random random = new Random();
            int posiYzombie = random.Next(15, 400);


            if (nZombiesANDtimer == zombies.Length - 1)
            {
                tzombie.Stop();
            }

            zombies[nZombiesANDtimer] = new PictureBox
            {
                Image = PLANTSVSZOMBIES.Properties.Resources.zombie_cono,

                SizeMode = PictureBoxSizeMode.StretchImage,

                BackColor = Color.Transparent,
                Size = new Size(79, 86),
                Location = new Point(787, posiYzombie),


            };//zombies nivel facil

            this.Controls.Add(zombies[nZombiesANDtimer]);


            nZombiesANDtimer++;
        }

        void movzombie()
        {

        }
        private void tmovimizombie_Tick_1(object sender, EventArgs e)
        {
            if (dificultad == "normal")
            {
                tmovimizombie.Interval = 100;
            }
            if (dificultad == "xtreme")
            {
                tmovimizombie.Interval = 85;
            }

            for (int i = 0; i < zombies.Length; i++)
            {
                if (zombies[i] != null)
                {
                    zombies[i].Left -= 4;

                    if (zombies[i].Left == 2)
                    {


                        tmovimizombie.Stop();
                        tzombie.Stop();


                        MessageBox.Show("fin del juego");

                    }
                }

                // si un zombie llega a la casa es game over




            }


            /* BUSCAR CONDICION PARA DETENER ESTETIMER DE MOVIMIENTO DE ZOMBIES
              if (nZombiesANDtimer == zombies.Length - 1)
              {
                  tmovimizombie.Stop();

              }*/
        }


        private void tmovimizombie_Tick(object sender, EventArgs e)
        {

        }


        private void pnl_progreso_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsleccionarplanta_Tick(object sender, EventArgs e)
        {


        }






        private void planta1_Click_1(object sender, EventArgs e)
        {
            contmov = 0;

            planta.Image = planta1.Image;
            planta.Tag = planta1.Tag;
            if (planta.Tag == seleccionar_plantas.instance.megaman.Tag)
            {
                bala.Image = Properties.Resources.rayo;
                bala2.Image = Properties.Resources.rayo;
                bala3.Image = Properties.Resources.rayo;


                ibala.Image = Properties.Resources.rayo;
                ibala2.Image = Properties.Resources.rayo;
                ibala3.Image = Properties.Resources.rayo;
            }
             if (planta.Tag == seleccionar_plantas.instance.pikachu.Tag)
             {
                 bala.Image = Properties.Resources.pokebola;
                 bala2.Image = Properties.Resources.pokebola;
                 bala3.Image = Properties.Resources.pokebola;
                
                 ibala.Image = Properties.Resources.pokebola;
                 ibala2.Image = Properties.Resources.pokebola;
                 ibala3.Image = Properties.Resources.pokebola;
   
             }
             if (planta.Tag == seleccionar_plantas.instance.sonic.Tag)
             {

                 bala.Image = Properties.Resources.rayo;
                 bala2.Image = Properties.Resources.rayo;
                 bala3.Image = Properties.Resources.rayo;
             

                 ibala.Image = Properties.Resources.rayo;
                 ibala2.Image = Properties.Resources.rayo;
                 ibala3.Image = Properties.Resources.rayo;
                
             }

             if (planta.Tag == seleccionar_plantas.instance.kirby.Tag)
             {
                 bala.Image = Properties.Resources.estrella;
                 bala2.Image = Properties.Resources.estrella;
                 bala3.Image = Properties.Resources.estrella;
               
                 ibala.Image = Properties.Resources.estrella;
                 ibala2.Image = Properties.Resources.estrella;
                 ibala3.Image = Properties.Resources.estrella;
              
             }
             if (planta.Tag == seleccionar_plantas.instance.mario.Tag)
             {
                 bala.Image = Properties.Resources.fuego1;
                 bala2.Image = Properties.Resources.fuego1;
                 bala3.Image = Properties.Resources.fuego1;
                 
                 ibala.Image = Properties.Resources.fuego1;
                 ibala2.Image = Properties.Resources.fuego1;
                 ibala3.Image = Properties.Resources.fuego1;
               
             }
        }

        private void planta2_Click(object sender, EventArgs e)
        {
            contmov = 0;
            planta.Image = planta2.Image;
            planta.Tag = planta2.Tag;
            if (planta.Tag == seleccionar_plantas.instance.megaman.Tag)
            {
                bala.BackgroundImage = Properties.Resources.rayo;
                bala2.BackgroundImage = Properties.Resources.rayo;
                bala3.BackgroundImage = Properties.Resources.rayo;
           

                ibala.BackgroundImage = Properties.Resources.rayo;
                ibala2.BackgroundImage = Properties.Resources.rayo;
                ibala3.BackgroundImage = Properties.Resources.rayo;
              
            }
            if (planta.Tag == seleccionar_plantas.instance.pikachu.Tag)
            {
                bala.BackgroundImage = Properties.Resources.pokebola;
                bala2.BackgroundImage = Properties.Resources.pokebola;
                bala3.BackgroundImage = Properties.Resources.pokebola;
               

                ibala.BackgroundImage = Properties.Resources.pokebola;
                ibala2.BackgroundImage = Properties.Resources.pokebola;
                ibala3.BackgroundImage = Properties.Resources.pokebola;
            
            }
            if (planta.Tag == seleccionar_plantas.instance.sonic.Tag)
            {

                bala.BackgroundImage = Properties.Resources.rayo;
                bala2.BackgroundImage = Properties.Resources.rayo;
                bala3.BackgroundImage = Properties.Resources.rayo;
              

                ibala.BackgroundImage = Properties.Resources.rayo;
                ibala2.BackgroundImage = Properties.Resources.rayo;
                ibala3.BackgroundImage = Properties.Resources.rayo;
              

            }

            if (planta.Tag == seleccionar_plantas.instance.kirby.Tag)
            {
                bala.BackgroundImage = Properties.Resources.estrella;
                bala2.BackgroundImage = Properties.Resources.estrella;
                bala3.BackgroundImage = Properties.Resources.estrella;
               

                ibala.BackgroundImage = Properties.Resources.estrella;
                ibala2.BackgroundImage = Properties.Resources.estrella;
                ibala3.BackgroundImage = Properties.Resources.estrella;
               
            }
            if (planta.Tag == seleccionar_plantas.instance.mario.Tag)
            {
                bala.BackgroundImage = Properties.Resources.fuego1;
                bala2.BackgroundImage = Properties.Resources.fuego1;
                bala3.BackgroundImage = Properties.Resources.fuego1;
               
                ibala.BackgroundImage = Properties.Resources.fuego1;
                ibala2.BackgroundImage = Properties.Resources.fuego1;
                ibala3.BackgroundImage = Properties.Resources.fuego1;
               
            }
        }

        private void planta3_Click(object sender, EventArgs e)
        {
            contmov = 0;
            planta.Image = planta3.Image;
            planta.Tag = planta3.Tag;
            if (planta.Tag == seleccionar_plantas.instance.megaman.Tag)
            {
                bala.BackgroundImage = Properties.Resources.rayo;
                bala2.BackgroundImage = Properties.Resources.rayo;
                bala3.BackgroundImage = Properties.Resources.rayo;
              
                ibala.BackgroundImage = Properties.Resources.rayo;
                ibala2.BackgroundImage = Properties.Resources.rayo;
                ibala3.BackgroundImage = Properties.Resources.rayo;
              
            }
            if (planta.Tag == seleccionar_plantas.instance.pikachu.Tag)
            {
                bala.BackgroundImage = Properties.Resources.pokebola;
                bala2.BackgroundImage = Properties.Resources.pokebola;
                bala3.BackgroundImage = Properties.Resources.pokebola;
              

                ibala.BackgroundImage = Properties.Resources.pokebola;
                ibala2.BackgroundImage = Properties.Resources.pokebola;
                ibala3.BackgroundImage = Properties.Resources.pokebola;
              
            }
            if (planta.Tag == seleccionar_plantas.instance.sonic.Tag)
            {

                bala.BackgroundImage = Properties.Resources.rayo;
                bala2.BackgroundImage = Properties.Resources.rayo;
                bala3.BackgroundImage = Properties.Resources.rayo;
             
                ibala.BackgroundImage = Properties.Resources.rayo;
                ibala2.BackgroundImage = Properties.Resources.rayo;
                ibala3.BackgroundImage = Properties.Resources.rayo;
              

            }

            if (planta.Tag == seleccionar_plantas.instance.kirby.Tag)
            {
                bala.BackgroundImage = Properties.Resources.estrella;
                bala2.BackgroundImage = Properties.Resources.estrella;
                bala3.BackgroundImage = Properties.Resources.estrella;
              

                ibala.BackgroundImage = Properties.Resources.estrella;
                ibala2.BackgroundImage = Properties.Resources.estrella;
                ibala3.BackgroundImage = Properties.Resources.estrella;
              
            }
            if (planta.Tag == seleccionar_plantas.instance.mario.Tag)
            {
                bala.BackgroundImage = Properties.Resources.fuego1;
                bala2.BackgroundImage = Properties.Resources.fuego1;
                bala3.BackgroundImage = Properties.Resources.fuego1;
               

                ibala.BackgroundImage = Properties.Resources.fuego1;
                ibala2.BackgroundImage = Properties.Resources.fuego1;
                ibala3.BackgroundImage = Properties.Resources.fuego1;
              
            }
        }


        /// M O V I M I E N T O////////////

        private void movimiento()

        {
            if (planta.Tag == seleccionar_plantas.instance.megaman.Tag)
            {

                planta.Image = sprites_mega[0];
                planta.Image = sprites_mega[contmov];
                if (contatimer % 5 == 0)
                {
                    contmov++;
                }


                if (contmov == 6)
                {
                    contmov = 0;
                }
                contatimer++;
            }
            if (planta.Tag == seleccionar_plantas.instance.pikachu.Tag)
            {
                planta.Image = sprites_pikachu[0];
                planta.Image = sprites_pikachu[contmov];

                if (contatimer % 4 == 0)
                {
                    contmov++;
                }


                if (contmov == 4)
                {
                    contmov = 0;
                }
                contatimer++;
            }
            if (planta.Tag == seleccionar_plantas.instance.sonic.Tag)
            {

                planta.Image = sprites_sonic[0];
                planta.Image = sprites_sonic[contmov];
                if (contatimer % 2 == 0)
                {
                    contmov++;
                }


                if (contmov == 6)
                {
                    contmov = 0;
                }
                contatimer++;
            }

            if (planta.Tag == seleccionar_plantas.instance.kirby.Tag)
            {

                planta.Image = sprites_kirby[0];
                planta.Image = sprites_kirby[contmov];
                if (contatimer % 4 == 0)
                {
                    contmov++;
                }


                if (contmov == 3)
                {
                    contmov = 0;
                }
                contatimer++;
            }
            if (planta.Tag == seleccionar_plantas.instance.mario.Tag)
            {
                planta.Image = sprites_mario[0];
                planta.Image = sprites_mario[contmov];
                if (contatimer % 4 == 0)
                {
                    contmov++;
                }


                if (contmov == 3)
                {
                    contmov = 0;
                }
                contatimer++;
            }



        }
        private void game_KeyDown(object sender, KeyEventArgs e)
        {
            


            if (e.KeyCode == Keys.W)
            {
                arriba = true;

            }

            if (e.KeyCode == Keys.S)
            {
                abajo = true;
            }


            if (e.KeyCode == Keys.D)
            {
                der = true;

                if (primeravez == true)
                {
                    rotar = true;
                    primeravez = false;
                }



                if (planta.Tag == seleccionar_plantas.instance.megaman.Tag)
                {

                    if (rotar == false)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            sprites_mega[i].RotateFlip(RotateFlipType.Rotate180FlipY);
                        }
                        rotar = true;


                    }
                }
                if (planta.Tag == seleccionar_plantas.instance.pikachu.Tag)
                {
                    if (rotar == false)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            sprites_pikachu[i].RotateFlip(RotateFlipType.Rotate180FlipY);
                        }
                        rotar = true;
                    }

                }
                if (planta.Tag == seleccionar_plantas.instance.kirby.Tag)
                {
                    if (rotar == false)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            sprites_kirby[i].RotateFlip(RotateFlipType.Rotate180FlipY);
                        }
                        rotar = true;
                    }
                }
                if (planta.Tag == seleccionar_plantas.instance.mario.Tag)
                {
                    if (rotar == false)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            sprites_mario[i].RotateFlip(RotateFlipType.Rotate180FlipY);
                        }
                        rotar = true;
                    }
                }
                if (planta.Tag == seleccionar_plantas.instance.sonic.Tag)
                {
                    if (rotar == false)
                    {
                        for (int i = 0; i < 12; i++)
                        {
                            sprites_sonic[i].RotateFlip(RotateFlipType.Rotate180FlipY);
                        }
                        rotar = true;
                    }

                }
            }

            if (e.KeyCode == Keys.A)
            {



                izq = true;


                if (planta.Tag == seleccionar_plantas.instance.megaman.Tag)
                {

                    if (rotar == true)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            sprites_mega[i].RotateFlip(RotateFlipType.Rotate180FlipY);
                        }
                        rotar = false;

                    }
                }
                if (planta.Tag == seleccionar_plantas.instance.pikachu.Tag)
                {
                    if (rotar == true)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            sprites_pikachu[i].RotateFlip(RotateFlipType.Rotate180FlipY);
                        }
                        rotar = false;
                    }

                }
                if (planta.Tag == seleccionar_plantas.instance.kirby.Tag)
                {
                    if (rotar == true)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            sprites_kirby[i].RotateFlip(RotateFlipType.Rotate180FlipY);
                        }
                        rotar = false;
                    }
                }
                if (planta.Tag == seleccionar_plantas.instance.mario.Tag)
                {
                    if (rotar == true)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            sprites_mario[i].RotateFlip(RotateFlipType.Rotate180FlipY);
                        }
                        rotar = false;
                    }
                }
                if (planta.Tag == seleccionar_plantas.instance.sonic.Tag)
                {
                    if (rotar == true)
                    {
                        for (int i = 0; i < 12; i++)
                        {
                            sprites_sonic[i].RotateFlip(RotateFlipType.Rotate180FlipY);
                        }
                        rotar = false;
                    }





                }
            }


        }



        private void game_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {

                disparo = false;



            }

            if (e.KeyCode == Keys.W)
            {
                arriba = false;
            }

            if (e.KeyCode == Keys.S)
            {
                abajo = false;
            }
            if (e.KeyCode == Keys.D)
            {
                der = false;
                if (planta.Tag == seleccionar_plantas.instance.pikachu.Tag)
                {
                    planta.Image = sprites_pikachu[1];
                }
                if (planta.Tag == seleccionar_plantas.instance.mario.Tag)
                {
                    planta.Image = sprites_mario[0];
                }
                if (planta.Tag == seleccionar_plantas.instance.megaman.Tag)
                {
                    planta.Image = sprites_mega[5];
                }
                if (planta.Tag == seleccionar_plantas.instance.sonic.Tag)
                {
                    planta.Image = sprites_sonic[0];
                }
                if (planta.Tag == seleccionar_plantas.instance.kirby.Tag)
                {
                    planta.Image = sprites_kirby[0];
                }

            }

            if (e.KeyCode == Keys.A)
            {
                izq = false;
                if (planta.Tag == seleccionar_plantas.instance.pikachu.Tag)
                {
                    planta.Image = sprites_pikachu[1];
                }
                if (planta.Tag == seleccionar_plantas.instance.mario.Tag)
                {
                    planta.Image = sprites_mario[0];
                }
                if (planta.Tag == seleccionar_plantas.instance.megaman.Tag)
                {
                    planta.Image = sprites_mega[5];
                }
                if (planta.Tag == seleccionar_plantas.instance.sonic.Tag)
                {
                    planta.Image = sprites_sonic[0];
                }
                if (planta.Tag == seleccionar_plantas.instance.kirby.Tag)
                {
                    planta.Image = sprites_kirby[0];
                }

            }

        }

        private void pnl_yard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }


        private void tmovimientoperso_Tick(object sender, EventArgs e)
        {

         if (contaprogreso > zombies.Length)
            {
                contaprogreso = zombies.Length;
            }
            progressBar1.Value = contaprogreso;

            if (contadanoboss > ProgressBoss.Maximum)
            {
                contadanoboss = ProgressBoss.Maximum;
                efecto_sonido.URL = "pausa.mp3";
                efecto_sonido.controls.play();

                efecto2_sonido.URL = "pausa_back.mp3";
                efecto2_sonido.controls.play();
                efecto2_sonido.settings.setMode("Loop", true);
                tboss.Stop();
                tmovimientoperso.Stop();
                tzombiextreme.Stop();
                tmovimizombie.Stop();
                tzombie.Stop();




                pnl_ganar.Location = new Point(427, 168);
                pnl_ganar.BringToFront();
                pnl_ganar.Focus();

                pnl_ganar.Dock = DockStyle.Fill;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                pnl_ganar.Enabled = true;
            }

            ProgressBoss.Value = contadanoboss;

            if (progressBar1.Value == zombies.Length && actboss==false)
            {
               
                tletrero.Start();
              
            }
            if (bala.Bounds.IntersectsWith(zomboss.Bounds))
            {
                efecto2_sonido.URL = "bala.mp3";
                efecto2_sonido.controls.play();
                contadanoboss++;
                bala.Location = new Point(2000, 2000);
            }
            if (bala2.Bounds.IntersectsWith(zomboss.Bounds))
            {
                efecto2_sonido.URL = "bala.mp3";
                efecto2_sonido.controls.play();
                contadanoboss++;
                bala2.Location = new Point(2000, 2000);

            }
            if (bala3.Bounds.IntersectsWith(zomboss.Bounds))
            {
                efecto2_sonido.URL = "bala.mp3";
                efecto2_sonido.controls.play();
                bala3.Location = new Point(2000, 2000);

                contadanoboss++;
            }
            if (ibala.Bounds.IntersectsWith(zomboss.Bounds))
            {
                efecto2_sonido.URL = "bala.mp3";
                efecto2_sonido.controls.play();
                contadanoboss++;
                ibala.Location = new Point(2000, 2000);

            }
            if (ibala2.Bounds.IntersectsWith(zomboss.Bounds))
            {
                efecto2_sonido.URL = "bala.mp3";
                efecto2_sonido.controls.play();
                contadanoboss++;
                ibala2.Location = new Point(2000, 2000);

            }
            if (ibala3.Bounds.IntersectsWith(zomboss.Bounds))
            {
                efecto2_sonido.URL = "bala.mp3";
                efecto2_sonido.controls.play();
                contadanoboss++;
                ibala3.Location = new Point(2000, 2000);

            }

            if (planta.Bounds.IntersectsWith(barrera.Bounds))
            {
             
                planta.Left+=4;
              
            }


            if (planta.Bounds.IntersectsWith(barrera2.Bounds))
            {

                planta.Top += 4;

            }

            if (planta.Bounds.IntersectsWith(barrera3.Bounds))
            {

                planta.Top -= 4;

            }

            if (planta.Bounds.IntersectsWith(barrera4.Bounds))
            {

                planta.Left -= 4;

            }



            if (na.Bounds.IntersectsWith(barrera.Bounds))
            {

                na.Location = new Point(5000, 5000);

            }
            if (na2.Bounds.IntersectsWith(barrera.Bounds))
            {


                na2.Location = new Point(5000, 5000);

            }
            if (na3.Bounds.IntersectsWith(barrera.Bounds))
            {


                na3.Location = new Point(5000, 5000);

            }
            if (na4.Bounds.IntersectsWith(barrera.Bounds))
            {


                na4.Location = new Point(5000, 5000);

            }
            if (na5.Bounds.IntersectsWith(barrera.Bounds))
            {


                na5.Location = new Point(5000, 5000);

            }
            if (na6.Bounds.IntersectsWith(barrera.Bounds))
            {


                na6.Location = new Point(5000, 5000);

            }
            if (na7.Bounds.IntersectsWith(barrera.Bounds))
            {


                na7.Location = new Point(5000, 5000);

            }
            if (na8.Bounds.IntersectsWith(barrera.Bounds))
            {

                na8.Location = new Point(5000, 5000);
            }
            if (ibala.Bounds.IntersectsWith(barrera.Bounds))
            {

                ibala.Location = new Point(5000, 5000);
            }
            if (ibala2.Bounds.IntersectsWith(barrera.Bounds))
            {

                ibala2.Location = new Point(5000, 5000);
            }
            if (ibala3.Bounds.IntersectsWith(barrera.Bounds))
            {

                ibala3.Location = new Point(5000, 5000);
            }


            if (planta.Bounds.IntersectsWith(zomboss.Bounds))
            {
                muerte += 1;
                planta.Location = posicion_inicio;
                zomboss.Location = new Point(630, 168);
                efecto_sonido.URL = "muerte.mp3";
                efecto_sonido.controls.play();
            }
            if (na.Bounds.IntersectsWith(planta.Bounds))
            {
                na.Location = new Point(2000, 2000);
                muerte += 1;
                planta.Location = posicion_inicio;
                efecto_sonido.URL = "muerte.mp3";
                efecto_sonido.controls.play();
            }
            if (na2.Bounds.IntersectsWith(planta.Bounds))
            {
                na2.Location = new Point(2000, 2000);
                muerte += 1;
                planta.Location = posicion_inicio;
                efecto_sonido.URL = "muerte.mp3";
                efecto_sonido.controls.play();
            }
            if (na3.Bounds.IntersectsWith(planta.Bounds))
            {
                na3.Location = new Point(2000, 2000);
                muerte += 1;
                planta.Location = posicion_inicio;
                efecto_sonido.URL = "muerte.mp3";
                efecto_sonido.controls.play();
            }
            if (na4.Bounds.IntersectsWith(planta.Bounds))
            {
                na4.Location = new Point(2000, 2000);
                muerte += 1;
                planta.Location = posicion_inicio;
                efecto_sonido.URL = "muerte.mp3";
                efecto_sonido.controls.play();
            }
            if (na5.Bounds.IntersectsWith(planta.Bounds))
            {
                na5.Location = new Point(2000, 2000);
                muerte += 1;
                planta.Location = posicion_inicio;
                efecto_sonido.URL = "muerte.mp3";
                efecto_sonido.controls.play();
            }
            if (na6.Bounds.IntersectsWith(planta.Bounds))
            {
                na6.Location = new Point(2000, 2000);
                muerte += 1;
                planta.Location = posicion_inicio;
                efecto_sonido.URL = "muerte.mp3";
                efecto_sonido.controls.play();
            }
            if (na7.Bounds.IntersectsWith(planta.Bounds))
            {
                na7.Location = new Point(2000, 2000);
                muerte += 1;
                planta.Location = posicion_inicio;
                efecto_sonido.URL = "muerte.mp3";
                efecto_sonido.controls.play();
            }
            if (na8.Bounds.IntersectsWith(planta.Bounds))
            {
                na8.Location = new Point(2000, 2000);
                muerte += 1;
                planta.Location = posicion_inicio;
                efecto_sonido.URL = "muerte.mp3";
                efecto_sonido.controls.play();
            }


            for (int i = 0; i < zombies.Length; i++)
                {
                    if (zombies[i] != null)
                    {
                        if (planta.Bounds.IntersectsWith(zombies[i].Bounds))
                        {


                        //this.Controls.Remove(zombies[i]);
                        efecto_sonido.URL = "muerte.mp3";
                        efecto_sonido.controls.play();
                        zombies[i].Dispose();
                        contaprogreso += 1;

                        zombies[i].Location = new Point(1000, 1000);
                        muerte++;
                       // label4.Text = muerte.ToString();
              

                     
                        }

                    if (barrera.Bounds.IntersectsWith(zombies[i].Bounds))
                    {
                        zombies[i].Dispose();
                        zombies[i].Location = new Point(1000, 1000);
                        contaprogreso += 1;
                        muerte += 1;
                      
                    }
                    if (bala.Bounds.IntersectsWith(zombies[i].Bounds))
                    {
                        efecto2_sonido.URL = "bala.mp3";
                        efecto2_sonido.controls.play();
                        bala.Location = new Point(2000, 2000);
                        zombies[i].Location = new Point(1000, 1000);
                        contaprogreso += 1;
                    }
                    if (bala2.Bounds.IntersectsWith(zombies[i].Bounds))
                    {
                        efecto2_sonido.URL = "bala.mp3";
                        efecto2_sonido.controls.play();
                        bala2.Location = new Point(2000, 2000);
                        zombies[i].Location = new Point(1000, 1000);
                        contaprogreso += 1;

                    }
                    if (bala3.Bounds.IntersectsWith(zombies[i].Bounds))
                    {
                        efecto2_sonido.URL = "bala.mp3";
                        efecto2_sonido.controls.play();
                        bala3.Location = new Point(2000, 2000);
                        zombies[i].Location = new Point(1000, 1000);
                        contaprogreso += 1;

                    }
            
                    if (ibala.Bounds.IntersectsWith(zombies[i].Bounds))
                    {
                        contaprogreso += 1;
                        efecto2_sonido.URL = "bala.mp3";
                        efecto2_sonido.controls.play();
                        ibala.Location = new Point(2000, 2000);
                        zombies[i].Location = new Point(1000, 1000);
                    }
                    if (ibala2.Bounds.IntersectsWith(zombies[i].Bounds))
                    {
                        efecto2_sonido.URL = "bala.mp3";
                        efecto2_sonido.controls.play();
                        contaprogreso += 1;
                        ibala2.Location = new Point(2000, 2000);
                        zombies[i].Location = new Point(1000, 1000);
                    }
                    if (ibala3.Bounds.IntersectsWith(zombies[i].Bounds))
                    {
                               efecto2_sonido.URL = "bala.mp3";
                efecto2_sonido.controls.play();
                        contaprogreso += 1;
                        ibala3.Location = new Point(2000, 2000);
                        zombies[i].Location = new Point(2000, 2000);
                    }
             
                }
                }
            
                
          



            switch (muerte)
            {
                case 1:
                    vida4.Visible = false;
                    break;
                case 2:
                    vida3.Visible = false;
                    break;
                case 3:
                    vida2.Visible = false;
                    break;
                case 4:
                    vida1.Visible = false;
                    efecto2_sonido.URL = "gameover.mp3";
                    efecto2_sonido.controls.play();
                    background.controls.stop();

                    muerte muerte = new muerte();
                        muerte.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
            bala.Left += 5;
            bala2.Left += 5;
            bala3.Left += 5;
 

            ibala.Left -= 5;
            ibala2.Left -= 5;
            ibala3.Left -= 5;
           
            if (disparo == true && rotar == false)
            {
                switch (contabalas)
                {
                    case 1:
                        ibala.Left = planta.Left;
                        ibala.Top = planta.Top + 5;
                        break;

                    case 2:
                        ibala2.Left = planta.Left;
                        ibala2.Top = planta.Top + 5;
                        break;
                    case 3:
                        ibala3.Left = planta.Left;
                        ibala3.Top = planta.Top + 5;
                        break;
                 

                }
            }


            if (disparo == true && rotar == true)
            {
                switch (contabalas)
                {
                    case 1:
                        bala.Left = planta.Right;
                        bala.Top = planta.Top + 5;
                        break;

                    case 2:
                        bala2.Left = planta.Right;
                        bala2.Top = planta.Top + 5;
                        break;
                    case 3:
                        bala3.Left = planta.Right;
                        bala3.Top = planta.Top + 5;
                        break;
                
                }
            }
            if (contabalas >= 3)
            {
                contabalas = 0;
            }





            if (arriba == true)
            {

                planta.Top -= 3;
                //ye.Text = planta.Location.Y.ToString();
                movimiento();
            }

            if (abajo == true)
            {

                planta.Top += 3;
              //  ye.Text = planta.Location.Y.ToString();
                movimiento();
            }
            if (der == true)
            {

                planta.Left += 3;
             //   equis.Text = planta.Location.X.ToString();
                movimiento();
            }
            if (izq == true)
            {

                planta.Left -= 3;
                //equis.Text = planta.Location.Y.ToString();
                movimiento();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void game_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                // Mi codigo
                disparo = true;
                contabalas++;

            }
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                if (tzombie.Enabled == true)
                {
                    tzombie.Enabled = false;
                    pausa1 = true;
                }
                if (tmovimientoperso.Enabled == true)
                {
                    tmovimientoperso.Enabled = false;
                    pausa2 = true;

                }
                if (tmovimizombie.Enabled == true)
                {
                    tmovimizombie.Enabled = false;
                    pausa3 = true;

                }
                if (tboss.Enabled == true)
                {
                    tboss.Enabled = false;
                    pausa4 = true;

                }

                background.controls.pause();

                efecto_sonido.URL = "pausa.mp3";
                efecto_sonido.controls.play();

                efecto2_sonido.URL = "pausa_back.mp3";
                efecto2_sonido.controls.play();
                efecto2_sonido.settings.setMode("Loop", true);





                pnl_pausa.Location = new Point(427, 168);
                pnl_pausa.BringToFront();
                pnl_pausa.Focus();
               
                pnl_pausa.Dock = DockStyle.Fill;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                pnl_pausa.Enabled = true;

            }
        }

        private void ibala11_Click(object sender, EventArgs e)
        {

        }

        private void tboss_Tick(object sender, EventArgs e)
        {
    
            na.Left -= 20;
            na2.Left -= 20;
            na3.Left -= 20;
            na4.Left -= 20;
            na5.Left -= 20;
            na6.Left -= 20;
            na7.Left -= 20;
            na8.Left -= 20;
     

            Random random = new Random();

            int posina1 = random.Next(20,40 );
            int posina2 = random.Next(60, 80);
            int posina3 = random.Next(90, 120);
            int posina4 = random.Next(150, 170);
            int posina5 = random.Next(190, 210);
            int posina6 = random.Next(230, 250);
            int posina7 = random.Next(270, 290);
            int posina8 = random.Next(300, 304);

            int posiYzombie = random.Next(15, 400);

            if (dificultad == "normal")
            {
                tboss.Interval = 60;
            }
            if (dificultad == "xtreme")
            {
                tmovimizombie.Interval = 150;
                tboss.Interval = 40;
            
                tmovimizombie.Start();
                tzombiextreme.Start();
            }


            if (zomboss.Location.X > 340 && bosslado==false)
                {
                    zomboss.Left  -=2;
                    
                }
            if (zomboss.Location.X == 340)
            {
                bosslado = true;
            }


            if (zomboss.Location.X < 632 && bosslado==true)
            {
                zomboss.Left += 4;

            }
            if (zomboss.Location.X == 632)
            {
                bosslado = false;
            }


            if (zomboss.Location.Y > -22 && bossarriba == false)
            {
                zomboss.Top -= 2;
            }


            if (zomboss.Location.Y == -22)
            {
                bossarriba = true;
            }

            if (zomboss.Location.Y < 304 && bossarriba == true)

            {
                zomboss.Top += 2;

            }
            if (zomboss.Location.Y == 304)
            {
                bossarriba = false;
            }
            if (zomboss.Location.Y == posina1)
            {
                na.Top = zomboss.Top-10;
                na.Left = zomboss.Left;
                efecto3_sonido.URL = "bala2.mp3";
                efecto3_sonido.controls.play();
            }

            if (zomboss.Location.Y == posina2)
            {
                na2.Top = zomboss.Top - 10;
                na2.Left = zomboss.Left;
                efecto3_sonido.URL = "bala2.mp3";
                efecto3_sonido.controls.play();
            }
            if (zomboss.Location.Y == posina3)
            {
                na3.Top = zomboss.Top - 10;
                na3.Left = zomboss.Left;
                efecto3_sonido.URL = "bala2.mp3";
                efecto3_sonido.controls.play();
            }
            if (zomboss.Location.Y == posina4)
            {
                na4.Top = zomboss.Top - 10;
                na4.Left = zomboss.Left;
                efecto3_sonido.URL = "bala2.mp3";
                efecto3_sonido.controls.play();
            }
            if (zomboss.Location.Y == posina5)
            {
                na5.Top = zomboss.Top - 10;
                na5.Left = zomboss.Left;
                efecto3_sonido.URL = "bala2.mp3";
                efecto3_sonido.controls.play();
            }
            if (zomboss.Location.Y == posina6)
            {
                na6.Top = zomboss.Top - 10;
                na6.Left = zomboss.Left;
                efecto3_sonido.URL = "bala2.mp3";
                efecto3_sonido.controls.play();
            }
            if (zomboss.Location.Y == posina7)
            {
                na7.Top = zomboss.Top - 10;
                na7.Left = zomboss.Left;
                efecto3_sonido.URL = "bala2.mp3";
                efecto3_sonido.controls.play();
            }
            if (zomboss.Location.Y == posina8)
            {
                na8.Top = zomboss.Top - 10;
                na8.Left = zomboss.Left;
                efecto3_sonido.URL = "bala2.mp3";
                efecto3_sonido.controls.play();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the game?", "Plants vs zombies", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
                background.controls.stop();
                efecto_sonido.controls.stop();
                efecto2_sonido.controls.stop();
                efecto2_sonido.settings.setMode("Loop", false);

            }
            else if (result == DialogResult.No)
            {
               

                efecto_sonido.controls.stop();
            }
       
     
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go to main menu?", "Plants vs zombies", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                main_menu main_Menu = new main_menu();
                main_Menu.Show();
                this.Close();
                background.controls.stop();

                efecto_sonido.controls.stop();
                efecto2_sonido.controls.stop();
                efecto2_sonido.settings.setMode("Loop", false);

            }
            else if (result == DialogResult.No)
            {
                efecto_sonido.controls.stop();
            }

        }

        private void pnl_pausa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (pausa1 == true)
            {
                tzombie.Enabled = true;
                pausa1 = false;
            }
            if (pausa2 == true)
            {
                tmovimientoperso.Enabled = true;
                pausa2 = false;

            }
            if (pausa3 == true)
            {
                tmovimizombie.Enabled = true;
                pausa3 = false;

            }
            if (pausa4 == true)
            {
                tboss.Enabled = true;
                pausa4 = false;

            }
            efecto_sonido.controls.stop();
            efecto2_sonido.controls.stop();
            efecto2_sonido.settings.setMode("Loop", false);
            background.controls.play();

            pnl_pausa.Location = new Point(1000,1000) ;
            pnl_pausa.SendToBack();
            pnl_pausa.Enabled = false;
            pnl_pausa.Dock = DockStyle.None;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            this.Focus();
            this.BringToFront();
            this.Activate();
        }

        private void barrera4_Click(object sender, EventArgs e)
        {

        }

        private void barrera3_Click(object sender, EventArgs e)
        {

        }

        private void tzombiextreme_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int posiYzombie = random.Next(15, 400);

         

            if (nZombiesANDtimer == 20)
            {
                tzombiextreme.Stop();
            }


                zombies[nZombiesANDtimer].Location = new Point(786, posiYzombie);
            zombies[nZombiesANDtimer].Image = Properties.Resources.zombie_fijo;
            zombies[nZombiesANDtimer].SendToBack();
            nZombiesANDtimer++;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go to main menu?", "Plants vs zombies", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                main_menu main_Menu = new main_menu();
                main_Menu.Show();
                this.Close();
                background.controls.stop();

                efecto_sonido.controls.stop();
                efecto2_sonido.controls.stop();
                efecto2_sonido.settings.setMode("Loop", false);

            }
            else if (result == DialogResult.No)
            {
                efecto_sonido.controls.stop();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the game?", "Plants vs zombies", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
                background.controls.stop();
                efecto_sonido.controls.stop();
                efecto2_sonido.controls.stop();
                efecto2_sonido.settings.setMode("Loop", false);

            }
            else if (result == DialogResult.No)
            {


                efecto_sonido.controls.stop();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pausa1 == true)
            {
                tzombie.Enabled = true;
                pausa1 = false;
            }
            if (pausa2 == true)
            {
                tmovimientoperso.Enabled = true;
                pausa2 = false;

            }
            if (pausa3 == true)
            {
                tmovimizombie.Enabled = true;
                pausa3 = false;

            }
            if (pausa4 == true)
            {
                tboss.Enabled = true;
                pausa4 = false;

            }
            efecto_sonido.controls.stop();
            efecto2_sonido.controls.stop();
            efecto2_sonido.settings.setMode("Loop", false);
            background.controls.play();

            pnl_ganar.Location = new Point(1000, 1000);
            pnl_ganar.SendToBack();
            pnl_ganar.Enabled = false;
            pnl_ganar.Dock = DockStyle.None;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            this.Focus();
            this.BringToFront();
            this.Activate();
        }
    }
    }


