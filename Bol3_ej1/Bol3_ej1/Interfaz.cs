using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bol3_ej1
{
    class Interfaz
    {
        public void Menu()
        {
            Ordenadores ordenadores = new Ordenadores();
            int eleccion = 0;
            string ipAux = "";
            char punto = '.';
            bool correcto = false;
            string[] ip_array = new string[4];
            int cont = 0;

            do
            {
                Console.WriteLine("\n--Elige una opción del 1 al 4--\n" +
                    "1- Introducir datos\n" +
                    "2- Eliminar un dato\n" +
                    "3- Mostrar colección entera\n" +
                    "4- Mostrar elemento de la colección\n" +
                    "5- Salir del programa");
                try
                {
                    eleccion = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("--Elige una opción del 1 al 4--\n");
                }

                switch (eleccion)
                {
                    case 1:
                        do
                        {
                            cont = 0;
                            try
                            {
                                Console.WriteLine("Introduce la IP del ordenador");
                                ordenadores.IP = Console.ReadLine();
                                ip_array = ordenadores.IP.Split(punto);

                                for (int i = 0; i < ip_array.Length; i++)
                                {
                                    if (Convert.ToInt32(ip_array[i]) >= 0 && Convert.ToInt32(ip_array[i]) <= 255)
                                    {
                                        cont++;
                                        correcto = true;
                                        Console.WriteLine(correcto);
                                    }
                                    else
                                    {
                                        cont--;
                                        correcto = false;
                                        Console.WriteLine(correcto);
                                    }
                                }
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Introduce una IP correcta. Plantilla: \"X.X.X.X\"");
                            }
                        } while (!correcto || cont < 4);

                        do
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
                        } while (ordenadores.RAM <= 0 || ordenadores.RAM >= Int32.MaxValue);

                        ordenadores.hashtable.Add(ordenadores.IP, ordenadores.RAM);
                        Console.WriteLine("Se ha creado el equipo con IP {0} y {1} GB de RAM", ordenadores.IP, ordenadores.RAM);
                        break;
                    case 2:

                        Console.WriteLine("Introduce la IP del ordenador que deseas eliminar");
                        ipAux = Console.ReadLine();

                        if (ordenadores.hashtable.ContainsKey(ipAux))
                        {
                            ordenadores.hashtable.Remove(ipAux);
                            Console.WriteLine("Se ha eliminado el equipo con IP {0}", ipAux);
                        }
                        break;
                    case 3:
                        foreach (DictionaryEntry entry in ordenadores.hashtable)
                        {
                            Console.WriteLine("IP: {0} RAM: {1}GB", entry.Key, entry.Value);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Introduce la IP del ordenador que deseas mostrar");
                        ipAux = Console.ReadLine();

                        foreach (DictionaryEntry entry in ordenadores.hashtable)
                        {
                            if (entry.Key.Equals(ipAux))
                            {
                                correcto = true;
                                Console.WriteLine("IP: {0} RAM: {1}GB", entry.Key, entry.Value);
                            }
                        }

                        if (!correcto)
                        {
                            Console.WriteLine("ERROR (!): No existe un equipo con esa dirección IP");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Nos vemos!");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Tiene que ser entre 1 y 4");
                        break;
                }
            } while (eleccion != 5);
        }
    }
}