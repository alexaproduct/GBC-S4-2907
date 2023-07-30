// Задать массив, заполнить числами 1 и 0.

int[] arr = new int[15];

for (int i = 0; i <= 14; i++)
{
    arr[i] = new Random().Next(0, 2);
    Console.WriteLine(arr[i]);
}
Console.WriteLine();

// // Задача - Определить сколько 
// подряд единиц максимально

int MI = 1;
int max = 0;

for (int i = 1; i <= 14; i++)
{
    if (arr[i]==1)
    {
        if (arr[i-1] == 1) MI = MI + 1;
        else if (arr[i-1] != 1) MI = 1;
    }
    if (MI > max) max = MI;
    else if (MI == max) max = MI;
}

Console.WriteLine(max);
