namespace SwitchApp;

class Program
{
    static void Main(string[] args)
    {
        string? dayOfWeek = "Monday";

        switch (dayOfWeek)
        {
            case "Monday":
                Console.WriteLine("Today is Monday");
                break;
            case "Tuesday":
                Console.WriteLine("Today is Tuesday");
                break;
            case "Wednesday":
                Console.WriteLine("Today is Wednesday");
                break;
            case "Thursday":
                Console.WriteLine("Today is Thursday");
                break;
            default: Console.WriteLine("Unknown day");
                break;
        }

        int day = 2;
        var dayName = day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            _ => "Invalid day"
        };
        
        // Switch Expression with Pattern Matching
        int grade = 85;

        var letterGrade = grade switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };
    }
}