using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3EVA_DI_ej5
{
    public partial class Form1 : Form
    {
        ToolTip tip;
        public Form1()
        {
            InitializeComponent();
            tip = new ToolTip();
            this.AcceptButton = button1;
            tip.SetToolTip(this.button1, "Añade un nuevo elemento a la lista 1");
            tip.SetToolTip(this.button2, "Elimina un elemento de la lista 1");
            tip.SetToolTip(this.button3, "Mueve todos los elementos de la lista 1 a la lista 2");
            tip.SetToolTip(this.button4, "Mueve todos los elementos de la lista 2 a la lista 1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                label1.Text = "Nº elementos: " + listBox1.Items.Count.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string elemento in listBox1.Items)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }

            label2.Text = "Índice: " + listBox1.SelectedIndex.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox2.Items.Insert(i, listBox1.SelectedItem);
                }
                listBox1.Items.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void aÑADIRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void qUITARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tRASPASARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tRASPASARToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}