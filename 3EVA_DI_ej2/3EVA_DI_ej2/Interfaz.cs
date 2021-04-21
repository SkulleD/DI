using System;
using System.Collections.Generic;
using System.Text;

namespace _3EVA_DI_ej2
{
    class Interfaz
    {
        public void menuPrincipal()
        {
            int menu = 0;

            do
            {
                Console.WriteLine("--- Elige una opción ---\n" +
                "1- Calcular media de notas de la tabla\n" +
                "2- Media de un alumno\n" +
                "3- Media de una asignatura\n" +
                "4- Visualizar notas de una asignatura\n" +
                "5- Nota máxima y mínima de un alumno\n" +
                "6- Tabla de aprobados\n" +
                "7- Visualizar tabla completa\n" +
                "8- Salir del programa");

                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:

                        break;
                }
            } while (menu != 8);
        }
    }
}
