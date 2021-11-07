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
            this.AcceptButton = button1;
            this.CancelButton = button3;
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
            try
            {
                this.BackColor = Color.FromArgb(red, green, blue);
            }
            catch (ArgumentException)
            {
                label5.Text = "Error: tiene que ser en un valor entre 0 y 255";
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttons_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.Goldenrod;
        }

        private void buttons_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.LightGray;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.T))
            {
                this.Text = "Colores e Imágenes";
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

        private void Form1_MouseMove(object sender, MouseEventArgs e) //Se usa el polimorfismo para obtener la propiedad Location de Control en el sender
        {
            Point location;
            if (sender == this)
            {
                this.Text = $"{e.X},{e.Y}";
            }
            else
            {
                location = ((Control)sender).Location;
                this.Text = $"{e.X + location.X},{e.Y + location.Y}";
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Colores e Imágenes";
        }
    }
}