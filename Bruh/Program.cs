using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bruh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Count: ");
            int count = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();
            for (int i = 0; i < count; i++)
            {
                list.Add(Console.ReadLine());
            }
            Console.Write("list1 = ");
            PrintList(list);

            Console.Write("Count: ");
            count = int.Parse(Console.ReadLine());
            List<string> list2 = new List<string>();
            for (int i = 0; i < count; i++)
            {
                list2.Add(Console.ReadLine());
            }
            Console.Write("list2 = ");
            PrintList(list2);


            Console.WriteLine();


            List<string> unionList = new List<string>();
            unionList.AddRange(list);
            for (int i = unionList.Count - 1; i >= 0; i--)
            {
                if (list2.Contains(unionList[i]))
                    unionList.RemoveAt(i);
            }
            unionList.AddRange(list2);

            Console.Write("union = ");
            PrintList(unionList);

            List<string> intersectList = new List<string>();
            intersectList.AddRange(list);

            for (int i = intersectList.Count - 1; i >= 0; i--)
            {
                if (!list2.Contains(intersectList[i]))
                    intersectList.RemoveAt(i);
            }

            Console.Write("intersect = ");
            PrintList(intersectList);

            Console.Read();
        }

        public static void PrintList(List<string> list)
        {
            Console.Write("{ ");

            Console.Write(String.Join(" ", list));

            Console.WriteLine(" }");
        }
    }
}
