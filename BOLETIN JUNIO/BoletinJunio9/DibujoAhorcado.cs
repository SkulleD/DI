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
        }
    }
}
