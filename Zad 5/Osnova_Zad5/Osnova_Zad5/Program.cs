using Osnova_Zad5;

internal class Program
{


    private static void Main(string[] args)
    {
        Book b1 = new Book();
        b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2012);
        Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013, 101, true);
        Book b3 = new Book("Лермонтов М.Ю.", "Мцыри");
        Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
        mag1.Show();
        mag1.IfSubs = true;
        mag1.Subs();

        Item[] itmas = new Item[4];
        itmas[0] = b1;
        itmas[1] = b2;
        itmas[2] = b3;
        itmas[3] = mag1;
        Array.Sort(itmas);
        Console.WriteLine("\n Сортировка по инвентарному номеру");
        foreach (Item x in itmas)
        {
            x.Show();
        }

        Book b4 = new Book("Толстой Л.Н.", "Анна Каренина", "Знание", 1204, 2014, 103, true);
        Book b5 = new Book("Неш Т", "Программирование для профессионалов", "Вильямс", 1200, 2014, 108, true);
        b4.ReturnSrok = true;
        b5.ReturnSrok = false;
        Console.WriteLine("\nКниги возвращены в срок:");
        b4.ProcessPaperbackBooks(Operation.PrintTitle);
        b5.ProcessPaperbackBooks(Operation.PrintTitle);

        Book.RetSrok += new Book.ProcessBookDelegate(Operation.MetodObrabotchik);
        b4.ReturnSrok = true;
        b5.ReturnSrok = true;
        Console.WriteLine("\n Книги возвращены в срок:");
        b4.ProcessPaperbackBooks(Operation.PrintTitle);
        b5.ProcessPaperbackBooks(Operation.PrintTitle);
    }
}
