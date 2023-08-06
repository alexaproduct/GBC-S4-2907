// Дано нечетное число n.
// Создайте двумерный массив 
// из n×n элементов, заполнив 
// его символами "." (каждый элемент 
// массива является строкой из 
// одного символа). Затем заполните 
// символами "*" среднюю строку 
// массива, средний столбец массива, 
// главную диагональ и побочную 
// диагональ. В результате 
// единицы в массиве должны 
// образовывать изображение звездочки.
// Выведите полученный массив 
// на экран, разделяя элементы 
// массива пробелами.

/*
string[,] table = new string[5,5];

// String.Empty
// table [0,0] table [0,1] table [0,2] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,4]

// table[1, 2] = "слово";


// table[2, 2] = "*";

for (int rows = 0; rows < 5; rows++)
{
 for (int columns = 0; columns < 5; columns++)
 {
 Console.Write($"{table[rows, columns]}. ");
 }
Console.WriteLine();
}

for (int rows = 0; rows < 2; rows++)
{
 for (int columns = 0; columns < 2; columns++)
 {
 Console.Write($"{table[rows, columns]}* ");
 }
Console.WriteLine();
}
*/


/*
string[,] matrix = new string[5, 5];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]}* ");
        if (i == 2) Console.Write($"{matrix[i, j]}. ");
    }
    Console.WriteLine();
}
*/


void PrintArray(string[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 Console.Write($"{matr[i, j]}. ");
 }
 Console.WriteLine();
 }
}
void FillArray(string[,] matr)
{
 for (int i = 0; i < matr.GetLength(1); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 if (i == 2 | j == 2) Console.Write($"{matr[i, j]}* ");
 else
 {
    Console.Write($"{matr[i, j]}. ");
 }
 }
 Console.WriteLine();
 }
}
string[,] matrix = new string[5, 5];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

/*
void FillArray(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 3) Console.Write($"{matrix[i, j]}. ");
            Console.Write($"{matrix[i, j]}* ");
        }
    }
    Console.WriteLine();
}
FillArray(matrix);
*/

/*
void PrintArray(string[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{table[rows, columns]}. ");
        }
        Console.WriteLine();
    }
}

/*void FillArray(string[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{table[rows, columns]}* ");
        }
    }
}
*/

/*
string[,] matrix = new string[5, 5];
PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);
*/


/*
string[,] table = new string[2,5];

// String.Empty
// table [0,0] table [0,1] table [0,2] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,4]

table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
 for (int columns = 0; columns < 5; columns++)
 {
 Console.Write($"-{table[rows, columns]}- ");
 }
Console.WriteLine();
}
*/