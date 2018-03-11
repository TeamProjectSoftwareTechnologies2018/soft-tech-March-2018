using System;
// Confirmed by  Gergana Mileva (allsi89)
namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Receive and read a floating point number from the console
            double miles = double.Parse(Console.ReadLine());
            // Convert miles to kilometers with the formula down below
            double km = miles * 1.60934;
            // Print the result -> a number to the second digit after the floating point
            Console.WriteLine($"{km:f2}");
        }
    }
}
