using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            //Read string from the console & parse it to Int32
            int n = Int32.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            //Read string from the console & parse it to Int32
            int k = Int32.Parse(Console.ReadLine());

            //Declare int array with lenght of 'K'
            int[] arr = new int[k];

            Console.ReadKey();
        }

        /// <summary>
        /// Gets all possible combinations
        /// </summary>
        static void GetCombinations(int[] arr, int index, int start, int end)
        {
            //If Index is larger or equal to Array lenght
            if (index >= arr.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arr.Length; i++)
                {
                    //If I is smaller than Array lenth - 1
                    if (i < arr.Length - 1)
                        Console.Write($"{arr[i]} ");
                    else
                        Console.Write(arr[i]);
                }
                Console.Write("), ");
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    //Change array value
                    arr[index] = i;
                    //Call GetCombinations();
                    GetCombinations(arr, index + 1, i, end);
                }
            }
        }


    }
}
