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

namespace FormBol10
{
    public partial class Entrada : Form
    {
        private string currentDirectory = Directory.GetCurrentDirectory();
        public Friki friki = new Friki();

        public Entrada()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(currentDirectory + "\\cliente0.jpg");
            comboBox1.DataSource = Enum.GetValues(typeof(eAficion));
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                try
                {
                    fileDialog.InitialDirectory = currentDirectory;
                    fileDialog.Filter = "Imágenes|*.png; *.jpg; *.jpeg";
                    fileDialog.ShowDialog();

                    pictureBox1.Image = Image.FromFile(fileDialog.FileName);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Argument Exception");
                }
            }
        }
    }
}