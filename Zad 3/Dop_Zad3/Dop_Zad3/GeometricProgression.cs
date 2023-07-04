using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop_Zad3
{
    internal class GeometricProgression
    {
        private double a;
        private double d;

        public GeometricProgression(double a, double d)
        {
            this.a = a;
            this.d = d;
        }

        public double GetElement(int k)
        {
            return a * Math.Pow(d, k - 1);
        }
        public double SumElement(int k)
        {
            return (a * (Math.Pow(d, k) - 1)) / (d - 1);
        }
    }
}
