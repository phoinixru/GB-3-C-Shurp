/* Задача 34:
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

var RandomNumber = (int min, int max) =>
{
    Random rnd = new Random();
    return () => rnd.Next(min, max + 1);
};
var RandomThreeDigit = RandomNumber(100, 999);
var EmptyArray = (int length) => new int[length];
var RandomArray = (int length) => EmptyArray(length).Select(_ => RandomThreeDigit()).ToArray();
var Log = (string text) => Console.WriteLine(text);
var ArrayToString = (int[] array) => "[" + String.Join(", ", array) + "]";

var CountEven = (int[] array) =>
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        count += array[i] % 2 == 0 ? 1 : 0;
    }
    return count;
};

int[] randomArray = RandomArray(5);
int evenCount = CountEven(randomArray);

Log($"There {(evenCount == 1 ? "is" : "are")} {evenCount} even number{(evenCount == 1 ? "" : "s")} in array: \n{ArrayToString(randomArray)}");