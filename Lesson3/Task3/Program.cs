// удаление четных чисел из массива

void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (var e in arr)
    {
        Console.Write($"{e} ");
    }
}
int[] array = {1, 2, 3, 4, 5};
ZeroEvenElements(array);
PrintArray(array);