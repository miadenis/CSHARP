// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

using System;

class Program
{
    static void Main()
    {
        // Пример массива для переворота
        int[] array = { 1, 2, 3, 4, 5 };
        
        // Выводим исходный массив
        Console.WriteLine("Исходный массив: " + string.Join(", ", array));
        
        // Вызываем функцию для переворота массива
        ReverseArray(array);
        
        // Выводим перевёрнутый массив
        Console.WriteLine("Перевёрнутый массив: " + string.Join(", ", array));
    }

    static void ReverseArray(int[] arr)
    {
        int temp;
        int n = arr.Length;
        for (int i = 0; i < n / 2; i++)
        {
            // Меняем местами элементы
            temp = arr[i];
            arr[i] = arr[n - i - 1];
            arr[n - i - 1] = temp;
        }
    }
}
