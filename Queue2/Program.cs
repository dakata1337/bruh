using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);

            int index = 0;
            Console.Write("N = 2 --> ");
            while (index < 50)
            {
                index++;
                int current = queue.Dequeue();
                Console.Write(current + " ");
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);
            }

            Console.ReadLine();
        }
    }
}
