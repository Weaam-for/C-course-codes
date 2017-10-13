using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace type_of_data_charstingboolean
{
    class Program
    {
        static void Main(string[] args)
        {
            int CharMin = Char.MinValue;
            int CharMax = Char.MaxValue;

            Char myVar = 'G';
            // TO know what is the variable number (alskicode)
            int myVarValue = 'G';
            // TO Know is the number (71) it is reserve to character (G)(note you can changeConvert.ToChar(myVarValue)and put inside the brackets numbers like (71 or 75 etc
            Char myVarValue2 = Convert.ToChar(myVarValue);
            Console.WriteLine(" Min ={0} Max = {1}  my character = {2} my variable number = {3} my conversion value is {4}", CharMin, CharMax, myVar, myVarValue, myVarValue2);
            // to identify variable string type
            String myString = "this is my variable";
            Console.WriteLine("\n my string is {0}", myString);
            // to identify variable boolean type
            bool myBool = false;
            Console.WriteLine("my boolean value is{0}", myBool);

            Console.ReadKey();
        }
    }
}
