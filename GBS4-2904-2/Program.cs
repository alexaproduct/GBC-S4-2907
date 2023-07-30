// Дан одномерный массив целых чисел. 
// Найдите, сколько раз в нем повторяется
// самое частое число.
// Например, 15 23 14 23 17 23 21 14 -> 3

int[] arr = new int[8];

for (int i = 0; i <= 7; i++)
{
    arr[i] = new Random().Next(14, 31);
    Console.WriteLine(arr[i]);
}
Console.WriteLine();

int freq = 0;
int maxfreq = 0;

for (int i = 0; i <= 7; i++)
{
    for (int j = i+1; j <= 7; j++)
    {
        if (arr[i] == arr [j]) freq = freq + 1;
    }
    if (freq > maxfreq) maxfreq = freq;
    else if (freq == maxfreq) maxfreq = freq;
}

Console.WriteLine(maxfreq);


