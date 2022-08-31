using System;

namespace Nilakanthapi
{
    class Program
    {
        static void Main(string[] args)
        {
            string iterations = "1";
            int interationi = 1;
            pi pi;
            while (interationi != 0)
            {
                Console.Write("\tEnter Number of Iterations to run:");
                iterations = Console.ReadLine();
                if (int.TryParse(iterations, out interationi))
                {
                    pi = new pi(interationi);
                    Console.Write(pi.CalcPi().ToString());
                }
            }
        }
    }  

}