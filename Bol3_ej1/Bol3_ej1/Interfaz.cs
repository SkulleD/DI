using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bol3_ej1
{
    class Interfaz
    {
        Ordenadores ordenadores = new Ordenadores();
        string ipAux = "";

        public void MuestraPCs()
        {
            foreach (DictionaryEntry entry in ordenadores.hashtable)
            {
                Console.WriteLine("IP: {0} RAM: {1}GB", entry.Key, entry.Value);
            }
        }

        public string EnterIP()
        {
            try
            {
                Console.WriteLine("Introduce la IP del ordenador\n");
                ordenadores.IP = Console.ReadLine();
            }
            catch (FormatException e)
            {
            }
            catch (OverflowException)
            {
                Console.WriteLine("No puede ser una cantidad mayor a 2,147,483,647");
            }

            return ordenadores.IP;
        }

        public int EnterRAM()
        {
            try
            {
                Console.WriteLine("Introduce su cantidad de memoria RAM en GB (mayor que 0)");
                ordenadores.RAM = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Escribe la cantidad de RAM con NÚMEROS solamente");
            }
            catch (OverflowException)
            {
                Console.WriteLine("No puede ser una cantidad mayor a 2,147,483,647");
            }

            return ordenadores.RAM;
        }

        public void Menu()
        {
            int eleccion = 0;

            do
            {
                Console.WriteLine("\n--Elige una opción del 1 al 4--\n" +
                    "1- Introducir datos\n" +
                    "2- Eliminar un equipo\n" +
                    "3- Mostrar colección entera\n" +
                    "4- Mostrar elemento de la colección\n" +
                    "5- Salir del programa");
                try
                {
                    eleccion = int.Parse(Console.ReadLine());

                    switch (eleccion)
                    {
                        case 1:
                            do
                            {
                                ipAux = ordenadores.CheckIP();

                                if (ordenadores.CheckRepetidaIP(ipAux))
                                {
                                    Console.WriteLine("(!) Ya existe un equipo con esa IP");
                                }
                            } while (ordenadores.CheckRepetidaIP(ipAux));
                            ordenadores.CheckRAM();

                            if (ordenadores.HaFuncionado())
                            {
                                ordenadores.AddToHashtable();
                                Console.WriteLine("Se ha creado el equipo con IP {0} y {1} GB de RAM", ordenadores.IP, ordenadores.RAM);
                            }
                            break;
                        case 2:
                            ipAux = ordenadores.CheckIP();

                            ordenadores.RemoveByIP(ipAux);
                            Console.WriteLine("Se ha eliminado el equipo con IP {0}", ipAux);
                            break;
                        case 3:
                            MuestraPCs();
                            break;
                        case 4:
                            ipAux = ordenadores.CheckIP();

                            Console.WriteLine("IP: {0} RAM: {1} GB", ipAux, ordenadores.hashtable[ipAux]);

                            break;
                        case 5:
                            Console.WriteLine("Nos vemos!");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Tiene que ser entre 1 y 4");
                            break;
                    }
                }
                catch (FormatException)
                {

                }
                catch (OverflowException)
                {

                }
            } while (eleccion != 5);
        }
    }
}