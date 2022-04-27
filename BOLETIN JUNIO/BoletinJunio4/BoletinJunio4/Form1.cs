using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoletinJunio4
{
    public partial class Form1 : Form
    {
        public delegate double calcular(double n1, double n2);
        public calcular delCalcular;
        Hashtable hash = new Hashtable();
        int min = 0;
        int sec = 00;

        public Form1()
        {
            InitializeComponent();

            rbSuma.Tag = "+";
            rbResta.Tag = "-";
            rbMultiplicacion.Tag = "*";
            rbDivision.Tag = "/";

            hash = new Hashtable();
            hash.Add(rbSuma.Text, (calcular)((n1, n2) => n1 + n2));
            hash.Add(rbResta.Text, (calcular)((n1, n2) => n1 - n2));
            hash.Add(rbMultiplicacion.Text, (calcular)((n1, n2) => n1 * n2));
            hash.Add(rbDivision.Text, (calcular)((n1, n2) => n1 / n2));

            delCalcular = (calcular)hash[rbSuma.Text];
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(txt2.Text) == 0 && lblSymbol.Text.Equals("/"))
                {
                    lblResult.Text = "¡No es posible dividir entre 0!";
                }
                else
                {
                    double result = 0;
                    result = delCalcular(double.Parse(txt1.Text), double.Parse(txt2.Text));
                    lblResult.Text = String.Format("{0:F2}", result);
                }
            }
            catch (Exception ex) when (ex is FormatException || ex is ArgumentException || ex is OverflowException)
            {
                lblResult.Text = "Número no válido.";
            }
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            lblSymbol.Text = (string)((RadioButton)sender).Tag;
            delCalcular = (calcular)hash[((RadioButton)sender).Text];
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Salir?", "Ejercicio Junio 4", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sec == 59)
            {
                min++;
                sec = 0;
            }
            else
            {
                sec++;
            }

            Text = String.Format("{0:00}:{1:00}", min, sec);
        }
    }
}