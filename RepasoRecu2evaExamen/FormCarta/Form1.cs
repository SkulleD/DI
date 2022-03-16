using RepasoRecu2evaExamen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCarta
{
    public partial class Form1 : Form
    {
        private Carta[] cartas;
        private string[] imagenes;
        int miCarta = 0;
        Random rand = new Random();
        string ruta = Environment.GetEnvironmentVariable("USERPROFILE");

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(ruta);
            cartas = new Carta[] { cartaPiedra, cartaPapel, cartaTijera };
            imagenes = new string[] { ruta + "\\piedra.png", ruta + "\\papel.png", ruta + "\\tijera.png" };
            rbPiedra.Tag = 0;
            rbPapel.Tag = 1;
            rbTijera.Tag = 2;
        }

        private void Carta_AlcanzaMax(object sender, EventArgs e)
        {
            Carta c = (Carta)sender;
            c.Valor = 0;
            c.Nivel++;
        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            miCarta = (int)((RadioButton)sender).Tag;
        }

        private bool ganar(int carta1, int carta2)
        {
            return carta1 == 0 && carta2 == 2 ||
                   carta1 == 1 && carta2 == 0 ||
                   carta1 == 2 && carta2 == 1;

        }

        private int x = 0;
        private void btnJugar_Click(object sender, EventArgs e)
        {
            Carta cartaJugador = cartas[miCarta];
            int numeroCPU = rand.Next(3);

            cartaCPU.Imagen = Image.FromFile(imagenes[numeroCPU]);
            cartaCPU.Nivel = cartaJugador.Nivel - 1 + rand.Next(3);
            cartaCPU.Valor = 0;
            lblResult.Text = "Empate";

            if (ganar(miCarta, numeroCPU))
            {
                if (cartaJugador.Nivel >= cartaCPU.Nivel)
                {
                    lblResult.Text = "Jugador gana!";
                }
            }
            else
            {
                if (ganar(numeroCPU, miCarta))
                {
                    if (cartaJugador.Nivel <= cartaCPU.Nivel)
                    {
                        lblResult.Text = "CPU gana!";
                    }
                }
            }

            cartaJugador.Valor += rand.Next(10, 21);

            panel1.Controls.Add(new Carta(cartaJugador.Imagen, cartaJugador.Valor, cartaJugador.Nivel, x, 0, 40, 70));
            panel1.Controls.Add(new Carta(cartaCPU.Imagen, cartaCPU.Valor, cartaCPU.Nivel, x, 90, 40, 70));
            x += 50;
        }
    }
}
