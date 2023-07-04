using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop_Zad3
{
    internal class ArithmeticProgression
    {
        private double a;
        private double d;

        public ArithmeticProgression(double a, double d)
        {
            this.a = a;
            this.d = d;
        }
        public double GetElement(int k)
        {
            return a + d * (k - 1);
        }
        public double SumElement(int k)
        {
            return (2 * a + d * (k - 1)) / 2 * k;
        }
    }
}
