using System.Numerics;

namespace ProductWhileApp;
/// <summary>
///  Υπολογίζει το 1*2*3*4...*n με BigInteger.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        const int LIMIT = 100;
        BigInteger result = 1;
        int i = 1;

        while (i <= LIMIT)
        {
            result *= i;
            i++;
        }

        Console.WriteLine($"Το αποτέλεσμα είναι: {result:N0}");
    }
}