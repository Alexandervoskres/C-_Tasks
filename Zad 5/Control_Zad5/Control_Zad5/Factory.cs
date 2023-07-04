using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Zad5
{
    internal class Factory : Organization
    {
        public int NumberOfWorkers { get; set; }
        public string ProductType { get; set; }

        public Factory(string name, string address, int rating, int numberOfWorkers, string productType) : base(name, address, rating)
        {
            NumberOfWorkers = numberOfWorkers;
            ProductType = productType;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($" Количество сотрудников: {NumberOfWorkers} \n Производимый продукт: {ProductType} \n");
        }
    }
}
