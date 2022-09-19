/* Задача 56:
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка */

var Log = (string text) => Console.WriteLine(text);
var RandomNumber = (int min, int max) =>
{
    Random rnd = new Random();
    return () => rnd.Next(min, max + 1);
};
var GetRandomNumber = RandomNumber(1, 9);
var ArrayToString = (int[] array) => "[" + String.Join(", ", array.Select(v => String.Format("{0:0}", v))) + "]";


int[,] squareMatrix = RandomSquareMatrix(4);
int[] sums = FindRowSums(squareMatrix);
int minSumRow = FindRowWithMinSum(squareMatrix);

Log($"Matrix:\n{PrintMatrix(squareMatrix)}\nRow sums:\n{ArrayToString(sums)}\nMin row: {minSumRow}");



int FindRowWithMinSum(int[,] matrix)
{
    int[] sums = FindRowSums(matrix);
    return MinElementIndex(sums) + 1;
}

int MinElementIndex(int[] array)
{
    int minIndex = 0;
    int min = array[minIndex];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            minIndex = i;
            min = array[minIndex];
        }
    }
    return minIndex;
}

int[] FindRowSums(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[] result = new int[columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i] += matrix[i, j];
        }
    }
    return result;
}

int[,] RandomSquareMatrix(int length)
{
    return RandomMatrix(length, length);
}

int[,] RandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = GetRandomNumber();
        }
    }
    return matrix;
}

string PrintMatrix(int[,] matrix)
{
    string result = string.Empty;
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result += String.Format("{0:0 }", matrix[i, j]);
        }
        if (i != rows - 1)
        {
            result += "\n";
        }
    }
    return result;
}