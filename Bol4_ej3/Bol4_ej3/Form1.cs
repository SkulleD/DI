using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bol4_ej3
{
    public partial class Form1 : Form
    {
        Form2 form2;
        string initialDirectory = "C:\\Users\\AlvaroVila\\source\\repos\\Bol4_ej3\\Bol4_ej3";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {
            DialogResult res;
            string filePath = "";
            string fileName = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = initialDirectory;
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|All Files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    try
                    {
                        fileName = Path.GetFileName(filePath);
                        form2 = new Form2(filePath, fileName); // Form2 is created
                        form2.Text = fileName;
                        form2.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        form2.pictureBox.Image = new Bitmap(filePath);

                        if (checkModal.Checked)
                        {
                            res = form2.ShowDialog();
                        }
                        else
                        {
                            form2.Show();
                        }
                    } catch (ArgumentException)
                    {
                        if (MessageBox.Show("You can only choose a PICTURE (.jpg, .jpeg, .png)", this.Text,
                             MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) { }
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exit program?", this.Text,
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}