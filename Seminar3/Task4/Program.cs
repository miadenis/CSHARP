﻿// Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. 
// Младший разряд числа должен располагаться на 0-м индексе массива, старший – на 2-м.

int[] arr = new int[3];
int num = int.Parse(Console.ReadLine()!);


for (int i = 0; /*i < arr.Length;*/ i < 3; i++)
{
    arr[i] = num % 10; // забирает последнюю цифру числа
    num = num / 10;
    Console.WriteLine(arr[i] + " ");
}