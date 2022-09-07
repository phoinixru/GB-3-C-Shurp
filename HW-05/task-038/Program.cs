/* Задача 38:
Задайте массив вещественных чисел. Найдите разницу между
максимальным и минимальным элементом массива.

[3 7 22 2 78] -> 76 */

var RandomRealNumber = (int min, int max) =>
{
    Random rnd = new Random();
    return () => rnd.NextDouble() * rnd.Next(min, max);
};
var GetRandomRealNumber = RandomRealNumber(-100, 100);
var EmptyArray = (int length) => new int[length];
var RandomArray = (int length) => EmptyArray(length).Select(_ => GetRandomRealNumber()).ToArray();
var Log = (string text) => Console.WriteLine(text);
var ArrayToString = (double[] array) => "[" + String.Join(", ", array) + "]";

var Max = (double[] array) =>
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max > array[i]) continue;
        max = array[i];
    }
    return max;
};

var Min = (double[] array) =>
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min < array[i]) continue;
        min = array[i];
    }
    return min;
};

double[] randomArray = RandomArray(5);
double max = Max(randomArray);
double min = Min(randomArray);
double diff = max - min;

Log($"Max({max}) - Min({min}) = {diff} of array:\n{ArrayToString(randomArray)}");