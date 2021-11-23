using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bol4_ej5
{
    public partial class Form1 : Form
    {
        ToolTip tooltip;
        public delegate void Delegate_ej5();
        public Delegate_ej5 buttonsDelegate;
        public Hashtable hash;

        public Form1()
        {
            InitializeComponent();
            tooltip = new ToolTip();
            tooltip.SetToolTip(btnAdd, "Adds a new element to ListBox1");
            tooltip.SetToolTip(btnRemove, "Removes the selected elements from ListBox1");
            tooltip.SetToolTip(btnMoveRight, "Moves the selected elements from ListBox1 to ListBox2");
            tooltip.SetToolTip(btnMoveLeft, "Moves one selected element from ListBox2 to ListBox1");
            tooltip.SetToolTip(listBox2, "Number of elements inside: " + listBox2.Items.Count);
            textIntro.Select(); //Tiene el foco al iniciar el programa

            hash = new Hashtable();
            hash.Add(btnAdd.Text, (Delegate_ej5)(() => lblinfo.Text = "Funciono Add"));
        }

        public void ButtonsClick(object sender, EventArgs e) // No va
        {
            buttonsDelegate = (Delegate_ej5)hash[((Button)sender).Text];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textIntro.Text))
            {
                listBox1.Items.Add(textIntro.Text);
                textIntro.Text = "";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e) //Recorre los elementos seleccionados y los va borrando de último a primero
        {
            if (listBox1.Items.Count > 0)
            {
                for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    listBox1.Items.Remove(listBox1.SelectedItems[i]);
                }
            }
        }

        private void btnMoveRight_Click(object sender, EventArgs e) // Se pasan VARIOS elementos
        {
            if (listBox1.SelectedItem != null)
            {
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                {
                    listBox2.Items.Insert(i,listBox1.SelectedItems[i]);
                }

                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                {
                    listBox1.Items.Remove(listBox1.SelectedItems[i]);
                }
            }

            tooltip.SetToolTip(listBox2, "Number of elements inside: " + listBox2.Items.Count);
        }

        private void btnMoveLeft_Click(object sender, EventArgs e) // Se pasa solo UN elemento
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Insert(0, listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }

            lblInfoRight.Text = $"Selected index: ";
            tooltip.SetToolTip(listBox2, "Number of elements inside: " + listBox2.Items.Count);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exit program?", "Bol4_ej5",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfoRight.Text = $"Selected index: {listBox2.SelectedIndex}";
        }
    }
}