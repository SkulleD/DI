#define KEY

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bol4_ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
#if KEYS
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = "Mouse Tester";
            }
            else
            {
                this.Text = e.KeyCode.ToString();
            }
#endif
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
#if !KEYS
            this.Text = e.KeyChar.ToString();
#endif
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnIzquierdo.BackColor = Color.DarkBlue;
            }
            else if (e.Button == MouseButtons.Right)
            {
                btnDerecho.BackColor = Color.DeepPink;
            }
            else
            {
                btnDerecho.BackColor = Color.Purple;
                btnIzquierdo.BackColor = Color.Purple;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnIzquierdo.BackColor = Color.Transparent;
            }
            else if (e.Button == MouseButtons.Right)
            {
                btnDerecho.BackColor = Color.Transparent;
            }
            else
            {
                btnDerecho.BackColor = Color.Transparent;
                btnIzquierdo.BackColor = Color.Transparent;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Quieres salir?", "Mouse Tester",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
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
            }
            else
            {
                location = ((Control)sender).Location;
                this.Text = $"{e.X + location.X},{e.Y + location.Y}";
            }
        }
    }
}