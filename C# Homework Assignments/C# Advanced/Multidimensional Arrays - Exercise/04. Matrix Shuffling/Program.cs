using System;
using System.Linq;

namespace _04._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = dimentions[0];
            int m = dimentions[1];
            string[,] matrix = new string[n, m];

            for (int row = 0; row < n; row++)
            {
                string[] elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] task = command.Split();
                if (task[0] != "swap" || task.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int coord1 = int.Parse(task[1]);
                    int coord2 = int.Parse(task[2]);
                    int coord3 = int.Parse(task[3]);
                    int coord4 = int.Parse(task[4]);

                    if (coord1 <= n && coord2 <= m && coord3 <= n && coord4 <= m)
                    {
                        string value1 = matrix[coord1, coord2];
                        string value2 = matrix[coord3, coord4];
                        matrix[coord1, coord2] = value2;
                        matrix[coord3, coord4] = value1;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write($"{matrix[row, col]}" + " ");
                            }

                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
