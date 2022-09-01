// Задача 21
// Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] a = RequestPointCoordinates("A");
int[] b = RequestPointCoordinates("B");

double distance = CalculateDistance(a, b);
Console.WriteLine($"Distance betwee A and B: {distance}");


int[] RequestPointCoordinates(string name)
{
    int[] point = new int[3];
    string[] axis = { "x", "y", "z" };

    for (int i = 0; i < 3; i++)
    {
        int n;
        bool isNumber;
        do
        {
            Console.WriteLine($"Enter {name}{axis[i]}");
            isNumber = int.TryParse(Console.ReadLine(), out n);

        } while (!isNumber);
        point[i] = n;
    }

    return point;
}

double CalculateDistance(int[] a, int[] b)
{
    double sum = 0;
    for (int i = 0; i < a.Length; i++)
    {
        sum += Math.Pow(b[i] - a[i], 2);
    }
    return Math.Sqrt(sum);
}