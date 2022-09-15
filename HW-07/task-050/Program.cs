/* Задача 50.
Напишите программу, которая на вход принимает число и ищет в двумерном массиве,
и возвращает индексы этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
7 -> 0, 2
5 -> 1, 0
18 -> нет такого элемента */

var Log = (string text) => Console.WriteLine(text);
var RandomNumber = (int min, int max) =>
{
    Random rnd = new Random();
    return () => rnd.Next(min, max + 1);
};
var GetRandomNumber = RandomNumber(0, 9);
var CoordinatesToString = (int[] coordinates) => "(" + String.Join(", ", coordinates) + ")";




int[,] matrix = RandomMatrix(4, 4);
int element = 7;
int[] coordinates = FindElementInMatrix(matrix: matrix, element: element);

if (coordinates[0] == -1)
{
    Log($"There is no element {element} in matrix:\n{PrintMatrix(matrix)}");
}
else
{
    Log($"Coordinates of lement {element} in matrix:\n{PrintMatrix(matrix)}\nare: {CoordinatesToString(coordinates)}");
}




int[] FindElementInMatrix(int[,] matrix, int element)
{
    int[] result = { -1, -1 };
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (element == matrix[i, j])
            {
                result[0] = i;
                result[1] = j;
                return result;
            }
        }
    }

    return result;
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