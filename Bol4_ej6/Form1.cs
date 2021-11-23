using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bol4_ej6
{
    public partial class Form1 : Form
    {
        DialogResult res;
        Form2 form2;
        int arriba = 50;
        int izq = 100;
        Button btn;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            //res = form2.ShowDialog();
            ButtonCreator();
        }

        private void ButtonCreator()
        {
            flowLayoutPanel1.Controls.Clear();

            for (int i = 1; i <= 10; i++)
            {
                if (i <= 9)
                {
                    if (izq == 150)
                    {
                        izq = 50;
                    }

                    btn = new Button();
                    btn.Left = izq;
                    btn.Top = arriba;
                    btn.Name = "Button " + i.ToString();
                    btn.Text = i.ToString();
                    flowLayoutPanel1.Controls.Add(btn);
                }
                else
                {
                    btn = new Button();
                    btn.Name = "Button " + i.ToString();
                    btn.Text = "*";
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }

            for (int i = 0; i <= 1; i++)
            {
                if (i == 0)
                {
                    izq = 100;
                    btn = new Button();
                    btn.Left = izq;
                    btn.Name = "Button " + 11.ToString();
                    btn.Text = "0";
                    flowLayoutPanel1.Controls.Add(btn);
                }
                else
                {
                    izq = 150;
                    btn = new Button();
                    btn.Left = izq;
                    btn.Name = "Button " + 12.ToString();
                    btn.Text = "#";
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }
        }
    }
}
