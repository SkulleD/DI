using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bol5_ej1
{
    public enum ePosicion
    {
        IZQUIERDA, DERECHA
    }

    public partial class LabelTextbox : UserControl
    {
        public LabelTextbox()
        {
            InitializeComponent();
            Text_Label = Name;
            Text_TextBox = "";
            recolocar();
        }


        void recolocar()
        {
            switch (posicion)
            {
                case ePosicion.IZQUIERDA:
                    lbl.Location = new Point(0, 0);
                    txt.Location = new Point(lbl.Width + Separacion, 0); // Label + TextBox
                    //txt.Width = this.Width - lbl.Width - Separacion;
                    this.Width = txt.Width + lbl.Width + Separacion;
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
                case ePosicion.DERECHA:
                    txt.Location = new Point(0, 0);
                    lbl.Location = new Point(txt.Width + Separacion, 0); // TextBox + Label
                    //txt.Width = this.Width - lbl.Width - Separacion;
                    this.Width = txt.Width + lbl.Width + Separacion;
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
        }

        private ePosicion posicion = ePosicion.IZQUIERDA;

        [Category("Appearance")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del TextBox")]
        public ePosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosicion), value))
                {
                    posicion = value;
                    recolocar();

                    if (CambiaPosicion != null)
                    {
                        CambiaPosicion(this, new EventArgs());
                    }

                    //CambiaPosicion?.Invoke(this, EventArgs.Empty); // Esto es otra manera de hacer lo del if
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

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posición cambia")]
        public event EventHandler CambiaPosicion;

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
                    recolocar();

                    if (SeparacionChanged != null)
                    {
                        SeparacionChanged(this, new EventArgs());
                    }
                }
            }

            get
            {
                return separacion;
            }
        }

        public event EventHandler SeparacionChanged;

        [Category("Appearance")]
        [Description("Texto asociado a la Label del control")]
        public string Text_Label
        {
            set
            {
                lbl.Text = value;
                recolocar();
            }

            get
            {
                return lbl.Text;
            }
        }

        [Category("Appearance")]
        [Description("Texto asociado al TextBox del control")]
        public string Text_TextBox
        {
            set
            {
                txt.Text = value;
            }

            get
            {
                return txt.Text;
            }
        }

        [Category("Appearance")]
        [Description("Oculta el texto introducido")]
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

        protected override void OnSizeChanged(EventArgs e) // Se acomoda al tamaño que se le ponga en formulario
        {
            base.OnSizeChanged(e);
            recolocar();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }

        private new void TextChanged(object sender, EventArgs e)
        {
            if (TxtChanged != null)
            {
                TxtChanged(this, new EventArgs());
            }
        }

        public event EventHandler TxtChanged;
    }
}