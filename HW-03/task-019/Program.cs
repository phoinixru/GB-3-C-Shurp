// Задача 19
// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Enter 5-digit number:");
string? input = Console.ReadLine();
bool isNumber = int.TryParse(input, out int n);

if (!isNumber)
{
    ShowMessage("Nice try.");
    return;
}

if (!IsNumberFiveDigit(n))
{
    ShowMessage("5-digit only");
    return;
}

if (n < 0)
{
    ShowMessage("Be more positive!");
    return;
}

if (IsNumberPalindrome(n))
{
    ShowMessage($"Yep, {n} is palindrome");
}
else
{
    ShowMessage("Nope, {n} is not palindrome");
}

// Methods
// Show error in console
void ShowMessage(string msg)
{
    Console.WriteLine(msg);
}

//
bool IsNumberFiveDigit(int n)
{
    return Math.Floor(Math.Log10(n)) + 1 == 5;
}

// Check palindromity
bool IsNumberPalindrome(int n)
{
    int len = (int)Math.Floor(Math.Log10(n)) + 1;
    int[] digits = new int[len];

    for (int i = 0; i < len; i++)
    {
        digits[len - i - 1] = n % 10;
        n /= 10;
    }

    for (int i = 0; i < len / 2; i++)
    {
        if (digits[i] != digits[len - i - 1])
        {
            return false;
        }
    }
    return true;
}

// // Print array
// void PrintArray(int[] arr)
// {
//     string str = string.Empty;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         str += $"{arr[i]} ";
//     }
//     ShowMessage(str);
// }