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

    public partial class EtiquetaAviso : UserControl
    {
        Rectangle rect;

        public EtiquetaAviso()
        {
            InitializeComponent();
            this.Text = "Curro eres el mejor";
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


            Image image = Image.FromFile("C:\\Users\\AlvaroVila\\source\\repos\\Bol5_ej1\\Bol5_ej1Form\\burgallina.png");
            SolidBrush brush = new SolidBrush(this.ForeColor);
            LinearGradientBrush linearBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(0, 100),
                Color.FromArgb(100, 0, 60, 200),
                Color.FromArgb(190, 255, 120, 0));
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            switch (Marca)
            {
                case eMarca.Cruz:
                    graphics.FillRectangle(linearBrush, 0, 0, this.Width, this.Height);
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
                    graphics.FillRectangle(linearBrush, 0, 0, this.Width, this.Height);
                    grosor = 20;
                    graphics.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor, altura, altura);
                    offsetX = altura + grosor;
                    offsetY = grosor;

                    rect = new Rectangle(grosor, grosor, altura, altura);
                    graphics.DrawRectangle(new Pen(Color.Transparent), rect);
                    break;
                case eMarca.Imagen:
                    grosor = 20;
                    graphics.FillRectangle(linearBrush, 0, 0, this.Width, this.Height);
                    graphics.DrawImage(image, grosor, grosor, altura, altura);
                    offsetX = altura + grosor;
                    offsetY = grosor;

                    rect = new Rectangle(grosor, grosor, altura, altura);
                    graphics.DrawRectangle(new Pen(Color.Transparent), rect);
                    break;
            }

            graphics.DrawString(this.Text, this.Font, brush, offsetX + grosor, offsetY);
            Size size = graphics.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(size.Width + offsetX + grosor, size.Height + offsetY * 2);
       
            brush.Dispose();
            linearBrush.Dispose();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if ( e.X <= rect.Right)
            {
               this.Text = "Marca Clickada!";
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