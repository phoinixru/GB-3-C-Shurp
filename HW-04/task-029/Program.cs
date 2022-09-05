// Задача 29: Напишите программу, которая задаёт массив из 
// 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int len = 8;
int[] array = ReadArray(len);

if (array.Length != len)
{
    Console.WriteLine("Does not compute");
    return;
}
else
{
    PrintArray(array);
}

int[] ReadArray(int len)
{
    Console.WriteLine($"Input an array of {len} elements using ',' as a separator:");
    int[] empty = new int[0];

    var input = Console.ReadLine();
    if (input == null || len == 0)
    {
        return empty;
    }

    int[] result = new int[len];
    string[] chunks = input.Split(',');

    if (chunks.Length != len)
    {
        return empty;
    }

    for (int i = 0; i < chunks.Length; i++)
    {
        bool isNumber = int.TryParse(chunks[i], out int n);
        if (!isNumber)
        {
            return empty;
        }
        result[i] = n;
    }
    return result;
}

void PrintArray(int[] array)
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result += i != 0 ? "," : "";
        result += array[i];
    }
    result += "]";

    Console.WriteLine(result);
}