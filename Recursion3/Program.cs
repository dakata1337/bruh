using System;
using System.Text;

namespace Recursion3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cyrillization
            Console.OutputEncoding = Encoding.Unicode;

            // Display msg
            Console.Write("Въведете число: ");

            // Read & parse the string to int
            int num = int.Parse(Console.ReadLine());

            // Display msg
            Console.WriteLine(Reverse(num));

            // Wait for key press to exit
            Console.ReadKey();
        }

        public static int Reverse(int number, int result = 0, int reminder = 0)
        {
            // If the number is 0 return the answer
            if (number == 0)
                return result * 10 + reminder;

            // Else call Reverse 
            return Reverse(number / 10, result * 10 + reminder, number % 10);
        }
    }
}
