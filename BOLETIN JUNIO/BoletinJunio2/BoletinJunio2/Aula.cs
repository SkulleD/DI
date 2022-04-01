using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinJunio2
{
    class Aula
    {
        int[,] notas;
        string[] nombreAlumnos;
        string[] nombreAsignaturas;
        Random random = new Random();

        public Aula(string[] nombreAlumnos, string[] nombreAsignaturas)
        {
            notas = new int[nombreAlumnos.Length, nombreAsignaturas.Length];


        }

        private void devuelveAprobados()
        {

        }
    }
}
