/* Задача 64: 
Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"
*/

var Log = (string text) => Console.WriteLine(text);
var ArrayToString = (int[] array) => "[" + String.Join(", ", array.Select(v => String.Format("{0:0}", v))) + "]";

int m = 1;
int n = 5;

int[] natural = NaturalNumbers(m, n, new int[0]);

Log(ArrayToString(natural));

int[] NaturalNumbers(int from, int to, int[] numbers, int i = 0)
{
    int len = to - from + 1;

    if (i == 0)
    {
        numbers = new int[len];
    }

    if (i == len)
    {
        return numbers;
    }
    else
    {
        numbers[i] = from + i;
        return NaturalNumbers(from, to, numbers, i + 1);
    }
}