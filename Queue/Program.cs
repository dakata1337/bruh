using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Bruh";

            int n = 3;
            int search = 16;

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);

            int index = 0;
            Console.Write("S = ");
            while (queue.Count > 0)
            {
                index++;
                int current = queue.Dequeue();
                Console.Write(current + " ");

                if (current == search)
                {
                    Console.WriteLine();
                    Console.WriteLine("Index = " + index);
                    break;
                }
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current);
            }

            Console.ReadLine();
        }
    }
}
