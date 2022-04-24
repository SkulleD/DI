using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        int top = 40;
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
                        top += 40;
                    }

                    btn = new Button();
                    btn.Left = left;
                    btn.Top = top;
                    btn.Text = $"{i}";
                    btn.Name = "btn" + i;
                    Controls.Add(btn);

                    left += 80;
                }
                else
                {
                    btn = new Button();
                    btn.Top = 160;
                    btn.Text = "*";
                    btn.Name = "btnAsterisco";
                    Controls.Add(btn);
                }
            }

            for (int i = 0; i <= 1; i++)
            {
                if (i == 0)
                {
                    btn = new Button();
                    btn.Left = 80;
                    btn.Top = 160;
                    btn.Text = $"{i}";
                    btn.Name = "btn" + i;
                    Controls.Add(btn);
                }
                else
                {
                    btn = new Button();
                    btn.Left = 160;
                    btn.Top = 160;
                    btn.Text = "#";
                    btn.Name = "btnAlmohadilla";
                    Controls.Add(btn);
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}