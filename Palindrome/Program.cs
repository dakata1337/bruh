using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool isPalindrome = true;

            foreach (var letter in word)
            {
                stack.Push(letter);
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != stack.Pop())
                    isPalindrome = false;
            }
            Console.WriteLine(isPalindrome ? "The word is palindrome!" : "The word is NOT a palindrome!");
            Console.ReadLine();
        }
    }
}
