/*
Задача 4: Напишите программу, которая принимает на вход три числаи
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Enter thre numbers: a b c");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a > b ? a : b;
max = c > max ? c : max;

Console.WriteLine($"Max = {max}");