// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter day of the week:");
string? input = Console.ReadLine();
bool isNumber = int.TryParse(input, out int n);

if (!isNumber)
{
    Console.WriteLine("We need a number!");
    return;
}

if (!IsWeekDay(n)) {
    Console.WriteLine("We need a day of the week!");
    return;
}

if (IsWeekend(n)) {
    Console.WriteLine("Yep, It's time for a party!");
} else {
    Console.WriteLine("Nope, still workweek");
}

bool IsWeekDay(int day)
{
    return day >= 1 && day <= 7;
}

bool IsWeekend(int weekday)
{
    if (weekday == 6 || weekday == 7)
    {
        return true;
    }
    return false;
}