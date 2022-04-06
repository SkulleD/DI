using System;
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

        public void Menu()
        {
            int opcion = 0;

            do
            {
                Console.WriteLine("1- Visualizar tabla completa\n" +
                    "2- Calcular media de notas de toda la tabla\n" +
                    "3- Media de un alumno\n" +
                    "4- Media de una asignatura\n" +
                    "5- Visualizar notas de un alumno\n" +
                    "6- Visualizar notas de una asignatura\n" +
                    "7- Nota máxima y mínima de un alumno\n" +
                    "8- Tabla solo de aprobados\n" +
                    "9- Salir del programa");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MuestraNotasTabla();
                        break;
                    case 2:
                        Console.WriteLine("Media: " + aula.MediaNotasTabla());
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:
                        MuestraNotasAlumno();
                        break;
                    case 7:
                        MuestraNotasAsignatura();
                        break;
                    case 8:

                        break;
                    case 9:
                        Console.WriteLine("¡Hasta otra!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 9);
        }

        private void MuestraNotasTabla()
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

            Console.ReadLine();
        }

        private void MuestraNotasAlumno()
        {

        }

        private void MuestraNotasAsignatura()
        {

        }
    }
}
