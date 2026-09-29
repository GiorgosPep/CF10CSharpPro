namespace PyramidChallenge;
/// <summary>
/// Ο χρήστης εισάγει το ύψος της πυραμίδας και το πρόγραμμα εμφανίζει την πυραμίδα με αστεράκια.
/// Για παράδειγμα αν ο χρήστης εισάγει 5 η έξοδος θα είναι:
///     *
///    ***
///   *****
///  *******
/// *********
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        int height = 0;
        int numberOfSpaces = 0;
        
        Console.WriteLine("Εισάγετε το ύψος της πυραμίδας");
        if (!int.TryParse(Console.ReadLine(), out height) ||  height <= 0)
        {
            Console.WriteLine("Μη έγκυρος αριθμός");
        }
        numberOfSpaces = height -1;
        
        for (int i = 0; i < height - 1; i++)
        {
            for (int j = 1; j < height - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}