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
    public partial class Form1 : Form
    {
        public delegate int delCalcular(int n1, int n2);
        public delCalcular fSuma;
        public delCalcular fResta;
        public delCalcular fMulti;
        public delCalcular fDivision;
        public delCalcular fFinal;
        public Hashtable tabla;
        int resultado;
        int minutos = 0, segundos = 0;

        public Form1()
        {
            InitializeComponent();

            this.CenterToScreen();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
            label1.Text = "+";

            tabla = new Hashtable();
            tabla.Add(radioButton1.Text, (delCalcular)fSuma);
            tabla.Add(radioButton2.Text, (delCalcular)fResta);
            tabla.Add(radioButton3.Text, (delCalcular)fMulti);
            tabla.Add(radioButton4.Text, (delCalcular)fDivision);

            radioButton1.Tag = "+";
            radioButton2.Tag = "-";
            radioButton3.Tag = "*";
            radioButton4.Tag = "/";
            fSuma = (n1, n2) => n1 + n2;
            fResta = (n1, n2) => n1 - n2;
            fMulti = (n1, n2) => n1 * n2;
            fDivision = (n1, n2) => n1 / n2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                resultado = fFinal(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                label3.Text = resultado.ToString();
            }
            catch (FormatException)
            {

            }
            catch (NullReferenceException) // No la captura ????
            {

            }
        }

        private void radioButtons(object sender, EventArgs e)
        {
            label1.Text = (string)((RadioButton)sender).Tag;
            fFinal = (delCalcular)tabla[((RadioButton)sender).Text];

            if (tabla.ContainsKey("+"))
            {
                fFinal = fSuma;
            }
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
                this.Text = String.Format("{0:d2}:{1:d2}", minutos, segundos);
            }
        }
    }
}