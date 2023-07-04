using Dop_Zad2;

        Progression progression = new ArithmeticProgression(3, 3);
        Console.WriteLine(progression.GetElement(10));
        progression = new GeometricProgression(3, 3);
        Console.WriteLine(progression.GetElement(5));
        Console.ReadKey();
