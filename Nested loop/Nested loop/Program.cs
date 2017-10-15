using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" hi");
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("\t hellow");
                }
                Console.WriteLine("\n");
            }
            //Q/ creat multiplication table from 1-5 for all numbers <= 10
            int x =5, multi = 0;
            for (int n = 1; n <= x; n++) 
            {
               
                for (int m = 1; m <= 10; m++)
                {
                    multi = n * m;
                    Console.WriteLine("{0}* {1} = {2}", n ,m, multi );
                   
                }
                  Console.WriteLine("\n");
            }
            //Q/ creat multiplication table from 1-5 for even numbers <= 10 
            int R = 6, evenno = 0;
            for (int c = 2; c <= R; c+=2 )
            {
                for (int s= 2; s<=10; s+=2)
                {
                    evenno = c * s;
                    Console.WriteLine("{0} *{1} ={2}", c,s,evenno);

                }
            }
            Console.WriteLine("\n");
            // Q/ creat multiplication table from 1-6 for odd numbers <= 10 

            int a = 6, oddno = 0;
           for ( int b = 1; b <= a; b += 2)
            {
                for (int p = 1; p <= 10; p += 2 )
                {
                    oddno = b * p ;
                    Console.WriteLine( "{0} *{1} = {2}", b,p,oddno);
                }
                
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
