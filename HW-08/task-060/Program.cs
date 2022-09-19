/* Задача 60.
...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

var Log = (string text) => Console.WriteLine(text);
var RandomNumber = (int min, int max) =>
{
    Random rnd = new Random();
    return () => rnd.Next(min, max + 1);
};
var GetRandomNumber = RandomNumber(1, 9);
var ArrayToString = (int[] array) => "[" + String.Join(", ", array.Select(v => String.Format("{0:0}", v))) + "]";
int MAX_SIZE = 5;

int size = 2;
if (size >= MAX_SIZE)
{
    Log("Does not compute, buy...");
    return;
}

int[,,] threeDeeArray = TwoDigits3DArray(size);
Log(Print3DArrayWithIndeces(threeDeeArray));


int[,,] TwoDigits3DArray(int size)
{
    int[,,] result = new int[size, size, size];
    int[] randomUniqueTwoDigits = ShuffleArray(TwoDigitNumbers());
    int index = 0;

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                result[i, j, k] = randomUniqueTwoDigits[index];
                index++;
            }
        }
    }
    return result;
}

int[] TwoDigitNumbers()
{
    int[] result = new int[90];
    for (int i = 10; i < 100; i++)
    {
        result[i - 10] = i;
    }
    return result;
}

int[] ShuffleArray(int[] array)
{
    int length = array.Length;
    var GetRandomIndex = RandomNumber(0, length - 1);

    for (int i = 0; i < array.Length; i++)
    {
        int newPosition = GetRandomIndex();
        int tmp = array[newPosition];
        array[newPosition] = array[i];
        array[i] = tmp;
    }
    return array;
}

string Print3DArrayWithIndeces(int[,,] array)
{
    string result = string.Empty;

    for (int i = 0; i < size; i++)
    {
        string padding = string.Empty;
        for (int j = 0; j < size; j++)
        {
            result += padding;
            for (int k = 0; k < size; k++)
            {
                int el = array[i, j, k];
                result += $"{el}({i}, {j}, {k}) ";
            }
            result += "\n";
            padding += "  ";
        }
        result += "\n";
    }
    return result;
}