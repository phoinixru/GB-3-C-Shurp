/* Задача 43:
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

var Log = (string text) => Console.WriteLine(text);
var ArrayToString = (int[] array) => "[" + String.Join(", ", array) + "]";
var PointToString = (double[] point) => "(" + String.Join("; ", point) + ")";

int[] userInput = InputLines();
if (userInput.Length != 4)
{
    Log("Wrong input");
    return;
}
else
{
    Log($"User input: {ArrayToString(userInput)}");
}

int b1 = userInput[0];
int k1 = userInput[1];
int b2 = userInput[2];
int k2 = userInput[3];
bool isParallelLines = IsParallelLines(k1, k2);

if (isParallelLines)
{
    Log("These are parallel lines");
    return;
}

double[] crossPoint = FindIntersection(k1: k1, b1: b1, k2: k2, b2: b2);
Log($"Lines cross at: {PointToString(crossPoint)}");

int[] InputLines()
{
    string[] names = { "k1", "b1", "k2", "b2" };
    int len = names.Length;
    int[] result = new int[len];

    for (int i = 0; i < len; i++)
    {
        Log($"Enter {names[i]}:");

        bool isNumber = int.TryParse(Console.ReadLine(), out int n);
        if (!isNumber)
        {
            return new int[0];
        }
        result[i] = n;
    }
    return result;
}

bool IsParallelLines(int k1, int k2)
{
    return k1 == k2;
}

double[] FindIntersection(int b1, int k1, int b2, int k2)
{

    double x = (double) (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] point = { x, y };

    return point;
}