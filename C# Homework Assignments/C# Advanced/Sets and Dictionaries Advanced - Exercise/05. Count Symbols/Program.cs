using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (symbols.ContainsKey(input[i]))
                {
                    symbols[input[i]]++;
                }
                else
                {
                    symbols[input[i]] = 1;
                }
            }
            foreach (var symbol in symbols)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
