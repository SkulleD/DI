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

namespace BoletinJunio6
{
    public partial class Form3 : Form
    {
        public Form3(string path)
        {
            InitializeComponent();
        }

        public string MuestraDatos(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    textBox1.Text = reader.ReadToEnd();
                }
            } catch (FileNotFoundException)
            {
                Console.WriteLine("Archivo no encontrado");
            }

            return textBox1.Text;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Modified)
            {
                if (MessageBox.Show("El contenido del archivo ha sido modificado. ¿Quieres guardar los cambios?", "Contenido modificado",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        File.WriteAllText(Text, textBox1.Text);

                        //using (StreamWriter writer = new StreamWriter(Text))
                        //{
                        //    writer.Write(textBox1.Text);
                        //} 
                    }
                    catch (Exception ex) when (ex is ArgumentException || ex is ArgumentNullException || ex is PathTooLongException ||
                    ex is DirectoryNotFoundException || ex is IOException || ex is UnauthorizedAccessException || ex is NotSupportedException)
                    {
                        Console.WriteLine("ERROR AQUÍ");
                    }
                }
            }
        }
    }
}