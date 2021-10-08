using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bol3_ej1
{
    class Interfaz  // overflow en menu, clave repetida, longitud ip, revisar ultima opcion menu, modularidad
    {
        Ordenadores ordenadores = new Ordenadores();
        string ipAux = "";
        char punto = '.';
        bool correcto = false;
        string[] ip_array = new string[4];
        int cont = 0;
        bool llamada4 = false;

        public string EnterIP()
        {
            do
            {
                cont = 0;
                try
                {
                    Console.WriteLine("Introduce la IP del ordenador\n");
                    ordenadores.IP = Console.ReadLine();
                    ip_array = ordenadores.IP.Split(punto);

                    if (!ordenadores.hashtable.ContainsKey(ordenadores.IP))
                    {
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

                        if (ip_array.Length > 4)
                        {
                            correcto = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("(!) Ya existe un ordenador con esa IP");
                        correcto = false;
                    }
                }
                catch (FormatException e)
                {
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("No puede ser una cantidad mayor a 2,147,483,647");
                }
            } while (!correcto || cont < 4);

            ordenadores.IP = ordenadores.IP.Trim(' ', '.');
            return ordenadores.IP;
        }

        public int EnterRAM()
        {
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

            return ordenadores.RAM;
        }

        public void MuestraPCs()
        {
            foreach (DictionaryEntry entry in ordenadores.hashtable)
            {
                Console.WriteLine("IP: {0} RAM: {1}GB", entry.Key, entry.Value);
            }
        }

        //public void Muestra1PC() //cambiar,sin bucle
        //{
        //    foreach (DictionaryEntry entry in ordenadores.hashtable)
        //    {
        //        if (entry.Key.Equals(ipAux))
        //        {
        //            correcto = true;
        //            Console.WriteLine("IP: {0} RAM: {1}GB", entry.Key, entry.Value);
        //        }
        //    }

        //    if (!correcto)
        //    {
        //        Console.WriteLine("ERROR (!): No existe un equipo con esa dirección IP");
        //    }
        //}

        public void Menu()
        {
            int eleccion = 0;

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

                    switch (eleccion)
                    {
                        case 1:
                            EnterIP();
                            EnterRAM();

                            ordenadores.hashtable.Add(ordenadores.IP, ordenadores.RAM);
                            Console.WriteLine("Se ha creado el equipo con IP {0} y {1} GB de RAM", ordenadores.IP, ordenadores.RAM);
                            break;
                        case 2:
                            Console.WriteLine("Introduce la IP del ordenador que deseas eliminar");
                            ipAux = EnterIP();

                            if (ordenadores.hashtable.ContainsKey(ipAux))
                            {
                                ordenadores.hashtable.Remove(ipAux);
                                Console.WriteLine("Se ha eliminado el equipo con IP {0}", ipAux);
                            }
                            break;
                        case 3:
                            MuestraPCs();
                            break;
                        case 4:
                            llamada4 = true;
                            ipAux = EnterIP();
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
                catch (OverflowException e)
                {

                }
            } while (eleccion != 5);
        }
    }
}