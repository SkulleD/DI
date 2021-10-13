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
        Interfaz interfaz;
        public Hashtable hashtable = new Hashtable();
        public string IP { set; get; }
        public int RAM { set; get; }
        char punto = '.';
        bool correcto = false;
        string[] ip_array = new string[4];
        int cont = 0;
        bool haFuncionado = false;

        public Ordenadores()
        {

        }

        public string CheckIP()
        {
            CreaInterfaz();
            haFuncionado = false;

            do
            {
                cont = 0;

                IP = interfaz.EnterIP();
                ip_array = IP.Split(punto);

                if (CheckLongitudIP())
                {
                    haFuncionado = true;
                }
                else
                {
                    haFuncionado = false;
                    correcto = false;
                }

            } while (!correcto || cont < 4);

            IP = IP.Trim(' ', '.');
            return IP;
        }

        public int CheckRAM()
        {
            CreaInterfaz();

            do
            {
                RAM = interfaz.EnterRAM();
            } while (RAM <= 0);

            return RAM;
        }

        public bool CheckLongitudIP()
        {
            for (int i = 0; i < ip_array.Length; i++)
            {
                if (Convert.ToInt32(ip_array[i]) >= 0 && Convert.ToInt32(ip_array[i]) <= 255)
                {
                    cont++;
                    correcto = true;
                    Console.WriteLine(correcto);
                }
                else
                {
                    cont--;
                    correcto = false;
                    Console.WriteLine(correcto);
                }
            }

            if (ip_array.Length > 4)
            {
                correcto = false;
            }

            return correcto;
        }

        public void RemoveByIP(string ipAux)
        {
            if (hashtable.ContainsKey(ipAux))
            {
                hashtable.Remove(ipAux);
            }
        }

        public bool HaFuncionado()
        {
            return haFuncionado;
        }

        public void CreaInterfaz()
        {
            interfaz = new Interfaz();
        }

        public bool CheckRepetidaIP(string IP)
        {
            return hashtable.ContainsKey(IP);
        }

        public void AddToHashtable()
        {
            hashtable.Add(IP, RAM);
        }
    }
}