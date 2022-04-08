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
            double total = notas.Length;// nombreAlumnos.Length * nombreAsignaturas.Length;
            double media = 0;

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    cont += notas[i, j];
                }
            }

            media = cont / total;

            return media;
        }

        public double MediaAlumno(int numAlumno)  //Solo 1 bucle
        {
            double cont = 0;
            double total = nombreAsignaturas.Length;
            double media = 0;

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                if (i == numAlumno)
                {
                    for (int j = 0; j < notas.GetLength(1); j++)
                    {
                        cont += notas[i, j];
                    }
                }
            }

            media = cont / total;

            return media;
        }

        public double MediaAsignatura(int numAsignatura)  //Solo 1 bucle
        {
            double cont = 0;
            double total = nombreAlumnos.Length;
            double media = 0;

            for (int i = 0; i < notas.GetLength(0); i++)
            {

                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    if (j == numAsignatura)
                    {
                        cont += notas[i, j];
                    }
                }
            }

            media = cont / total;

            return media;
        }

        public void NotaMaxMinAlumno(int numAlumno, ref int max, ref int min)  //Solo 1 bucle
        {
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                if (i == numAlumno)
                {
                    for (int j = 0; j < notas.GetLength(1); j++)
                    {
                        if (max <= notas[i, j])
                        {
                            max = notas[i, j];
                        }

                        if (min >= notas[i, j])
                        {
                            min = notas[i, j];
                        }
                    }
                }
            }
            //Console.WriteLine("Nota max:" + max);
            //Console.WriteLine("Nota min:" + min);
        }

        public Hashtable DevuelveAprobados()   //Revisar
        {
            Hashtable hashtable = new Hashtable();
            int[] arrayExtra = new int[nombreAsignaturas.Length];

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    if (notas[i, j] >= 5)
                    {
                        arrayExtra[j] = notas[i, j];
                    }
                }

                hashtable.Add(nombreAlumnos[i], arrayExtra);
            }

            return hashtable;
        }
    }
}