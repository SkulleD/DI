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
        private string palabra;

        public Form1()
        {
            InitializeComponent();
            palabra = "CACAOLAT";
            lblUsadas.Text += "\r\n";
            DibujaPalabra("");
        }

        private void btnUsarLetra_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLetra.Text) && txtLetra.Text.Length == 1)
            {
                if (palabra.Contains(txtLetra.Text.ToUpper()))
                {
                    DibujaPalabra(txtLetra.Text.ToUpper());
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

        private void DibujaPalabra(string letra)
        {
            lblPalabra.Text = "";

            for (int i = 0; i <= palabra.Length; i++)
            {
                if (palabra[0].Equals(letra))
                {
                    lblPalabra.Text += $"{letra.ToUpper()} ";
                }
                else
                {
                    lblPalabra.Text += "_ ";
                }
            }
        }
    }
}
