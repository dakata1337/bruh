using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers: ");
            string input = Console.ReadLine();
            List<int> list = Array.ConvertAll(input.Split(' '), int.Parse).ToList();

            int sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }

            float average = sum / list.Count;
            Console.WriteLine($"Sum={sum}; Average={average}");
            Console.ReadLine();
        }
    }
}
