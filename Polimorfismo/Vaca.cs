﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Vaca : ISonido
    {
        public string HacerSonido()
        {
            return "La Vaca hace muuuuuu";
        }

    }
}
