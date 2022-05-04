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
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        int left = 0;
        int top = 60;
        Button btn;
        string path = Directory.GetCurrentDirectory() + "\\Numeros.txt"; // Archivo por defecto

        public Form1()
        {
            InitializeComponent();
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.ShowDialog();
            CreaBotones();

            //Controls["CurroBoton"].BackColor = Color.Green;
        }

        private void CreaBotones()
        {
            for (int i = 1; i <= 12; i++)
            {
                if (left == 240)
                {
                    left = 0;
                    top += 30;
                }

                btn = new Button();
                btn.Left = left;
                btn.Top = top;

                if (i <= 9) // Nums 1 al 9
                {
                    btn.Text = $"{i}";
                    btn.Name = "btn" + i;
                }

                if (i == 10) // *
                {
                    btn.Text = "*";
                    btn.Name = "btn" + i;
                }

                if (i == 11) // 0
                {
                    btn.Text = $"{0}";
                    btn.Name = "btn" + i;
                }

                if (i == 12) // #
                {
                    btn.Text = "#";
                    btn.Name = "btn" + i;
                }

                btn.Click += new EventHandler(buttonClick);
                btn.MouseEnter += new EventHandler(buttonEnter);
                btn.MouseLeave += new EventHandler(buttonLeave);
                Controls.Add(btn);

                left += 80;
            }
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (boton == btnReset) // Si es RESET pues resetea todo, sino colorea de amarillo
            {
                textBox1.Text = "";
                ResetColors();
            }
            else
            {
                textBox1.Text += boton.Text;
                boton.BackColor = Color.Yellow;
            }
        }

        private void buttonEnter(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (!(boton.BackColor == Color.Yellow))
            {
                boton.BackColor = Color.LightGreen;
            }
        }

        private void buttonLeave(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (!(boton.BackColor == Color.Yellow))
            {
                boton.BackColor = Color.Transparent;
            }
        }

        private void grabarNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Archivos de texto |*.txt| Todos los archivos |*.*";
            int numero;
            bool esNum = false;

            esNum = int.TryParse(textBox1.Text, out numero);

            if (!string.IsNullOrWhiteSpace(textBox1.Text) && esNum) // Se comprueba que hay escrito un número
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = fileDialog.FileName;

                    try
                    {
                        using (writer = new StreamWriter(path, true))
                        {
                            writer.Write(textBox1.Text + Environment.NewLine);
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("Archivo no encontrado");
                    }
                }
            }
        }

        private void verNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(path))
            {
                Form3 form3 = new Form3(path);
                form3.Text = path;
                form3.textBox1.Text = form3.MuestraDatos(path);
                form3.ShowDialog();
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            ResetColors();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3("");
            form3.Text = "Derechos de Autor";
            form3.textBox1.Text = "--Autor--\r\nÁlvaro Rodríguez Vila\r\n\r\n" +
                    "--Fecha finalización--\r\n29/04/2022\r\n\r\n" +
                    "--Agradecimientos especiales--\r\nCurro Bellas";
            form3.ShowDialog();
        }

        private void ResetColors()
        {
            for (int i = 1; i <= 12; i++)
            {
                Controls["btn" + i].BackColor = Color.Transparent;
            }
        }
    }
}