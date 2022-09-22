/* Задача 66: 
Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

var Log = (string text) => Console.WriteLine(text);

int m = 4;
int n = 8;

int sum = NaturalSum(m, n);

Log($"Sum of natural numbers from {m} to {n}: {sum}");

int NaturalSum(int from, int to)
{
    if (from == to)
    {
        return to;
    }
    else
    {
        return from + NaturalSum(from + 1, to);
    }
}