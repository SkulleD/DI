using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinJunio2
{
    class Usuario
    {
        string[] nombreAlumnos = new string[7];
        string[] nombreAsignaturas = new string[4];
        Aula aula;

        public Usuario()
        {
            for (int i = 0; i < nombreAlumnos.Length; i++) // Rellena array de nombres alumnos
            {
                this.nombreAlumnos[i] = "Alumno " + (i + 1);
            }

            for (int i = 0; i < nombreAsignaturas.Length; i++) // Rellena array de nombres asignaturas
            {
                this.nombreAsignaturas[i] = "Asignatura " + (i + 1);
            }

            aula = new Aula(nombreAlumnos, nombreAsignaturas);
        }

        public void Menu()  //Sale del menu si fallo
        {
            int opcion = 0;

            do
            {
                try
                {

                    Console.WriteLine("1- Visualizar tabla completa\n" +
                        "2- Calcular media de notas de toda la tabla\n" +
                        "3- Media de un alumno\n" +
                        "4- Media de una asignatura\n" +
                        "5- Visualizar notas de un alumno\n" +
                        "6- Visualizar notas de una asignatura\n" +
                        "7- Nota máxima y mínima de un alumno\n" +
                        "8- Tabla de solo aprobados\n" +
                        "9- Salir del programa");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            MuestraNotasTabla();
                            break;
                        case 2:
                            Console.WriteLine(string.Format("Media de notas: {0:0.00}", aula.MediaNotasTabla()));
                            break;
                        case 3:
                            Console.WriteLine(string.Format("Media de alumno: {0:0.00} ", aula.MediaAlumno(EnterAlumno())));
                            break;
                        case 4:
                            Console.WriteLine(string.Format("Media de asignatura: {0:0.00}", aula.MediaAsignatura(EnterAsignatura())));
                            break;
                        case 5:
                            MuestraNotasAlumno();
                            break;
                        case 6:
                            MuestraNotasAsignatura();
                            break;
                        case 7:
                            int min = 10;
                            int max = 0;
                            aula.NotaMaxMinAlumno(EnterAlumno(), ref max, ref min);
                            Console.WriteLine($"Nota máxima: {max}\nNota mínima: {min}");
                            break;
                        case 8:
                            MuestraAprobados(aula.DevuelveAprobados());
                            break;
                        case 9:
                            Console.WriteLine("¡Hasta otra!");
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                catch (Exception ex) when (ex is FormatException || ex is OverflowException || ex is ArgumentException)
                {
                    Console.WriteLine("Error de entrada.");
                }
            } while (opcion != 9);
        }

        private void MuestraNotasTabla()  //Con cadenas de formato no tabuladores
        {
            Console.Write($"{"",10}");

            for (int i = 0; i < nombreAsignaturas.Length; i++) // Nombres de asignaturas
            {
                Console.Write($"{nombreAsignaturas[i],15}");
            }

            Console.WriteLine();

            for (int i = 0; i < aula.notas.GetLength(0); i++)
            {
                Console.Write($"{nombreAlumnos[i],10}"); // Nombres de alumnos

                for (int j = 0; j < aula.notas.GetLength(1); j++)
                {
                    Console.Write($"{aula.notas[i, j],15}"); // Notas
                }

                Console.WriteLine();
            }
        }

        private void MuestraNotasAlumno()
        {
            int num = EnterAlumno();

            Console.Write($"{"",10}");

            for (int i = 0; i < nombreAsignaturas.Length; i++) // Nombres de asignaturas
            {
                Console.Write($"{nombreAsignaturas[i],15}");
            }

            Console.WriteLine();

            // (Sobraba un bucle)
            Console.Write($"{nombreAlumnos[num],10}"); // Nombres de alumnos

            for (int i = 0; i < aula.notas.GetLength(1); i++)
            {
                Console.Write($"{aula.notas[num, i],15}"); // Notas
            }

            Console.WriteLine();
        }

        private void MuestraNotasAsignatura()
        {
            int num = EnterAsignatura();

            Console.Write($"{"",10}");

            // (Sobraba un bucle)
            Console.WriteLine(nombreAsignaturas[num]); // Nombres de asignaturas

            // (Sobraba un bucle)
            for (int i = 0; i < aula.notas.GetLength(0); i++)
            {
                Console.Write(nombreAlumnos[i]); // Nombres de alumnos
                Console.Write($"{aula.notas[i, num],10}"); // Notas

                Console.WriteLine();
            }
        }

        public void MuestraAprobados(Hashtable hash)
        {
            foreach (DictionaryEntry entry in hash)
            {
                Console.Write("Nombre: {0}\nNotas: ", entry.Key);

                for (int i = 0; i < ((int[])entry.Value).Length; i++)
                {
                    Console.Write(((int[])entry.Value)[i] + " ");
                }

                Console.WriteLine();
            }
        }

        private int EnterAlumno()
        {
            int numAlumno = 0;

            do
            {
                try
                {
                    Console.WriteLine("¿Número de alumno? Num máximo de alumno: " + nombreAlumnos.Length);
                    numAlumno = int.Parse(Console.ReadLine()) - 1;
                }
                catch (Exception ex) when (ex is FormatException || ex is ArgumentException || ex is OverflowException)
                {
                    Console.WriteLine("Error de entrada.");
                }

            } while (numAlumno + 1 > nombreAlumnos.Length || numAlumno < 0);

            return numAlumno;
        }

        private int EnterAsignatura()
        {
            int numAsignatura = 0;

            do
            {
                try
                {
                    Console.WriteLine("¿Número de asignatura? Num máximo de asignatura: " + nombreAsignaturas.Length);
                    numAsignatura = int.Parse(Console.ReadLine()) - 1;
                }
                catch (Exception ex) when (ex is FormatException || ex is ArgumentException || ex is OverflowException)
                {
                    Console.WriteLine("Error de entrada.");
                }
            } while (numAsignatura + 1 > nombreAsignaturas.Length || numAsignatura < 0);

            return numAsignatura;
        }
    }
}