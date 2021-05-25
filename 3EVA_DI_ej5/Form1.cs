using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _3EVA_DI_ej5
{
    public partial class Form1 : Form
    {
        ToolTip tip;
        string[] titulo;
        string espacios = "            ";
        string espacios2;
        int i = 13;
        string directorio = Directory.GetCurrentDirectory();
        double ms = 0;

        public Form1()
        {
            InitializeComponent();
            tip = new ToolTip();
            this.AcceptButton = button1;
            tip.SetToolTip(this.button1, "Añade un nuevo elemento a la lista 1");
            tip.SetToolTip(this.button2, "Elimina un elemento de la lista 1");
            tip.SetToolTip(this.button3, "Mueve todos los elementos de la lista 1 a la lista 2");
            tip.SetToolTip(this.button4, "Mueve todos los elementos de la lista 2 a la lista 1");
            titulo = this.Text.Split();
            espacios2 = espacios;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // AÑADIR
        {
            Anadir();
        }

        private void button2_Click(object sender, EventArgs e) // QUITAR
        {
            Quitar();
        }

        private void button3_Click(object sender, EventArgs e) // TRASPASAR ->
        {
            TraspasarDER();
        }

        private void button4_Click(object sender, EventArgs e) // <- TRASPASAR
        {
            TraspasarIZQ();
        }

        private void aÑADIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anadir();
        }

        private void qUITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quitar();
        }

        private void tRASPASARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraspasarDER();
        }

        private void tRASPASARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TraspasarIZQ();
        }

        private void Anadir()
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void Quitar()
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void TraspasarDER() // FALTA ARREGLAR EL DETALLE DE ELEMENTOS CLONADOS
        {
            if (listBox1.SelectedItem != null)
            {
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                {
                    listBox2.Items.Insert(i, listBox1.SelectedItem);
                }
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void TraspasarIZQ() // FALTA ARREGLAR EL DETALLE DE ELEMENTOS CLONADOS
        {
            if (listBox2.SelectedItem != null)
            {
                for (int i = 0; i < listBox2.SelectedItems.Count; i++)
                {
                    listBox1.Items.Insert(i, listBox2.SelectedItem);
                }
                listBox2.Items.Remove(listBox2.SelectedItem);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Nº elementos: " + listBox1.Items.Count.ToString();
            label2.Text = "Índice: " + listBox1.SelectedIndex.ToString();

            if (i != -1 && espacios2.Length != 0) // FALTA QUE MUESTRE EL "EJ" DE EJERCICIO
            {
                Text = espacios2 + titulo[i];
                espacios2 = espacios2.Remove(0, 1);
                i--;
            }
            else
            {
                i = 13;
                espacios2 = espacios;
            }

            if (ms == 100) // Para que no llegue a valores súper altos
            {
                ms = 0;
            }

            ms++;

            if ((ms % 2) == 0)
            {
                this.Icon = new Icon(directorio + "\\bocatagarto.ico");
            }
            else
            {
                this.Icon = new Icon(directorio + "\\burgallina.ico");
            }
        }
    }
}