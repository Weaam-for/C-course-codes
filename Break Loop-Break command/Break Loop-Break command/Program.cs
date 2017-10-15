using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Loop_Break_command
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("hi");
                // this below step show how can stop the processing loop when it reach conditions and after it break to finish the program
                if (i > 2)
                    break;
                for (int j = 0; j <=4; j++)
                {
                    Console.WriteLine("\t hello");
                }
                Console.WriteLine("\n");
            }
            // Q/ Create multiplication table for number in the range 1-10 and stop the loop in the multiplication table for number 7 from 1-10
            int x = 10, multi = 0;
            for ( int n = 0; n <= x; n++)
            {
                
                for ( int m = 0; m <= 10 ; m++)
                {
                    multi = n * m;
                    if (n > 6)
                        break;

                    Console.WriteLine(" {0} * {1} = {2}", n, m, multi);
                }
               
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
