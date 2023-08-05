// Задача 38: Задайте массив 
// вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76



double[] numbers = new double[8];
Random rnd = new Random();
for (int i = 0; i < 8; i++)
{
    numbers[i] = rnd.NextDouble();
}


for (int i = 0; i < 8; i++)
{
    numbers[i] = numbers[i]*100;
    Console.WriteLine(numbers[i]);
}

double max = 0;
double min = 0;

max = numbers[0];
min = numbers[0];

for (int i = 0; i < 8; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

Console.WriteLine("Макс : {0}", max);

for (int i = 0; i < 8; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

Console.WriteLine("Мин : {0}", min);

double delta = max - min;

Console.WriteLine("Разница между Макс и Мин : {0}", delta);


// numbers[i] = rnd.NextDouble();

// Console.WriteLine(string.Join(" ", numbers.Select(n => $"{n:F2}")));

