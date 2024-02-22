// Напишите программу, которая выводит третью с конца цифру заданного числа или сообщает, что
//третьей цифры нет.

int num = int.Parse(Console.ReadLine()!);
if (num < 100)
{
    Console.WriteLine("нет"); //третьей цифры нет
}
else
{
    Console.WriteLine((num / 100) % 10);
}

