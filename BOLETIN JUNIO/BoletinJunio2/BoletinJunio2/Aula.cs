using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinJunio2
{
    class Aula
    {
        public int[,] notas;
        public string[] nombreAlumnos;
        public string[] nombreAsignaturas;
        Random random = new Random();

        public Aula(string[] nombreAlumnos, string[] nombreAsignaturas)
        {
            notas = new int[nombreAlumnos.Length, nombreAsignaturas.Length];
            this.nombreAlumnos = new string[nombreAlumnos.Length];
            this.nombreAsignaturas = new string[nombreAsignaturas.Length];

            for (int i = 0; i < this.nombreAlumnos.Length; i++) // Rellena array de nombres alumnos
            {
                this.nombreAlumnos[i] = "Alumno " + (i + 1);
            }

            for (int i = 0; i < this.nombreAsignaturas.Length; i++) // Rellena array de nombres asignaturas
            {
                this.nombreAsignaturas[i] = "Asignatura " + (i + 1);
            }

            for (int i = 0; i < notas.GetLength(0); i++) // Rellena array de notas
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    notas[i, j] = random.Next(0, 11); // Notas entre 0 y 10
                }
            }
        }

        public double MediaNotasTabla()
        {
            double cont = 0;
            double total = nombreAlumnos.Length * nombreAsignaturas.Length;
            double media = 0;

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    cont += notas[i,j];
                }
            }

            media = cont / total;

            return media;
        }

        public void MediaAlumno()
        {

        }

        public void MediaAsignatura()
        {

        }

        public void NotaMaxMinAlumno()
        {

        }

        public void DevuelveAprobados()
        {

        }
    }
}