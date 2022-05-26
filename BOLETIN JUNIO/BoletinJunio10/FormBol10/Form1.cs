﻿using System;
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
    public partial class Form1 : Form
    {
        private List<Friki> frikis = new List<Friki>();
        private Friki friki = new Friki();
        private string rutaFotos = Directory.GetCurrentDirectory();

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

            friki = new Friki("Bocatagarto", 54, rutaFotos + "\\cliente1.png", eAficion.SciFi, Sexo.Hombre, SexoOpuesto.Mujer);
            frikis.Add(friki);
            listBox1.Items.Add(friki);
            friki = new Friki("Burgallina", 57, rutaFotos + "\\cliente3.png", eAficion.SciFi, Sexo.Mujer, SexoOpuesto.Hombre);
            frikis.Add(friki);
            listBox1.Items.Add(friki);
            friki = new Friki("Perrito", 2, rutaFotos + "\\cliente4.png", eAficion.Tecnología, Sexo.Hombre, SexoOpuesto.Hombre);
            frikis.Add(friki);
            listBox1.Items.Add(friki);
            friki = new Friki("Sapocadillo", 99, rutaFotos + "\\cliente2.png", eAficion.Tecnología, Sexo.Hombre, SexoOpuesto.Hombre);
            frikis.Add(friki);
            listBox1.Items.Add(friki);
            friki = new Friki("Kirbo", 42, rutaFotos + "\\cliente6.png", eAficion.SciFi, Sexo.Hombre, SexoOpuesto.Mujer);
            frikis.Add(friki);
            listBox1.Items.Add(friki);
            friki = new Friki("Hamsterene", 30, rutaFotos + "\\cliente7.png", eAficion.Manga, Sexo.Mujer, SexoOpuesto.Mujer);
            frikis.Add(friki);
            listBox1.Items.Add(friki);
            friki = new Friki("Hamsterilla", 27, rutaFotos + "\\cliente5.png", eAficion.Manga, Sexo.Mujer, SexoOpuesto.Mujer);
            frikis.Add(friki);
            listBox1.Items.Add(friki);
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

                    friki = new Friki(entrada.validateTextBoxNombre.Texto, int.Parse(entrada.validateTextBoxEdad.Texto), entrada.rutaFoto, friki.Aficion = (eAficion)entrada.comboBox1.SelectedItem, friki.Sexo, friki.SexoOpuesto);
                    frikis.Add(friki);
                    listBox1.Items.Add(friki);
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
                if (frikis[listBox1.SelectedIndex].Equals(listBox1.SelectedItem))
                {
                    frikis.RemoveAt(listBox1.SelectedIndex);
                }

                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                picCliente.Image = null;
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
            Friki frikiCheck;

            if (listBox1.SelectedIndices != null)
            {
                listBox2.Items.Clear();

                try
                {
                    picCliente.Image = Image.FromFile(frikis[listBox1.SelectedIndex].Foto);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Argument null");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Argument exception");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }

                frikiCheck = (Friki)listBox1.SelectedItem; // El cliente actual de quien se van a buscar parejas compatibles
                int ancho = 0;
                int alto = 0;
                panel1.Controls.Clear();

                PictureBox picParejas;

                // Se muestran en la lista 2 solo las personas con aficiones y género buscado que coincidan con las del primer cliente seleccionado de lista 1 (no va)
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (frikiCheck.Aficion == frikis[i].Aficion)
                    {
                        if (frikiCheck.Sexo.ToString() == frikis[i].SexoOpuesto.ToString())
                        {
                            if (frikiCheck != frikis[i])
                            {
                                listBox2.Items.Insert(0, frikis[i]);

                                picParejas = new PictureBox();
                                picParejas.Name = "picturebox";
                                picParejas.Size = new Size(80, 80);
                                picParejas.Location = new Point(ancho, 0);
                                picParejas.SizeMode = PictureBoxSizeMode.StretchImage;
                                picParejas.Image = Image.FromFile(frikis[i].Foto);
                                panel1.Controls.Add(picParejas);
                                ancho += 80;
                            }
                        }
                    }

                    //if (frikiCheck.Aficion == frikis[i].Aficion && frikiCheck.Sexo.ToString() == frikis[i].SexoOpuesto.ToString() && frikiCheck != frikis[i])
                    //{
                    //    listBox2.Items.Insert(0, frikis[i]);
                    //}
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