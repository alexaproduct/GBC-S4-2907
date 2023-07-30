// Задан список имен. Обменяйте местами имена
// первого и последнего, второго и предпоследнего,
// третьего от начала и третьего с конца и т.д.


string s = Console.ReadLine()??"";
string[] names = s.Split(" ");


void PrintMassString(string[] arr)
{
    foreach (var item in names)
    {
        Console.Write(item+ " ");
    }
}

PrintMassString(names);
Console.WriteLine();

for (int i = 0; i < names.Length/2; i++)
{
    string temp = names[i];
    names[i] = names[names.Length-1-i];
    names[names.Length-1-i] = temp;
}
PrintMassString(names);
Console.WriteLine();



