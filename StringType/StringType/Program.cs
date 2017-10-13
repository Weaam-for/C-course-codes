using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringType
{
    class Program
    {
        static void Main(string[] args)
        { 
// there are sign called escape sequences you can used this for correct the sting text
// \'\" \\ \0 \a\b \n \r \t \v \f
// \0 put at the end of text
// \a appear voice when debugging from computer
// \b bacespace and delete the letter from onr word
// \n put in new line
// \n\n put after two line
// \r called carrage return and it delele the string(text) before it and print the text after it
//@ put when we have wrong with path

// to identify string variable is reference type not value type. string accept null value this means no value here
            string myString = "I told mohammed to do his homework";
            string myString2 = " ,Mohammed said He cann't complete his homework\a";
            // in case you want to put the two string in one line you can do it by identify third variable
            string myString3 = myString + myString2;
            Console.WriteLine("{0}",myString3);

          // Console.WriteLine("{0} {1}", myString,myString2);
            Console.ReadKey();
 
        }
    }
}
