// Преобразовать массив так, 
// чтобы сначала шли 
// нулевые элементы, а затем
// все остальные.
// -1 -3 -1 -3 -1 0 -4 -2 
//  0 -1 -3 -1 -3 -1 -4 -2
//-> 0 -3 -1 -3 -1 -1 -4 -2 ; 


int[] arr = new int[8];
arr [0] = -1;
arr [1] = -3;
arr [2] = -1;
arr [3] = -3;
arr [4] = -1;
arr [5] = 0;
arr [6] = -4;
arr [7] = -2;

for (int i = 0; i <= 7; i++)
{
    Console.WriteLine(arr[i]);
}
Console.WriteLine();

// Только для случаев, если один 0 в массиве:

int temp = 0;
int temp2 = 0;
int k = 0;

for (int i = 0; i <= 7; i++)
{
    if (arr[i] == 0)
    {
        temp = arr[0];
        temp2 = temp;
        arr[0] = arr[i];
        arr[i] = arr[i-1];
        k = i;
    }
}

if (arr[0] == 0)
{
    for (int i = 1; i <= k-1; i++)
    {
        temp = temp2;
        temp2 = arr[i];
        arr[i] = temp;
    }
}

for (int i = 0; i <= 7; i++)
{
    Console.WriteLine(arr[i]);
}