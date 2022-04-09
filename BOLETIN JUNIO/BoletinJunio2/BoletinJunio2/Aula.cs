using System;
using System.Collections;
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
            double total = notas.Length;// nombreAlumnos.Length * nombreAsignaturas.Length;

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    cont += notas[i, j];
                }
            }

            return cont / total;
        }

        public double MediaAlumno(int numAlumno)  //Solo 1 bucle
        {
            double cont = 0;
            double total = nombreAsignaturas.Length;

            for (int i = 0; i < notas.GetLength(1); i++)
            {
                cont += notas[numAlumno, i];
            }

            return cont / total;
        }

        public double MediaAsignatura(int numAsignatura)  //Solo 1 bucle
        {
            double cont = 0;
            double total = nombreAlumnos.Length;

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                cont += notas[i, numAsignatura];
            }

            return cont / total;
        }

        public void NotaMaxMinAlumno(int numAlumno, ref int max, ref int min)  //Solo 1 bucle
        {
            for (int i = 0; i < notas.GetLength(1); i++)
            {
                if (max <= notas[numAlumno, i])
                {
                    max = notas[numAlumno, i];
                }

                if (min >= notas[numAlumno, i])
                {
                    min = notas[numAlumno, i];
                }
            }
        }

        public Hashtable DevuelveAprobados()   //Revisar
        {
            Hashtable hashtable = new Hashtable();
            int cont = 0;

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                int[] arrayExtra = new int[nombreAsignaturas.Length];
                cont = 0;

                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    if (notas[i, j] >= 5)
                    {
                        arrayExtra[j] = notas[i, j];
                        cont++;

                        if (cont == nombreAsignaturas.Length)
                        {
                            hashtable.Add(nombreAlumnos[i], arrayExtra = new int[nombreAsignaturas.Length]);
                        }
                    }
                }
            }

            return hashtable;
        }
    }
}