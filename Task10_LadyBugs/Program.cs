using System;
using System.Linq;

namespace Task10_LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int filedSize = int.Parse(Console.ReadLine());
            int[] field = new int[filedSize];
            int[] indexBegin = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < indexBegin.Length; i++)
            {
                if(indexBegin[i] >= 0 && indexBegin[i] <= filedSize - 1)
                {
                    field[indexBegin[i]] = 1;
                }
            }

            while(true)
            {
                string[] comand = Console.ReadLine().Split().ToArray();
                if(comand[0] == "end")
                    {
                        break;
                    }

                int start = int.Parse(comand[0]);
                int fly = int.Parse(comand[2]);

                
                    if (comand[1] == "right" && fly > 0 && start >= 0 && start <= filedSize - 1) // в полето е
                    {
                        if (field[start] == 1) // има калинка
                        {
                            field[start] = 0;
                            if (start + fly <= filedSize - 1) // каца в полето
                            {
                                while (true)
                                {
                                    if (start + fly <= filedSize - 1) // излиза от полето
                                    {
                                        break;
                                    }
                                    if (field[start + fly] != 1) // при кацане няма калинка
                                    {
                                        field[start + fly] = 1; // каца
                                        break;
                                    }
                                    fly *= 2;// ново кацане
                                }
                            }
                        }
                    }
            }

            Console.WriteLine($"{string.Join(" ", field)}");
        }
    }
}
