using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Perro : ISonido
    {
        public string HacerSonido()
        {
            return "El perro hace Guau Guau";
        }
    }
}
