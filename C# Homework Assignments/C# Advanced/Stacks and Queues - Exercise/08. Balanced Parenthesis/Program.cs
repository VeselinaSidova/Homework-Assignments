using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> openParantheses = new Stack<char>();
            bool isBalanced = true;

            foreach (var c in input)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    openParantheses.Push(c);
                }
                else
                {
                    if (!openParantheses.Any())
                    {
                        isBalanced = false;
                        break;
                    }
                    else
                    {
                        char currentSymbol = openParantheses.Pop();
                        bool isRoundBalanced = currentSymbol == '(' && c == ')';
                        bool isSqueareBalanced = currentSymbol == '[' && c == ']';
                        bool isCurlyBalanced = currentSymbol == '{' && c == '}';

                        if (isRoundBalanced == false && isCurlyBalanced == false && isSqueareBalanced == false)
                         {
                            isBalanced = false;
                            break;
                        }
                    } 
                }
            }
            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");   
            }
        }
    }
}
