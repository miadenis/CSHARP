// Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите координату X (не равную 0): ");
        int x = int.Parse(Console.ReadLine()!);
        Console.Write("Введите координату Y (не равную 0): ");
        int y = int.Parse(Console.ReadLine()!);

        if (x > 0 && y > 0)
            Console.WriteLine("1-я координатная четверть.");
        else if (x < 0 && y > 0)
            Console.WriteLine("2-я координатная четверть.");
        else if (x < 0 && y < 0)
            Console.WriteLine("3-я координатная четверть.");
        else if (x > 0 && y < 0)
            Console.WriteLine("4-я координатная четверть.");
    }
}
