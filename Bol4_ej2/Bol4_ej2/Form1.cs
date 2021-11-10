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
    public partial class Form1 : Form //Arreglar excepciones, poner la X y usar Form Closing
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
            UseColor();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            UseImage();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            if (sender == textImage)
            {
                AcceptButton = btnImage;
            }
            else
            {
                AcceptButton = btnColor;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit program?", "Colors & Pictures",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exit program?", "Colors & Pictures",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void RestoreLabelColor()
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
        }

        private void UseColor()
        {
            try
            {
                labelWarning.Text = "";
                RestoreLabelColor();

                this.BackgroundImage = null;
                this.BackColor = Color.FromArgb(255, int.Parse(textRed.Text), int.Parse(textGreen.Text), int.Parse(textBlue.Text));
            }
            catch (FormatException)
            {
                labelWarning.Text = "No color selected!";
            }
            catch (ArgumentException)
            {
                labelWarning.Text = "No color selected!";
            }
            catch (OverflowException)
            {
                labelWarning.Text = "No color selected!";
            }
        }

        private void UseImage()
        {
            try
            {
                RestoreLabelColor();
                this.BackgroundImage = Image.FromFile(textImage.Text.ToString());
            }
            catch (ArgumentException)
            {
                labelWarning.Text = "No image found!";
            }
            catch(System.IO.FileNotFoundException)
            {
                labelWarning.Text = "No image found!";
            }
        }
    }
}