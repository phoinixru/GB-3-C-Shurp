// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter three-digit number:");
string? input = Console.ReadLine();

if (!IsThreeDigitNumber(input))
{
    Console.WriteLine("Nope, please enter three-digit number. Buy.");
    return;
}

char secondDigit = input[input.Length - 2];
Console.WriteLine($"The second digit is {secondDigit}");

bool IsThreeDigitNumber(string input)
{
    bool isNumber = int.TryParse(input, out int number);
    int abs = Math.Abs(number);
    bool isThreeDigit = abs > 99 && abs < 999;

    return isNumber && isThreeDigit;
}