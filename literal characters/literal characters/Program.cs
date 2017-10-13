using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace literal_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            //define the integer32 variable doesn't require to put f,d,m like with float,double and decimal and this types of variables can accept negtive and postive value(numbers)
            int myVar = 100;
            // YOU can define uinteger32 but just accept positive value and you can put U after thre value (1000U) or not
            uint myUVar = 1000;
            // identify longinteger64 accepT negtive and postive value as well as you can put after the value L (1000L) OR (1000UL)OR (1000LU) WHATHER it is capital letter or small or without put anything
            ulong myLVar = 1000L;
            // but with float variable you must put the letter after the value like( 1.5F)
            float myFlVar = 1.5F;
            // double no problem with the compiler but is the best to put d after the number 
            double myDVar = 100.5;
            // decimal you must to put the letter M  after the value so no fail with the compiler wherther small or capital letter
            decimal myDecVar = 100.5m;
            Console.WriteLine("{0} {1} ", myVar,myUVar, myLVar,myFlVar, myDVar,myDecVar);
            // microsoft find new way to print instad of used the step before we don't need to assgin {0} and others
            Console.WriteLine($"{myDecVar},{myDVar},{myFlVar},{myLVar},{myUVar},{myVar}");
            Console.ReadKey();
            
        }
    }
}
