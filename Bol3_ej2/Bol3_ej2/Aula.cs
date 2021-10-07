using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bol3_ej2
{
    class Aula
    {
        private string[] alumnos = { "Alumno1", "Alumno2", "Alumno3", "Alumno4", "Alumno5" +
                "Alumno6", "Alumno7", "Alumno8", "Alumno9", "Alumno10" };
        public string[] Alumnos
        {
            set
            {
                for (int i = 0; i <= value.Length-1; i++)
                {
                    this.alumnos[i] = value[i].Trim(' ').ToUpper();
                }
            }

            get
            {
                return alumnos;
            }
        }
        public int[,] notas;

        public Aula(string[] nombres)
        {
            notas = new int[4, alumnos.Length];
        }
    }
}
