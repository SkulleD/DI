using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bol1_ej5
{
    public partial class Form1 : Form
    {
        DialogResult mensaje;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mensaje = MessageBox.Show("¿Quieres usar este texto como título?",
                "Modificar título",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            this.Text = textBox1.Text;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mensaje = MessageBox.Show("¿Quieres usar este texto como título?",
                   "Modificar título",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                this.Text = textBox1.Text;
                e.Handled = true;
            }
        }
    }
}
