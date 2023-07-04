using Control_Zad5;

class Program
{
    static void Main(string[] args)
    {
        InsuranceCompany insurance = new InsuranceCompany("Застрахуйся", "Ул.Толстого 123", 2, 400, 200);
        insurance.Print();
        insurance.NewClient += OnNewClient;
        insurance.AddClient();
        Console.WriteLine($" Теперь клиентов в компании {insurance.Name} стало на {insurance.Rating} больше \n");
        OilAndGasCompany oilandgas = new OilAndGasCompany("ТрансбансГазНефть", "Ул. Пушкина 123", 6, 12000, 1000, 1000);
        oilandgas.Print();
        Factory factory = new Factory("Завод имени Ленина", "Ул.Горького 123", 3, 100, "Машины");
        factory.Print();
    }
    static void OnNewClient() { 
        Console.WriteLine(" Появился новый клиент");
    }
}
