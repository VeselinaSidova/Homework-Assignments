using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            int sumFirst = 0;
            int sumSecond = 0;
            int counter = n - 1;

            for (int row = 0; row < n; row++)
            {
                sumFirst += matrix[row, row];
                sumSecond += matrix[row, counter--];
            }
            Console.WriteLine(Math.Abs(sumFirst - sumSecond));
        }
    }
}
