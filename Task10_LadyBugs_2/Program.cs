using System;
using System.Linq;

namespace Task10_LadyBugs_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int filedSize = int.Parse(Console.ReadLine());                      // set the size
            int[] field = new int[filedSize];                                   // set the empty field
            
            int[] indexBegin = Console.ReadLine()                               // vvvvv
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)              // read the begin position of ladybugs
                .Select(int.Parse).ToArray();                                   // ^^^^^
            
            int direction = 0;
            
            for (int i = 0; i < indexBegin.Length; i++)                         // vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
            {                                                                   //
                if (indexBegin[i] >= 0 && indexBegin[i] <= filedSize - 1)       //    
                {                                                               // set the ladybugs on field
                    field[indexBegin[i]] = 1;                                   //
                }                                                               //
            }                                                                   // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            while(true)                                                         // endless loop
            {

                string[] comand = Console.ReadLine().Split().ToArray();         // the 3 parts of every comand
                
                if (comand[0] == "end")                                         // vvvvvvvvv
                {                                                               //        
                    break;                                                      //  "end" - exit of the loop
                }                                                               // 
                                                                                // ^^^^^^^^^
                
                int start = int.Parse(comand[0]);                               // vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
                int fly = int.Parse(comand[2]);                                 //
                switch (comand[1])                                              //  split the comand
                {                                                               //
                    case "left":                                                //
                        direction = -1;                                         //  left => direction -1   
                        break;                                                  //   
                    case "right":                                               //   right => direction +1 
                        direction = 1;                                          //
                        break;                                                  //
                }                                                               // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

                if (start < 0 || start > filedSize - 1)
                {
                    continue;                                                  // incorect comand => no fly, new comand, 
                }
                
                if (field[start] == 0)                                          // vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
                    {
                            continue;                                           // no ladybug in this position => no fly, new comand
                    }                                                           // vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
               
                else                                                            // LETS FLY
                    {
                        field[start] = 0;
                        bool noLanding = true;
                        
                        while(noLanding)                                         //  vvvvvv looking for place to land vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
                            {
                                int land = LandField(start, fly, direction);     // where must be landing

                                if (land < 0 || land > filedSize - 1) break;     // landing outside of the field, no change in field => new comand

                                if (field[land] == 0)                            // free for landing
                                    {
                                        field[land] = 1;                         // LANDING =>
                                        noLanding = false;                       // => new comand
                                    }
                                else
                                    {
                                        fly *= 2;                                // new longer fly
                                    }
                            }                                                    // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                    }
            }
            
            
            Console.WriteLine($"{string.Join(" ", field)}");                    // final state of field
        }

        private static int LandField(int start, int fly, int direction)         // where must be landing
        {
            int land = start + (direction * fly);
            return land;
        }
    }
}
