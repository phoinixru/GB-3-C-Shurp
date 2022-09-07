/* Задача 36:
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

var RandomNumber = (int min, int max) =>
{
    Random rnd = new Random();
    return () => rnd.Next(min, max + 1);
};
var RandomDigit = RandomNumber(-10, 10);
var EmptyArray = (int length) => new int[length];
var RandomArray = (int length) => EmptyArray(length).Select(_ => RandomDigit()).ToArray();
var Log = (string text) => Console.WriteLine(text);
var ArrayToString = (int[] array) => "[" + String.Join(", ", array) + "]";

var SumOfEven = (int[] array) =>
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) continue;
        sum += array[i];
    }
    return sum;
};

int[] randomArray = RandomArray(5);
int sumOfEven = SumOfEven(randomArray);

Log($"Sum of even elements of array {ArrayToString(randomArray)} is {sumOfEven}");