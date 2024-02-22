// Дано N гирь с разным весом в случайном порядке. Определить вес самой тяжелой гири.

// С циклом while

int n = 5;
int[] array = { 2, 4, 7, 3, 9 };
int i = 0;
int max = array[0];

while(i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);

// C циклом for

max = array[0];
for(int j = 0; j < n; j++) //j++ тоже самое что и j = j + 1
{
   if (array[j] > max)
    {
        max = array[j];
    }
} 
Console.WriteLine(max);

// С циклом foreach

max = array[0];
foreach(int e in array) // e - имя переменной
{
   if (e > max)
    {
        max = e;
    } 
}
Console.WriteLine(max);