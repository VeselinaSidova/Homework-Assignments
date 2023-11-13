using System.Collections;

namespace _01.EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] encrypted = new int[n];

            for (int i = 0; i < encrypted.Length; i++)
            {
                string word = Console.ReadLine();
                int sum = 0;

                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == 'A' ||
                        word[j] == 'a' ||
                        word[j] == 'O' ||
                        word[j] == 'o' ||
                        word[j] == 'E' ||
                        word[j] == 'e' ||
                        word[j] == 'I' ||
                        word[j] == 'i' ||
                        word[j] == 'U' ||
                        word[j] == 'u')
                    {
                        sum += word[j] * word.Length;
                    }
                    else
                    {
                        sum += word[j] / word.Length;
                    }
                }
                encrypted[i] = sum;
            }

            Array.Sort(encrypted);

            Console.WriteLine(String.Join("\n", encrypted));
        }
    }
}