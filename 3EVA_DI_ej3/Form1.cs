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
            this.ShowInTaskbar = false;
            this.KeyPreview = true;
            label1.ForeColor = System.Drawing.Color.Red;
            label2.ForeColor = System.Drawing.Color.Green;
            label3.ForeColor = System.Drawing.Color.Blue;
            button1.BackColor = System.Drawing.Color.LightGray;
            button2.BackColor = System.Drawing.Color.LightGray;
            button3.BackColor = System.Drawing.Color.LightGray;

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
            }
            catch (System.ArgumentException)
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
            this.Close();
        }

        private void onKeyEnterDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return))
            {
                button1_Click(this, e);
            }
        }

        private void button1_MouseHover(object sender, System.EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Goldenrod;
        }

        private void button2_MouseHover(object sender, System.EventArgs e)
        {
            button2.BackColor = System.Drawing.Color.Goldenrod;
        }

        private void button3_MouseHover(object sender, System.EventArgs e)
        {
            button3.BackColor = System.Drawing.Color.Goldenrod;
        }

        private void button1_MouseLeave(object sender, System.EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.LightGray;
        }

        private void button2_MouseLeave(object sender, System.EventArgs e)
        {
            button2.BackColor = System.Drawing.Color.LightGray;
        }

        private void button3_MouseLeave(object sender, System.EventArgs e)
        {
            button3.BackColor = System.Drawing.Color.LightGray;
        }

        private void onKeyTDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.T))
            {
                this.Text = "Colores e Imágenes";
            }

            if (e.KeyCode.Equals(Keys.Escape))
            {
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "¿Realmente quieres cerrar el programa?";
            string caption = "Salir del Programa";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point location;
            if (sender == this)
            {
                this.Text = $"{e.X},{e.Y}";
            } else
            {
                if (sender == textBox1)
                {
                    location = new Point(textBox1.Size);
                    this.Text = $"{e.X + location.X},{e.Y + location.Y}";
                }
            }

        }
    }
}