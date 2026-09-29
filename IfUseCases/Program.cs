namespace IfUseCases;

class Program
{
    static void Main(string[] args)
    {
        int age = 20;
        string? firstname = "John";

        if (age >= 18)
        {
            Console.WriteLine("Ενήλικας");
        }
        else
        {
            Console.WriteLine("Ανήλικος");
        }
        
        // ternary

        var status = (age >= 18) ? "Ενήλικας" : "Ανήλικος";
        Console.WriteLine($"Status: {status}");
        
        // Null-coalescing operator for default value assignment
        var name = firstname ?? "Uknown"; // (fistname is null) ? "Uknown" : firstname;
        
        // Null-conditional operator for safe member access
        
        var nameLength = firstname?.Length ?? 0; // (firstname == null) ? 0 : firstname.Length;
        Console.WriteLine($"Name Length: {nameLength}");
    }
}