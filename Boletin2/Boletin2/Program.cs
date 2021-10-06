using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin2
{
    class Program
    {
        static void Main(string[] args)
        {
            Directivo directivo = new Directivo(12, "1", 5050);
            Empleado empleado = new Empleado(1300, "660828323");
            EmpleadoEspecial empleadoEsp = new EmpleadoEspecial("Alvaro", "Especial", 23, "21075006", 2000, "660828323");
            int menu = 0;

            do
            {
                Console.WriteLine("\n1- Visualizar datos de Directivo\n" +
                    "2- Visualizar datos de Empleado\n" +
                    "3- Visualizar datos de EmpleadoEspecial\n" +
                    "4- Salir del programa");
                try
                {
                    menu = int.Parse(Console.ReadLine());

                    switch (menu)
                    {
                        case 1:
                            //directivo.IntroCampos();
                            directivo.MuestraCampos();
                            Console.ReadKey();
                            break;
                        case 2:
                            //empleado.IntroCampos();
                            empleado.MuestraCampos();
                            Console.ReadKey();
                            break;
                        case 3:
                            empleadoEsp.MuestraCampos();
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("Nos vemos :)");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Elige una opción del 1 al 4");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException e)
                {

                }
            } while (menu != 4);
        }
    }
}