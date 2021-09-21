#define FRASE_

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bol1_ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase1 = "";
            string frase2 = "";
            frase1 = Console.ReadLine();
            frase2 = Console.ReadLine();

#if FRASE
            Console.WriteLine("\"{0}\" \\{1}\\", frase1, frase2);
;           Console.ReadKey();
#else
            Console.WriteLine("{0}\t{1}\n{0}\n{1}", frase1, frase2);
            Console.ReadKey();
#endif
        }
    }
}
