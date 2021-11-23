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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("3560"))
            {
                this.Close();
            }
        }
    }
}
