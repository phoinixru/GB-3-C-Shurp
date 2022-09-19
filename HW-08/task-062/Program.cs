/* Задача 62.
Напишите программу, которая заполнит спирально массив 4 на 4.

Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

var Log = (string text) => Console.WriteLine(text);
var ArrayToString = (int[] array) => "[" + String.Join(", ", array.Select(v => String.Format("{0:0}", v))) + "]";

int[,] spiral = SpiralMatrix(4);
Log($"Spiral matrix:\n{PrintMatrix(spiral)}");

int[,] SpiralMatrix(int size)
{
    int[,] result = new int[size, size];
    int elements = size * size;

    int turns = 0;
    int[] inc = MakeTurn(turns);
    int row = 0;
    int col = 0;
    int stepsBeforeTurn = size;

    for (int i = 0; i < elements; i++)
    {
        if (--stepsBeforeTurn == 0)
        {
            stepsBeforeTurn = size - 1 - turns++ / 2;
            inc = MakeTurn(turns);
        }

        result[row, col] = i + 1;

        row += inc[0];
        col += inc[1];
    }
    return result;
}

int[] MakeTurn(int turn)
{
    int direction = turn % 4;
    int[] r = new int[2];
    switch (direction)
    {
        case 0:
            r[1] = 1; break;
        case 1:
            r[0] = 1; break;
        case 2:
            r[1] = -1; break;
        case 3:
            r[0] = -1; break;
    }
    return r;
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
            result += String.Format("{0:00 }", matrix[i, j]);
        }
        if (i != rows - 1)
        {
            result += "\n";
        }
    }
    return result;
}