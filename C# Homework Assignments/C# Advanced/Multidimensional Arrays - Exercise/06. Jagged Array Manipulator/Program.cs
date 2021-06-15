using System;
using System.Linq;

namespace _06._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jagged = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                jagged[i] = Console.ReadLine().Split().Select(double.Parse).ToArray();
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] = jagged[row][col] * 2;
                        jagged[row + 1][col] = jagged[row + 1][col] * 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] = jagged[row][col] / 2;  
                    }
                    if (jagged[row + 1].Length < jagged[row].Length || jagged[row + 1].Length > jagged[row].Length)
                    {
                        for (int i = 0; i <= jagged[row + 1].Length - 1; i++)
                        {
                            jagged[row + 1][i] = jagged[row + 1][i] / 2;
                        }
                    }
                }
            }
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split();
                if (tokens.Length == 4)
                {
                    int row = int.Parse(tokens[1]);
                    int col = int.Parse(tokens[2]);
                    int value = int.Parse(tokens[3]);

                    if (row >= 0 && row < rows && col >= 0 && col < jagged[row].Length)
                    {
                        if (tokens[0] == "Add")
                        {
                            jagged[row][col] += value;
                        }
                        else if (tokens[0] == "Subtract")
                        {
                            jagged[row][col] -= value;
                        }
                    } 
                }
                command = Console.ReadLine();
            }
            foreach (double[] row in jagged)
            {
                Console.WriteLine(string.Join(' ', row));
            }
        }
    }
}
