using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bol1_ej6
{
    class Program
    {
        private const int FILA = 10;
        private const int COLUMNA = 10;
        public int[,] casillas = new int[FILA, COLUMNA];
        Random random = new Random();

        static void Main(string[] args)
        {
            Program flota = new Program();
            flota.CreaTablero();

            //Console.WriteLine("Cosas: " + flota.casillas[2, 6]);
            Console.WriteLine("La IA coloca un barco en {0}", flota.BarcoEnemigo());
            Console.ReadKey();
        }

        public void CreaTablero()
        {
            int cont = 0;
            for (int i = 0; i <= FILA-1; i++)
            {
                for (int j = 0; j <= COLUMNA-1; j++)
                {
                    casillas[i, j] = cont;
                    Console.Write(casillas[i, j] + " ");
                }
                cont++;
                Console.WriteLine();
            }
        }

        public int[,] BarcoEnemigo()
        {
            int x = random.Next(0, 10);
            int y = random.Next(0, 10);
            int[,] colocaBarco = new int[x, y]; 

            return (colocaBarco);
        }
    }
}