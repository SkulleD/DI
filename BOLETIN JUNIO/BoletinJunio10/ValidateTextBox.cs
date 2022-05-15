using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoletinJunio10
{
    public enum eTipo
    {
        Numérico,
        Textual
    }

    public partial class ValidateTextBox : UserControl
    {
        public ValidateTextBox()
        {
            InitializeComponent();
            Height = textBox1.Height + 20;
            textBox1.Width = Width - 20;
        }

        [Category("Frikilove")]
        [Description("Texto de la TextBox.")]
        public string Texto
        {
            set
            {
                textBox1.Text = value;
            }

            get
            {
                return textBox1.Text;
            }
        }

        [Category("Frikilove")]
        [Description("Se activa cuando cambia el texto de la TextBox.")]
        public event EventHandler CambiaTexto;


        public bool Comprobar(string cadena)
        {
            bool esNum = int.TryParse(cadena, out int cad);

            return esNum;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (Comprobar(textBox1.Text))
            {
                graphics.DrawRectangle(new Pen(Color.Green), 5, 5, Width - 5, Height - 5);
            }
            else
            {
                graphics.DrawRectangle(new Pen(Color.Red), 5, 5, Width - 5, Height - 5);
            }

        }
    }
}