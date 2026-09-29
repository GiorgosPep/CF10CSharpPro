using System.Globalization;

namespace PrintingApp;

class Program
{
    static void Main(string[] args)
    {
        int num = 12_334_555;
        double dNum = 100.1230000456;

        CultureInfo.CurrentCulture = new CultureInfo("en-US");          //Set culture to en-US for consistent
        Console.WriteLine("Int-Num = {0, -10:N0}, Double-Num = {1, -20:N2}", num, dNum);    // placeholder syntax
        Console.WriteLine($"Int-Num = {num, -10:N0}, Double-num = {dNum, -20:N2}");         // interpolation syntax
        
    }
}