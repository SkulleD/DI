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
        private bool addLinea = false; // Para solo dibujar la siguiente línea cuando se falle
        private delegate void lineasAhorcado();
        private lineasAhorcado[] drawLineas = new lineasAhorcado[] { };

        public DibujoAhorcado()
        {
            InitializeComponent();
        }

        private int errores = 1;

        [Category("Ahorcado")]
        [Description("Número de errores al no acertar una letra.")]
        public int Errores
        {
            set
            {
                if (value != errores)
                {
                    addLinea = true;
                    CambiaError?.Invoke(this, new EventArgs());
                    Refresh();
                }

                errores = value;

                if (errores == 10)
                {
                    Ahorcado?.Invoke(this, new EventArgs());
                }
            }

            get
            {
                return errores;
            }
        }

        [Category("Ahorcado")]
        [Description("Se lanza cada vez que cambia el número de errores.")]
        public event EventHandler CambiaError;

        [Category("Ahorcado")]
        [Description("Se lanza cuando el dibujo del ahorcado es completado.")]
        public event EventHandler Ahorcado;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.Black);

            // Point brazos = new Point(Width / 2, 40);
            // Point piernas = new Point(Width / 2, 80);

            graphics.DrawLine(pen, 0, Height - 1, Right - Left, Height - 1); // Base

            if (addLinea)
            {
                //drawLineas = new lineasAhorcado[]
                //{
                //    () => { graphics.DrawLine(pen, 0, Height, 0, 15); },
                //    () => { graphics.DrawLine(pen, 0, 15, Width / 2, 15); },
                //    () => { graphics.DrawLine(pen, Width / 2, 15, Width / 2, 25); },
                //    () => { graphics.DrawEllipse(pen, (Width / 2) - 8, 25, 15, 15); },
                //    () => { graphics.DrawLine(pen, Width / 2, 40, Width / 2, 80); },
                //    () => { graphics.DrawLine(pen, Width / 2, 40, (Width / 2) - 10, 75); },
                //    () => { graphics.DrawLine(pen, Width / 2, 40, (Width / 2) + 10, 75); },
                //    () => { graphics.DrawLine(pen, Width / 2, 80, (Width / 2) - 10, 120); },
                //    () => { graphics.DrawLine(pen, Width / 2, 80, (Width / 2) + 10, 120); },
                //};

                switch (errores)
                {
                    //Horca
                    case 1:
                        graphics.DrawLine(pen, 0, Height, 0, 15); // Soporte
                        break;
                    case 2:
                        graphics.DrawLine(pen, 0, 15, Width / 2, 15); // Techo
                        goto case 1;
                        break;
                    case 3:
                        graphics.DrawLine(pen, Width / 2, 15, Width / 2, 25); // Soga
                        goto case 2;
                        break;

                    //Ahorcado
                    case 4:
                        graphics.DrawEllipse(pen, (Width / 2) - 8, 25, 15, 15); // Cabeza
                        goto case 3;
                        break;
                    case 5:
                        graphics.DrawLine(pen, Width / 2, 40, Width / 2, 80); // Tronco
                        goto case 4;
                        break;
                    case 6:
                        graphics.DrawLine(pen, Width / 2, 40, (Width / 2) - 10, 75); // Brazo 1
                        goto case 5;
                        break;
                    case 7:
                        graphics.DrawLine(pen, Width / 2, 40, (Width / 2) + 10, 75); // Brazo 2
                        goto case 6;
                        break;
                    case 8:
                        graphics.DrawLine(pen, Width / 2, 80, (Width / 2) - 10, 120); // Pierna 1
                        goto case 7;
                        break;
                    case 9:
                        graphics.DrawLine(pen, Width / 2, 80, (Width / 2) + 10, 120); // Pierna 2
                        goto case 8;
                        break;
                }
            }

            addLinea = false;
            pen.Dispose();
        }
    }
}