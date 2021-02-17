using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaZa3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> vs = new Queue<string>();
            vs.Enqueue("math");
            vs.Enqueue("bulgarian");
            vs.Enqueue("music");
            vs.Enqueue("english");
            vs.Enqueue("it");

            Console.WriteLine("Original queue:");
            Display(vs);


            vs = new Queue<string>(vs.Where(x => x != "music"));
            Console.WriteLine("New Queue:");
            Display(vs);


            Console.Read();
        }

        static void Display(Queue<string> vs)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in vs)
            {
                builder.Append(item + " ");
            }
            Console.WriteLine(builder);
        }
    }
}
