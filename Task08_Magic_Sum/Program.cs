using System;
using System.Linq;

namespace Task08_Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int fixSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if(i != j)
                    {
                        if(numbers[i] + numbers[j] == fixSum)
                        {
                            Console.Write($"{numbers[i]} {numbers[j]}");
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
