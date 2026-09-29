namespace CitiesForApp;
/// <summary>
/// For Control Structure.
/// Demonstration purposes only.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        string[] cities = { "Athens", "Thessaloniki", "Patras", "Heraklion", "Larissa" };

        for (int i = 0; i < cities.Length; i++)
        {
            if (cities[i] == "Patras")
            {
                Console.WriteLine($"Found {cities[i]} at inedex {i}");
                break;  // Exit the loop when "Patras" is found
            }
        }

        foreach (string city in cities)
        {
            if (city == "Heraklion")
            {
                Console.WriteLine($"Found {city} in the list.");
                break;  // Exit the loop when "Heraklion" is found.
            }
        }
    }
}