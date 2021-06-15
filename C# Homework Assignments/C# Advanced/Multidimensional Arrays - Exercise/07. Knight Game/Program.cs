using System;
using System.Linq;

namespace _07._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] chessBoard = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] elements = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    chessBoard[row, col] = elements[col];
                }
            }
            int counterRemovedKnights = 0;

            while (true)
            {
                int maxAttachedKnights = 0;
                int maxAttachedKnightsRow = -1;
                int maxAttachedKnightsCol = -1;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char symbol = chessBoard[row, col];

                        if (symbol == 'K')
                        {
                            int currentAttachedKnights = GetAttachedKnightsCount(chessBoard, row, col);

                            if (currentAttachedKnights > maxAttachedKnights)
                            {
                                maxAttachedKnights = currentAttachedKnights;
                                maxAttachedKnightsRow = row;
                                maxAttachedKnightsCol = col;

                            }
                        }
                    }
                }
                if (maxAttachedKnights == 0)
                {
                    break;
                }
                //validate
                chessBoard[maxAttachedKnightsRow, maxAttachedKnightsCol] = '0';
                counterRemovedKnights++;
            }
            Console.WriteLine(counterRemovedKnights);
        }
        static int GetAttachedKnightsCount (char[,] chessBoard, int row, int col)
        {
            int counter = 0;
            int n = chessBoard.GetLength(0);

            if (row - 2 >= 0 && col -1 >= 0 && chessBoard[row-2, col-1] == 'K')
            {
                counter++;
            }
            if (row - 2 >= 0 && col + 1 < n && chessBoard[row - 2, col + 1] == 'K')
            {
                counter++;
            }
            if (row - 1 >= 0 && col - 2 >= 0 && chessBoard[row - 1, col - 2] == 'K')
            {
                counter++;
            }
            if (row - 1 >= 0 && col + 2 < n && chessBoard[row - 1, col + 2] == 'K')
            {
                counter++;
            }
            if (row + 1 < n && col - 2 >= 0 && chessBoard[row + 1, col - 2] == 'K')
            {
                counter++;
            }
            if (row + 1 < n && col + 2 < n && chessBoard[row + 1, col + 2] == 'K')
            {
                counter++;
            }
            if (row + 2 < n && col - 1 >= 0 && chessBoard[row + 2, col - 1] == 'K')
            {
                counter++;
            }
            if (row + 2 < n && col + 1 < n && chessBoard[row + 2, col + 1] == 'K')
            {
                counter++;
            }
            return counter;
        }
    } 
}
