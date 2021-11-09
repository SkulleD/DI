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
            try
            {
                if (sender == btnColor)
                {
                    labelWarning.Text = "";

                    this.BackgroundImage = null;
                    this.BackColor = Color.FromArgb(255, int.Parse(textRed.Text), int.Parse(textGreen.Text), int.Parse(textBlue.Text));
                }
                else if (sender == btnImage)
                {
                    this.BackgroundImage = Image.FromFile(textImage.Text.ToString());
                }
            }
            catch (FormatException)
            {
                labelWarning.Text = "No color selected!";
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = Image.FromFile(textImage.Text.ToString());
            } catch (ArgumentException) {
                labelWarning.Text = "No image found!";
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quieres salir?", "Mouse Tester",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(255, 0, 170, 150);
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Transparent;
        }
    }
}