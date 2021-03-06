﻿//CONFIRMED from maleksieva
using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console info for name of product:
            string productName = Console.ReadLine();

            // Console info for volume of product:
            int volumeOfProduct = int.Parse(Console.ReadLine());

            //Console info for energy of product:
            int energy= int.Parse(Console.ReadLine());

            //Console info for sugar content of product:
            int sugar = int.Parse(Console.ReadLine());

            //Calculation of energy and sugar content for given volume:
            double energyContent = (volumeOfProduct * energy * 1.0) / 100;
            double sugarContent = (volumeOfProduct * sugar * 1.0) / 100;

            //Print:
            Console.WriteLine($"{volumeOfProduct}ml {productName}:");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");
        }
    }
}
