using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cyrillization
            Console.OutputEncoding = Encoding.Unicode;

            // Display msg
            Console.Write("Въведете число за намиране сумата на цифрите му: ");

            // Read & parse the string to ulong
            ulong n = ulong.Parse(Console.ReadLine());

            // Display the result
            Console.WriteLine("Сумата от цифрите на числото " + n + " е = " + sumN(n));

            // Wait for key press to exit
            Console.ReadKey();
        }

        static ulong sumN(ulong x) 
        { 
            // If the number is smaller than 10 - return it
            if (x < 10) 
                return x; 

            // Sum all digits
            return x % 10 + sumN(x / 10); 
        }
    }
}
