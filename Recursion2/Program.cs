using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display msg
            Console.Write("Въведете число за степенуване: ");

            // Read & parse the string to ulong
            double x = double.Parse(Console.ReadLine());

            // Display msg
            Console.Write("Въведете цяло число за степенен показател: ");

            // Read & parse the string to int
            int y = int.Parse(Console.ReadLine());

            // Display msg
            Console.WriteLine(" на степен " + y + " е = " + xZ(x, y));
        }
        static double xZ(double x, int Z) 
        { 
            if (Z < 0) 
            { 
                x = 1 / x; 
                Z = -Z; 
            } 

            if (N == 0) 
                return 1; 
            
            return x * xZ(x, Z - 1); 
        }
    }
}
