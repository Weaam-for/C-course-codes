using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If_Statement2
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = 4, var2 = 6;
            if (var <= 3 && var2 >=5)
            {
                Console.WriteLine("condition one right");
            }
            else if (var <= 4 && var2 >= 6)
            {
                Console.WriteLine("conditions two right");
            }
            else if (var2 > 5)
            {
                Console.WriteLine("conditions three right");
            }
            else
            {
                Console.WriteLine("no one of the condition");
            }
            Console.ReadKey();

        }
    }
}
