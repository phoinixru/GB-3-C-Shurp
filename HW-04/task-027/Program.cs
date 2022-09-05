// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Enter number:");
string? input = Console.ReadLine();
bool isNumber = int.TryParse(input, out int n);

if (!isNumber)
{
    Console.WriteLine("Nice try.");
    return;
}

int sum = SumOfDigits(n);
Console.WriteLine($"Sum of {n} digits is {sum}");


int SumOfDigits(int n) {
    int result = 0;
    int abs = Math.Abs(n);
    do {
        result += abs%10;
        abs /= 10;
    } while(abs != 0);

    return result;
}