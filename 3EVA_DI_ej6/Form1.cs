using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3EVA_DI_ej6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateButtons();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateButtons()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 1; i <= 10; i++)
            {
                if (i <= 9)
                {
                    Button boton = new Button();
                    boton.Name = "Button " + i.ToString();
                    boton.Text = i.ToString();
                    boton.AutoSize = true;
                    flowLayoutPanel1.Controls.Add(boton);
                }
                else
                {
                    Button boton = new Button();
                    boton.Name = "Button " + i.ToString();
                    boton.Text = "*";
                    boton.AutoSize = true;
                    flowLayoutPanel1.Controls.Add(boton);
                }
            }

            for (int i = 0; i <= 1; i++)
            {
                if (i == 0)
                {
                    Button boton = new Button();
                    boton.Name = "Button " + 11.ToString();
                    boton.Text = 0.ToString();
                    boton.AutoSize = true;
                    flowLayoutPanel1.Controls.Add(boton);
                }
                else
                {
                    Button boton = new Button();
                    boton.Name = "Button " + 12.ToString();
                    boton.Text = "#";
                    boton.AutoSize = true;
                    flowLayoutPanel1.Controls.Add(boton);
                }
            }
        }
    }
}
