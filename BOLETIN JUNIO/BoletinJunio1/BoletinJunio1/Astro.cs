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
        public Astro()
        {
            Nombre = "";
            Radio = 0;
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
            string[] nombreArray = nombre.Split(' ');
            string nombreSeparado = nombreArray[0];

            for (int i = 1; i <= nombreArray.Length - 1; i++)
            {
                nombreSeparado += caracter + nombreArray[i];
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

                radio = value;
            }

            get
            {
                return radio;
            }
        }

        // Comprueba si el nombre del Astro es igual a otro existente y si el objeto en sí es un Astro
        public override bool Equals(object obj)
        {
            Astro astroCheckeador = (Astro)obj;

            if (nombre.Equals(astroCheckeador.Nombre) && astroCheckeador is Astro)
            {
                return base.Equals(obj);
            }

            return false;
        }

        public override string ToString()
        {
            return string.Format("%s %.2f", GetNombre("_"), radio);
        }
    }
}