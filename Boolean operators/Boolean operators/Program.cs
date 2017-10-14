using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool myResult;
            int myVar1 = 5, myVar2 = 8;
            // This assign == for comparison you must to write == not = while != means not equal
            // the other assign <,>, >=,<=
            myResult = myVar1 != 6;
            // boolean conitions &&,||
            myResult = (myVar1 >= 5) || (myVar2 == 7);// the result is false //& table truth for OR||
            Console.WriteLine("{0}", myResult);       //           F F  ---> F     F F --->F
            Console.ReadKey();                        //           F T  ---> F     F T --->T
        }                                             //           T F  ---> F     T F --->T
    }                                                 //           T T  ---> T     T T --->T
}
