using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bol4_ej2
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

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (sender == btnColor)
            {
                this.BackColor = Color.FromArgb(255, int.Parse(textRed.Text), int.Parse(textGreen.Text), int.Parse(textBlue.Text));
            }
            else if (sender == btnImage)
            {
                this.BackgroundImage = Image.FromFile(textImage.Text.ToString());
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(textImage.Text.ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quieres salir?", "Mouse Tester",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            if (((TextBox)sender) != textImage)
            {
                textRed.Focus();
            } else
            {
                textImage.Focus();
            }
        }
    }
}
