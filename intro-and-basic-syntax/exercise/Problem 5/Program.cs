using System;
//Confirmed by allsi89
namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
			//We introduce characterName from console
            string characterName = Console.ReadLine();
			//We introduce health from console
            int health = int.Parse(Console.ReadLine());
			//We introduce maxHealth from console
            int maxHealth = int.Parse(Console.ReadLine());
			//We introduce energy from console
            int energy = int.Parse(Console.ReadLine());
			//We introduce maxEnergy from console
            int maxEnergy = int.Parse(Console.ReadLine());

			//We print characterName
            Console.WriteLine($"Name: {characterName}");
			//We print health
            Console.WriteLine($"Health: |"+new string('|', health)+ new string('.', maxHealth - health)+"|");
			//We print energy
            Console.WriteLine($"Energy: |" + new string('|', energy) + new string('.', maxEnergy - energy) + "|");
        }
    }
}
