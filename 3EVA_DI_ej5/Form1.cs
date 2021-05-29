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
using System.Collections;

namespace _3EVA_DI_ej5
{ // menú, lista indices, quitar (DONE), icono, TraspasarIZQ sin bucle (DONE)
    public partial class Form1 : Form
    {
        ToolTip tip;
        string titulo;
        string titleChanged = "";
        char chara;
        string directorio = Directory.GetCurrentDirectory();
        double ms = 0;
        int i = 11;
        bool iconChange = false;
        delegate void Delegado();
        Delegado funcion;
        public Hashtable hash;

        public Form1()
        {
            InitializeComponent();
            tip = new ToolTip();
            this.AcceptButton = button1;
            tip.SetToolTip(this.button1, "Añade un nuevo elemento a la lista 1");
            tip.SetToolTip(this.button2, "Elimina un elemento de la lista 1");
            tip.SetToolTip(this.button3, "Mueve los elementos seleccionados de la lista 1 a la lista 2");
            tip.SetToolTip(this.button4, "Mueve un elemento seleccionado de la lista 2 a la lista 1");
            tip.SetToolTip(this.listBox2, "Nº de elementos: " + listBox2.Items.Count);
            titulo = this.Text;
            timer1.Start();
            hash = new Hashtable();
            hash.Add("Add", (Delegado)Anadir);
            hash.Add("Remove", (Delegado)funcion);
            hash.Add("mRight", (Delegado)funcion);
            hash.Add("mLeft", (Delegado)funcion);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // AÑADIR
        {
            funcion();
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

        private void Funciones(object sender, EventArgs e)
        {
            funcion = (Delegado)hash[((Button)sender)];
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
            if (listBox1.Items.Count > 0)
            {
                for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    listBox1.Items.Remove(listBox1.SelectedItems[i]);
                }
            }
        }

        private void TraspasarDER()
        {
            if (listBox1.SelectedItem != null)
            {
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                {
                    listBox2.Items.Insert(i, listBox1.SelectedItems[i]);
                }

                for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    listBox1.Items.Remove(listBox1.SelectedItems[i]);
                }
            }
            tip.SetToolTip(this.listBox2, "Nº de elementos: " + listBox2.Items.Count);
        }

        private void TraspasarIZQ()
        {
            if (listBox2.SelectedItem != null)
            {

                listBox1.Items.Insert(0, listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            tip.SetToolTip(this.listBox2, "Nº de elementos: " + listBox2.Items.Count);
        }

        private string listIndexes()
        {
            string indices = "";
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                indices = indices + " " + i.ToString();
            }

            return indices;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Nº elementos: " + listBox1.Items.Count.ToString();
            label2.Text = listIndexes();

            if (this.Text.Equals("EjercicioDI5"))
            {
                i = 11;
                titleChanged = "";
            }

            chara = titulo[i];
            titleChanged = chara + titleChanged;
            this.Text = titleChanged;
            i--;

            if (ms == 100) // Para que no llegue a valores súper altos
            {
                ms = 0;
            }

            ms++;

            if ((ms % 2) == 0 && iconChange == true)
            {
                this.Icon = new Icon(directorio + "\\bocatagarto.ico");
                iconChange = false;

            }
            else
            {
                this.Icon = new Icon(directorio + "\\burgallina.ico");
                iconChange = true;

            }
        }
    }
}