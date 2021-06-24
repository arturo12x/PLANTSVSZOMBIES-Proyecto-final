namespace PLANTSVSZOMBIES
{
    partial class seleccionar_plantas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.megaman = new System.Windows.Forms.Button();
            this.pikachu = new System.Windows.Forms.Button();
            this.sonic = new System.Windows.Forms.Button();
            this.mario = new System.Windows.Forms.Button();
            this.kirby = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(68)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 423);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.megaman);
            this.panel2.Controls.Add(this.pikachu);
            this.panel2.Controls.Add(this.sonic);
            this.panel2.Controls.Add(this.mario);
            this.panel2.Controls.Add(this.kirby);
            this.panel2.Location = new System.Drawing.Point(12, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 365);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(68)))), ((int)(((byte)(16)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Colonna MT", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(16)))));
            this.button1.Location = new System.Drawing.Point(144, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "LETS ROCK!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // megaman
            // 
            this.megaman.BackgroundImage = global::PLANTSVSZOMBIES.Properties.Resources.mm2;
            this.megaman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.megaman.Location = new System.Drawing.Point(330, 177);
            this.megaman.Name = "megaman";
            this.megaman.Size = new System.Drawing.Size(90, 106);
            this.megaman.TabIndex = 4;
            this.megaman.Tag = "megaman";
            this.megaman.UseVisualStyleBackColor = true;
            this.megaman.Click += new System.EventHandler(this.megaman_Click);
            // 
            // pikachu
            // 
            this.pikachu.BackgroundImage = global::PLANTSVSZOMBIES.Properties.Resources.p1;
            this.pikachu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pikachu.Location = new System.Drawing.Point(40, 177);
            this.pikachu.Name = "pikachu";
            this.pikachu.Size = new System.Drawing.Size(90, 106);
            this.pikachu.TabIndex = 3;
            this.pikachu.Tag = "pikachu";
            this.pikachu.UseVisualStyleBackColor = true;
            this.pikachu.Click += new System.EventHandler(this.pikachu_Click);
            // 
            // sonic
            // 
            this.sonic.BackgroundImage = global::PLANTSVSZOMBIES.Properties.Resources.s1;
            this.sonic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sonic.Location = new System.Drawing.Point(330, 17);
            this.sonic.Name = "sonic";
            this.sonic.Size = new System.Drawing.Size(90, 106);
            this.sonic.TabIndex = 2;
            this.sonic.Tag = "sonic";
            this.sonic.UseVisualStyleBackColor = true;
            this.sonic.Click += new System.EventHandler(this.sonic_Click);
            // 
            // mario
            // 
            this.mario.BackgroundImage = global::PLANTSVSZOMBIES.Properties.Resources.m0;
            this.mario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mario.Location = new System.Drawing.Point(183, 108);
            this.mario.Name = "mario";
            this.mario.Size = new System.Drawing.Size(90, 106);
            this.mario.TabIndex = 1;
            this.mario.Tag = "mario";
            this.mario.UseVisualStyleBackColor = true;
            this.mario.Click += new System.EventHandler(this.mario_Click);
            // 
            // kirby
            // 
            this.kirby.BackgroundImage = global::PLANTSVSZOMBIES.Properties.Resources.k0;
            this.kirby.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kirby.Location = new System.Drawing.Point(40, 17);
            this.kirby.Name = "kirby";
            this.kirby.Size = new System.Drawing.Size(90, 106);
            this.kirby.TabIndex = 0;
            this.kirby.Tag = "kirby";
            this.kirby.UseVisualStyleBackColor = true;
            this.kirby.Click += new System.EventHandler(this.kirby_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(16)))));
            this.label1.Location = new System.Drawing.Point(29, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your plants";
            // 
            // seleccionar_plantas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(467, 423);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "seleccionar_plantas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "seleccionar_plantas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button kirby;
        public System.Windows.Forms.Button megaman;
        public System.Windows.Forms.Button pikachu;
        public System.Windows.Forms.Button sonic;
        public System.Windows.Forms.Button mario;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
    }
}