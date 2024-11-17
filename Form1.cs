using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Navidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmBienvenida frm = new frmBienvenida();
            frm.ShowDialog();

            { // Crea un GraphicsPath
                GraphicsPath path = new GraphicsPath();
                // Define el tamaño del botón
                int width = button1.Width;
                int height = button1.Height;
                // Añade el arco superior
                path.AddArc(0, 0, width, width, 180, 180);
                // Añade la parte rectangular inferior
                path.AddRectangle(new Rectangle(0, width / 2, width, height - (width / 2)));
                // Establece la región del botón a la nueva forma
                button1.Region = new Region(path);


                SoundPlayer Player = new SoundPlayer();//Nombrar la variable de sonido
                //Ruta de acceso de la canción para poder reproducirse
                Player.SoundLocation = "E:\\Imagenes Proyecto\\Frank-Sinatra-Jingle-Bells.wav";
                Player.Play();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();//Esconder formulario
            frmInterior frm = new frmInterior();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
