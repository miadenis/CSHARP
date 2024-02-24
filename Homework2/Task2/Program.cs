﻿// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

//через foreach:

using System;
using System.Linq;

class UserInputToCompileForTest
{ 
    // Подсчет количества четных элементов массива
    public static int CountEvenItems(int[] numbers)
    {
        int count = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
    
    // Вывод результата
    public static void PrintResult(int[] array)
    {
        int countEven = CountEvenItems(array);
        Console.WriteLine($"{countEven}");
    }
}

class Answer
{
    public static void Main(string[] args)
    {
        int[] array;
        
        if (args.Length >= 1) {
            string joinedArgs = string.Join(" ", args);
            array = joinedArgs.Split(", ")
                              .Select(int.Parse)
                              .ToArray();
        } else {
            array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Заданный по умолчанию массив
        }
        
        UserInputToCompileForTest.PrintResult(array);
    }
}

// через for:

using System;
using System.Linq;

class UserInputToCompileForTest
{ 
    // Подсчет количества четных элементов массива
    public static int CountEvenItems(int[] numbers)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
    
    // Вывод результата
    public static void PrintResult(int[] array)
    {
        int countEven = CountEvenItems(array);
        Console.WriteLine($"{countEven}");
    }
}

class Answer
{
    public static void Main(string[] args)
    {
        int[] array;
        
        if (args.Length >= 1) {
            string joinedArgs = string.Join(" ", args);
            array = joinedArgs.Split(", ")
                              .Select(int.Parse)
                              .ToArray();
        } else {
            array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Заданный по умолчанию массив
        }
        
        UserInputToCompileForTest.PrintResult(array);
    }
}

// Решение автотеста:

using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Подсчет количества четных элементов массива
    // numbers - массив, в котором ведется подсчет
    public static int CountEvenItems(int[] numbers)
    {
        int cnt = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                cnt++;
            }
        }
        return cnt;
    }

    public static void PrintResult(int[] array)
    {
        Console.WriteLine(CountEvenItems(array));
    }
}


//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[] array;


        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();

            // Теперь arr содержит преобразованные в целые числа из командной строки

        } else {
           // Если аргументов на входе нет
            array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}
