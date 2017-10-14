using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 10;

            if (myVar == 10)
            {
                myVar = 11;
                Console.WriteLine(" {0}", myVar);

                Console.WriteLine("my variable equal 10");
            }
            else
                Console.WriteLine("my variable not equal 10");

            int myVar1 = 9, myVar2 = 7;
            if ((myVar1<= 7) || (myVar2 >= 8))
            {
                Console.WriteLine("the conditions is ture");
            }
            else
            {
                Console.WriteLine("my condition is false");
            }
            int var = 8;
            string myresult;

            if ( var < 10)
            {
                myresult="less than 1o";
                Console.WriteLine( myresult);
            }
            if (var ==10)
            {
                myresult = "Equal 10";
                Console.WriteLine(myresult);
            }
            if (var>10)
            {
                myresult = "grather than 10";
                Console.WriteLine(myresult);
                 
            }

            int var4 = 8;
            if (var4 > 8)
            
                Console.WriteLine( "my variable is greater than 10");
            else
                Console.WriteLine("my variable value is less than10");

            int var5 = 10, var6 = 5, var7 = 9;
            string Result;

            if ((var6 == 5) && (var7 >= 8) || (var5 <= 11))
            {
                Result = "True";
                Console.WriteLine(Result);
            }
            else
                Result = "fluse";
            Console.WriteLine(Result);


            

            Console.ReadKey();
        }
    }
}
