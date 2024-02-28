// Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем генератор случайных чисел
        Random random = new Random();

        // Задаем размер массива
        int arraySize = 10; // Можно задать любое другое значение

        // Создаем массив
        int[] numbers = new int[arraySize];

        // Заполняем массив случайными трехзначными числами
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100, 1000);
        }

        // Выводим массив на экран
        Console.WriteLine("Массив случайных трехзначных чисел:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Подсчитываем количество четных чисел в массиве
        int evenCount = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        // Выводим результат на экран
        Console.WriteLine("Количество четных чисел в массиве: " + evenCount);

        Console.ReadLine(); // Чтобы консольное окно не закрывалось сразу
    }
}
