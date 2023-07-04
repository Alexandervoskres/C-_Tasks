using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop_Zad2
{
    internal class ArithmeticProgression : Progression
    {
        private float a;
        private float d;

        public ArithmeticProgression(float a, float d)
        {
            this.a = a;
            this.d = d;
        }

        public override double GetElement(int k)
        {
            return a + (k - 1) * d;
        }
    }
}
