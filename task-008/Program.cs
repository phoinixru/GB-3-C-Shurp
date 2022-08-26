/*
Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Enter number N");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

if (number < 1) Console.WriteLine("You gotta be kidding!");
else
{
    Console.WriteLine($"Are there any even numbers less than than {number}?");

    while (i <= number)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i} ");
        }
        i++;
    }
}