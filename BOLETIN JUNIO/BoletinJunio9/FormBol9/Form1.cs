using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBol9
{
    public partial class Form1 : Form
    {
        private string palabra; // La palabra a adivinar
        private string subrayado; // Un string con solo subrayada la longitud de la palabra a adivinar que se muestra al principio en el TextBox
        private string subrayaArrayLetras; // String que es igual que el otro subrayado pero sin espacios. Se usa para rellenar arrayLetras
        private char[] arrayLetras = { }; // Array de chars que ayudan a ir cambiando la palabra según se va acertando letras
        private string rutaPalabras = Directory.GetCurrentDirectory() + "\\palabras.txt";
        private string[] arrayPalabras;

        public Form1()
        {
            InitializeComponent();
            palabra = txtAdivinar.Text;
            subrayado = "";
            subrayaArrayLetras = "";
            lblUsadas.Text += "\r\n";

            btnUsarLetra.Enabled = false;
            txtLetra.Enabled = false;
            SubrayaPalabra();
            DibujaPalabra(' ');
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            palabra = "";
            arrayLetras = palabra.ToCharArray(); // Se reinicia el array de letras

            if (!string.IsNullOrWhiteSpace(txtAdivinar.Text))
            {
                palabra = txtAdivinar.Text.ToUpper();

            } else
            {
                arrayPalabras = File.ReadAllLines(rutaPalabras);
                Random random = new Random();
                int rand = random.Next(0, arrayPalabras.Length + 10);

                for (int i = 0; i < rand; i++)
                {
                    palabra = arrayPalabras[i];
                }
            }

            txtAdivinar.Text = "";
            txtAdivinar.Enabled = false;
            btnJugar.Enabled = true;
            btnUsarLetra.Enabled = true;
            txtLetra.Enabled = true;

            SubrayaPalabra();

            btnJugar.Enabled = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dibujoAhorcado1.Errores = 0;
            lblUsadas.Text = "Letras erróneas usadas: \r\n";
            lblResult.Text = "";
            lblFallos.Text = "Fallos: ";
            txtAdivinar.Enabled = true;
            btnJugar.Enabled = true;
            btnUsarLetra.Enabled = false;
            txtLetra.Enabled = false;

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
                    lblFallos.Text = $"Fallos: {dibujoAhorcado1.Errores++}";
                    lblUsadas.Text += $"{txtLetra.Text.ToUpper()}, ";
                }

                txtLetra.Text = "";
                txtLetra.Select();
            }

            string letrasString = new string(arrayLetras);

            if (letrasString.Equals(palabra))
            {
                lblResult.Text = "Has ganado!";
                txtLetra.Enabled = false;
                btnUsarLetra.Enabled = false;
            }
        }

        private void dibujoAhorcado1_CambiaError(object sender, EventArgs e)
        {

        }

        private void dibujoAhorcado1_Ahorcado(object sender, EventArgs e)
        {
            lblResult.Text = "Has perdido.";
            txtLetra.Enabled = false;
            btnUsarLetra.Enabled = false;
        }

        private void DibujaPalabra(char letra)
        {
            for (int i = 0; i <= palabra.Length - 1; i++) // Se comprueba que la letra del TextBox coincida con alguna que tenga la palabra y si coincide se guarda
            {
                if (palabra[i] == letra)
                {
                    arrayLetras[i] = letra;
                }
            }

            lblPalabra.Text = "";

            foreach (char chara in arrayLetras)
            {
                if (chara != '_')
                {
                    lblPalabra.Text += $"{chara} ";
                }
                else
                {
                    lblPalabra.Text += "_ ";
                }
            }
        }

        private void SubrayaPalabra() // Iniciar subrayado de palabra
        {
            arrayLetras = new char[palabra.Length];
            subrayado = "";
            subrayaArrayLetras = "";
            lblPalabra.Text = "";
            txtAdivinar.Text = "";

            for (int i = 0; i <= palabra.Length - 1; i++) // Se crean los subrayados de las letras
            {
                subrayado += "_ ";
                subrayaArrayLetras += "_";
            }

            arrayLetras = subrayaArrayLetras.ToCharArray();
            lblPalabra.Text = subrayado;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ahorcado", "¿Salir del programa?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}