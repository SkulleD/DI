using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoRecu2evaExamen
{
    [DefaultEvent("AlcanzaMax")]
    public partial class Carta : UserControl
    {
        public Carta()
        {
            InitializeComponent();
        }

        public Carta(Image Imagen, int Valor, int Nivel, int x, int y, int w, int h)
        {
            InitializeComponent();
            this.Imagen = Imagen;
            this.Valor = Valor;
            this.Nivel = Nivel;
            this.Location = new Point(x, y);
            this.Size = new Size(w, h);
        }

        [Category("Examen")]
        [Description("Imagen de PictureBox")]
        public Image Imagen
        {
            set
            {
                pb.Image = value;
            }

            get
            {
                return pb.Image;
            }
        }

        private int nivel;

        [Category("Examen")]
        [Description("Nivel de carta")]
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

        private int valor;

        [Category("Examen")]
        [Description("Valor de la barra de experiencia")]
        public int Valor
        {
            set
            {
                if (value > 100)
                {
                    value = 100;
                }
                else
                {
                    if (value < 0)
                    {
                        value = 0;
                    }
                }

                valor = value;

                if (valor == 100 && this.Enabled)
                {
                    AlcanzaMax?.Invoke(this, new EventArgs());
                }

                this.Refresh();
            }

            get
            {
                return valor;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            pb.Width = this.Width;
            pb.Height = this.Height - lbl.Height;
            lbl.Location = new Point(0, pb.Height);

            int ancho = (this.Width - lbl.Width) * Valor / 100;
            Color color = Color.Blue;

            if (Valor == 100)
            {
                color = Color.Green;
            }

            if (!Enabled)
            {
                color = Color.LightGray;
            }

            e.Graphics.FillRectangle(new SolidBrush(color), lbl.Width, lbl.Top, ancho, lbl.Height);
        }

        [Category("Examen")]
        [Description("Al llegar a 100")]
        public event EventHandler AlcanzaMax;

        private void Lbl_DoubleClick(object sender, EventArgs e)
        {
            this.OnDoubleClick(e);
        }
    }
}
