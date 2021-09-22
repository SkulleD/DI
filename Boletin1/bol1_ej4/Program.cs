using System;

namespace bol1_ej4
{
    class Program
    {
        Random random = new Random();
        bool repetir = false;

        static void Main(string[] args)
        {
            Program juegos = new Program();
            int choice = 0;
            bool jugarTodos = false;

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

                        if (jugarTodos)
                        {
                            goto case 2;
                        }
                        break;
                    case 2:
                        juegos.Juego2();

                        if (jugarTodos)
                        {
                            goto case 3;
                        }
                        break;
                    case 3:
                        juegos.Juego3();

                        if (jugarTodos)
                        {
                            jugarTodos = false; ;
                        }
                        break;
                    case 4:
                        jugarTodos = true;
                        goto case 1;
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

                RepetirPrograma();
            } while (repetir == true);
        }

        public void Juego2()
        {
            do
            {
                int intentos = 5;
                int numAcertar = random.Next(1, 101);
                int numUser = 0;
                bool acierto = false;
                do
                {
                    Console.WriteLine("Adivina el número entre 1 y 100\n" +
                        "Tienes {0} intentos", intentos);
                    numUser = Convert.ToInt32(Console.ReadLine());

                    if (numUser == numAcertar)
                    {
                        Console.WriteLine("\n¡Felicidades! ¡Has acertado!");
                        acierto = true;
                    }
                    else if (numUser < numAcertar)
                    {
                        intentos--;
                        Console.WriteLine("\nHas fallado. El número es MAYOR que ese");
                    }
                    else
                    {
                        intentos--;
                        Console.WriteLine("\nHas fallado. El número es MENOR que ese");
                    }
                } while (intentos > 0 && acierto == false);

                if (acierto == false)
                {
                    Console.WriteLine("\nHas perdido :(\n" +
                        "El número era {0}\n", numAcertar);
                }

                RepetirPrograma();
            } while (repetir == true);
        }

        public void Juego3()
        {
            do
            {
                for (int i = 0; i <= 13; i++)
                {
                    Console.WriteLine(Quiniela());
                }
                RepetirPrograma();
            } while (repetir == true);
        }

        public void RepetirPrograma()
        {
            char letra = 'a';

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
        }

        public string Quiniela()
        {
            string result = "a";
            int numero = random.Next(1, 101);

            switch (numero)
            {
                case int n when n <= 60:
                    result = String.Format("{0}", "1");
                    return result;

                case int n when n >= 61 && n <= 85:
                    result = String.Format("{0,5}", "X");
                    return result;

                case int n when n >= 86:
                    result = String.Format("{0,10}", "2");
                    return result;
            }
            return result;
        }
    }
}