using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinJunio2
{
    class Aula
    {
        private int[,] notas;
        string[] nombreAlumnos;
        string[] nombreAsignaturas;
        Random random = new Random();

        public Aula(string[] nombreAlumnos, string[] nombreAsignaturas)
        {
            notas = new int[nombreAlumnos.Length, nombreAsignaturas.Length];
            this.nombreAlumnos = new string[nombreAlumnos.Length];
            this.nombreAsignaturas = new string[nombreAsignaturas.Length];

            for (int i = 0; i <= this.nombreAlumnos.Length + 1; i++) // Rellena array de nombres alumnos
            {
                this.nombreAlumnos[i] = "Alumno 1" + i + 1;
            }

            for (int i = 0; i <= this.nombreAsignaturas.Length + 1; i++) // Rellena array de nombres asignaturas
            {
                this.nombreAsignaturas[i] = "Asignatura 1" + i + 1;
            }

            for (int i = 0; i < notas.GetLength(0); i++) // Rellena array de notas
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    notas[i, j] = random.Next(0, 11); // Notas entre 0 y 10
                }
            }
        }

        private void devuelveAprobados()
        {

        }
        public void muestraNotas()
        {
            for (int i = 0; i < notas.GetLength(0); i++) // Rellena array de notas
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    Console.WriteLine(notas[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}