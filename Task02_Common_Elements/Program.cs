using System;
using System.Linq;

namespace Task02_Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split().ToArray();
            string[] arr2 = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = arr1.Length - 1; j >= 0; j--)
                {
                    if(arr1[j] == arr2[i])
                    {
                        Console.Write($"{arr1[j]} ");
                    }
                }
            }
        }
    }
}
