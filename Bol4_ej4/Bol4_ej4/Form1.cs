using System;
using System.Collections;
using System.Windows.Forms;

namespace Bol4_ej4
{
    public partial class Form1 : Form
    {
        public delegate double calculo(double num1, double num2);
        public calculo calcular;
        public Hashtable hash;
        public double result;
        public int min = 0;
        public int sec = 0;

        public Form1()
        {
            InitializeComponent();

            radioSuma.Tag = "+";
            radioResta.Tag = "-";
            radioMulti.Tag = "*";
            radioDivision.Tag = "/";

            hash = new Hashtable();
            hash.Add(radioSuma.Text, (calculo)((v1, v2) => v1 + v2));
            hash.Add(radioResta.Text, (calculo)((v1, v2) => v1 - v2));
            hash.Add(radioMulti.Text, (calculo)((v1, v2) => v1 * v2));
            hash.Add(radioDivision.Text, (calculo)((v1, v2) => v1 / v2));

            calcular = (calculo)hash[radioSuma.Text];
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtNumber2.Text) == 0 && lblSigno.Text.Equals("/"))
                {
                    lblFinalResult.Text = "Can't divide a number by zero!";
                } else
                {
                    result = calcular(int.Parse(txtNumber1.Text), int.Parse(txtNumber2.Text));
                    lblFinalResult.Text = String.Format("{0:f3}", result);
                }
            }
            catch (Exception ex) when (ex is FormatException || ex is ArgumentException || ex is OverflowException)
            {
                lblFinalResult.Text = "That's not a valid number!";
            }
        }

        public void radioButtonsClick(object sender, EventArgs e)
        {
            lblSigno.Text = (string)((RadioButton)sender).Tag;
            calcular = (calculo)hash[((RadioButton)sender).Text];
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exit program?", "DI_ej4",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sec == 59)
            {
                sec = 0;
                min++;
            } else
            {
                sec++;
            }

            this.Text = String.Format("{0:d2}:{1:d2}", min, sec);
        }
    }
}