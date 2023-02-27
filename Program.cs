/*
Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа.
*/

string[] GetArray(string message)
{
    Console.WriteLine(message);
    string arrayStr = Console.ReadLine()!.Replace(" ", "").Replace("\"", "");
    return arrayStr.Split(",");
}

string[] PrepareArray(string[] array, int maxLength)
{
    int newLength = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength) newLength++;
    }

    string[] newArray = new string[newLength];

    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            newArray[j] = array[i];
            j++;
        }
    }

    return newArray;
}

string[] array = GetArray("Введите массив строк (через запятую):");
Console.WriteLine($"[\"{String.Join("\",\"", PrepareArray(array, 3))}\"]");