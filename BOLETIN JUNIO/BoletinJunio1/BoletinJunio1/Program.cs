using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinJunio1
{
    class Program
    {
        List<Astro> astros = new List<Astro>();
        static Program program = new Program();

        static void Main(string[] args)
        {
            program.astros.Add(new Astro("Astro1", 2.32));
            program.astros.Add(new Astro("Astro2", 42000.0));
            program.astros.Add(new Astro("Astro3", 56000.0));
            program.astros.Add(new Planeta("Planeta", 56000.0, true));

            int menu;
            do
            {
                Console.WriteLine("Elige una opción\n" +
                                    "1- Añadir planeta\n" +
                                    "2- Añadir astro\n" +
                                    "3- Mostrar datos\n" +
                                    "4- Eliminar astros repetidos\n" +
                                    "5- Salir del programa");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:
                        program.MuestraDatos();
                        break;
                    case 4:

                        break;
                    case 5:
                        Console.WriteLine("¡Hasta otra!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (menu != 5);
        }

        private void addPlaneta()
        {

        }

        private void addAstro()
        {

        }

        private void MuestraDatos()
        {
            Console.WriteLine("KIRBO");

            foreach (Astro astro in program.astros)
            {
                Console.WriteLine(astro.GetNombre("_") + " " + astro.Radio);

                if (astro is Planeta)
                {
                    Console.WriteLine("Planeta");
                }
                else
                {
                    Console.WriteLine("Astro");
                }
            }
        }

        private void EliminaRepetidos()
        {

        }
    }
}