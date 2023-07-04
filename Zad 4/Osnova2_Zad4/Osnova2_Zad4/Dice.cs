using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osnova2_Zad4
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
