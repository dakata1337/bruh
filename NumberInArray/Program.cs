using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace NumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers: ");
            string input = Console.ReadLine();
            int[] array = Array.ConvertAll(input.Split(' '), int.Parse).ToArray();

            Console.WriteLine();

            Console.Write("Look for: ");
            bool found = false;
            int search = int.Parse(Console.ReadLine());
            foreach (var num in array)
            {
                if (num == search)
                {
                    found = true;
                    break;
                }
            }

            if(found)
                Console.WriteLine($"{search} Exists in the Array");
            else
                Console.WriteLine($"{search} Not exists in the Array");

            Console.ReadLine();
        }
    }
}
