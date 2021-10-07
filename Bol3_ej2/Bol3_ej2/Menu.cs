using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bol3_ej2
{
    class Menu
    {
        Aula aula;
        private string[] nombres;

        public Menu (params string[] nombres)
        {
            this.nombres = nombres;
            aula = new Aula(this.nombres);
        }

        public void Inicio()
        {
            int menu = 0;

            switch (menu)
            {

            }
        }
    }
}
