using System;

namespace Comp5202_Problem2_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int j,n;
            
            Console.Write("n\n\");
            Console.Write("===========================================");
            Console.Write("Display division tables of 1 to 12");
            Console.Write("===========================================");
            Console.Write("\n\n");

            int counter = 12;

            Console.Write("Please enter a number(to be calcualted):");
            n=Convert.ToIn32(Console.ReadLine());
            
            for(j=1;j<12;j++)
            {
            Console.Write("{0}/{1}={2}\n",n,j,n/j);
            Console.ReadLine();
            
            }

        }
    }
}
