using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Array: ");
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).ToArray();

            Console.Write("Looking for: ");
            int lookingFor = int.Parse(Console.ReadLine());

            int foundIndex = FindIndex(array, lookingFor);
            if (foundIndex == -1)
                Console.WriteLine("The number can't be found");
            else
                Console.WriteLine($"The index of \"{lookingFor}\" is {foundIndex}");


            Console.ReadLine();
        }

        private static int FindIndex(int[] array, int lookingFor)
        {
            int foundIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == lookingFor)
                {
                    foundIndex = i;
                    break;
                }
            }
          
            return foundIndex;
        }
    }
}
