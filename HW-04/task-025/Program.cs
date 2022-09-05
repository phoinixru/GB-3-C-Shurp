// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Enter number A:");
string? inputA = Console.ReadLine();
bool isANumber = int.TryParse(inputA, out int a);

Console.WriteLine("Enter number B:");
string? inputB = Console.ReadLine();
bool isBNumber = int.TryParse(inputB, out int b);

if (!isANumber || !isBNumber)
{
    Console.WriteLine("Nice try.");
    return;
}

int pow = Pow(a, b);
Console.WriteLine($"A ** B = {pow}");

int Pow(int a, int b) {
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    return result;
}