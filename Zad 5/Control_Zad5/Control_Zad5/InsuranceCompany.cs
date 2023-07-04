using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace Control_Zad5
{
    internal delegate void ClientAddedHandler();
    internal class InsuranceCompany : Organization
    {
        public event ClientAddedHandler NewClient;
        public int NumberOfClients { get; set; }
        public int CountOfPaids { get; set; }
        public int Changes;

        public InsuranceCompany(string name, string address, int rating, int numberOfClients, int countofpaids)
            : base(name, address, rating)
        {
            NumberOfClients = numberOfClients;
            CountOfPaids = countofpaids;
        }
        public void AddClient()
        {
            NumberOfClients++;
            NewClient?.Invoke();
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($" Количество клиентов: {NumberOfClients} \n Количетсво выплат клиентам: {CountOfPaids} \n");
        }
    }
}
