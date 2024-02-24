// Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа 
//и выводит, какое число большее, а какое меньшее.



using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
     
        if (firstNumber > secondNumber)
          Console.WriteLine("первое число больше");
      
        else if (firstNumber < secondNumber)
            Console.WriteLine("второе число больше");
        else
        Console.WriteLine("числа равны");
  
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 6;
            secondNumber = 3;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}

//Решение автотеста:
using System;


public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        if (firstNumber == secondNumber)
        {
            Console.WriteLine($"числа равны");
        }
        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"первое число больше`");
        }
        if (firstNumber < secondNumber)
        {
            Console.WriteLine($"второе число больше");
        }
    }

    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
            firstNumber = 5;
            secondNumber = 5;
        }

        CompareNumbers(firstNumber, secondNumber);
    }
}
