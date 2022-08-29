// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter a number:");
string? input = Console.ReadLine();
bool isNumber = int.TryParse(input, out int n);

if (!isNumber)
{
    Console.WriteLine("Come on! This is not a number!");
    return;
}

string abs = $"{Math.Abs(n)}";

if (!IsMoreThanTwoDigitNumber(abs))
{
    Console.WriteLine("There is no third digit, sorry");
    return;
}

char thirdDigit = abs[2];
Console.WriteLine($"The third digit is {thirdDigit}");

bool IsMoreThanTwoDigitNumber(string abs)
{
    bool isNumber = int.TryParse(abs, out int number);
    bool isMoreThanTwoDigit = number > 99;

    return isNumber && isMoreThanTwoDigit;
}