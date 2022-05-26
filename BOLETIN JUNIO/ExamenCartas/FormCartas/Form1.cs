using ExamenCartas;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormCartas
{
    public partial class Form1 : Form
    {
        //string ruta = System.Environment.GetEnvironmentVariable("%USERPROFILE%");
        Carta[] cartas;
        Image[] imagenes;
        Random random = new Random();
        int cartaElegida = 0;
        int cartaElegidaRival = 0;

        public Form1()
        {
            InitializeComponent();
            cartas = new Carta[] { carta1, carta2, carta3 };
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
            Carta miCarta = cartas[cartaElegida];
            cartaElegidaRival = random.Next(3); // Saca un num aleatorio entre 0 y 2 para asignarle carta a la CPU.
            cartaRival.Imagen = imagenes[cartaElegidaRival]; // Se asigna la carta de piedra, papel o tijera a la CPU.
            cartaRival.Nivel = miCarta.Nivel - 1 + random.Next(3); // El nivel de la carta rival será el de tu carta +- 1.
            cartaRival.Valor = 0;

            lblResult.Text = "Empate"; // Si alguno de los 2 gana esto se sobreescribe al instante, si no se queda así.

            if (Ganar(cartaElegida, cartaElegidaRival))
            {
                if (miCarta.Nivel >= cartaRival.Nivel)
                {
                    lblResult.Text = "¡Has ganado!";
                }
            }
            else
            {
                if (Ganar(cartaElegidaRival, cartaElegida))
                {
                    if (miCarta.Nivel <= cartaRival.Nivel)
                    {
                        lblResult.Text = "¡Has perdido!";
                    }
                }
            }

            miCarta.Valor += random.Next(10, 21); // La carta jugada obtiene entre 10 y 20 puntos de experiencia.
        }

        private bool Ganar(int cartaPlayer, int cartaCPU)
        {
            return cartaPlayer == 0 && cartaCPU == 2 || // Player Piedra vs CPU Tijera: Ganas
                   cartaPlayer == 1 && cartaCPU == 0 || // Player Papel vs CPU Piedra: Ganas
                   cartaPlayer == 2 && cartaCPU == 1;   // Player Tijera vs CPU Papel: Ganas
        }

        private void carta1_AlcanzaMax(object sender, EventArgs e) // Se actualizan el Valor y Nivel de las cartas que se juegan.
        {
            Carta carta = (Carta)sender;
            carta.Valor = 0;
            carta.Nivel++;
        }
    }
}