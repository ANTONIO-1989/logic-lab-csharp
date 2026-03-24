using System;
using System.Collections.Generic;

namespace TechLogisticsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Smart Load Balancer Utility ---");

            Console.Write("Set Maximum Capacity (kg): ");
            double maxCapacity = Convert.ToDouble(Console.ReadLine());

            double currentWeight = 0;
            int itemsCount = 0;

            while (currentWeight < maxCapacity)
            {
                Console.Write($"Current Weight: {currentWeight}kg. Add next item weight (or 0 to stop): ");
                double item = Convert.ToDouble(Console.ReadLine());

                if (item <= 0) break;

                if (currentWeight + item <= maxCapacity)
                {
                    currentWeight += item;
                    itemsCount++;
                    Console.WriteLine(">> Item added successfully.");
                }
                else
                {
                    Console.WriteLine(">> WARNING: Item too heavy for remaining capacity!");
                }
            }

            Console.WriteLine("\n--- Final Report ---");
            Console.WriteLine($"Total items loaded: {itemsCount}");
            Console.WriteLine($"Total weight: {currentWeight}kg");
            Console.WriteLine($"Remaining space: {maxCapacity - currentWeight}kg");
            Console.WriteLine("------------------------------");
        }
    }
}
