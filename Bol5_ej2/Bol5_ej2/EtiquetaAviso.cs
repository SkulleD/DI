using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bol5_ej2
{
    public enum eMarca
    {
        Nada,
        Cruz,
        Circulo,
        Imagen
    }

    public partial class EtiquetaAviso : Control
    {
        Rectangle rect;

        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        private eMarca marca = eMarca.Nada;

        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public eMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }

            get
            {
                return marca;
            }
        }

        private Image imagen;
        [Category("Appearance")]
        [Description("Cambia la imagen de la marca")]
        public Image Imagen
        {
            set
            {
                imagen = value;
                if (imagen == null)
                {
                    marca = eMarca.Nada;
                }
                this.Refresh();
            }
            get
            {
                return imagen;
            }
        }

        private Color color1;
        [Category("Appearance")]
        [Description("Cambia el primer color del gradiente")]
        public Color Color1
        {
            set
            {
                color1 = value;
                this.Refresh();
            }
            get
            {
                return color1;
            }
        }

        private Color color2;
        [Category("Appearance")]
        [Description("Cambia el segundo color del gradiente")]
        public Color Color2
        {
            set
            {
                color2 = value;
                this.Refresh();
            }
            get
            {
                return color2;
            }
        }

        private bool gradiente = true;
        [Category("Appearance")]
        [Description("Cambia el segundo color del gradiente")]
        public bool Gradiente
        {
            set
            {
                gradiente = value;
                this.Refresh();
            }
            get
            {
                return gradiente;
            }
        }


        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics graphics = pe.Graphics;
            int grosor = 0;
            int offsetX = 0;
            int offsetY = 0;
            int altura = this.Font.Height;

            SolidBrush brush = new SolidBrush(this.ForeColor);
            LinearGradientBrush linearBrush;

            if (gradiente) // Si es true sale el gradiente de background, sino NO
            {
                linearBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(0, 100),
                color1,
                color2);
                graphics.FillRectangle(linearBrush, 0, 0, this.Width, this.Height);
                linearBrush.Dispose();
            }


            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            switch (Marca)
            {
                case eMarca.Nada:

                    break;
                case eMarca.Cruz:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    graphics.DrawLine(lapiz, grosor, grosor, altura, altura);
                    graphics.DrawLine(lapiz, altura, grosor, grosor, altura);
                    offsetX = altura + grosor;
                    offsetY = grosor / 2;

                    rect = new Rectangle(grosor, grosor, altura, altura);
                    graphics.DrawRectangle(new Pen(Color.Transparent), rect);
                    lapiz.Dispose();
                    break;
                case eMarca.Circulo:
                    grosor = 20;
                    graphics.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor, altura, altura);
                    offsetX = altura + grosor;
                    offsetY = grosor;

                    rect = new Rectangle(grosor, grosor, altura, altura);
                    graphics.DrawRectangle(new Pen(Color.Transparent), rect);
                    break;
                case eMarca.Imagen:
                    if (Imagen != null) // AHORA FUNCIONA ????
                    {
                        grosor = 20;
                        graphics.DrawImage(Imagen, grosor, grosor, altura, altura);
                        offsetX = altura + grosor;
                        offsetY = grosor;

                        rect = new Rectangle(grosor, grosor, altura, altura);
                        graphics.DrawRectangle(new Pen(Color.Transparent), rect);
                    }
                    break;
            }

            graphics.DrawString(this.Text, this.Font, brush, offsetX + grosor, offsetY);
            Size size = graphics.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(size.Width + offsetX + grosor, size.Height + offsetY * 2);

            brush.Dispose();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (e.X <= rect.Right)
            {
                this.Text = "Marca Clickada!";
            } else
            {
                this.Text = "Soy una etiqueta bonita";
            }

            if (ClickEnMarca != null)
            {
                ClickEnMarca(this, new EventArgs());
            }
        }

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad click se activa.")]
        public event EventHandler ClickEnMarca;

    }
}