using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Zad3
{
    internal class Circle
    {
        private double r;

        public Circle(double r)
        {
            this.r = r;
        }

        public  double Area()
        {
            return Math.PI * r * r;
        }
    }
}
