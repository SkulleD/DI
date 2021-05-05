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
        Timer timerino;
        public Hashtable tabla;

        public Form1()
        {
            InitializeComponent();
            //timerino.Start();
            tabla = new Hashtable();
            tabla.Add(radioButton1.Text, (delCalcular)Suma);
            tabla.Add(radioButton2.Text, (delCalcular)Resta);
            tabla.Add(radioButton3.Text, (delCalcular)Multiplicacion);
            tabla.Add(radioButton4.Text, (delCalcular)Division);

            this.Text = "aa";

            radioButton1.Tag = "+";
            radioButton2.Tag = "-";
            radioButton3.Tag = "*";
            radioButton4.Tag = "/";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

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

        private int Suma(int n1, int n2) {

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

        }
    }
}