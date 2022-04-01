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
        Planeta planeta = new Planeta("s", 3, true);


        List<Astro> astros = new List<Astro>();
        string nombreAstro = "";
        double radioAstro = 0;
        int isGaseoso = 0; // 0 false, 1 true
        bool isGaseosoFinal = false;
        int numLunas = 0;
        bool lunaOrAstro = false;

        static void Main(string[] args)
        {
            program.astros.Add(new Astro("Astro2", 75000));
            program.astros.Add(new Astro("Astro1", 75000));
            program.astros.Add(new Astro("Astro1", 75000));
            program.astros.Add(new Astro("Astro1", 75000));
            program.astros.Add(new Astro("Astro1", 75000));
            program.astros.Add(new Astro("Astro1", 42000));
            program.astros.Add(new Astro("Planeta", 5600));
            program.astros.Add(new Astro("Planeta", 5600));
            program.astros.Add(new Astro("Planeta", 5600));
            program.astros.Add(new Astro("Astro3", 75000));
            program.astros.Add(new Planeta("Planeta", 220000, true));
            program.astros.Add(new Planeta("Planeta", 220000, true));
            program.astros.Add(new Planeta("Planeta", 220000, true));
            program.astros.Add(new Astro("Astro1", 75000));
            program.astros.Add(new Astro("Astro1", 75000));
            program.astros.Add(new Astro("Astro1", 75000));
            program.astros.Add(new Astro("Astro1", 75000));
            program.astros.Add(new Planeta("Planeta2", 220000, true));


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
                            throw new FormatException();

                    }

                } while (menu != 5);
            }
            catch (Exception ex) when (ex is FormatException || ex is ArgumentException || ex is OverflowException)
            {
                Console.WriteLine("Opción no válida.");
            }
        }

        private void AddPlaneta()
        {
            try
            {
                do
                {
                    Console.WriteLine("Inserte el nombre del planeta");
                    nombreAstro = Console.ReadLine();
                } while (String.IsNullOrWhiteSpace(nombreAstro));

                do
                {
                    Console.WriteLine("Inserte el radio del planeta");
                    radioAstro = Convert.ToDouble(Console.ReadLine());
                } while (String.IsNullOrWhiteSpace(radioAstro.ToString()));

                do
                {
                    Console.WriteLine("¿El planeta es gaseoso? 0 = NO, 1 = SÍ");
                    isGaseoso = Convert.ToInt32(Console.ReadLine());
                } while (String.IsNullOrWhiteSpace(isGaseoso.ToString()));

                isGaseosoFinal = isGaseoso != 0;

                Console.WriteLine("¿Número de lunas del planeta?");
                numLunas = Convert.ToInt32(Console.ReadLine());

                astros.Add(planeta = new Planeta(nombreAstro, radioAstro, isGaseosoFinal));
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
            catch (Exception ex) when (ex is FormatException || ex is ArgumentException || ex is OverflowException)
            {
                Console.WriteLine("Error.");
            }
            catch (RadioNegativoException)
            {
                Console.WriteLine("Error: el radio no puede ser negativo.");
            }
        }

        private void AddAstro()
        {
            try
            {
                do
                {
                    Console.WriteLine("Inserte el nombre del astro");
                    nombreAstro = Console.ReadLine();
                } while (String.IsNullOrWhiteSpace(nombreAstro));

                do
                {
                    Console.WriteLine("Inserte el radio del astro");
                    radioAstro = Convert.ToDouble(Console.ReadLine());
                } while (String.IsNullOrWhiteSpace(radioAstro.ToString()));

                if (!lunaOrAstro)
                {
                    astros.Add(new Astro(nombreAstro, radioAstro));
                }
            }
            catch (Exception ex) when (ex is FormatException || ex is ArgumentException || ex is OverflowException)
            {
                Console.WriteLine("Error.");
            }
            catch (RadioNegativoException)
            {
                Console.WriteLine("Error: el radio no puede ser negativo.");
            }
        }

        private void MuestraDatos()
        {
            foreach (Astro astro in program.astros)
            {
                if (astro is Planeta)
                {
                    planeta = (Planeta)astro;
                    Console.WriteLine($"Nombre: {planeta.GetNombre(".")}, Radio: {planeta.Radio:F2} Gaseoso: {planeta.Gaseoso}, Nº Lunas: {planeta.astrosList.Count}");

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
            List<Astro> astrosAux = new List<Astro>();

            for (int i = 0; i <= astros.Count - 1; i++)
            {
                for (int j = astros.Count - 1; j >= 0; j--)
                {
                    if (astros[i].Equals(astros[j]) && !astrosAux.Contains(astros[i]))
                    {
                        astrosAux.Add(astros[i]);
                    }
                }
            }

            astros.Clear();
            astros = astrosAux;
        }
    }
}