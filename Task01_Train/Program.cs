using System;
using System.Linq;

namespace _Task01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfWagons = int.Parse(Console.ReadLine());
            int[] wagon = new int[numbersOfWagons];

            for (int i = 0; i <= numbersOfWagons - 1; i++)
            {
                wagon[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= numbersOfWagons - 1; i++)
            {
                Console.Write($"{wagon[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine(wagon.Sum());
        }
    }
}
