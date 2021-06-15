using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = dimentions[0];
            int m = dimentions[1];
            char[,] matrix = new char[n, m];
            string snake = Console.ReadLine();
            Queue<char> snakeQ = new Queue<char>();
            int counter = 0;
            int capacity = n * m;

            for (int i = 0; i < snake.Length; i++)
            {
                snakeQ.Enqueue(snake[i]);
                counter++;

                if (counter == capacity)
                {
                    break;
                }
                if (i == snake.Length - 1)
                {
                    i = -1;
                }
            }

            for (int row = 0; row < n; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < m; col++)
                    {
                        matrix[row, col] = snakeQ.Dequeue();
                    }
                }
                else if (row % 2 != 0)
                {
                    for (int col = m - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snakeQ.Dequeue();
                    }
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
