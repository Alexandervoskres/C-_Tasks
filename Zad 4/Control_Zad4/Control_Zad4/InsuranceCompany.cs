using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Control_Zad4
{
    internal class InsuranceCompany : Organization
    {
        public int NumberOfClients { get; set; }
        public int CountOfPaids { get; set; }

        public InsuranceCompany(string name, string address, int rating, int numberOfClients, int countofpaids)
            : base(name, address, rating)
        {
            NumberOfClients = numberOfClients;
            CountOfPaids = countofpaids;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($" Количество клиентов: {NumberOfClients} \n Количетсво выплат клиентам: {CountOfPaids} \n");
        }
    }

}
