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

            if (!path.ToLower().Equals("autor"))
            {
                Text = path;
                MuestraDatos(path);
            }
            else
            {
                textBox1.Visible = false;
                Text = "Derechos del Programa";
                textBox1 = new TextBox();
                textBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                textBox1.Location = new Point(9, 10);
                textBox1.Margin = new Padding(2);
                textBox1.Multiline = true;
                textBox1.Name = "textBox2";
                textBox1.ScrollBars = ScrollBars.Vertical;
                textBox1.Size = new Size(240, 310);
                textBox1.TabIndex = 0;
                textBox1.ReadOnly = true;
                textBox1.Text = "--Autor--\r\nÁlvaro Rodríguez Vila\r\n\r\n" +
                    "--Fecha finalización--\r\n29/04/2022\r\n\r\n" +
                    "--Agradecimientos especiales--\r\nCurro Bellas";
                Controls.Add(textBox1);
            }
        }

        private void MuestraDatos(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                textBox1.Text = reader.ReadToEnd();
            }
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