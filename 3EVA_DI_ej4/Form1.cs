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

namespace _3EVA_DI_ej4
{
    public partial class Form1 : Form //timer, overflow, if de /0
    {
        public delegate int delCalcular(int n1, int n2);
        public delCalcular fFinal;
        public Hashtable tabla;
        int resultado;
        int minutos = 0, segundos = 55;

        public Form1()
        {
            InitializeComponent();

            this.CenterToScreen();
     
            label1.Text = "+";

            tabla = new Hashtable();
            tabla.Add(radioButton1.Text, (delCalcular)((n1, n2) => n1 + n2));
            tabla.Add(radioButton2.Text, (delCalcular)((n1, n2) => n1 - n2));
            tabla.Add(radioButton3.Text, (delCalcular)((n1, n2) => n1 * n2));
            tabla.Add(radioButton4.Text, (delCalcular)((n1, n2) => n1 / n2));

            fFinal = (delCalcular)tabla[radioButton1.Text];
                ;
            radioButton1.Tag = "+";
            radioButton2.Tag = "-";
            radioButton3.Tag = "*";
            radioButton4.Tag = "/";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   if (Convert.ToInt32(textBox2.Text) == 0 && label1.Text == "/")
                {
                    label4.Text = "(!) No se puede dividir entre 0.";
                } else
                {
                    resultado = fFinal(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    label3.Text = resultado.ToString();
                    label4.Text = "";
                }
            }
            catch (FormatException)
            {
                label4.Text = "(!) Valor/es no válido/s.";
            }
            catch (OverflowException)
            {
                label4.Text = "(!) Cantidad demasiado grande.";
            }
        }

        private void radioButtons(object sender, EventArgs e)
        {
            label1.Text = (string)((RadioButton)sender).Tag;
            fFinal = (delCalcular)tabla[((RadioButton)sender).Text];
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "¿Quieres salir del programa?";
            string caption = "Salir del Programa";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (segundos == 59)
            {
                segundos = 0;
                minutos++;
            } else
            {
                segundos++;
            }
                this.Text = String.Format("{0:d2}:{1:d2}", minutos, segundos);
        }
    }
}