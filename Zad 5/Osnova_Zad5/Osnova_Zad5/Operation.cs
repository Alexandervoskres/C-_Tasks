using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osnova_Zad5
{
    class Operation
    {
        public static void PrintTitle(Book book)
        {
            book.Show();
        }
        public static void MetodObrabotchik(Book b)
        {
            Console.WriteLine("Книга {0} сдана в срок.", b.ToString());
        }
    }
}
