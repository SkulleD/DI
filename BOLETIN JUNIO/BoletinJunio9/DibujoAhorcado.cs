using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoletinJunio9
{
    public partial class DibujoAhorcado : Control
    {
        public DibujoAhorcado()
        {
            InitializeComponent();
        }

        private int errores = 0;

        [Category("Ahorcado")]
        [Description("Número de errores al no acertar una letra")]
        public int Errores
        {
            set
            {
                if (value != errores)
                {
                    CambiaError?.Invoke(this, new EventArgs());
                }

                errores = value;
            }

            get
            {
                return errores;
            }
        }

        [Category("Ahorcado")]
        [Description("Se lanza cada vez que cambia el número de errores")]
        public event EventHandler CambiaError;

        [Category("Ahorcado")]
        [Description("Se lanza cuando el dibujo del ahorcado es completado")]
        public event EventHandler Ahorcado;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.Black);

            int centrar = Right - Left;
            // Point brazos = new Point(Width / 2, 40);
            // Point piernas = new Point(Width / 2, 80);

            //Horca
            graphics.DrawLine(pen, 0, Height - 1, centrar, Height - 1); // Base
            graphics.DrawLine(pen, 0, Height, 0, 15); // Soporte
            graphics.DrawLine(pen, 0, 15, Width / 2, 15); // Techo
            graphics.DrawLine(pen, Width / 2, 15, Width / 2, 25); // Soga

            //Ahorcado
            graphics.DrawEllipse(pen, (Width / 2) - 8, 25, 15, 15); // Cabeza
            graphics.DrawLine(pen, Width / 2, 40, Width / 2, 80); // Tronco
            graphics.DrawLine(pen, Width / 2, 40, (Width / 2) - 10, 75); // Brazo 1
            graphics.DrawLine(pen, Width / 2, 40, (Width / 2) + 10, 75); // Brazo 2
            graphics.DrawLine(pen, Width / 2, 80, (Width / 2) - 10, 120); // Pierna 1
            graphics.DrawLine(pen, Width / 2, 80, (Width / 2) + 10, 120); // Pierna 2

            pen.Dispose();
        }
    }
}