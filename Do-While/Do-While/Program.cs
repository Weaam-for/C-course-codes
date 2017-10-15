using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 1000.20, total = 0.0;
            int i = 0;
            do
            {
                total += salary; //total = total + salary;
                i++;
                System.Console.WriteLine("i values equal {0}", i);
            } while (i < 10);
            System.Console.WriteLine("salarly value equal {0}", total);
            // Q: how many years do you need to reach 2000$ if your salary was 1020 and increment percentage was 20$ per month and print the result

            double mysalary = 1020; // b represent the month
            int b = 0;
            do
            {
                mysalary += 20;// mysalary = mysalary +20;
                b++;
            } while (mysalary < 2000);
            int year = b / 12;
            int month = b % 12;
            System.Console.WriteLine(" year {0} and month {1}", year, month );
            
            


        }
    }
}
