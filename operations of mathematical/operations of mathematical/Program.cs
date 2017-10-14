using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operations_of_mathematical
{
    class Program
    {
        static void Main(string[] args)
        {
            // these variables are oprand (10.5f and 10.7f)
            // float myVar = 10.5f;
            // float myVar2 = 10.7f;
            // this oprator(+) to add myVar to myVar2 and the expression is ( temp = myVar + myVar2;)
            //float temp = myVar + myVar2;
            int myvar1 = 15;
            int myVar2 = 10;
            int temp = myvar1 + myVar2;
            int temp2 = myvar1 - myVar2;
            int temp3 = myvar1 % myVar2;
            int temp4 = myvar1 * myVar2;
            int temp5 = myvar1 / myVar2;

            string myStr = " this is my bag";
            string myStr2 = "what this is?";
            myStr = myStr2 + myStr;


            //basic operators +, - , divide, *
            // bitwise operations (binary sytem
            //logical operation boolean ture, false

            //1- unary operand
            //2- Binary operands (most of states is binary system)
            //3- 3 operands (for conitional operator)
            Console.WriteLine("\n the result is {0} \nthe result2{1} the remaing is {2} \n the result4 {3} \n the result5 divide is {4}", temp, temp2, temp3, temp4, temp5);
            Console.WriteLine($"{temp},{temp2},{temp3},{temp4},{temp5}");
            Console.WriteLine("{0}", myStr);
            Console.ReadKey();




        }
    }
}

        
    


        
    

