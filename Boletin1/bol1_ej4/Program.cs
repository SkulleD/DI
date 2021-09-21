using System;

namespace bol1_ej4
{
    class Program
    {
        Random random = new Random();

        static void Main(string[] args)
        {
            Program juegos = new Program();
            int choice = 0;
            do
            {
                Console.WriteLine("¿A qué quieres jugar?\n" +
                    "1- Dados\n" +
                    "2- Adivinar número\n" +
                    "3- Quiniela\n" +
                    "4- Jugar a todos\n" +
                    "5 - Salir del programa");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        juegos.Juego1(6);
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:
                        Console.WriteLine("Nos vemos");
                        Console.ReadKey();
                        break;
                    default:

                        break;
                }
            } while (choice != 5);
        }

        public void Juego1(int num2)
        {
            bool repetir = false;
            int numElegido = 0;
            do
            {
                do
                {
                    Console.WriteLine("Escribe un número del 1 al {0}", num2);
                    numElegido = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                } while (numElegido < 1 || numElegido > num2);
                double numRandom = 0;
                int aciertos = 0;
                char letra = 'a';

                for (int i = 0; i < num2; i++)
                {
                    numRandom = random.Next(1, num2 + 1);
                    Console.WriteLine(numRandom);

                    if (numRandom == numElegido)
                    {
                        aciertos++;
                    }
                }
                Console.WriteLine("¡Has acertado {0} veces!", aciertos);

                while (letra != 'S' && letra != 's' && letra != 'N' && letra != 'n')
                {
                    Console.WriteLine("¿Quieres volver a jugar a este juego? S/N");
                    letra = Convert.ToChar(Console.ReadLine());

                    if (letra == 'S' || letra == 's')
                    {
                        repetir = true;
                    }
                    else
                    {
                        repetir = false;
                    }
                }
            } while (repetir == true);
        }
    }
}
