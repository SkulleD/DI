using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinJunio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombreAlumnos = new string[10];
            string[] nombreAsignaturas = new string[5];

            Usuario user = new Usuario();
            Aula clase = new Aula(nombreAlumnos, nombreAsignaturas);
            clase.muestraNotas();
        }
    }
}
