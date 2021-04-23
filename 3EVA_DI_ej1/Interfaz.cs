#define iniciajuegos
using System;
using System.Collections.Generic;
using System.Text;

namespace _3eva_di_ej1
{
    class Interfaz
    {
        Videojuegos juegos = new Videojuegos();
        string titulo;
        int year;
        estilo genero;
        bool bandera;
        int inicio = 0;
        int final = 0;
        bool flag = false;

        public void principal()
        {
            int menu = 0;
#if iniciajuegos
            Videojuego juego1 = new Videojuego("Space Invaders", 1978, estilo.Arcade);
            Videojuego juego2 = new Videojuego("Fire Emblem", 1990, estilo.Estrategia);
            Videojuego juego3 = new Videojuego("Xenoblade", 2010, estilo.Videoaventura);
            juegos.juegosLista.Add(juego1);
            juegos.juegosLista.Add(juego2);
            juegos.juegosLista.Add(juego3);
#endif
            do
            {
                Console.WriteLine("---ELIJA UNA OPCIÓN---\n" +
                "1- Insertar nuevo videojuego\n" +
                "2- Eliminar videojuegos\n" +
                "3- Visualizar lista de videojuegos\n" +
                "4- Visualizar videojuegos de un estilo\n" +
                "5- Modificar videojuego\n" +
                "6- Salir del programa");
                menu = PideInt();

                switch (menu)
                {
                    case 1:
                        CrearVideojuego();
                        break;
                    case 2:
                        bool eliminar;

                        if (juegos.juegosLista.Count >= 1)
                        {
                            Console.WriteLine("¿Desde qué videojuego hasta cuál quieres eliminar?\n" +
                            "Posición de videojuego inicial: ");
                            Console.WriteLine("(El límite de la colección es " + (juegos.juegosLista.Count - 1) + ")");
                            inicio = PideInt(0, juegos.juegosLista.Count);
                            Console.WriteLine("Posición de videojuego final: ");
                            Console.WriteLine("(El límite de la colección es " + (juegos.juegosLista.Count - 1) + ")");
                            final = PideInt(0, juegos.juegosLista.Count);

                            eliminar = Eliminar(inicio, final);
                        }
                        else
                        {
                            Console.WriteLine("LA COLECCIÓN ESTÁ VACÍA.");
                        }
                        break;
                    case 3:
                        if (juegos.juegosLista.Count >= 1)
                        {
                            MuestraJuegos(juegos.juegosLista);
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
                            MuestraJuegos(juegos.Busqueda(genero));
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

                            Console.WriteLine("Escribe la posición del videojuego que quieres modificar");
                            pos = PideInt();
                            try
                            {
                                juegos.juegosLista.RemoveAt(pos);
                                Console.WriteLine("Elige el nuevo nombre, año y estilo del videojuego.");
                                CrearVideojuego();
                            }
                            catch (ArgumentOutOfRangeException e)
                            {
                                Console.WriteLine("\nError: Esa posición está vacía.");
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

            for (int i = min; i <= max; i++)
            {
                Console.WriteLine(juegos.juegosLista[i].Titulo + " Año: " + juegos.juegosLista[i].year + " Estilo: " + juegos.juegosLista[i].generos);
            }

            while (!respuesta.Equals("S") && !respuesta.Equals("N"))
            {
                Console.WriteLine("¿Quieres eliminar los videojuegos seleccionados? S/N");
                respuesta = Console.ReadLine().ToUpper();
            }
            if (respuesta == "S" || respuesta == "s")
            {
                juegos.Eliminar(min, max);
            }
            return true;
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
                        try
                        {
                            genero = (estilo)Convert.ToInt32(Console.ReadLine());
                        }
                        catch (OverflowException e)
                        {
                            Console.WriteLine("\nError de desbordamiento");
                        }
                    } while ((int)genero < 1 || (int)genero > 5);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error. Tiene que ser número del 1 al 5");
                }
            } while (flag == true);
            return genero;
        }

        public void MuestraJuegos(List<Videojuego> coleccion)
        {
            foreach (Videojuego juego in coleccion)
            {
                Console.WriteLine("Posición: {0} Título: {1} Estilo: {2}", juego.year, juego.Titulo, juego.generos);
            }
        }

        public void CrearVideojuego()
        {
            Console.WriteLine("¿Nombre del videojuego?");
            titulo = Console.ReadLine();

            Console.WriteLine("¿Año de lanzamiento del videojuego?");
            year = PideInt();

            genero = EligeEstilo();

            Videojuego juegoNuevo = new Videojuego(titulo, year, genero);
            int insertado = juegos.Posicion(juegoNuevo.year);

            juegos.juegosLista.Insert(insertado, juegoNuevo);
            Console.WriteLine("Se ha añadido el videojuego \"" + titulo + "\"");
        }

        public int PideInt()
        {
            int num = 0;
            do
            {
                bandera = false;
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    bandera = true;
                    Console.WriteLine("\nError de formato.");
                }
                catch (OverflowException)
                {
                    bandera = true;
                    Console.WriteLine("\nError de desbordamiento");
                }
            } while (bandera);
            return num;
        }

        public int PideInt(int min, int max)
        {
            int num = 0;
            do
            {
                bandera = false;
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    bandera = true;
                    Console.WriteLine("\nError de formato. Solo se pueden introducir números");
                }
                catch (OverflowException)
                {
                    bandera = true;
                    Console.WriteLine("\nError de desbordamiento");
                }
            } while (bandera || num < min || num > max - 1); // (inicio < 0 || inicio > juegos.juegosLista.Count || final < 0 || final > juegos.juegosLista.Count - 1) && (year < 1950 || year > 2100));
            return num;
        }
    }
}