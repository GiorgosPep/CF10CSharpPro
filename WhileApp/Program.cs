namespace WhileApp;

class Program
{
    static void Main(string[] args)
    {
        const int END = 3;
        int i = 1;
        int sum = 0;
        

        while (i <= END)
        {
            Console.WriteLine($"Attempts {i + 1}");
            sum += i;
            i++;
        }
    }
}