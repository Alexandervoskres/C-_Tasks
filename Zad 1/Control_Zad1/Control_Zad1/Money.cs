using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Zad1
{
    internal class Money
    {
        int denomination;
        int count;
        public Money(int denomination, int count)
        {
            this.denomination = denomination;
            this.count = count;
        }
        public void Show()
        {
            Console.WriteLine(" Номинал: {0} \n Количество Купюр: {1}", denomination , count);
        }
        public bool Check(int n)
        {
            if (denomination * count >= n)
            {
                Console.WriteLine(" Дружище , у тебя хватает");
                return true;
            }
            else 
            {
                Console.WriteLine(" Дружище , у тебя не хватает");
                return false;
            }
        }
        public int CountTovar(int n)
        {
            if (n != 0)
            {
                return (denomination * count) / n;
            }
            else
            {
                return 0;
            }
        }
        public int Denomination
        {
            get { return this.denomination; }
            set { this.denomination = value; }
        }

        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }
    }
}
