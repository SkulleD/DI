using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormCartas
{
    public partial class Form1 : Form
    {
        //string ruta = System.Environment.GetEnvironmentVariable("%USERPROFILE%");
        object[] cartas;
        Image[] imagenes;
        Random random = new Random();
        int cartaElegida = 0;
        int cartaElegidaRival = 0;

        public Form1()
        {
            InitializeComponent();
            cartas = new object[] { carta1, carta2, carta3 };
            imagenes = new Image[] { carta1.Imagen, carta2.Imagen, carta3.Imagen };
            rb1.Tag = 0;
            rb2.Tag = 1;
            rb3.Tag = 2;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            cartaElegida = (int)((RadioButton)sender).Tag;
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            cartaElegidaRival = random.Next(3);
            cartaRival.Imagen = imagenes[cartaElegidaRival];
        }
    }
}