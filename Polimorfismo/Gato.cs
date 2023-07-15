using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Gato : ISonido
    {
        public string HacerSonido()
        {
            return "EL gato hace miau miau me dicen la gata";
        }
    }
}
