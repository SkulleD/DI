#define iniciajuegos
using System;

namespace _3eva_di_ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            string titulo;
            int year = 0;
            estilo genero;
            Videojuegos juegos = new Videojuegos();
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

                }

                switch (menu)
                {
                    case 1:
                        juegos.crearVideojuego();
                        break;
                    case 2:
                        int inicio;
                        int final;
                        bool eliminar;

                        if (juegos.juegosLista.Count > 1)
                        {
                            try
                            {
                                Console.WriteLine("¿Desde qué videojuego hasta cuál quieres eliminar?\n" +
                                    "Posición de videojuego inicial: ");
                                inicio = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Posición de videojuego final: ");
                                final = Convert.ToInt32(Console.ReadLine());
                                eliminar = juegos.Eliminar(inicio, final);
                            }
                            catch (FormatException e)
                            {

                            }
                        }
                        else
                        {
                            Console.WriteLine("LA COLECCIÓN ESTÁ VACÍA.");
                        }
                        break;
                    case 3:
                        if (juegos.juegosLista.Count > 1)
                        {
                            juegos.muestraJuegos();
                        }
                        else
                        {
                            Console.WriteLine("LA COLECCIÓN ESTÁ VACÍA.");
                        }
                        break;
                    case 4:
                        if (juegos.juegosLista.Count > 1)
                        {
                            genero = juegos.eligeEstilo();
                            Console.WriteLine(juegos.Busqueda(genero));
                        }
                        else
                        {
                            Console.WriteLine("LA COLECCIÓN ESTÁ VACÍA.");
                        }
                        break;
                    case 5:
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
                            juegos.crearVideojuego();
                        }
                        catch (ArgumentOutOfRangeException e)
                        {
                            Console.WriteLine("Error: Esa posición está vacía.");
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
    }
}