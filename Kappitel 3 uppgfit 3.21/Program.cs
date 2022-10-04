using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en addition");
            string[] addition = Console.ReadLine().Split('+');

            int[] tal = Array.ConvertAll(addition, int.Parse);

            int summan = tal.Sum();

            Console.WriteLine($"Summan blir då {summan}.");
        }
    }
}

