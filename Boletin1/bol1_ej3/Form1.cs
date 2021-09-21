#define CINC

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bol1_ej3
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        double n1;
        double n2;
        double n3;
        int creditos = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Créditos: " + creditos;
        }

        private void btn_jugar_Click(object sender, EventArgs e)
        {
            creditos = creditos - 2;
            label1.Text = "Créditos: " + creditos;

            n1 = random.Next(1, 8);
            n2 = random.Next(1, 8);
            n3 = random.Next(1, 8);

            textBox1.Text = n1.ToString();
            textBox2.Text = n2.ToString();
            textBox3.Text = n3.ToString();

            if (n1 == n2 && n1 == n3)
            {
                creditos = creditos + 20;
                label1.Text = "Créditos: " + creditos;
                label_premio.Text = "GANAS 20 €!!!";
            } else if (n1 == n2 || n1 == n3 || n2 == n3)
            {
#if CINCO
                creditos = creditos - 5;
                label1.Text = "Créditos: " + creditos;
                label_premio.Text = "Pierdes 5 €!";
#else
                creditos = creditos + 5;
                label1.Text = "Créditos: " + creditos;
                label_premio.Text = "Ganas 5 €!";
#endif
            }
            else
            {
                label_premio.Text = "No hay premio.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            creditos = creditos + 10;
            label1.Text = "Créditos: " + creditos;
        }
    }
}
