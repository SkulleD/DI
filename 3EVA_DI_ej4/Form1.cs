using System;
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
        int calculo = 0;
        public Form1()
        {
            InitializeComponent();
            var hashmap = new Dictionary<string, int>();
            hashmap.Add(radioButton1.Text, Calcular(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
            hashmap.Add(radioButton2.Text, Calcular(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
            hashmap.Add(radioButton3.Text, Calcular(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
            hashmap.Add(radioButton4.Text, Calcular(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
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
            calculo = 1;
            label1.Text = "+";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            calculo = 2;
            label1.Text = "-";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            calculo = 3;
            label1.Text = "*";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            calculo = 4;
            label1.Text = "/";
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

        private int Calcular(int n1, int n2)
        {
            int result = 0;

            if (calculo == 1)
            {
                result = n1 + n2;
            }

            if (calculo == 2)
            {
                result = n1 - n2;
            }

            if (calculo == 3)
            {
                result = n1 * n2;
            }

            if (calculo == 4)
            {
                result = n1 / n2;
            }
            return result;
        }
    }
}
