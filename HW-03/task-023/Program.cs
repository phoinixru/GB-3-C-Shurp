// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Enter N:");
string? input = Console.ReadLine();
bool isNumber = int.TryParse(input, out int n);

if (!isNumber)
{
    ShowMessage("Nice try.");
    return;
}

if (n < 1)
{
    ShowMessage("Be extra positive!");
    return;
}

PrintCubes(n);


// Show error in console
void ShowMessage(string msg)
{
    Console.WriteLine(msg);
}

void PrintCubes(int n)
{
    int[] cubes = new int[n];
    for (int i = 1; i <= n; i++)
    {
        cubes[i - 1] = (int)Math.Pow(i, 3);
    }
    PrintArray(cubes);
}

// Print array
void PrintArray(int[] arr)
{
    string str = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        str += (i == 0 ? "" : ", ") + $"{arr[i]}";
    }
    ShowMessage(str);
}