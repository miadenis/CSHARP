// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите целое число или 'q' для выхода:");
            string input = Console.ReadLine()!;
            
            if (input == "q")
            {
                break;
            }

            if (int.TryParse(input, out int number))
            {
                int sum = 0, temp = Math.Abs(number);
                
                while (temp > 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }

                if (sum % 2 == 0)
                {
                    Console.WriteLine("Сумма цифр чётная. Завершение работы.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введено не число.");
            }
        }
    }
}
