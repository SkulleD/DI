using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinJunio1
{
    [Serializable]
    class RadioNegativoException : Exception
    {
        public RadioNegativoException(string msg) : base(msg)
        {
    
        }
    }
}