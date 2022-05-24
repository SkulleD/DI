using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenCartas
{
    [DefaultEvent("AlcanzaMax")]
    public partial class Carta : UserControl
    {
        public Carta()
        {
            InitializeComponent();
        }

        private Image imagen;
        [Category("Examen")]
        [Description("Imagen de la carta.")]
        public Image Imagen
        {
            set
            {
                imagen = value;
                pb.Image = imagen;
            }

            get
            {
                return pb.Image;
            }
        }

        private int nivel = 0;
        [Category("Examen")]
        [Description("Nivel de la carta.")]
        public int Nivel
        {
            set
            {
                nivel = value;
                lbl.Text = nivel.ToString();
            }

            get
            {
                return nivel;
            }
        }

        private int valor = 0;
        [Category("Examen")]
        [Description("Experiencia de la carta.")]
        public int Valor
        {
            set
            {
                if (value > 100)
                {
                    valor = 100;

                    if (Enabled) // El evento solo se lanza si el compomente está habilitado.
                    {
                        AlcanzaMax?.Invoke(this, new EventArgs());
                    }

                    //if (AlcanzaMax != null)
                    //{
                    //    AlcanzaMax(this, new EventArgs()); // La otra manera de llamar al evento.
                    //}
                }

                if (value < 0)
                {
                    valor = 0;
                }

                valor = value;

                Refresh();
            }

            get
            {
                return valor;
            }
        }

        [Category("Examen")]
        [Description("Se lanza cuando la experiencia de una carta llegue al máximo")]
        public event EventHandler AlcanzaMax;

        private void lbl_DoubleClick(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            pb.Width = Width;
            pb.Height = Height - lbl.Height;
            lbl.Location = new Point(0, pb.Height);

            Graphics graphics = e.Graphics;

            int ancho = (Width - lbl.Width) * Valor / 100;
            Color color = Color.Blue;

            if (Valor == 100)
            {
                color = Color.Green;
            }

            if (!Enabled) // NO FUNCIONA
            {
                color = Color.LightGray;
            }

            graphics.FillRectangle(new SolidBrush(color), lbl.Width, lbl.Top, ancho, lbl.Height);
        }
    }
}
