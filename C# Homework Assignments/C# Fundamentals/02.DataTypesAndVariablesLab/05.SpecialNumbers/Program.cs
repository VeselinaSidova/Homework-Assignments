using System;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int num = i;

                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }

                bool isSpecial;

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                    Console.WriteLine($"{i} -> {isSpecial}");
                }
                else
                {
                    isSpecial = false;
                    Console.WriteLine($"{i} -> {isSpecial}");
                }
                sum = 0;
            }
        }
    }
}