using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Control_Zad4
{
   internal class OilAndGasCompany : Organization
    {
        public int NumberOfEmployees { get; set; }
        public int OilReserv { get; set; }
        public int GazReserv { get; set; }

        public OilAndGasCompany(string name, string address, int rating, int numberOfEmployees, int oilreserv , int gazreserv)
            : base(name, address, rating)
        {
            NumberOfEmployees = numberOfEmployees;
            OilReserv = oilreserv;
            GazReserv = gazreserv;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($" Количество сотрудников: {NumberOfEmployees} \n Запасы нефти: {OilReserv} баррель \n Запасы газа: {GazReserv} кубометров\n");
        }
    }
}
