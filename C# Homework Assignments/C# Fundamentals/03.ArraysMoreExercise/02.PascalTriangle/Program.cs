﻿using System.Runtime.ExceptionServices;

namespace _02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] pascal = new string[n];

            pascal[0] = "1";

            for (int i = 1; i < n; i++)
            {
                int[] row = new int[i + 1];
                row[0] = 1;
                row[i] = 1;

                if (row.Length > 2)
                {
                    int[] previousRow = pascal[i - 1].Split(' ').Select(int.Parse).ToArray();

                    for (int j = 1; j < previousRow.Length; j++)
                    {
                        row[j] = previousRow[j - 1] + previousRow[j];
                    }
                }

                pascal[i] = string.Join(' ', row);
            }

            Console.WriteLine(string.Join('\n', pascal));
        }
    }
}
