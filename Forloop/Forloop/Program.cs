using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int salary = 1000, total = 0;
            for (int i = 0; i < 12; i++)
            {
                total += salary;
                Console.WriteLine("salary for 12 months {0}", total);
            }
            
            Console.ReadKey();
        }
    }
}
