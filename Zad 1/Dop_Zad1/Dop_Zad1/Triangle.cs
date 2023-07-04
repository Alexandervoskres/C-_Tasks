using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop_Zad1
{
    internal class Triangle
    {
        double a, b, c;
        public Triangle()
        {
        }
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Show()
        {
            Console.WriteLine("Длины треугольника: {0}, {1}, {2}", a, b, c);
        }
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p / 2 * (p - a) * (p - b) * (p - c));
        }

        public double Perimetr()
        {
            return a + b + c;
        }
        public bool TriangleChecking()
        {
            return (a + b > c && a + c > b && b + c > a);
        }
    }
}
