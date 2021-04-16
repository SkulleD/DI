using System;
using System.Collections.Generic;
using System.Text;

namespace _3eva_di_ej1
{
    class Videojuegos
    {
        public List<Videojuego> juegosLista = new List<Videojuego>();
        int generoNum = 0;
        int year;
        string titulo;
        estilo genero = estilo.Arcade;

        public int Posicion(int year)
        {
            for (int i = 0; i <= juegosLista.Count-1; i++)
            {
                if (year <= juegosLista[i].year)
                {
                    return i;
                }
            }
            return 1;
        }

        public bool Eliminar(int min, int max)
        {
            string respuesta = "";

            Console.WriteLine("Videojuegos a eliminar:");
            try
            {
                for (int i = min; i <= max; i++)
                {
                    Console.WriteLine(juegosLista[i].titulo + " Año: " + juegosLista[i].year + " Estilo: " + juegosLista[i].generos); // Falla
                }
            } catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("\nError. Límite de rango superado.\n" +
                    "Se eliminarán los videojuegos dentro del rango realizable\n");
            }
             
            
            while (!respuesta.Equals("S") && !respuesta.Equals("N")) {
                Console.WriteLine("¿Quieres eliminar los videojuegos seleccionados? S/N");
                respuesta = Console.ReadLine();
                respuesta.ToUpper();
            }

            if (respuesta == "S" || respuesta == "s")
            {
                return true;
            } else
            {
                return false;
            }
        }

        public List<Videojuego> Busqueda(estilo generos)
        {
            for (int i = 0; i <= juegosLista.Count; i++)
            {
                return juegosLista; // Coger los juegos de la lista que tengan ese género y meterlos en una nueva lista
            }
            return juegosLista;
        }

        public estilo eligeEstilo()
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
                    generoNum = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error. Tiene que ser número del 1 al 5");
                }
            } while (flag == true);
            for (int i = 0; i < Enum.GetNames(typeof(estilo)).Length; i++)
            {
                int extra = i;
                genero = (estilo)extra;
                return genero;
            }
            return genero;
        }

        public void muestraJuegos()
        {
            foreach (Videojuego coleccion in juegosLista)
            {
                Console.WriteLine("Posición: {0} Título: {1} Estilo: {2}", coleccion.year, coleccion.titulo, coleccion.generos);
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
            genero = eligeEstilo();

            Videojuego juegoNuevo = new Videojuego(titulo, year, genero);
            int insertado = Posicion(juegoNuevo.year);

            juegosLista.Insert(insertado, juegoNuevo);
            Console.WriteLine("Se ha añadido el videojuego \"" + titulo + "\"");
        }
    }
}