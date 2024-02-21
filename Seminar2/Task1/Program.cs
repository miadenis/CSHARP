// Напишите программу которая принимает на вход трехзначное число и удаляет вторую цифру этого числа

int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine(num1/100 * 10 + num1%10);
