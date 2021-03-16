using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargesAndMostUsedNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = input.Split().Select(int.Parse).ToList();

            int[] counts = new int[numbers.Max() + 1];
            foreach (var number in numbers)
                counts[number]++;

            int biggestNumber = 0;
            int biggestNumberCount = 0;
            for (int i = 0; i < counts.Length; i++)
            {
                int count = counts[i];
                if (count == 0)
                    continue;

                if (biggestNumber > i || biggestNumberCount > count)
                    continue;

                biggestNumber = i;
                biggestNumberCount = count;
            }

            Console.WriteLine($"{biggestNumber} was found {biggestNumberCount}");
            Console.ReadLine();
        }
    }
}
