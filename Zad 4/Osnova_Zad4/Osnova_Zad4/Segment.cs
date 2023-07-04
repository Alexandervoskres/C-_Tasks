using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osnova_Zad4
{
    internal class Segment
    {
        private Point pStart;
        private Point pEnd;

        public Segment(Point pStart, Point pEnd)
        {
            this.pStart = pStart;
            this.pEnd = pEnd;
        }
        public Segment() { }
        public void Show()
        {
            Console.WriteLine("Отрезок с координатами: {0}-{1}", pStart, pEnd);
        }
        public double Length()
        {
            return pStart.Interval(pEnd);
        }

    }
}
