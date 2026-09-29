using System.Numerics;

namespace PowerAPp;
/// <summary>
/// Gets base and power and calculates the result.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        const int BASE = 2;
        const int POWER = 10;
        BigInteger result = 1;

        for (int i = 1; i <= POWER; i++)
        {
         result *= BASE;   
        }

        Console.WriteLine($"Restult: {result}");
    }
}