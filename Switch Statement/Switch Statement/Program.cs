using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = "Cat";

            switch (animal)
            {
              case  "canary":
                   Console.WriteLine("animal is canary brid");
                   break;
              case  "Cat":
                    Console.WriteLine("animal is a cat");
                    break;
              case "Camel":
                    Console.WriteLine("animal is a camel");
                    break;
                default:
                Console.WriteLine("non of them");
                break;
            }
            int VAR = 25;
            switch (VAR)
            {
               case 10:
                    Console.WriteLine("vlue is 10");
                    break;
               case 7:
                    Console.WriteLine("value is 7");
                    break;
               case 4:
                    Console.WriteLine("value is 4");
                    break;
               default:
                    Console.WriteLine( "no value");
                    break;

            }
            string whathesay = "Hello";
            switch (whathesay)
            {
               case "hello":
                    Console.WriteLine(" hello");
                    break;
                case "Bye":
                    Console.WriteLine("Bye");
                    break;
                case "welcome":
                    break;
                default:
                    Console.WriteLine("no one");
                    break;
            }
            Console.ReadKey();
        }
    }
}
