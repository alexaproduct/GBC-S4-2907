// Задача 34: Задайте массив 
// заполненный случайными 
// положительными трёхзначными числами.
// Напишите программу, 
// которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = new int[8];

for (int i = 0; i <= 7; i++)
{
    arr[i] = new Random().Next(100, 999);
    Console.WriteLine(arr[i]);
}
Console.WriteLine();

int even = 0;

for (int i = 0; i <= 7; i++)
{
    if (arr[i] % 2 == 0) even = even + 1;
}

Console.WriteLine(even);