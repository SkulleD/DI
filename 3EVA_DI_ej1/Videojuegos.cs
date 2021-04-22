using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3eva_di_ej1
{
    class Videojuegos
    {
        public List<Videojuego> juegosLista = new List<Videojuego>();

        public int Posicion(int year)
        {
            for (int i = 0; i <= juegosLista.Count - 1; i++)
            {
                if (year <= juegosLista[i].year)
                {
                    return i;
                }
            }
            return juegosLista.Count;
        }

        public List<Videojuego> Busqueda(estilo generos)
        {
            List<Videojuego> estilos = new List<Videojuego>();
            Videojuego newJuego;

            for (int i = 0; i < juegosLista.Count; i++)
            {
                if (juegosLista[i].generos == generos)
                {
                    string title = juegosLista[i].Titulo;
                    int yiar = juegosLista[i].year;
                    estilo style = juegosLista[i].generos;
                    newJuego = new Videojuego(title, yiar, style);
                    estilos.Add(newJuego);

                }
            }
            return estilos;

        }

        public bool Eliminar(int min, int max)
        {
            for (int i = max; i >= min; i--)
            {
                juegosLista.RemoveAt(i);
            }
            return true;
        }
    }
}