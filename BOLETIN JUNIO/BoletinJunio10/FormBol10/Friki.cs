using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBol10
{
    public enum eAficion
    {
        Manga,
        SciFi,
        RPG,
        Fantasía,
        Terror,
        Tecnología
    }

    public enum Sexo
    {
        Hombre,
        Mujer
    }

    public enum SexoOpuesto
    {
        Hombre,
        Mujer
    }

    public class Friki
    {
        public string Nombre { set; get; }
        public int Edad { set; get; }
        public string Foto { set; get; }
        public eAficion Aficion { set; get; }
        public Sexo Sexo { set; get; }
        public SexoOpuesto SexoOpuesto { set; get; }

        public Friki()
        {

        }

        public Friki(string Nombre, int Edad, string Foto, eAficion Aficion, Sexo Sexo, SexoOpuesto SexoOpuesto)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Foto = Foto;
            this.Aficion = Aficion;
            this.Sexo = Sexo;
            this.SexoOpuesto = SexoOpuesto;
        }
    }
}