using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBol10
{
    public enum eAficion
    {
        Manga,
        SciFi,
        RPG,
        Fantasía,
        Terror,
        Tecnología
    }

    public enum Sexo
    {
        Hombre,
        Mujer
    }

    public enum SexoOpuesto
    {
        Hombre,
        Mujer
    }

    public partial class Entrada : Form
    {
        private List<StructFormat> frikis = new List<StructFormat>();
        private string nombre;
        private int edad;
        private string foto;

        public Entrada()
        {
            InitializeComponent();
        }
    }
}
