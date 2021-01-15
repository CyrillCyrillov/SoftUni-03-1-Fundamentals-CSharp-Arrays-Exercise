using System;
using System.Linq;

namespace Task04_Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberRotation = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberRotation; i++)
            {
                int helpVar = arr[0];
                for (int j = 1; j < arr.Length; j++)
                {
                    int helpVar2 = arr[j];
                    arr[j-1] = helpVar2;
                }
                arr[arr.Length-1] = helpVar;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
