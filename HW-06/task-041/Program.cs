/* Задача 41:
Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

var Log = (string text) => Console.WriteLine(text);
var ArrayToString = (int[] array) => "[" + String.Join(", ", array) + "]";


int m = 5;
int[] userInput = ReadArray(m);

if (userInput.Length != m) {
    Log("Wrong input");
    return;
}

int positiveCount = CountPositive(userInput);

Log(
    $"There {(positiveCount == 1 ? "is" : "are")} {positiveCount} positive number{(positiveCount == 1 ? "" : "s")} in array: \n" +
    ArrayToString(userInput)
);



int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        count += array[i] > 0 ? 1 : 0;
    }
    return count;
}

int[] ReadArray(int len)
{
    Console.WriteLine($"Input an array of {len} numbers using ',' as a separator:");
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