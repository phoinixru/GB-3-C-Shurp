/* Задача 54:
Задайте двумерный массив. Напишите программу, которая упорядочит по 
убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

var Log = (string text) => Console.WriteLine(text);
var RandomNumber = (int min, int max) =>
{
    Random rnd = new Random();
    return () => rnd.Next(min, max + 1);
};
var GetRandomNumber = RandomNumber(1, 9);
var ArrayToString = (double[] array) => "[" + String.Join(", ", array.Select(v => String.Format("{0:0.00}", v))) + "]";


int[,] matrix = RandomMatrix(3, 4);
Log($"Original:\n{PrintMatrix(matrix)}\n");
SortMatrixRows(matrix);
Log($"Sorted:\n{PrintMatrix(matrix)}");


void SortMatrixRows(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    for (int i = 0; i < rows; i++)
    {
        SortMatrixRow(matrix, i);
    }
}

void SortMatrixRow(int[,] matrix, int row)
{
    int cols = matrix.GetLength(1);
    for (int j = 0; j < cols - 1; j++)
    {
        for (int i = 0; i < cols - j - 1; i++)
        {
            int a = matrix[row, i];
            int b = matrix[row, i + 1];

            if (b > a)
            {
                matrix[row, i] = b;
                matrix[row, i + 1] = a;
            }
        }
    }

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