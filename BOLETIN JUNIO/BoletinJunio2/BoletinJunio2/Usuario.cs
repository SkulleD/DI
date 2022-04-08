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
        string[] nombreAlumnos = new string[5];
        string[] nombreAsignaturas = new string[3];
        Aula aula;

        public Usuario()
        {
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
                            Console.WriteLine("Media de notas: " + aula.MediaNotasTabla());
                            break;
                        case 3:
                            Console.WriteLine("Media de alumno: " + aula.MediaAlumno(0));
                            break;
                        case 4:
                            Console.WriteLine("Media de asignatura: " + aula.MediaAsignatura(0));
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
                            aula.NotaMaxMinAlumno(0, ref max, ref min);
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
                catch (Exception ex) when (ex is FormatException)
                {
                    Console.WriteLine("Error de entrada.");
                }
            } while (opcion != 9);
        }

        private void MuestraNotasTabla()  //Con cadenas de formato no tabuladores
        {
            Console.Write("\t");

            for (int i = 0; i < aula.nombreAsignaturas.Length; i++) // Nombres de asignaturas
            {
                Console.Write(aula.nombreAsignaturas[i] + "\t");
            }

            Console.WriteLine();

            for (int i = 0; i < aula.notas.GetLength(0); i++)
            {
                Console.Write(aula.nombreAlumnos[i] + "\t"); // Nombres de alumnos

                for (int j = 0; j < aula.notas.GetLength(1); j++)
                {
                    Console.Write(aula.notas[i, j] + "\t\t"); // Notas
                }

                Console.WriteLine();
            }
        }

        private void MuestraNotasAlumno()
        {
            int numAlumno = 0;

            do
            {
                Console.WriteLine("¿Número de alumno? Num máximo de alumno: " + nombreAlumnos.Length);
                numAlumno = int.Parse(Console.ReadLine()) - 1;
            } while (numAlumno + 1 > nombreAlumnos.Length || numAlumno < 0);

            Console.Write("\t");

            for (int i = 0; i < aula.nombreAsignaturas.Length; i++) // Nombres de asignaturas
            {
                Console.Write(aula.nombreAsignaturas[i] + "\t");
            }

            Console.WriteLine();

            for (int i = 0; i < aula.notas.GetLength(0); i++)  //Sobra 1 bucle
            {
                if (i == numAlumno)
                {
                    Console.Write(aula.nombreAlumnos[i] + "\t"); // Nombres de alumnos

                    for (int j = 0; j < aula.notas.GetLength(1); j++)
                    {
                        Console.Write(aula.notas[i, j] + "\t\t"); // Notas
                    }
                }
            }

            Console.WriteLine();
        }

        private void MuestraNotasAsignatura()
        {
            int numAsignatura = 0;

            do
            {
                Console.WriteLine("¿Número de asignatura? Num máximo de asignatura: " + nombreAsignaturas.Length);
                numAsignatura = int.Parse(Console.ReadLine()) - 1;
            } while (numAsignatura + 1 > nombreAsignaturas.Length || numAsignatura < 0);

            Console.Write("\t");

            for (int i = 0; i < aula.nombreAsignaturas.Length; i++) // Nombres de asignaturas   //Sobra el bucle
            {
                if (i == numAsignatura)
                {
                    Console.Write(aula.nombreAsignaturas[i] + "\t");
                }
            }

            Console.WriteLine();

            for (int i = 0; i < aula.notas.GetLength(0); i++)
            {
                Console.Write(aula.nombreAlumnos[i] + "\t"); // Nombres de alumnos

                for (int j = 0; j < aula.notas.GetLength(1); j++)  //Sobra 1 bucle
                {
                    if (j == numAsignatura)
                    {
                        Console.Write(aula.notas[i, j] + "\t\t"); // Notas
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public void MuestraAprobados(Hashtable hash)
        {
            foreach (DictionaryEntry entry in hash)
            {
                Console.Write("Nombre: {0}, Notas: {1}", entry.Key);

                for (int i = 0; i < ((int[])entry.Value).Length; i++)
                {
                    Console.WriteLine("\t" + ((int[])entry.Value)[i]);
                }
            }
        }
    }
}