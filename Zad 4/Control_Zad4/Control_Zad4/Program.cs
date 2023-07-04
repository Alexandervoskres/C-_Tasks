using Control_Zad4;

class Program
{
    static void Main(string[] args)
    {
        InsuranceCompany insurance= new InsuranceCompany("Застрахуйся", "Ул.Толстого 123", 10, 400, 200);
        insurance.Print();

        OilAndGasCompany oilandgas = new OilAndGasCompany("ТрансбансГазНефть", "Ул. Пушкина 123", 6, 12000, 1000, 1000);
        oilandgas.Print();

        Factory factory = new Factory("Завод имени Ленина", "Ул.Горького 123", 3, 100 ,"Машины");
        factory.Print();
    }
}