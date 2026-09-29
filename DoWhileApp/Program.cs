using System.Globalization;

namespace DoWhileApp;
/// <summary>
/// Counts the number of digits.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        int num = 0;
        int numberOfDigits = 0;
        int tmp = 0;

        Console.WriteLine("Παρακαλώ εισάγετε έναν ακέραιο: ");
        if (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Μη έγκυρη είσαδος. Παρακαλώ εισάγετε έναν ακέραιο αριθμό");
            return;
        }

        tmp = num;

        do
        {
            tmp /= 10;
            numberOfDigits++;
        } while (tmp != 0);

        Console.WriteLine($"Ο αριθμός {num} έχει {numberOfDigits} ψηφία.");
    }
}