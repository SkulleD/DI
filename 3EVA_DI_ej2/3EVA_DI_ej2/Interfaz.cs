using System;
using System.Collections.Generic;
using System.Text;

namespace _3EVA_DI_ej2
{
    class Interfaz
    {
        Funciones func = new Funciones();
        Aula aula = new Aula();
        bool bandera;

        public void menuPrincipal()
        {
            aula.CrearAlumnos();
            int menu = 0;
            bandera = false;
            int alumno = 0;
            int asignatura = 0;

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

                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine(func.CalculaMedia() / 12);
                        break;
                    case 2:
                        Console.Write("¿Nº del alumno?");
                        alumno = PideInt();
                        Console.WriteLine(func.MediaAlumno(alumno) / 4);
                        break;
                    case 3:
                        Console.Write("¿Nº de la asignatura?");
                        asignatura = PideInt();
                        Console.WriteLine(func.MediaAlumno(alumno) / 4);
                        break;
                    case 4:
                        Console.Write("¿Nº del alumno?");
                        alumno = PideInt();
                        func.VerNotasAlumno(alumno);
                        break;
                    case 5:
                        Console.Write("¿Nº de la asignatura?");
                        asignatura = PideInt();
                        func.VerNotasAsignatura(asignatura);
                        break;
                    case 6:

                        break;
                    case 7:
                        func.TablaAprobados();
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
                    Console.WriteLine("\nError de formato. Solo se pueden introducir números");
                }
                catch (OverflowException)
                {
                    bandera = true;
                    Console.WriteLine("\nError de desbordamiento");
                }
            } while (bandera);
            return num;
        }
    }
}
