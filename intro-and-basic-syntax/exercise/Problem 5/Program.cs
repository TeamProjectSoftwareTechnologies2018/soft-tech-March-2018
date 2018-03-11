using System;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"Health: |"+new string('|', health)+ new string('.', maxHealth - health)+"|");
            Console.WriteLine($"Energy: |" + new string('|', energy) + new string('.', maxEnergy - energy) + "|");
        }
    }
}
