// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,90].


using System;
using System.Linq;

class UserInputToCompileForTest
{
    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
        int count = 0;
        foreach (var number in numbers)
        {
            if (number >= minRange && number <= maxRange)
            {
                count++;
            }
        }
        return count;
    }
    
    public static void PrintResult(int[] array)
    {
        int count = CountItemsRange(array, 10, 90);
        Console.WriteLine($"{count}");
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
            array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Исходный массив
        }
        
        UserInputToCompileForTest.PrintResult(array);
    }
}

/*
using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Подсчет количества элементов массива, попадающих в заданный диапазон
    // numbers - массив, в котором ведется подсчет
    // minRange - минимальная граница диапазона
    // maxRange - максимальная граница диапазона
    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
        int count = 0;
        foreach (var number in numbers)
        {
            if (number >= minRange && number <= maxRange)
            {
                count++;
            }
        }
        return count;
    }
    
    public static void PrintResult(int[] array)
    {
        
        int count = CountItemsRange(array, 10, 90);
        Console.WriteLine($"{count}");
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
            array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}
*/