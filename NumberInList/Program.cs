using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers: ");
            string input = Console.ReadLine();
            List<int> list = Array.ConvertAll(input.Split(';'), int.Parse).ToList();

            Console.WriteLine();

            Console.Write("Look for: ");
            bool found = false;
            int search = int.Parse(Console.ReadLine());
            foreach (var num in list)
            {
                if (num == search)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine($"{search} Exists in the List");
            else
                Console.WriteLine($"{search} Not exists in the List");

            Console.ReadLine();
        }
    }
}
