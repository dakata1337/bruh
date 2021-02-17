using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(4));
            Console.ReadKey();
        }

        public static int Factorial(int n)
        {
            if (n == 1)
                return 1;

            int result = 1;
            for (int i = n; i > 0; i--)
                result *= i;

            return result;
        }
    }
}
