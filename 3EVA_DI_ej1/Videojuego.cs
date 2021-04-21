using System;
using System.Collections.Generic;
using System.Text;

namespace _3eva_di_ej1
{
    enum estilo
    {
        Arcade = 1,
        Videoaventura,
        Shootemup,
        Estrategia,
        Deportivo
    }

    class Videojuego
    {
        public string Titulo { set; get; }
        public int year;
        public estilo generos;

        public Videojuego(string titulo, int year, estilo generos)
        {
            this.Titulo = titulo;
            this.year = year;
            this.generos = generos;
        }
    }
}