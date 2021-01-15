using System;
using System.Linq;

namespace Task09_Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine()); // the size of every DNA

            int bestSample = 0;
            int bestSum = 0;
            int bestStartIndex = -1;
            int longestOnes = 0;
            int nextSample = 0;
            int[] bestDnaCombination = new int[dnaLenght];

            //int startIndex = 0; /// DELETE 

            while (true) // endless loop
            {
                string nextComand = Console.ReadLine(); // next comant

                if(nextComand.ToUpper() == "CLONE THEM!") // vvvvvv
                {                                         //
                    break;                                // EXIT of the loop
                }                                         //^^^^^^^^

                nextSample += 1;

                int[] nextDna = nextComand                                              // vvvvvvvvvvv
                                .Split('!', StringSplitOptions.RemoveEmptyEntries)      // turn the comand to nex DNA Array
                                .Select(int.Parse)                                      //
                                .ToArray();                                             //^^^^^^^^^^^^^^^

                int nextDnaSum = 0;
                int nextDnaCount = 0;
                int nextDnaStartIndex = -1;
                int nextDnaLongestOnes = 0;
                int tempIndex = -1;

                for (int i = 0; i <= dnaLenght - 1; i++)
                {
                    if(nextDna[i] == 1)
                    {
                        nextDnaSum += 1;
                        nextDnaCount += 1;
                        if(nextDnaCount == 1)
                        {
                            tempIndex = i;
                        }

                    }
                    else
                    {
                        if(nextDnaCount > nextDnaLongestOnes)
                        {
                            nextDnaLongestOnes = nextDnaCount;
                            nextDnaStartIndex = tempIndex;
                            nextDnaCount = 0;
                            tempIndex = -1;
                        }
                    }
                    }

                if (nextDnaCount > nextDnaLongestOnes)
                {
                    nextDnaLongestOnes = nextDnaCount;
                    nextDnaStartIndex = tempIndex;
                    nextDnaCount = 0;
                    tempIndex = -1;
                }

            if(nextDnaLongestOnes > longestOnes)
                {
                    bestSample = nextSample;
                    bestSum = nextDnaSum;
                    bestStartIndex = nextDnaStartIndex;
                    longestOnes = nextDnaLongestOnes;
                    bestDnaCombination = nextDna;
                }
            else if(nextDnaLongestOnes == longestOnes)
                {
                    if(nextDnaStartIndex < bestStartIndex)
                    {
                        bestSample = nextSample;
                        bestSum = nextDnaSum;
                        bestStartIndex = nextDnaStartIndex;
                        longestOnes = nextDnaLongestOnes;
                        bestDnaCombination = nextDna;
                    }
                    else if(nextDnaStartIndex == bestStartIndex)
                    {
                        if(nextDnaSum > bestSum)
                        {
                            bestSample = nextSample;
                            bestSum = nextDnaSum;
                            bestStartIndex = nextDnaStartIndex;
                            longestOnes = nextDnaLongestOnes;
                            bestDnaCombination = nextDna;
                        }

                    }


                }
            }

            
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine(string.Join(' ', bestDnaCombination));
        }
    }
}
