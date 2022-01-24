using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        Circulo
    }

    public partial class EtiquetaAviso : UserControl
    {
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

            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            switch (Marca)
            {
                case eMarca.Cruz:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    graphics.DrawLine(lapiz, grosor, grosor, altura, altura);
                    graphics.DrawLine(lapiz, altura, grosor, grosor, altura);
                    offsetX = altura + grosor;
                    offsetY = grosor / 2;
                    lapiz.Dispose();
                    break;
                case eMarca.Circulo:
                    grosor = 20;
                    graphics.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor, altura, altura);
                    offsetX = altura + grosor;
                    offsetY = grosor;
                    break;
            }

            SolidBrush brush = new SolidBrush(this.ForeColor);
            graphics.DrawString(this.Text, this.Font, brush, offsetX + grosor, offsetY);
            Size size = graphics.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(size.Width + offsetX, size.Height + offsetY * 2);
            this.Text = "sfdjdsfjdgd";
            brush.Dispose();
        }
    }
}