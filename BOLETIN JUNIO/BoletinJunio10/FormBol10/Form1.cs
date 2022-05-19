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

    public partial class Form1 : Form
    {
        private List<StructFormat> frikis = new List<StructFormat>();
        struct {

        }
        private string nombre;
        private int edad;
        private string foto;

        //Timer
        int titleLength; // Se usa para obtener la longitud de la string del título.
        int i; // Se usa para colocar cada caracter del título en el timer.
        char[] charasTitulo; // Se usa para ir colocando los caracteres del título desde el último al primero.

        public Form1()
        {
            InitializeComponent();

            titleLength = Text.Length;
            charasTitulo = Text.ToCharArray();
            i = titleLength - 1;
            Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Deseas salir del programa?", "Frikilove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i < 0) // Se reinicia el nombre y se le vuelve a asignar el último caracter.
            {
                i = titleLength - 1;
                Text = "";
            }

            Text = charasTitulo[i] + Text;  // Se le van sumando los caracteres, del último al primero.
            i--;
        }
    }
}
