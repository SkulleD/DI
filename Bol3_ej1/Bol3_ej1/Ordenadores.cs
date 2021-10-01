using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bol3_ej1
{
    class Ordenadores
    {
        public Hashtable hashtable = new Hashtable();
        private string ip = "";
        private int ram = 0;
        public string IP { set; get; }
        public int RAM { set; get; }

        public Ordenadores()
        {

        }

        public Ordenadores(string ip, int ram)
        {
            this.IP = ip;
            this.RAM = ram;
        }
    }
}
