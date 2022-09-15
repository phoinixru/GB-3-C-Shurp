/* Задача 47.
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

var RandomRealNumber = (int min, int max) =>
{
    Random rnd = new Random();
    return () => rnd.NextDouble() * rnd.Next(min, max);
};
var GetRandomRealNumber = RandomRealNumber(-10, 10);


int m = 3;
int n = 4;

double[,] matrix = RandomRealMatrix(m, n);
PrintMatrix(matrix);



double[,] RandomRealMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = GetRandomRealNumber();
        }
    }
    return matrix;
}


void PrintMatrix(double[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            string formatted = String.Format("{0: 0.0;-0.0}", matrix[i, j]);
            Console.Write($"{formatted} ");
        }
        Console.WriteLine();
    }
}