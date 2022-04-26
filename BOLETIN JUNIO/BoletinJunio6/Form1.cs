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

        public Form1()
        {
            InitializeComponent();
            form2.StartPosition = FormStartPosition.CenterScreen;
            //form2.ShowDialog();
            CreaBotones();
        }

        private void CreaBotones()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i <= 9)
                {
                    if (left == 240)
                    {
                        left = 0;
                        top += 30;
                    }

                    btn = new Button();
                    btn.Left = left;
                    btn.Top = top;
                    btn.Text = $"{i}";
                    btn.Name = "btn" + i;
                    btn.Click += new EventHandler(buttonClick);
                    btn.MouseEnter += new EventHandler(buttonEnter);
                    btn.MouseLeave += new EventHandler(buttonLeave);
                    Controls.Add(btn);

                    left += 80;
                }
                else
                {
                    btn = new Button();
                    btn.Top = 150;
                    btn.Text = "*";
                    btn.Name = "btnAsterisco";
                    btn.Click += new EventHandler(buttonClick);
                    btn.MouseEnter += new EventHandler(buttonEnter);
                    btn.MouseLeave += new EventHandler(buttonLeave);
                    Controls.Add(btn);
                }
            }

            for (int i = 0; i <= 1; i++)
            {
                if (i == 0)
                {
                    btn = new Button();
                    btn.Left = 80;
                    btn.Top = 150;
                    btn.Text = $"{i}";
                    btn.Name = "btn" + i;
                    btn.Click += new EventHandler(buttonClick);
                    btn.MouseEnter += new EventHandler(buttonEnter);
                    btn.MouseLeave += new EventHandler(buttonLeave);
                    Controls.Add(btn);
                }
                else
                {
                    btn = new Button();
                    btn.Left = 160;
                    btn.Top = 150;
                    btn.Text = "#";
                    btn.Name = "btnAlmohadilla";
                    btn.Click += new EventHandler(buttonClick);
                    btn.MouseEnter += new EventHandler(buttonEnter);
                    btn.MouseLeave += new EventHandler(buttonLeave);
                    Controls.Add(btn);
                }
            }
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (boton.Text.ToLower().Equals("reset"))
            {
                textBox1.Text = "";
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
            fileDialog.Filter = "Text File | *.txt";
            int numero;
            bool esNum = false;
            string path = Directory.GetCurrentDirectory();

            esNum = int.TryParse(textBox1.Text, out numero);

            if (!string.IsNullOrWhiteSpace(textBox1.Text) && esNum)
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (writer = new StreamWriter(path))
                    {
                        writer.Write(textBox1.Text);
                    }
                }
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}