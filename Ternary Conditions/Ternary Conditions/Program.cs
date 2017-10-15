using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = 10;
            // this step decribe the ternary conditions which seems like if statement and here we find two types of variable interger for variable and string for printing because in question must write string 
            string result = (var < 10) ? "less then 10" : "greater than 10";
            Console.WriteLine("result {0}", result);

            string name = "mina", Result;
            Result = (name.Equals("mina")) ? "yes" : "no";
            Console.WriteLine("Result is {0}", Result );

            Console.ReadKey();
        }
    }
}
