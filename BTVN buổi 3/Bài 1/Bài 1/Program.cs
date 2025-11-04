using System;
using System.Collections.Generic;

namespace Bai_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            if (Check(s))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        static bool Check(string s)
        {
            Stack<char> stack1 = new Stack<char>();

            foreach (char i in s)
            {
                if (i == '(' || i == '[' || i == '{')
                {
                    stack1.Push(i);
                }
                else if (i == ')' || i == ']' || i == '}')
                {
                    if (stack1.Count == 0) return false;

                    char top = stack1.Pop();
                    if (!IsMatching(top, i)) return false;
                }
            }

            return stack1.Count == 0;
        }

        static bool IsMatching(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '[' && close == ']') ||
                   (open == '{' && close == '}');
        }
    }
}
