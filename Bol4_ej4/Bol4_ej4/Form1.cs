using System;
using System.Collections;
using System.Windows.Forms;

namespace Bol4_ej4
{
    public partial class Form1 : Form
    {
        public delegate void calculo(int num1, int num2);
        public calculo calcular;
        public Hashtable hash;

        public Form1()
        {
            InitializeComponent();

            radioSuma.Tag = "+";
            radioResta.Tag = "-";
            radioMulti.Tag = "*";
            radioDivision.Tag = "/";

            hash = new Hashtable();
            hash.Add(radioSuma.Text, (calculo)((v1 , v2) => v1 + v2);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        public void radioButtonsClick(object sender, EventArgs e)
        {
            lblSigno.Text = (string)((RadioButton)sender).Tag;
            calcular = (calculo)hash[((RadioButton)sender).Text];
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exit program?", this.Text,
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

        }
    }
}