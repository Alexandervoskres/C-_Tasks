using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Zad2
{
    internal class Circle : Shape
    {
        private double r;

        public Circle(double r)
        {
            this.r = r;
        }

        public override double Area()
        {
            return Math.PI * r * r;
        }
    }
}
