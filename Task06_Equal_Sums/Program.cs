using System;
using System.Linq;

namespace Task06_Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool yesEqualIndex = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                for (int k = i+1; k < numbers.Length; k++)
                {
                    rightSum += numbers[k];
                }

                if(leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    yesEqualIndex = true;
                }
            }
            if(yesEqualIndex == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
