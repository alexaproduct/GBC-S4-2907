// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами.
// Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[5];

for (int i = 0; i <= 4; i++)
{
    arr[i] = new Random().Next(0, 10);
    Console.WriteLine(arr[i]);
}
Console.WriteLine();

int sumuneven = 0;

for (int i = 0; i <= 4; i++)
{
    if (i%2 != 0) sumuneven = sumuneven + arr[i];
}

Console.WriteLine(sumuneven);