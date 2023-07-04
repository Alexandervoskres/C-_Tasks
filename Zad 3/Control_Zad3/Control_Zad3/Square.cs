using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Zad3
{
    internal class Square : IShape
    {
        private double a;

        public Square(double a)
        {
            this.a = a;
        }
        public  double Area()
        {
            return a * a;
        }
    }
}
