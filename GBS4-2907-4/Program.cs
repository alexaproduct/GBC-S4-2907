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

int temp = 0;
int temp2 = arr[0];

for (int i = 0; i <= 6; i++)
{
    temp = temp2;
    temp2 = arr[i+1];
    arr[i+1] = temp;
    Console.WriteLine(arr[i]);
}