// Создать массив на 5 элементов
//Заполнить его целыми числами
//Вывести элементы на экран

int[] arr = new int[5]; //команда выделения памяти
arr[0] = 5;
arr[1] = 7;
arr[2] = 5;
arr[3] = 4;
arr[4] = 3;
Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);
Console.WriteLine(arr[3]);
Console.WriteLine(arr[4]);

//Console.WriteLine(arr[5]); так нельзя, ошибка:Index was outside the bounds of the array

int[] arr2 = new int[5] { 1, 2, 3, 4, 5 }; //сразу указываем числа массива

int[] arr3 = { 1, 2, 3, 4, 5 }; // сокращаем, не используем команду выделения памяти

//arr = [1,2,3,4,5] на Python

