using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bol3_ej2
{
    class Menu
    {
        Aula aula;
        private string[] nombres;

        public Menu(params string[] alumnos)
        {
            
        }

        public void Inicio()
        {
            int menu = 0;

            do
            {
                Console.WriteLine("1- Calcular media de toda la tabla\n" +
                    "2- Media de un alumno\n" +
                    "3- Media de una asignatura\n" +
                    "4- Visualizar notas de un alumno\n" +
                    "5- Visualizar notas de una asignatura\n" +
                    "6- Nota máxima y mínima de un alumno\n" +
                    "7- Lista de alumnos con todo aprobado\n" +
                    "8- Visualizar tabla completa\n" +
                    "9- Salir del programa");

                menu = int.Parse(Console.ReadLine());
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
                        MuestraNotas();
                        break;
                    case 9:
                        Console.WriteLine("Nos vemos!");
                        break;
                    default:
                        Console.WriteLine("Solo puede ser un número del 1 al 9");
                        break;
                }
            } while (menu != 9);
        }

        public void CreaAula()
        {
            aula = new Aula();
        }

        public void MuestraNotas()
        {
            CreaAula();

            aula.RellenaNotas();
            Console.WriteLine("holaa");
            for (int i = 0; i < aula.notas[i, 0]; i++)
            {
                for (int j = 0; j < aula.notas[0, j]; j++)
                {
                    Console.WriteLine(aula.notas[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
