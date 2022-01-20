using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bol5_ej1Form
{
    public partial class Form1 : Form
    {
        string bocatagarto = "C:\\Users\\AlvaroVila\\source\\repos\\Bol5_ej1\\Bol5_ej1Form\\bocatagarto.jpg";
        string burgallina = "C:\\Users\\AlvaroVila\\source\\repos\\Bol5_ej1\\Bol5_ej1Form\\burgallina.png";

        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = new Bitmap(bocatagarto);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = new Bitmap(burgallina);
        }

        private void labelTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this.Text = "Letra: " + e.KeyChar;
        }

        private void labelTextbox1_KeyUp(object sender, KeyEventArgs e)
        {
            this.Text = e.KeyCode.ToString();
        }

        private void btnPos_Click(object sender, EventArgs e) // Apartado A
        {
            if (labelTextbox1.Posicion == Bol5_ej1.ePosicion.IZQUIERDA)
            {
                labelTextbox1.Posicion = Bol5_ej1.ePosicion.DERECHA;
            }
            else
            {
                labelTextbox1.Posicion = Bol5_ej1.ePosicion.IZQUIERDA;
            }
        }

        private void labelTextbox1_CambiaPosicion_1(object sender, EventArgs e)
        {
            this.Text = labelTextbox1.Posicion.ToString();
        }

        private void btnSeparaDer_Click(object sender, EventArgs e) // Apartado B
        {
            labelTextbox1.Separacion += 1;
        }

        private void btnSeparaIzq_Click(object sender, EventArgs e) // Apartado B
        {
            if (labelTextbox1.Separacion > 0)
            {
                labelTextbox1.Separacion -= 1;
            }
        }

        private void labelTextbox1_SeparacionChanged(object sender, EventArgs e)
        {
            labelTextbox1.Text_Label = labelTextbox1.Separacion.ToString();
        }

        private void labelTextbox1_CambiaPosicion(object sender, EventArgs e) // Apartado B
        {
            if (labelTextbox1.Posicion == Bol5_ej1.ePosicion.IZQUIERDA)
            {
                this.Text = Bol5_ej1.ePosicion.DERECHA.ToString();
            }
            else
            {
                this.Text = Bol5_ej1.ePosicion.IZQUIERDA.ToString();
            }
        }

        private void labelTextbox1_TxtChanged(object sender, EventArgs e) // Apartado D
        {
            labelTextbox1.Text_Label = "Asies";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Salir?", "DI tema 5 ej 1",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}