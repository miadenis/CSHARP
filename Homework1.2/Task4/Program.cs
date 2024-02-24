// Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число N: ");
        int N = Convert.ToInt32(Console.ReadLine())!;
        
        if (N < 10)
        {
            // Если число состоит из одной цифры, просто выводим его.
            Console.WriteLine(N);
        }
        else
        {
            // Преобразование числа в строку для удобства работы с цифрами
            string numberAsString = N.ToString();
            for (int i = 0; i < numberAsString.Length; i++)
            {
                // Вывод текущей цифры
                Console.Write(numberAsString[i]);
                // Добавление запятой после всех цифр, кроме последней
                if (i < numberAsString.Length - 1)
                {
                    Console.Write(",");
                }
            }
        }
    }
}
