using System;
using System.Collections.Generic;
using System.Text;

namespace _3EVA_DI_ej2_bien
{
    class Interfaz
    {
        Aula aula = new Aula();
        bool bandera;

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

                        break;
                    case 5:
                        Console.Write("¿Nº de la asignatura?");

                        break;
                    case 6:
                        Console.Write("¿Nº del alumno?");

                        break;
                    case 7:

                        break;
                    case 8:

                        break;
                    case 9:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:

                        break;
                }
            } while (menu != 9);
        }

        public int PideInt()
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
