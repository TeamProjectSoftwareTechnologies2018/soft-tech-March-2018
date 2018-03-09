using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());
            double enContent = (volume * energy * 1.0) / 100;
            double sugContent = (volume * sugar * 1.0) / 100;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{enContent}kcal, {sugContent}g sugars");
        }
    }
}
