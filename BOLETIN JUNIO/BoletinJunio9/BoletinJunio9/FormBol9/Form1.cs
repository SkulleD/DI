using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBol9
{
    public partial class Form1 : Form
    {
        private string palabra; // La palabra a adivinar
        private string palabraRellenada; // Un string con solo subrayada la longitud de la palabra a adiniviar
        private char[] arrayLetras = { }; // Array de chars que ayudan a ir cambiando la palabra según se va acertando letras

        public Form1()
        {
            InitializeComponent();
            palabra = "PROGRAMACION";
            palabraRellenada = "";
            lblUsadas.Text += "\r\n";

            DibujaPalabra(' ');
            SubrayaPalabra();
        }

        private void btnUsarLetra_Click(object sender, EventArgs e)
        {
            char letra;

            if (!string.IsNullOrWhiteSpace(txtLetra.Text) && txtLetra.Text.Length == 1)
            {
                if (palabra.Contains(txtLetra.Text.ToUpper()))
                {
                    letra = char.Parse(txtLetra.Text.ToUpper());
                    DibujaPalabra(letra);
                }
                else
                {
                    dibujoAhorcado1.Errores++;
                    lblUsadas.Text += $"{txtLetra.Text.ToUpper()}, ";
                }

                txtLetra.Text = "";
                txtLetra.Select();
            }
        }

        private void dibujoAhorcado1_CambiaError(object sender, EventArgs e)
        {

        }

        private void dibujoAhorcado1_Ahorcado(object sender, EventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dibujoAhorcado1.Errores = 0;
            lblUsadas.Text = "\r\n";
            DibujaPalabra(' ');
        }

        private void DibujaPalabra(char letra)
        {
            for (int i = 0; i <= palabra.Length - 1; i++)
            {
                if (palabra[i]==letra)
                {
                    arrayLetras[i] = letra;
                }

                // lblPalabra.Text += $"{arrayLetras[i]} "; // IndexOutOfRangeException
                string letrasPalabra = new string(arrayLetras);
                lblPalabra.Text = letrasPalabra;
            }
        }

        private void SubrayaPalabra() // Iniciar subrayado de palabra
        {
            for (int i = 0; i <= palabra.Length - 1; i++)
            {
                palabraRellenada += "_ ";
            }

            arrayLetras = palabraRellenada.ToCharArray();
            lblPalabra.Text = palabraRellenada;

            //for (int i = 0; i <= palabra.Length - 1; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        lblPalabra.Text += arrayLetras[i];
            //    }
            //    else
            //    {
            //        lblPalabra.Text += " ";
            //    }
            //}
        }
    }
}