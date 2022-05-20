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
                Refresh();
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

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (tipo == eTipo.Textual && Comprobar(textBox1.Text)) // Si tipo es textual y Comprobar que sea letra da true
            {
                graphics.DrawRectangle(new Pen(Color.Green), 5, 5, Width - 10, Height - 10);
            }
            else if (tipo == eTipo.Numérico && Comprobar(textBox1.Text)) // Si tipo es numérico y Comprobar que sea letra da false
            {
                graphics.DrawRectangle(new Pen(Color.Green), 5, 5, Width - 10, Height - 10);
            }
            else
            {
                graphics.DrawRectangle(new Pen(Color.Red), 5, 5, Width - 10, Height - 10);
            }
        }
    }
}