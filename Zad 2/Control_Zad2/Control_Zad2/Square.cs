using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Zad2
{
    internal class Square : Shape
    {
        private double a;

        public Square(double a)
        {
            this.a = a;
        }
        public override double Area()
        {
            return a * a;
        }
    }
}
