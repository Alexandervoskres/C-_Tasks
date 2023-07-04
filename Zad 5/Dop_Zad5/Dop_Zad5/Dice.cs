using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop_Zad5
{
    internal class Dice
    {
        private Random r;
        public Dice()
        {
            r = new Random();
        }
        public int Roll()
        {
            return r.Next(6) + 1;
        }
    }
}
