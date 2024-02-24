// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число из отрезка [10, 99]: ");
        int number = int.Parse(Console.ReadLine()!);

        if (number >= 10 && number <= 99)
        {
            int firstDigit = number / 10;
            int secondDigit = number % 10;

            if (firstDigit > secondDigit)
            {
                Console.WriteLine($"Наибольшая цифра числа: {firstDigit}");
            }
            else
            {
                Console.WriteLine($"Наибольшая цифра числа: {secondDigit}");
            }
        }
        else
        {
            Console.WriteLine("Число не входит в заданный отрезок.");
        }
    }
}
