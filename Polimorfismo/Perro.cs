using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Perro : ISonido
    {
        public string HacerSonido()
        {
            return "el perro hace Guau Guau";
        }
    }
}
