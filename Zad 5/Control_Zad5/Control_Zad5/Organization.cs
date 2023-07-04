using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Zad5
{
    internal class Organization
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }

        public Organization(string name, string address, int rating)
        {
            Name = name;
            Address = address;
            Rating = rating;
        }
        public virtual void Print()
        {
            Console.WriteLine($" Название организации: {Name} \n Адрес: {Address} \n Рейтинг: {Rating}/10");
        }
    }
}