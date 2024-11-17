namespace Navidad
{
    partial class frmInterior
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInterior));
            btnRegaloHomero = new Button();
            btnRegaloMaggie = new Button();
            btnRegaloLisa = new Button();
            lblCuentaRegresiva = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnRegaloBart = new Button();
            btnRegaloMarch = new Button();
            btnSalida = new Button();
            pictureBoxPino = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPino).BeginInit();
            SuspendLayout();
            // 
            // btnRegaloHomero
            // 
            btnRegaloHomero.BackColor = Color.Transparent;
            btnRegaloHomero.BackgroundImage = (Image)resources.GetObject("btnRegaloHomero.BackgroundImage");
            btnRegaloHomero.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegaloHomero.Enabled = false;
            btnRegaloHomero.FlatAppearance.BorderSize = 0;
            btnRegaloHomero.FlatStyle = FlatStyle.Flat;
            btnRegaloHomero.Location = new Point(30, 776);
            btnRegaloHomero.Name = "btnRegaloHomero";
            btnRegaloHomero.Size = new Size(171, 152);
            btnRegaloHomero.TabIndex = 0;
            btnRegaloHomero.UseVisualStyleBackColor = false;
            btnRegaloHomero.Click += btnRegaloHomero_Click;
            // 
            // btnRegaloMaggie
            // 
            btnRegaloMaggie.BackColor = Color.Transparent;
            btnRegaloMaggie.BackgroundImage = (Image)resources.GetObject("btnRegaloMaggie.BackgroundImage");
            btnRegaloMaggie.BackgroundImageLayout = ImageLayout.Zoom;
            btnRegaloMaggie.Enabled = false;
            btnRegaloMaggie.FlatAppearance.BorderSize = 0;
            btnRegaloMaggie.FlatStyle = FlatStyle.Flat;
            btnRegaloMaggie.Location = new Point(333, 835);
            btnRegaloMaggie.Name = "btnRegaloMaggie";
            btnRegaloMaggie.Size = new Size(151, 115);
            btnRegaloMaggie.TabIndex = 1;
            btnRegaloMaggie.UseVisualStyleBackColor = false;
            btnRegaloMaggie.Click += btnRegaloMaggie_Click;
            // 
            // btnRegaloLisa
            // 
            btnRegaloLisa.BackColor = Color.Transparent;
            btnRegaloLisa.BackgroundImage = (Image)resources.GetObject("btnRegaloLisa.BackgroundImage");
            btnRegaloLisa.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegaloLisa.Enabled = false;
            btnRegaloLisa.FlatAppearance.BorderSize = 0;
            btnRegaloLisa.FlatStyle = FlatStyle.Flat;
            btnRegaloLisa.Location = new Point(201, 815);
            btnRegaloLisa.Name = "btnRegaloLisa";
            btnRegaloLisa.Size = new Size(151, 128);
            btnRegaloLisa.TabIndex = 2;
            btnRegaloLisa.UseVisualStyleBackColor = false;
            btnRegaloLisa.Click += btnRegaloLisa_Click;
            // 
            // lblCuentaRegresiva
            // 
            lblCuentaRegresiva.AutoSize = true;
            lblCuentaRegresiva.BackColor = Color.White;
            lblCuentaRegresiva.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCuentaRegresiva.Location = new Point(1091, 120);
            lblCuentaRegresiva.Name = "lblCuentaRegresiva";
            lblCuentaRegresiva.Size = new Size(197, 35);
            lblCuentaRegresiva.TabIndex = 5;
            lblCuentaRegresiva.Text = "0         00 : 00 : 00";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MV Boli", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(1000, 9);
            label1.Name = "label1";
            label1.Size = new Size(419, 37);
            label1.TabIndex = 6;
            label1.Text = "¿Cuánto falta para navidad?";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1042, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1092, 94);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 8;
            label2.Text = "D           H     M     S    ";
            // 
            // btnRegaloBart
            // 
            btnRegaloBart.BackColor = Color.Transparent;
            btnRegaloBart.BackgroundImage = (Image)resources.GetObject("btnRegaloBart.BackgroundImage");
            btnRegaloBart.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegaloBart.Enabled = false;
            btnRegaloBart.FlatAppearance.BorderSize = 0;
            btnRegaloBart.FlatStyle = FlatStyle.Flat;
            btnRegaloBart.Location = new Point(467, 833);
            btnRegaloBart.Name = "btnRegaloBart";
            btnRegaloBart.Size = new Size(151, 121);
            btnRegaloBart.TabIndex = 10;
            btnRegaloBart.UseVisualStyleBackColor = false;
            btnRegaloBart.Click += btnRegaloBart_Click;
            // 
            // btnRegaloMarch
            // 
            btnRegaloMarch.BackColor = Color.Transparent;
            btnRegaloMarch.BackgroundImage = (Image)resources.GetObject("btnRegaloMarch.BackgroundImage");
            btnRegaloMarch.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegaloMarch.Enabled = false;
            btnRegaloMarch.FlatAppearance.BorderSize = 0;
            btnRegaloMarch.FlatStyle = FlatStyle.Flat;
            btnRegaloMarch.Location = new Point(614, 797);
            btnRegaloMarch.Name = "btnRegaloMarch";
            btnRegaloMarch.Size = new Size(195, 163);
            btnRegaloMarch.TabIndex = 9;
            btnRegaloMarch.UseVisualStyleBackColor = false;
            btnRegaloMarch.Click += btnRegaloMarch_Click;
            // 
            // btnSalida
            // 
            btnSalida.BackColor = Color.Transparent;
            btnSalida.Image = (Image)resources.GetObject("btnSalida.Image");
            btnSalida.Location = new Point(1348, 768);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(111, 168);
            btnSalida.TabIndex = 11;
            btnSalida.UseVisualStyleBackColor = false;
            btnSalida.Click += btnSalida_Click;
            // 
            // pictureBoxPino
            // 
            pictureBoxPino.BackColor = Color.Transparent;
            pictureBoxPino.Image = (Image)resources.GetObject("pictureBoxPino.Image");
            pictureBoxPino.Location = new Point(55, 86);
            pictureBoxPino.Name = "pictureBoxPino";
            pictureBoxPino.Size = new Size(602, 787);
            pictureBoxPino.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPino.TabIndex = 12;
            pictureBoxPino.TabStop = false;
            // 
            // frmInterior
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1471, 940);
            Controls.Add(btnRegaloLisa);
            Controls.Add(btnRegaloBart);
            Controls.Add(btnRegaloMarch);
            Controls.Add(btnRegaloMaggie);
            Controls.Add(btnRegaloHomero);
            Controls.Add(pictureBoxPino);
            Controls.Add(btnSalida);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCuentaRegresiva);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInterior";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "3";
            Load += frmInterior_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPino).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegaloHomero;
        private Button btnRegaloMaggie;
        private Button btnRegaloLisa;
        private Label lblCuentaRegresiva;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnRegaloBart;
        private Button btnRegaloMarch;
        private Button btnSalida;
        private PictureBox pictureBoxPino;
    }
}