// Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.

using System;
using System.Linq;

class UserInputToCompileForTest
{ 
    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
        return numbers.Min();
    }
    
    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
        return numbers.Max();
    }
    
    // Вывод результата
    public static void PrintResult(double[] array)
    {
        double min = FindMin(array);
        double max = FindMax(array);
        double difference = max - min;
        Console.WriteLine($"{difference}");
    }
}

class Answer
{
    public static void Main(string[] args)
    {
        double[] array;
        
        if (args.Length >= 1) {
            string joinedArgs = string.Join(" ", args);
            array = joinedArgs.Split(", ")
                              .Select(double.Parse)
                              .ToArray();
        } else {
            array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}
//Решение автотеста:
using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Разница между максимальным и минимальным элементами массива

    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (min > numbers[i])
            {
                min = numbers[i];
            }
        }
        return min;
    }

    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }
        }
        return max;
    }



    public static void PrintResult(double[] array)
    {

        double result = FindMax(array) - FindMin(array);
        Console.WriteLine(result);
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        double[] array;


        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(double.Parse)
                                  .ToArray();

            // Теперь arr содержит преобразованные в целые числа из командной строки

        } else {
           // Если аргументов на входе нет
            array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}
