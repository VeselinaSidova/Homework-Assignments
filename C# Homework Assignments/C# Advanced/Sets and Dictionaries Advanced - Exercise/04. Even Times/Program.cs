using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> numbers = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (numbers.ContainsKey(input))
                {
                    numbers[input]++;
                }
                else
                {
                    numbers[input] = 1;
                }
            }
            foreach (var item in numbers)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
