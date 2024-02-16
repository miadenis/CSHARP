// Напишите программу, которая на вход принимает два целых числа и проверяет,
// является ли первое число квадратом второго.



Console.WriteLine("num");
string var1 = Console.ReadLine();
int var_num1 = int.Parse(var1);

Console.WriteLine("num2");
string var2 = Console.ReadLine();
int var_num2 =int.Parse(var2);
if (var_num1 == var_num2 * var_num2)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");
