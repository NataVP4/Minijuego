namespace VegaJuego
{
    partial class Level1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            MovEnemigo1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            labelVida = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            Escudo = new Label();
            Arma = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // MovEnemigo1
            // 
            MovEnemigo1.Enabled = true;
            MovEnemigo1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.salud;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(587, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 39);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelVida
            // 
            labelVida.AutoSize = true;
            labelVida.BackColor = Color.Transparent;
            labelVida.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelVida.ForeColor = Color.Gold;
            labelVida.Location = new Point(634, 145);
            labelVida.Name = "labelVida";
            labelVida.Size = new Size(48, 23);
            labelVida.TabIndex = 1;
            labelVida.Text = "Vida";
            labelVida.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.escudo;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(587, 178);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 39);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.Arma;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(587, 225);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 39);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // Escudo
            // 
            Escudo.AutoSize = true;
            Escudo.BackColor = Color.Transparent;
            Escudo.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Escudo.ForeColor = Color.Gold;
            Escudo.Location = new Point(636, 190);
            Escudo.Name = "Escudo";
            Escudo.Size = new Size(68, 23);
            Escudo.TabIndex = 6;
            Escudo.Text = "Escudo";
            Escudo.Click += label1_Click_2;
            // 
            // Arma
            // 
            Arma.AutoSize = true;
            Arma.BackColor = Color.Transparent;
            Arma.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Arma.ForeColor = Color.Gold;
            Arma.Location = new Point(637, 232);
            Arma.Name = "Arma";
            Arma.Size = new Size(56, 23);
            Arma.TabIndex = 7;
            Arma.Text = "Arma";
            // 
            // Level1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoFinal1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(804, 459);
            Controls.Add(Arma);
            Controls.Add(Escudo);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(labelVida);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Level1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VegaZelda";
            KeyPress += Level1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer MovEnemigo1;
        private PictureBox pictureBox1;
        private Label labelVida;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label Escudo;
        private Label Arma;
    }
}