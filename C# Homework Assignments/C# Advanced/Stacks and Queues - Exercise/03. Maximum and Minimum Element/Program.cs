using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                string[] command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "1":
                        numbers.Push(int.Parse(command[1]));
                        break;
                    case "2":
                        if (numbers.Count > 0)
                        {
                            numbers.Pop();
                        }
                        break;
                    case "3":
                        if (numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.Max());
                        }
                        break;
                    case "4":
                        if (numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.Min());
                        }
                        break;
                }
            }
            if (numbers.Count > 0)
            {
                numbers.Reverse();
                Console.WriteLine(string.Join(", ", numbers));
            }
        }
    }
}
