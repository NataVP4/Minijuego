namespace VegaJuego
{
    partial class PantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            Button1 = new Button();
            CheckSonido = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.LogoBueno;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(15, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 123);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.ZeldaLogo;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(367, 99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(243, 97);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(405, 74);
            label2.Name = "label2";
            label2.Size = new Size(163, 17);
            label2.TabIndex = 4;
            label2.Text = "Creado por Natalia Vidal";
            // 
            // Button1
            // 
            Button1.BackColor = Color.Black;
            Button1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button1.ForeColor = Color.Gold;
            Button1.Image = Properties.Resources.Boton;
            Button1.ImageAlign = ContentAlignment.MiddleLeft;
            Button1.Location = new Point(288, 375);
            Button1.Name = "Button1";
            Button1.Size = new Size(268, 45);
            Button1.TabIndex = 6;
            Button1.Text = "Comienza la aventura";
            Button1.TextAlign = ContentAlignment.MiddleRight;
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += Button1_Click;
            // 
            // CheckSonido
            // 
            CheckSonido.AutoSize = true;
            CheckSonido.BackColor = Color.Transparent;
            CheckSonido.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CheckSonido.Location = new Point(427, 209);
            CheckSonido.Name = "CheckSonido";
            CheckSonido.Size = new Size(129, 21);
            CheckSonido.TabIndex = 7;
            CheckSonido.Text = "Sonido: ON/OFF";
            CheckSonido.UseVisualStyleBackColor = false;
            // 
            // PantallaInicio
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.FondoPantalla;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(669, 467);
            Controls.Add(CheckSonido);
            Controls.Add(Button1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PantallaInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaInicio";
            HelpButtonClicked += PantallaInicio_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Button Button1;
        private CheckBox CheckSonido;
    }
}