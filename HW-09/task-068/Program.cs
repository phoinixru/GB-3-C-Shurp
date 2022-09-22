/* Задача 68: 
Напишите программу вычисления функции Аккермана с помощью 
рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29 */

var Log = (string text) => Console.WriteLine(text);

int m = 3;
int n = 5;

int akkerman = Akkerman(m, n);

Log($"A({m},{n}) = {akkerman}");

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }

    if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    return 0;
}