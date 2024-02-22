// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число
//кратным второму. Если первое число некратно второму, то программа выводит остаток от деления.

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
if (num1 % num2 == 0)
    Console.WriteLine("да"); // если num1 кратно num2
else
    Console.WriteLine(num1 % num2);
