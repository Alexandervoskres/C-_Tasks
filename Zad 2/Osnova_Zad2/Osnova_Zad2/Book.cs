using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osnova_Zad2
{
    class Book : Item
    {
        private string author; // автор
        private string title; // название
        private string publisher; // издательство
        private int pages; // кол-во страниц
        private int year; // год издания
        private static double price = 9;
        private bool returnSrok;

        public override void Return() // операция "вернуть"
        {
            if (returnSrok == true) taken = true;
            else taken = false;
        }
        public void ReturnSrok()
        {
            returnSrok = true;
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Book(string author, string title, string publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }
        public Book()
        {
        }
        static Book() //статический конструктор
        {
            price = 10;
        }
        public Book(string author, string title)
        {
            this.author = author;
            this.title = title;
        }
        public void SetBook(String author, string title, string publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }
        public static void SetPrice(double price)
        {
            Book.price = price;
        }
        new public void Show()
        {
            Console.WriteLine("\n Книга:" +
                "\n Автор: {0}" +
                "\n Название: {1}" +
                "\n Год издания: {2}" +
                "\n Издательство: {3}" +
                "\n {4}стр." +
                "\n Стоимость аренды: {5}",
                author, title, year, publisher, pages, Book.price);
            base.Show();

        }
        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }
        public Book(string author, string title, string publisher, int pages, int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }


    }
}
