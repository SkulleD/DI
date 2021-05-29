using System;
using System.Collections.Generic;
using System.Text;

namespace _3EVA_DI_ej2_bien
{
    class Interfaz
    {
        Aula aula = new Aula();
        bool bandera;
        Asignaturas materias;

        public void menuPrincipal()
        {
            int menu;
            aula.RellenaTabla();

            do
            {
                Console.WriteLine("--- Elige una opción ---\n" +
                "1- Calcular media de notas de la tabla\n" +
                "2- Media de un alumno\n" +
                "3- Media de una asignatura\n" +
                "4- Visualizar notas de un alumno\n" +
                "5- Visualizar notas de una asignatura\n" +
                "6- Nota máxima y mínima de un alumno\n" +
                "7- Tabla de aprobados\n" +
                "8- Visualizar tabla completa\n" +
                "9- Salir del programa");

                menu = PideInt();
                switch (menu)
                {
                    case 1:
                        Console.WriteLine(aula.CalculaMedia());
                        break;
                    case 2:
                        Console.Write("¿Nº del alumno?");
                        Console.WriteLine(aula.MediaAlumno(PideInt()));
                        break;
                    case 3:
                        Console.Write("¿Nº de la asignatura?");
                        Console.WriteLine(aula.MediaAsignatura(PideInt()));
                        break;
                    case 4:
                        Console.Write("¿Nº del alumno?");
                        VerNotasAlumno(PideInt());
                        break;
                    case 5:
                        Console.Write("¿Nº de la asignatura?");
                        VerNotasAsignatura(PideInt());
                        break;
                    case 6:
                        Console.Write("¿Nº del alumno?");
                        NotaMinMax(PideInt(), ref PideInt(), ref PideInt()); // Cómo se llama a PideInt() siendo los parámetros ref
                        break;
                    case 7:
                        TablaAprobados();
                        break;
                    case 8:
                        TablaCompleta();
                        break;
                    case 9:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:

                        break;
                }
            } while (menu != 9);
        }

        public void VerNotasAlumno(int alumno)
        {
            for (int i = 0; i < aula.notas.GetLength(1); i++)
            {
                Console.Write("{0, 3}", aula.notas[alumno, i]);
            }
            Console.WriteLine(Environment.NewLine);
        }

        public void VerNotasAsignatura(int asignatura)
        {
            for (int i = 0; i < aula.notas.GetLength(0); i++)
            {
                Console.Write("{0, 3}", aula.notas[i, asignatura]);
            }
            Console.WriteLine(Environment.NewLine);
        }

        public void NotaMinMax(int alumno, ref int min, ref int max)
        {
            int extra;
            min = 10;
            max = 0;

            for (int i = 0; i < aula.notas.GetLength(1); i++)
            {
                extra = aula.notas[alumno, i];

                if (extra < min)
                {
                    min = extra;
                }

                if (extra > max)
                {
                    max = extra;
                }
            }
            Console.WriteLine("Mínima: {0}\nMáxima: {1}", min, max);
        }

        public void TablaAprobados() // CASI NUNCA MUESTRA ÚLTIMA COLUMNA
        {
            for (int i = 0; i < aula.notas.GetLength(0); i++)
            {
                for (int j = 0; j < aula.notas.GetLength(1); j++)
                    if (aula.notas[i, j] > 5)
                    {
                        Console.Write("{0,4}", aula.notas[i, j]);
                    }
                Console.WriteLine();
            }
        }

        public void TablaCompleta()
        {
            bool tab = false;

            foreach (string element in aula.alumnos)
            {
                Console.Write("{0,10}", element);
            }

            for (int i = 0; i < aula.notas.GetLength(1); i++)
            {
                materias = (Asignaturas)i;
                Console.WriteLine("{0}", materias);
                for (int j = 0; j < aula.notas.GetLength(0); j++)
                {
                    //if (!tab)
                    //{
                    //    Console.Write("\t\t");
                    //    tab = true;
                    //}
                    Console.Write("{0,10}", aula.notas[j, i]);
                }
                Console.WriteLine();
            }
        }

        public int PideInt() // Pide un número todo el rato mientras no lo pongan de manera correcta
        {
            int num = 0;
            do
            {
                bandera = false;
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    bandera = true;
                    Console.Write("\nError de formato. Solo se pueden introducir números");
                }
                catch (OverflowException)
                {
                    bandera = true;
                    Console.Write("\nError de desbordamiento");
                }
                catch (IndexOutOfRangeException)
                {
                    bandera = true;
                    Console.Write("\nRecuerda que hay no hay más de 12 alumnos ni más de 4 asignaturas.");
                }
            } while (bandera);
            return num;
        }
    }
}
