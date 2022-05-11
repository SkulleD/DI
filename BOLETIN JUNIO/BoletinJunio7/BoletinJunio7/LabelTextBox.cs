using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoletinJunio7
{
    public enum ePosicion
    {
        IZQUIERDA,
        DERECHA
    }

    public partial class LabelTextBox : UserControl
    {
        public LabelTextBox()
        {
            InitializeComponent();
            Recolocar();
        }

        private ePosicion posicion = ePosicion.IZQUIERDA;

        [Category("Appearance")]
        [Description("Indica si la label se sitúa a la IZQUIERDA o a la DERECHA del TextBox")]
        public ePosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosicion), value))
                {
                    posicion = value;
                    Recolocar();
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }

        private int separacion = 0;

        [Category("Design")]
        [Description("Píxeles de separación entre Label y TextBox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    Recolocar();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            get
            {
                return separacion;
            }
        }

        [Category("Appearance")]
        [Description("Texto asociado a la Label del control")]
        public string TextLabel
        {
            set
            {
                lbl.Text = value;
                Recolocar();
            }
            get
            {
                return lbl.Text;
            }
        }

        [Category("Appearance")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTextBox
        {
            set
            {
                txt.Text = value;
                Recolocar();
            }
            get
            {
                return txt.Text;
            }
        }

        void Recolocar()
        {
            switch (posicion)
            {
                case ePosicion.IZQUIERDA:
                    lbl.Location = new Point(0, 0);
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    //txt.Width = Width - lbl.Width - Separacion;
                    Width = txt.Width + lbl.Width + Separacion;
                    Height = Math.Max(txt.Height, lbl.Height);
                    break;
                case ePosicion.DERECHA:
                    txt.Location = new Point(0, 0);
                    //txt.Width = Width - lbl.Width - Separacion;
                    Width = txt.Width + lbl.Width + Separacion;
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
        }

        [Category("Appearance")]
        [Description("Oculta el texto con el caracter elegido")]
        public char PswChr
        {
            set
            {
                txt.PasswordChar = value;
            }
            get
            {
                return txt.PasswordChar;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Recolocar();
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

        [Category("Junio")]
        [Description("Se lanza cuando el texto cambia")]
        public event EventHandler TxtChanged;

        private new void TextChanged(object sender, EventArgs e) // También va sin hacer "new void"
        {
            if (TxtChanged != null)
            {
                TxtChanged(this, new EventArgs());
            }
        }
    }
}