using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navidad
{
    public partial class frmInterior : Form
    {
        //fecha para contador y pino
        private DateTime targetDate = new DateTime(DateTime.Now.Year, 12, 25, 00, 00, 00);
        string fecha = DateTime.Today.ToString("dd/MM");
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int tiempoTranscurridoSegundos;
        private const int totalSegundos = 30; 

        public frmInterior()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            ConfigurarTemporizador();
            MostrarPinoConOpacidad();
        }

        private void frmInterior_Load(object sender, EventArgs e)
        {
            
            switch (fecha)
            {
                case "25/12":
                    btnRegaloHomero.Enabled = true;
                    btnRegaloMaggie.Enabled = true;
                    btnRegaloLisa.Enabled = true;
                    btnRegaloBart.Enabled = true;
                    btnRegaloMarch.Enabled = true;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempoRestante = targetDate - DateTime.Now;

            if (tiempoRestante.TotalSeconds > 0)
            {
                lblCuentaRegresiva.Text = $"{tiempoRestante.Days}        {tiempoRestante.Hours} : {tiempoRestante.Minutes} : {tiempoRestante.Seconds}";
            }
            else
            {
                timer1.Stop();
                frmDespedida25 frm = new frmDespedida25();
                frm.ShowDialog();
            }
        }

        private void btnRegaloHomero_Click(object sender, EventArgs e)
        {
            frmRegaloHomero frm = new frmRegaloHomero();
            frm.Show();
        }

        private void btnRegaloLisa_Click(object sender, EventArgs e)
        {
            frmRegaloLisa frm = new frmRegaloLisa();
            frm.Show();
        }

        private void btnRegaloMaggie_Click(object sender, EventArgs e)
        {
            frmRegaloMaggie frm = new frmRegaloMaggie();
            frm.Show();
        }

        private void btnRegaloBart_Click(object sender, EventArgs e)
        {
            frmRegaloBart frm = new frmRegaloBart();
            frm.Show();
        }

        private void btnRegaloMarch_Click(object sender, EventArgs e)
        {
            frmRegaloMarch frm = new frmRegaloMarch();
            frm.Show();
        }

        private void ConfigurarTemporizador()
        {
            // Configura el temporizador para que ejecute cada segundo
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            tiempoTranscurridoSegundos++;
            MostrarPinoConOpacidad();

            // Detener el temporizador una vez que pasa 1 minutos
            if (tiempoTranscurridoSegundos >= totalSegundos)
            {
                timer.Stop();
            }
        }

        private void MostrarPinoConOpacidad()
        {
            // Calcular el nivel de opacidad en función del tiempo transcurrido
            float opacidad = Math.Min((float)tiempoTranscurridoSegundos / totalSegundos, 1.0f);

            // Cargar la imagen y establecer su opacidad
            pictureBoxPino.Image = AjustarOpacidad(new Bitmap("E:\\Navidad\\pino1.2.1-removebg-preview-removebg-preview.png"), opacidad);
            Console.WriteLine("Opacidad actual: " + opacidad); // Para verificar en la consola
        }

        private Bitmap AjustarOpacidad(Bitmap imagenOriginal, float opacidad)
        {
            Bitmap imagenOpaca = new Bitmap(imagenOriginal.Width, imagenOriginal.Height);
            using (Graphics g = Graphics.FromImage(imagenOpaca))
            {
                ColorMatrix colorMatrix = new ColorMatrix
                {
                    Matrix33 = opacidad // Controla la transparencia de la imagen
                };
                ImageAttributes atributos = new ImageAttributes();
                atributos.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(imagenOriginal,
                    new Rectangle(0, 0, imagenOriginal.Width, imagenOriginal.Height),
                    0, 0, imagenOriginal.Width, imagenOriginal.Height,
                    GraphicsUnit.Pixel,
                    atributos);
            }
            return imagenOpaca;
        }

    private void btnSalida_Click(object sender, EventArgs e)
        {
           this.Close(); 
        }
    }
}
