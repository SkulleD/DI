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

namespace BoletinJunio5
{
    public partial class Form1 : Form
    {
        ToolTip tooltip;

        // Variables usadas para el timer
        string directory = Directory.GetCurrentDirectory();
        double ms = 0;
        bool iconChanged = false;

        char letraTitulo;
        string tituloOriginal = "Junio 5";
        int titleLength;
        int i = 0;

        public Form1()
        {
            InitializeComponent();

            titleLength = Text.Length;

            tooltip = new ToolTip();
            tooltip.SetToolTip(btnAdd, "Añade un elemento a la Lista 1");
            tooltip.SetToolTip(btnRemove, "Elimina los elementos seleccionados de la Lista 1");
            tooltip.SetToolTip(btnToRight, "Mueve los elementos seleccionados de la Lista 1 a la Lista 2");
            tooltip.SetToolTip(btnToLeft, "Mueve el elemento seleccionado de la Lista 2 a la lista 1");
            tooltip.SetToolTip(listBox2, $"Nº de elementos actualmente: {listBox2.Items.Count}");
            textBox1.Select();
        }

        private void btnAdd_Click(object sender, EventArgs e) // AÑADIR
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }

            textBox1.Select();
        }

        private void btnRemove_Click(object sender, EventArgs e) // ELIMINAR
        {
            if (listBox1.SelectedItems.Count > 0) // También parece valer listBox1.Items.Count
            {
                for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--) // Parece que SelectedIndices también funciona??
                {
                    listBox1.Items.Remove(listBox1.SelectedItems[i]);
                }
            }

        }   

        private void btnToRight_Click(object sender, EventArgs e) // PASAR DE LISTA 1 A LISTA 2
        {
            if (listBox1.SelectedItems != null)
            {
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                {
                    listBox2.Items.Insert(i, listBox1.SelectedItems[i]);
                }

                for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--) // Después de ser movidos a lista 2 los borra de lista 1
                {
                    listBox1.Items.Remove(listBox1.SelectedItems[i]);
                }
            }
        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Insert(0, listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void RecorreIndices() // Sirve para mostrar indices seleccionados de Lista 1
        {
            lblSeleccionados.Text = "Seleccionados: ";

            if (listBox1.SelectedIndices.Count > 0)
            {
                foreach (int indice in listBox1.SelectedIndices)
                {
                    lblSeleccionados.Text += $"{indice}, ";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNumElementos.Text = $"Nº Elementos: {listBox1.Items.Count}";
            tooltip.SetToolTip(listBox2, $"Nº de elementos actualmente: {listBox2.Items.Count}");

            RecorreIndices();

            if (Text.Equals(tituloOriginal))
            {
                i = titleLength - 1;
                Text = "";
            }

            letraTitulo = tituloOriginal[i];
            Text += letraTitulo;
            i--;

            if (ms == 100) // Para que no aumente infinitamente
            {
                ms = 0;
            }

            ms++;

            if ((ms % 2) == 0 && iconChanged == true)
            {
                Icon = new Icon(directory + "\\bocatagarto.ico");
                iconChanged = false;
            }
            else
            {
                Icon = new Icon(directory + "\\burgallina.ico");
                iconChanged = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Salir?", "Boletín Junio ej 5", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
