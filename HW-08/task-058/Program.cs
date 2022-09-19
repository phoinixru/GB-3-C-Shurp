/* Задача 58: 
Задайте две матрицы. Напишите программу, которая 
будет находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:
18 20
15 18 */

var Log = (string text) => Console.WriteLine(text);
var RandomNumber = (int min, int max) =>
{
    Random rnd = new Random();
    return () => rnd.Next(min, max + 1);
};
var GetRandomNumber = RandomNumber(1, 9);
var ArrayToString = (int[] array) => "[" + String.Join(", ", array.Select(v => String.Format("{0:0}", v))) + "]";

int size = 2;
//int[,] a = {{2,4},{3,2}};
//int[,] b = {{3,4},{3,3}};
int[,] a = RandomSquareMatrix(size);
int[,] b = RandomSquareMatrix(size);
int[,] c = MatrixMultiplication(a, b);

Log($"Matrix (A):\n{PrintMatrix(a)}\n\nMatrix (B):\n{PrintMatrix(b)}\n\nMultiplied (AB):\n{PrintMatrix(c)}");



int[,] MatrixMultiplication(int[,] a, int[,] b)
{
    int length = a.GetLength(0);
    int[,] result = new int[length, length];
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            result[i, j] = MultiplyArrays(
                GetMatrixRow(a, i),
                GetMatrixCol(b, j)
            );
        }
    }
    return result;
}

int MultiplyArrays(int[] a1, int[] a2)
{
    int result = 0;
    for (int i = 0; i < a1.Length; i++)
    {
        result += a1[i] * a2[i];
    }
    return result;
}

int[] GetMatrixRow(int[,] matrix, int row)
{
    int cols = matrix.GetLength(1);
    int[] result = new int[cols];
    for (int i = 0; i < cols; i++)
    {
        result[i] = matrix[row, i];
    }
    return result;
}

int[] GetMatrixCol(int[,] matrix, int col)
{
    int rows = matrix.GetLength(0);
    int[] result = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        result[i] = matrix[i, col];
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