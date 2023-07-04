using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Control_Zad4
{
    internal class Factory : Organization
    {
        public int NumberOfWorkers { get; set; }
        public string ProductType { get; set; }

        public Factory(string name, string address, int rating, int numberOfWorkers, string productType): base(name, address ,rating)
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
