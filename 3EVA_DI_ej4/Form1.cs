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
        public delCalcular funcion;
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
            funcion = Suma;
            tabla = new Hashtable();
            tabla.Add(radioButton1.Text, (delCalcular)Suma);
            tabla.Add(radioButton2.Text, (delCalcular)Resta);
            tabla.Add(radioButton3.Text, (delCalcular)Multiplicacion);
            tabla.Add(radioButton4.Text, (delCalcular)Division);

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
            {
                resultado = funcion(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                label3.Text = resultado.ToString();
            }
            catch (FormatException)
            {

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            funcion = (n1, n2) => n1 + n2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            funcion = (n1, n2) => n1 - n2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            funcion = (n1, n2) => n1 * n2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            funcion = (n1, n2) => n1 / n2;
        }

        private void radioButtons(object sender, EventArgs e)
        {
            label1.Text = (string)((RadioButton)sender).Tag;
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

        private int Suma(int n1, int n2)
        {

            return n1 + n2;
        }

        private int Resta(int n1, int n2)
        {

            return n1 - n2;
        }

        private int Multiplicacion(int n1, int n2)
        {

            return n1 * n2;
        }

        private int Division(int n1, int n2)
        {

            return n1 / n2;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 99; i++) // SE PETA EL PC
            {

                for (int j = 0; j <= 59; j++)
                {
                    segundos++;
                    this.Text = String.Format("{0}:{1}", minutos, segundos);
                }
            }
        }
    }
}