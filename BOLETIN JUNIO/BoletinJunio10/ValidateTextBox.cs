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
        }

        private eTipo tipo = eTipo.Numérico;

        [Category("Frikilove")]
        [Description("Determina si se deben introducir caracteres numéricos o de texto")]
        public eTipo Tipo
        {
            set
            {
                if (Enum.IsDefined(typeof(eTipo), value))
                {
                    tipo = value;
                    Refresh();
                }
            }

            get
            {
                return tipo;
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CambiaTexto?.Invoke(this, new EventArgs());
            Refresh();
        }

        public bool Comprobar(string cadena)
        {
            bool esLetra = false;

            //bool esNum = int.TryParse(cadena.Trim(), out _);
            //esNum = cadena.Trim().Any(char.IsDigit);
            //esNum = cadena.Trim().Any(char.IsLetter);

            if (!string.IsNullOrWhiteSpace(cadena))
            {
                if (tipo == eTipo.Textual)
                {
                    for (int i = 0; i < cadena.Length; i++)
                    {
                        if (char.IsLetter(cadena[i]))
                        {
                            esLetra = true;
                        }
                        else
                        {
                            esLetra = false;
                            return esLetra;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < cadena.Length; i++)
                    {
                        if (char.IsDigit(cadena[i]))
                        {
                            esLetra = true;
                        }
                        else
                        {
                            esLetra = false;
                            return esLetra;
                        }
                    }
                }
            }

            return esLetra;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Height = textBox1.Height + 15;
            textBox1.Width = Width - 15;

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen pen;

            // Si tipo es textual y Comprobar que sea letra da true || Si tipo es numérico y Comprobar que sea letra da false
            if ((tipo == eTipo.Textual && Comprobar(textBox1.Text)) || (tipo == eTipo.Numérico && Comprobar(textBox1.Text)))
            {
                pen = new Pen(Color.Green);
            }
            else
            {
                pen = new Pen(Color.Red);
            }
            pen = tipo == eTipo.Textual && Comprobar(textBox1.Text) || (tipo == eTipo.Numérico && Comprobar(textBox1.Text)) ? new Pen(Color.Green) : new Pen(Color.Red);

            graphics.DrawRectangle(pen, 5, 5, textBox1.Width + 5, textBox1.Height + 5);
        }
    }
}