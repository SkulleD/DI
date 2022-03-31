using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinJunio1
{
    class Program
    {
        static Program program = new Program();
        Planeta planeta;
        List<Astro> astros = new List<Astro>();
        List<Astro> astrosAux = new List<Astro>();
        string nombreAstro = "";
        double radioAstro = 0;
        int isGaseoso = 0; // 0 false, 1 true
        bool isGaseosoFinal = false;
        int numLunas = 0;
        bool lunaOrAstro = false;

        static void Main(string[] args)
        {
            program.astros.Add(new Astro("Astro1", 75000));
            program.astros.Add(new Astro("Astro2", 42000));
            program.astros.Add(new Astro("Astro3", 56000));
            program.astros.Add(new Planeta("Planeta", 220000, true));

            int menu;
            try
            {
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
                            program.AddPlaneta();
                            break;
                        case 2:
                            program.AddAstro();
                            break;
                        case 3:
                            program.MuestraDatos();
                            break;
                        case 4:
                            program.EliminaRepetidos();
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
            catch (FormatException)
            {

            }
        }

        private void AddPlaneta()
        {
            try
            {
                Console.WriteLine("Inserte el nombre del planeta");
                nombreAstro = Console.ReadLine();

                Console.WriteLine("Inserte el radio del planeta");
                radioAstro = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("¿El planeta es gaseoso? 0 = NO, 1 = SÍ");
                isGaseoso = Convert.ToInt32(Console.ReadLine());

                if (isGaseoso == 0)
                {
                    isGaseosoFinal = false;
                }
                else
                {
                    isGaseosoFinal = true;
                }

                Console.WriteLine("¿Número de lunas del planeta?");
                numLunas = Convert.ToInt32(Console.ReadLine());

                astros.Add(planeta = new Planeta(nombreAstro, radioAstro, isGaseosoFinal));
                astrosAux.Add(planeta = new Planeta(nombreAstro, radioAstro, isGaseosoFinal));
                planeta.astrosList = new List<Astro>();

                if (numLunas > 0)
                {
                    lunaOrAstro = true;

                    for (int i = 1; i <= numLunas; i++)
                    {
                        AddAstro();
                        planeta.astrosList.Add(new Astro(nombreAstro, radioAstro));
                    }
                }

                lunaOrAstro = false;
            }
            catch (FormatException)
            {

            }
        }

        private void AddAstro()
        {
            try
            {
                Console.WriteLine("Inserte el nombre del astro");
                nombreAstro = Console.ReadLine();

                Console.WriteLine("Inserte el radio del astro");
                radioAstro = Convert.ToDouble(Console.ReadLine());

                if (!lunaOrAstro)
                {
                    astros.Add(new Astro(nombreAstro, radioAstro));
                    astrosAux.Add(new Astro(nombreAstro, radioAstro));
                }
            }
            catch (FormatException)
            {

            }
        }

        private void MuestraDatos()
        {
            foreach (Astro astro in program.astros)
            {
                if (astro is Planeta)
                {
                    planeta = (Planeta)astro;
                    Console.WriteLine($"Nombre: {planeta.GetNombre(".")} Radio: {planeta.Radio} Gaseoso: {planeta.Gaseoso} Nº Lunas: {planeta.astrosList.Count}");

                    if (planeta.astrosList.Count > 0)
                    {
                        Console.WriteLine("----Luna/s del planeta----");

                        foreach (Astro luna in planeta.astrosList)
                        {
                            Console.WriteLine(luna.ToString());
                        }

                        Console.WriteLine("--------------------------");
                    }
                }
                else
                {
                    Console.WriteLine($"{astro.ToString()}");
                }
            }
        }

        private void EliminaRepetidos()
        {
            bool eliminar = false;
            bool astrosCoinciden = false;
            bool planetasCoinciden = false;
            string nombreAux = "";

            foreach (Astro astro in astros)
            {
                foreach (Astro astroAux in astrosAux)
                {
                    if (astro.Equals(astroAux))
                    {
                        nombreAux = astro.Nombre;

                        if (astro is Astro && astroAux is Astro)
                        {
                            astrosCoinciden = true;
                            eliminar = true;
                        }

                        if (astro is Planeta && astroAux is Planeta)
                        {
                            planetasCoinciden = true;
                            eliminar = true;
                        }
                    }
                }
            }
        }
    }
}