namespace ProductsVat;
/// <summary>
/// Reads a product price from the console,
/// calculates the VAT amount (24%) and the total price,
/// and prints the results formatted to 2 decimal places.
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        //Declare and initialize variables
        const double VAT = 0.24d;
        double price = 0.0;
        double priceAfterVAT = 0.0;
        
        // Data input, data binding and validation
        if (!double.TryParse(Console.ReadLine(), out price) || price <= 0)
        {
            Console.WriteLine("Η τιμή που εισάγατε δεν είναι έγκυρος αριθμός");
            return;
        }
        
        // Calculate total price
        priceAfterVAT = price + price * VAT;
        
        // Print results
        Console.WriteLine($"Product Price: {price}");
        Console.WriteLine($"Total Price: {priceAfterVAT}");
        
        
    }
}