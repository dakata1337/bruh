using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "1 + (3 + 2 - (2+3) * 4 - ((3+1)*(4-2)))"; //Declare string variable

            Stack<int> stack = new Stack<int>(); //Declare stack
            bool correctBrackets = true; //Declare bool

            for (int index = 0; index < expression.Length; index++) //For loop
            {
                char ch = expression[index]; //Current char
                if (ch == '(') //Char Check
                {
                    stack.Push(index); //If the char matches '(' add it to the stack
                }

                else if (ch == ')') //If the char matches ')' removes it from the stack
                {
                    if (stack.Count == 0) //If the stack is empty
                    {
                        correctBrackets = false; //The amount of brackets isn't correct
                        break; //Break out of the for loop
                    }
                    stack.Pop(); //Remove form stack
                }
            }

            if (stack.Count != 0) //If the stack count isn't 0
            {
                correctBrackets = false; //The amount of brackets isn't correct
            }

            //Displays message in the console
            Console.WriteLine($"Are the brackets correct? {correctBrackets}");
            Console.ReadLine();
        }
    }
}
