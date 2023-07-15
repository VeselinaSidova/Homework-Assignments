using System.Runtime.InteropServices;

namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int number = int.Parse(input);
            int factorial = 1;
            int sumFactorial = 0;


            for (int i = 0; i < input.Length; i++)
            {
                int n = int.Parse(input[i].ToString());

                for (int j = 1; j <= n; j++)
                {
                    factorial *= j;
                }

                sumFactorial += factorial;
                factorial = 1;
            }

            if (number == sumFactorial)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}