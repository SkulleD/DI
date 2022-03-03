using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1EVA
{
    public partial class Form1 : Form
    {
        CheckBox check;
        int cont = 0; // Para el timer
        int marcados = 0;
        int aciertos = 0;

        public Form1()
        {
            InitializeComponent();
            CreaCasillas();
        }

        private void CreaCasillas()
        {
            int x = 30;
            int y = 30;

            for (int i = 1; i <= 49; i++)
            {
                check = new CheckBox();
                check.Text = i.ToString();
                check.Size = new Size(30, 30);
                check.Location = new Point(x, y);
                check.Appearance = Appearance.Button;
                check.TabIndex = i - 1;
                check.BackColor = Color.White;
                toolTip1.SetToolTip(check, "No marcado");
                this.check.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
                this.Controls.Add(check);

                x += 40;

                if (i % 9 == 0)
                {
                    x = 30;
                    y += 40;
                }
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;

            if (check.Checked)
            {
                toolTip1.SetToolTip(check, "Marcado");
                marcados++;
            } else
            {
                toolTip1.SetToolTip(check, "No marcado");
                marcados--;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) // Esto prefiero hacerlo con if elses pero bueno
        {
            Button[] btns = { btnJugar, btnReset, btnSalir };

            Array.ForEach(btns, (btn) => btn.BackColor = Color.Beige);

            btns[cont % 3].BackColor = Color.Yellow;
            cont++;
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            List<int> resultados = new List<int>();
            Random rand = new Random();

            if (marcados != 6)
            {
                MessageBox.Show("Debes marcar exactamente 6 números y has marcado " + marcados);
            } else
            {
                lblResultados.Text = "Resultados: ";

                for (int i = 0; i < 6; i++)
                {
                    int num;

                    do
                    {
                        num = rand.Next(1, 50);
                    } while (resultados.Contains(num));

                    resultados.Add(num);
                    lblResultados.Text += $"{num, 4}";
                }

                foreach (Control c in this.Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox check = (CheckBox)c;

                        foreach (int n in resultados)
                        {
                            if (int.Parse(check.Text) == n && check.Checked)
                            {
                                check.BackColor = Color.Gold;
                                aciertos++;
                            }
                        }
                    }
                }

                if (aciertos > 0)
                {
                    FrmDatos form2 = new FrmDatos();
                    DialogResult result = form2.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        listBox1.Items.Add($"Nombre: {form2.textBox1.Text} | Edad: {form2.comboBox1.SelectedItem} | Aciertos: {aciertos}");
                    }

                    btnReset.PerformClick();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                    c.BackColor = Color.White;
                }
            }

            lblResultados.Text = "Resultados: ";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                if (MessageBox.Show("Se saldrá del programa", "Lotería Simple", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedIndices.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}