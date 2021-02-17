using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cyrillization
            Console.OutputEncoding = Encoding.Unicode;

            // Display msg
            Console.Write("Въведете число: ");

            string str = Console.ReadLine();

            // Read & parse the string to ulong array
            List<int> list = str.Split(' ').Select(int.Parse).ToList();

            // Display the result
            Console.WriteLine(Sum(list));

            // Wait for key press to exit
            Console.ReadKey();
        }

        public static int Sum(List<int> listOfInt)
        {
            if (listOfInt[0] % 10 != 7)
            {
                return Convert.ToInt32(listOfInt[0]) + Sum(listOfInt.Skip(1).ToList());
            }

            if (listOfInt.Count == 1)
                return Convert.ToInt32(listOfInt[0]);

            return Convert.ToInt32(listOfInt[0]) + Sum(listOfInt.Skip(1).ToList());
        }

    }
}
