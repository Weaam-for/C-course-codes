using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increments_decrements_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is step describe the increments of variable so when you put th2 (++) infront of variable, the variable will increase and become 3. while after the variable will not increase
            int myVar = 1;
            int temp1 = ++myVar;
            // in step of put the(++) after the variable
            int myVar1 = 5;
            int temp2 = myVar1++;
            // this is step describe the decrements of variable
            int myVar2 = 4;
            int temp3 = --myVar2;
            // expression 
            int Var1 = 7;
            int Var2 = 2;
            int temp4 = Var1-- / ++Var2;

      
            Console.WriteLine(" \n {0} \n {1} \n {2} \n {3}"  , temp1, temp2,temp3,temp4);
            Console.ReadKey();
        }
    }
}
