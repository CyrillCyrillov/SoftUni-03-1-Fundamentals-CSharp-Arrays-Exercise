using System;
using System.Linq;

namespace Task05_Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            

            for (int i = 0; i < numbers.Length; i++)
            {
                bool integerNumber = true;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if(numbers[i] <= numbers[j])
                    {
                        integerNumber = false;
                        break;
                    }
                }
                
                if(integerNumber)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}
