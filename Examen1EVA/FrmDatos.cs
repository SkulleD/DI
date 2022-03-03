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
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();

            for (int i = 18; i < 101; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void btnAceptar_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Blue;
            ((Button)sender).Cursor = Cursors.Hand;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).UseVisualStyleBackColor = true;
            ((Button)sender).Cursor = Cursors.Default;
        }
    }
}
