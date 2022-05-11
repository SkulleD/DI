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

namespace BoletinJunio8
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
            color1 = Color.Yellow;
            color2 = Color.Fuchsia;
        }

        private eMarca marca = eMarca.Nada;

        [Category("Appearance")]
        [Description("Indica qué marca aparecerá junto al texto")]
        public eMarca Marca
        {
            set
            {
                marca = value;
                Refresh();
            }

            get
            {
                return marca;
            }
        }

        private Image imagen;

        [Category("Appearance")]
        [Description("Imagen para usar como marca")]
        public Image Imagen
        {
            set
            {
                imagen = value;

                if (imagen == null)
                {
                    marca = eMarca.Nada;
                }

                Refresh();
            }

            get
            {
                return imagen;
            }
        }

        private Color color1;

        [Category("Appearance")]
        [Description("Primer color del fondo gradiente")]
        public Color Color1
        {
            set
            {
                color1 = value;
                Refresh();
            }

            get
            {
                return color1;
            }
        }

        private Color color2;

        [Category("Appearance")]
        [Description("Segundo color del fondo gradiente")]
        public Color Color2
        {
            set
            {
                color2 = value;
                Refresh();
            }

            get
            {
                return color2;
            }
        }

        private bool gradiente = true;

        [Category("Appearance")]
        [Description("Activa o desactiva el fondo gradiente")]
        public bool Gradiente
        {
            set
            {
                gradiente = value;
                Refresh();
            }

            get
            {
                return gradiente;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            int grosor = 0;
            int offsetX = 0;
            int offsetY = 0;
            int height = Font.Height;

            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (gradiente)
            {
                LinearGradientBrush linearBrush = new LinearGradientBrush(
                    new Point(0, 0),
                    new Point(200, 100),
                    Color1,
                    Color2);

                graphics.FillRectangle(linearBrush, 0, 0, Width, Height);
                linearBrush.Dispose();
            }

            switch (Marca)
            {
                case eMarca.Nada:
                    break;
                case eMarca.Cruz:
                    grosor = 3;
                    graphics.DrawLine(new Pen(Color.OrangeRed, grosor), grosor, grosor, height, height);
                    graphics.DrawLine(new Pen(Color.OrangeRed, grosor), height, grosor, grosor, height);
                    offsetX = height + grosor;
                    offsetY = grosor / 2;

                    rect = new Rectangle(grosor, grosor, height, height);
                    graphics.DrawRectangle(new Pen(Color.Transparent), rect);
                    break;
                case eMarca.Circulo:
                    grosor = 25;
                    graphics.DrawEllipse(new Pen(Color.DarkTurquoise, 40), grosor, grosor, height, height);
                    offsetX = height + grosor;
                    offsetY = grosor;

                    rect = new Rectangle(grosor, grosor, height, height);
                    graphics.DrawRectangle(new Pen(Color.Transparent), rect);
                    break;
                case eMarca.Imagen:
                    if (Imagen != null)
                    {
                        height = height;
                        grosor = 20;
                        graphics.DrawImage(Imagen, grosor, grosor, height, height);
                        offsetX = height + grosor;
                        offsetY = grosor;
                    }

                    rect = new Rectangle(grosor, grosor, height, height);
                    graphics.DrawRectangle(new Pen(Color.Transparent), rect);
                    break;
            }

            SolidBrush brush = new SolidBrush(ForeColor);
            graphics.DrawString(this.Text, Font, brush, offsetX + grosor, offsetY);
            Size size = graphics.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(size.Width + offsetX + grosor, size.Height + offsetY * 2);
            brush.Dispose();
        }

        [Category("Misc")]
        [Description("Se activa cuando se pulsa en la imagen de EtiquetaAviso")]
        public event EventHandler ClickEnMarca;

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (e.X <= rect.Right)
            {
                ClickEnMarca?.Invoke(this, new EventArgs());
            }
        }
    }
}