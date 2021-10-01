﻿using System;
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

            do
            {
                Console.WriteLine("\n--Elige una opción del 1 al 4--\n" +
                    "1- Introducir datos\n" +
                    "2- Eliminar un dato\n" +
                    "3- Mostrar colección entera\n" +
                    "4- Mostrar elemento de la colección\n" +
                    "5- Salir del programa");
                eleccion = int.Parse(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        Console.WriteLine("Introduce la IP del ordenador");
                        ordenadores.IP = Console.ReadLine();
                        Console.WriteLine("Introduce su cantidad de memoria RAM en GB");
                        ordenadores.RAM = int.Parse(Console.ReadLine());

                        ordenadores.hashtable.Add(ordenadores.IP, ordenadores.RAM);
                        Console.WriteLine("Se ha creado el equipo con IP {0} y {1} GB de RAM", ordenadores.IP, ordenadores.RAM);
                        break;
                    case 2:
                        Console.WriteLine("Introduce la IP del ordenador que deseas eliminar");
                        ipAux = Console.ReadLine();

                        if (ipAux.Equals(ordenadores.IP))
                        {
                            ordenadores.hashtable.Remove(ipAux);
                            Console.WriteLine("Se ha eliminado el equipo con IP {0}", ipAux);
                        } else
                        {
                            Console.WriteLine("ERROR (!): No existe un equipo con esa dirección IP");
                        }
                        
                        break;
                    case 3:
                        foreach (DictionaryEntry entry in ordenadores.hashtable)
                        {
                            Console.WriteLine("IP: {0} RAM: {1}GB", entry.Key, entry.Value);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Introduce la IP del ordenador que deseas eliminar");
                        ipAux = Console.ReadLine();

                        if (ipAux.Equals(ordenadores.IP))
                        {
                            ordenadores.hashtable.Keys;
                            Console.WriteLine("Se ha eliminado el equipo con IP {0}", ipAux);
                        }
                        else
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
