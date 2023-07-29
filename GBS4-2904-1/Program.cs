// Задать массив, заполнить числами 1 и 0.

int[] arr = new int[8];

for (int i = 0; i <= 7; i++)
{
    arr[i] = new Random().Next(0, 2);
    Console.WriteLine(arr[i]);
}
Console.WriteLine();
