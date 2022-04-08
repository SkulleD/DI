using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinJunio1
{
    class Planeta : Astro
    {
        public List<Astro> astrosList;

        private bool gaseoso;
        public bool Gaseoso
        {
            set
            {
                gaseoso = value;
            }

            get
            {
                return gaseoso;
            }
        }

        public Planeta(string nombre, double radio, bool gaseoso) : base(nombre, radio)
        {
            Gaseoso = gaseoso;
            astrosList = new List<Astro>();
        }

        public Planeta() : this("", 0, false)
        {
        }
    }
}