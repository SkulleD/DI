using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBol7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Text = "Letra: " + e.KeyCode.ToString();
        }

        private void labelTextBox1_TxtChanged(object sender, EventArgs e)
        {
            labelTextBox1.TextLabel = "Changed";
        }
    }
}