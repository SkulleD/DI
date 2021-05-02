using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3EVA_DI_ej3
{
    public partial class Form1 : Form
    {
        int red, green, blue;
        Image imagen;
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            label1.ForeColor = System.Drawing.Color.Red;
            label2.ForeColor = System.Drawing.Color.Green;
            label3.ForeColor = System.Drawing.Color.Blue;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                red = Convert.ToInt32(textBox1.Text);
            }
            catch (System.FormatException)
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                green = Convert.ToInt32(textBox2.Text);
            }
            catch (System.FormatException)
            {

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                blue = Convert.ToInt32(textBox2.Text);
            }
            catch (System.FormatException)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                imagen = new Bitmap(textBox4.Text);
                this.BackgroundImage = imagen;
            } catch (System.ArgumentException)
            {

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "¿Realmente quieres cerrar el programa?";
            string caption = "Salir del Programa";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void onKeyEnterDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return))
            {
                button1_Click(this, e);
            }
        }

        private void onKeyEscDown(object sender, KeyEventArgs e)
        {

        }
    }
}
