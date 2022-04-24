using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoletinJunio6
{
    public partial class Form2 : Form
    {
        int intentos = 3;
        bool esNum = false;
        int pin;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            esNum = int.TryParse(txtPIN.Text, out pin);

            // Si no es nulo, ni cadena vacía, ni espacio en blanco y es un número de 4 caracteres de longitud entonces es true
            if (!string.IsNullOrWhiteSpace(txtPIN.Text) && esNum && txtPIN.Text.Length == 4)
            {
                if (txtPIN.Equals(pin.ToString()))
                {
                    Close();
                }
                else
                {
                    intentos--;

                    if (intentos == 0)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        lblTries.Text = $"Intentos restantes: {intentos}";
                    }
                }
            }
        }
    }
}