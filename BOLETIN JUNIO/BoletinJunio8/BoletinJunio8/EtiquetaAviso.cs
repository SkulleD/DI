using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        Circulo
    }

    public partial class EtiquetaAviso : Control
    {
        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        private eMarca marca = eMarca.Nada;

        [Category("Appearance")]
        [Description("Indica la marca que aparecerá junto al texto")]
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
    }
}