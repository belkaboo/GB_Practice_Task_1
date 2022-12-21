Console.Clear();

// Массивы из примера
string[] array1 = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };

Console.Write("Укажите кол-во символов для выполнения: "); // 3 символа по условиям задания
int size = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Исходный массив - [{string.Join(", ", array1)}]");
Console.WriteLine($"Результат 1 решения - [{string.Join(", ", GetArrayShortElements(array1, size))}]");
Console.WriteLine();
Console.WriteLine($"Результат 2 решения - [{string.Join(", ", GetArrayShortResize(array1, size))}]");




string[] GetArrayShortElements(string[] array, int n)
{
    int newSize = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n) newSize++;
    }
    string[] shortArray = new string[newSize];

    if (newSize != 0)
    {
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= n)
            {
                shortArray[j] = array[i];
                j++;
            }
        }
        return shortArray;
    }
    return shortArray;
}


string[] GetArrayShortResize(string[] array, int n)
{
    string[] shortArray = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            Array.Resize(ref shortArray, shortArray.Length + 1);
            shortArray[shortArray.Length - 1] = array[i];
        }
    }
    return shortArray;
}

