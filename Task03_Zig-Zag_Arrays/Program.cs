using System;
using System.Linq;

namespace Task03_Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] arr1 = new int[lines];
            int[] arr2 = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] next = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if(i % 2 != 0)
                    {
                        arr1[i] = next[0];
                        arr2[i] = next[1];
                    }
                else
                    {
                        arr1[i] = next[1];
                        arr2[i] = next[0];
                    }
            }

            for (int i = 0; i < lines; i++)
            {
                Console.Write($"{arr2[i]} ");
            }

            Console.WriteLine();
            
            for (int i = 0; i < lines; i++)
            {
                Console.Write($"{arr1[i]} ");
            }
        }
    }
}
