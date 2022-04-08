using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoletinJunio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            BackgroundColor();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            BackgroundPic();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BackgroundColor()
        {
            try
            {
                BackgroundImage = null;
                BackColor = Color.FromArgb(255, int.Parse(txtRed.Text), int.Parse(txtGreen.Text), int.Parse(txtBlue.Text));
            }
            catch (Exception ex) when (ex is FormatException || ex is ArgumentException || ex is OverflowException)
            {
                lblWarning.Text = "ERROR: Enter only numbers between 0 and 255.";
            }
        }

        private void BackgroundPic()
        {
            try
            {
                BackColor = Color.Transparent;
                BackgroundImage = Image.FromFile(txtPath.Text);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is System.IO.FileNotFoundException)
            {
                lblWarning.Text = "ERROR: File not found.";
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if (e.KeyCode == Keys.T)
            {
                Text = "Colores e Imágenes";
            }
        }

        private void btnMouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.LightGreen;
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Transparent;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exit?", "Colores e Imágenes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point point;

            if (sender == this)
            {
                Text = $"X: {e.X} Y: {e.Y}";
            }
            else
            {
                point = ((Control)sender).Location;
                Text = $"X: {e.X + point.X} Y: {e.Y + point.Y}";
            }
        }
    }
}