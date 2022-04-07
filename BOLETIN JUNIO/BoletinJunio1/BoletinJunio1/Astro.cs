using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinJunio1
{
    class Astro
    {
        // IMPORTANTES LOS CONSTRUCTORES
        public Astro() : this("", 0)
        {   
        }

        public Astro(string nombre, double radio)
        {
            Nombre = nombre;
            Radio = radio;
        }

        private string nombre;
        public string Nombre
        {
            set
            {
                nombre = value.ToUpper().Trim();
            }

            get
            {
                return nombre;
            }
        }

        public string GetNombre(string caracter)
        {
            string nombreSeparado = Nombre[0].ToString();

            for (int i = 1; i <= Nombre.Length - 1; i++)
            {
                nombreSeparado += caracter + Nombre[i];
            }

            return nombreSeparado;
        }

        private double radio;
        public double Radio
        {
            set
            {
                if (value < 0)
                {
                    throw new RadioNegativoException("Error: el radio no puede ser negativo.");
                }

                radio = value; //Math.Round(value, 2, MidpointRounding.AwayFromZero);
            }

            get
            {
                return radio;
            }
        }

        // Comprueba si el nombre del Astro es igual a otro existente y si el objeto en sí es un Astro
        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() == this.GetType())
            {
                Astro astroCheckeador = (Astro)obj;

                if (nombre.Equals(astroCheckeador.Nombre))
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            string mostrar = $"Nombre: {GetNombre("_")}, Radio: {Radio:F2}";
            return mostrar;
        }
    }
}