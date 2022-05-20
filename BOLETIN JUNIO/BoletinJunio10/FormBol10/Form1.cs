using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBol10
{
    public partial class Form1 : Form
    {
        private List<Friki> frikis = new List<Friki>();
        private Friki friki = new Friki();

        //Timer
        int titleLength; // Se usa para obtener la longitud de la string del título.
        int i; // Se usa para colocar cada caracter del título en el timer.
        char[] charasTitulo; // Se usa para ir colocando los caracteres del título desde el último al primero.

        public Form1()
        {
            InitializeComponent();

            titleLength = Text.Length;
            charasTitulo = Text.ToCharArray();
            i = titleLength - 1;
            Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();

            if (entrada.ShowDialog() == DialogResult.OK)
            {
                // Se usa el método de Comprobar para asegurarse de que los campos están correctos
                if (entrada.validateTextBoxNombre.Comprobar(entrada.validateTextBoxNombre.Texto) && entrada.validateTextBoxEdad.Comprobar(entrada.validateTextBoxEdad.Texto))
                {
                    lbldatoIncorrecto.Text = "";

                    if (entrada.rb1Hombre.Checked) // Primero se comprueba si la propia persona seleccionó hombre o mujer
                    {
                        friki.Sexo = Sexo.Hombre;
                    }
                    else
                    {
                        friki.Sexo = Sexo.Mujer;
                    }

                    if (entrada.rb2Hombre.Checked) // Luego se comprueba qué es lo que busca
                    {
                        friki.SexoOpuesto = SexoOpuesto.Hombre;
                    }
                    else
                    {
                        friki.SexoOpuesto = SexoOpuesto.Mujer;
                    }

                    friki = new Friki(entrada.validateTextBoxNombre.Texto, int.Parse(entrada.validateTextBoxEdad.Texto), entrada.pictureBox1.Image.ToString(), friki.Aficion = (eAficion)entrada.comboBox1.SelectedItem, friki.Sexo, friki.SexoOpuesto);
                    frikis.Add(friki);
                    listBox1.Items.Add($"{friki.Nombre}, {friki.Edad}, {friki.Sexo} | Afición: {friki.Aficion} | Buscando: {friki.SexoOpuesto}");
                }
                else
                {
                    lbldatoIncorrecto.Text = "Datos incorrectos.";
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre del software: Frikilove.\nAutor del software: Álvaro Vila.", "Frikilove", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                try
                {
                    foreach (Friki friki in frikis)
                    {
                        picCliente.Image = Image.FromFile(friki.Foto);
                    }
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Argument null");
                }
                catch (System.IO.FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Deseas salir del programa?", "Frikilove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i < 0) // Se reinicia el nombre y se le vuelve a asignar el último caracter.
            {
                i = titleLength - 1;
                Text = "";
            }

            Text = charasTitulo[i] + Text;  // Se le van sumando los caracteres, del último al primero.
            i--;
        }
    }
}