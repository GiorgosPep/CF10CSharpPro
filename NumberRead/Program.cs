namespace NumberRead;
/// <summary>
///  Safe reading float, double, from console input.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        float floatNum = 0f;
        double doubleNum = 0d;

        Console.WriteLine("Εισάγετε δύο δεκαδικούς");

        if (!float.TryParse(Console.ReadLine(), out floatNum))
        {
            Console.WriteLine("Η τιμή που εισάγατε δεν είναι έγκυρος δεκαδικός αριθμός.");
            return;
        }
        if (!double.TryParse(Console.ReadLine(), out doubleNum))
        {
            Console.WriteLine("Η τιμή που εισάγατε δεν είναι έγκυρος δεκαδικός αριθμός.");
            return;
        }

        Console.WriteLine($"Ο δεκαδικός αριθμός float είναι: {floatNum, -10:N2}");
        Console.WriteLine($"Ο δεκαδικός αριθμός double είναι: {doubleNum, -10:N2}");
    }
}