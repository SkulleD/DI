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
        Mujer,
        Hombre
    }

    public class Friki
    {
        public string Nombre { set; get; }
        private int edad;
        public int Edad
        {
            set
            {
                if (value > 120)
                {
                    value = 120;
                }

                edad = value;
            }
            get
            {
                return edad;
            }
        }
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

        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() == GetType())
            {
                Friki checkFriki = (Friki)obj;

                if (Nombre.Equals(checkFriki.Nombre))
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            return $"{Nombre}, {Edad}, {Sexo} | Afición: {Aficion} | Buscando: {SexoOpuesto}";
        }
    }
}