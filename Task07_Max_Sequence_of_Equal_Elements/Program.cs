using System;
using System.Linq;

namespace Task07_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startIndex = 0;
            int counter = 0;
            int maxCounter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                counter = 1;
                int curentNumber = numbers[i];
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if(curentNumber == numbers[j])
                    {
                        counter += 1;
                    }
                    else
                    {
                        break;
                    }
                }
                if(counter > maxCounter)
                {
                    maxCounter = counter;
                    startIndex = i;
                }

            }

            for (int i = 1; i <= maxCounter; i++)
            {
                Console.Write($"{numbers[startIndex]} ");
            }
            
        }
    }
}
