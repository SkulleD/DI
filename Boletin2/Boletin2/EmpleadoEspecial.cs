using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin2
{
    class EmpleadoEspecial : Empleado, IPastaGansa
    {
        public double ganarPasta(double pasta)
        {
            pasta = (0.5 * pasta) / 100;
            return pasta;
        }

        public override double Hacienda()
        {
            return base.Hacienda() + ((10 * ganarPasta(42356)) / 100);
        }
    }
}
