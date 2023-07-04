using Dop_Zad5;
class Program
{
    static void Main(string[] args)
    {
        Gamer g1 = new Gamer("Василий");
        g1.ScoreNotify += MaxScoreNotify;
        for (int i = 1; i <= 6; i++)
        {
            int alpha = g1.SeansGame();
            Console.WriteLine("Выпало количество очков {0} для игрока по имени {1}", alpha, g1.ToString());
        }
    }
    public static void MaxScoreNotify(string message)
    {
        Console.WriteLine(message);
    }
}