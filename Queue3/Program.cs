using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] partitioned = Array.ConvertAll(input.Split(' '), int.Parse).ToArray();
            Console.Title = "Bruh";

            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < partitioned.Length; i++)
            {
                queue.Enqueue(partitioned[i]);
            }

            //Odd
            for (int i = 0; i < queue.Count; i++)
            {
                int current = queue.ElementAt(i);
                if (current % 2 != 0)
                {
                    Console.WriteLine(current);
                }
            }

            //Even
            for (int i = 0; i < queue.Count; i++)
            {
                int current = current = queue.ElementAt(i);
                if (current % 2 == 0)
                {
                    Console.WriteLine(current);
                }
            }

            Console.ReadLine();
        }
    }
}
