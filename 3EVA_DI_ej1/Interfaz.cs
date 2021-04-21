#define iniciajuegos
using System;
using System.Collections.Generic;
using System.Text;

namespace _3eva_di_ej1
{
    // rango en eliminar, devolver buscar, repetir ultima oipcion, funcion pedir entero, elimnar en Videojuegos, sin excepciones de fuera de rango
    class Interfaz
    {
        Videojuegos juegos = new Videojuegos();
        string titulo;
        int year;
        estilo genero;

        public void principal()
        {
            int menu = 0;
            bool flag = false;
#if iniciajuegos
            Videojuego juego1 = new Videojuego("Xenoblade", 2010, estilo.Videoaventura);
            Videojuego juego2 = new Videojuego("Space Invaders", 1978, estilo.Arcade);
            Videojuego juego3 = new Videojuego("Fire Emblem", 1990, estilo.Estrategia);
            juegos.juegosLista.Add(juego2);
            juegos.juegosLista.Add(juego3);
            juegos.juegosLista.Add(juego1);
#endif
            do
            {
                try
                {
                    Console.WriteLine("---ELIJA UNA OPCIÓN---\n" +
                    "1- Insertar nuevo videojuego\n" +
                    "2- Eliminar videojuegos\n" +
                    "3- Visualizar lista de videojuegos\n" +
                    "4- Visualizar videojuegos de un estilo\n" +
                    "5- Modificar videojuego\n" +
                    "6- Salir del programa");
                    menu = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("\nError de formato. Elige un número del 1 al 6");
                }

                switch (menu)
                {
                    case 1:
                        crearVideojuego();
                        break;
                    case 2:
                        int inicio;
                        int final;
                        bool eliminar;

                        if (juegos.juegosLista.Count >= 1)
                        {
                            try
                            {
                                Console.WriteLine("¿Desde qué videojuego hasta cuál quieres eliminar?\n" +
                                    "Posición de videojuego inicial: ");
                                inicio = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Posición de videojuego final: ");
                                final = Convert.ToInt32(Console.ReadLine());
                                eliminar = Eliminar(inicio, final);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Error de formato");
                            }
                            catch (OverflowException e)
                            {
                                Console.WriteLine("Error de desbordamiento");
                            }
                        }
                        else
                        {
                            Console.WriteLine("LA COLECCIÓN ESTÁ VACÍA.");
                        }
                        break;
                    case 3:
                        if (juegos.juegosLista.Count >= 1)
                        {
                            muestraJuegos();
                        }
                        else
                        {
                            Console.WriteLine("LA COLECCIÓN ESTÁ VACÍA.");
                        }
                        break;
                    case 4:
                        if (juegos.juegosLista.Count >= 1)
                        {
                            genero = EligeEstilo();
                            Console.WriteLine(juegos.Busqueda(genero));
                        }
                        else
                        {
                            Console.WriteLine("LA COLECCIÓN ESTÁ VACÍA.");
                        }
                        break;
                    case 5:
                        if (juegos.juegosLista.Count >= 1)
                        {
                            int pos = 0;
                            do
                            {

                                flag = false;

                                Console.WriteLine("Escribe la posición del videojuego que quieres modificar");
                                try
                                {
                                    pos = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (FormatException e)
                                {
                                    flag = true;
                                    Console.WriteLine("Error. Solo se permiten números.");
                                }
                            } while (flag == true);
                            try
                            {
                                juegos.juegosLista.RemoveAt(pos);
                                Console.WriteLine("Elige el nuevo nombre, año y estilo del videojuego.");
                                crearVideojuego();
                            }
                            catch (ArgumentOutOfRangeException e)
                            {
                                Console.WriteLine("Error: Esa posición está vacía.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("LA COLECCIÓN ESTÁ VACÍA.");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            } while (menu != 6);
        }

        public bool Eliminar(int min, int max)
        {
            string respuesta = "";

            if (juegos.juegosLista.Count > 0)
            {
                try
                {
                    for (int i = min; i <= max; i++)
                    {
                        Console.WriteLine(juegos.juegosLista[i].Titulo + " Año: " + juegos.juegosLista[i].year + " Estilo: " + juegos.juegosLista[i].generos);
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("\nError. Límite de rango superado.\n");
                    return false;
                }

                while (!respuesta.Equals("S") && !respuesta.Equals("N"))
                {
                    Console.WriteLine("¿Quieres eliminar los videojuegos seleccionados? S/N");
                    respuesta = Console.ReadLine().ToUpper();
                }

                if (respuesta == "S" || respuesta == "s")
                {
                    try
                    {
                        for (int i = max; i >= min; i--)
                        {
                            juegos.juegosLista.RemoveAt(i);
                        }
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine("Error. Fuera de rango");
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public estilo EligeEstilo()
        {
            bool flag;

            do
            {
                flag = false;
                Console.WriteLine("¿Estilo del videojuego?\n" +
                    "1- Arcade\n" +
                    "2- Videoaventura\n" +
                    "3- Shootemup\n" +
                    "4- Estrategia\n" +
                    "5- Deportivo");
                try
                {
                    do
                    {
                        genero = (estilo)Convert.ToInt32(Console.ReadLine());
                    } while ((int)genero < 1 || (int)genero > 5);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error. Tiene que ser número del 1 al 5");
                }
            } while (flag == true);
            //for (int i = 0; i < Enum.GetNames(typeof(estilo)).Length; i++)
            //{
            //    int extra = i;
            //    genero = (estilo)extra;
            //    return genero;
            //}
            return genero;
        }

        public void muestraJuegos()
        {
            foreach (Videojuego coleccion in juegos.juegosLista)
            {
                Console.WriteLine("Posición: {0} Título: {1} Estilo: {2}", coleccion.year, coleccion.Titulo, coleccion.generos);
            }
        }

        public void crearVideojuego()
        {
            bool flag;

            Console.WriteLine("¿Nombre del videojuego?");
            titulo = Console.ReadLine();
            do
            {
                flag = false;

                Console.WriteLine("¿Año de lanzamiento del videojuego?");
                try
                {
                    year = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    flag = true;
                    Console.WriteLine("Error. El año solo permite números.");
                }
            } while (flag == true);
            genero = EligeEstilo();

            Videojuego juegoNuevo = new Videojuego(titulo, year, genero);
            int insertado = juegos.Posicion(juegoNuevo.year);

            juegos.juegosLista.Insert(insertado, juegoNuevo);
            Console.WriteLine("Se ha añadido el videojuego \"" + titulo + "\"");
        }
    }
}