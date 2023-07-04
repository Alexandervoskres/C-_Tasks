using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop_Zad2
{
    internal class GeometricProgression : Progression 
    {
        private float b;
        private float q;

        public GeometricProgression(float b, float q)
        {
            this.b = b;
            this.q = q;
        }

        public override double GetElement(int k)
        {
            return b * Math.Pow(q, k);
        }
    }
}
