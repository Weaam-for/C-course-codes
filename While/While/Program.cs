using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            // you must identify double as formula below
            double salary = 1000.30, total = 0.0;
            int i = 0;
            while (i< 15)
            {
                total += salary;
                i++;
            }
            Console.WriteLine("salary {0}", total);

            //Console.ReadKey();
            // Q/ find how many exercieses do need  to reach 83 Kg if  your wieght was 120kg and each exercise will make you lose 1Kg and print the result?
            // double wieght = 120.0, 

            int wieght = 120, wieghtreguired = 83;
            int j = 0;
            while( wieght> 83 )
            {
                wieght--;
                j++;
            }
            Console.WriteLine(" excercise no. is {0}", j);
            Console.ReadKey();

               
                
        }
    }
}
