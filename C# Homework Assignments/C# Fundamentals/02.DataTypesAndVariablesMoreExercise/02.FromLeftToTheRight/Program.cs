using System.Numerics;

namespace _02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string firstNumberString = string.Empty;
            string secondNumberString = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == ' ')
                    {
                        for (int k = j + 1; k < input.Length; k++)
                        {
                            secondNumberString += input[k];
                        }
                        break;
                    }
                    firstNumberString  += input[j];
                }

                long firstNumber = long.Parse(firstNumberString);
                long secondNumber = long.Parse(secondNumberString);
                int sum = 0;
                string absoluteString = string.Empty;

                if (firstNumber >= secondNumber)
                {
                    absoluteString = Math.Abs(firstNumber).ToString();
                    for (int j = 0; j < absoluteString.Length; j++)
                    {
                        sum += int.Parse(absoluteString[j].ToString());
                    }
                    Console.WriteLine(sum);
                }
                else if (firstNumber < secondNumber)
                {
                    absoluteString = Math.Abs(secondNumber).ToString();
                    for (int j = 0; j < absoluteString.Length; j++)
                    {
                        sum += int.Parse(absoluteString[j].ToString());
                    }
                    Console.WriteLine(sum);
                }

                firstNumberString = string.Empty;
                secondNumberString = string.Empty;
                sum = 0;
            }

        }
    }
}