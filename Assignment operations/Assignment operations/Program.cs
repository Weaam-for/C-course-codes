using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //We have assignment operations like = , += ,-= , *= ,/= , %=
        
            int myVar1 = 3, myVar2 = 4;
            // in this step the variable will take the value of myVar2 this means myVar1 and myVar2 = 4 and vise versa
            myVar1 = myVar2;
            // this step about +=
            int Var1 = 2, Var2 = 4;
            Var1 += Var2; // this means Var1 = Var1 + Var2;
            // for substractions
            int var3 = 3, var4 = 4;
            var3 -= var4; // this means var3 = var3 -var2;
            // for % 
            int Var5 = 6, Var6 = 2;
            Var5 %= Var6; // Var5 = Var5 % Var6;
            // for *=
            int var7 = 6, var8 = 7;
            var7 *= var8; // this means var7 = var7 *var8
            // for =/
            int var9 = 8, var10 = 4;
            var9 /= var10;// this means var9= var9/var10
            // for challenge experation
            int temp, var11 = 7, var12 = 2;
            var11 /= ++var12;

            // {0} this means index or position of variable and it always start from {0} and so on. 
            Console.WriteLine( " \n{0} \n{1} \n{2} \n{3} \n{4} \n{5} \n {6} \n {7} \n {8} \n {9}", myVar1, myVar2,Var1,Var2,var3,var4, Var5, var7, var9,var11);
            Console.ReadKey();
      
        }
    }
}
