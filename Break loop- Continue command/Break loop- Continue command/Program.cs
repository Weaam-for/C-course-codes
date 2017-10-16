using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_loop__Continue_command
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++ )
            {
                Console.WriteLine("hi");
                if (i > 2)
                    continue;
                for ( int j = 0; j<=4; j++)
                {
                    Console.WriteLine(" hello");
                   
                }
               // Console.WriteLine("hi");
            }
            Console.ReadKey();
        
        }
    }
}
