namespace _01.EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] encrypted = new int[n];

            for (int i = 0; i < n; i++)
            {
                string currentWord = Console.ReadLine();

                for (int j = 0; j < currentWord.Length; j++)
                {
                    if (currentWord[j] == 'a' ||
                        currentWord[j] == 'o' ||
                        currentWord[j] == 'e' ||
                        currentWord[j] == 'i' ||
                        currentWord[j] == 'u' ||
                        currentWord[j] == 'A' ||
                        currentWord[j] == 'O' ||
                        currentWord[j] == 'E' ||
                        currentWord[j] == 'I' ||
                        currentWord[j] == 'U')
                    {
                        encrypted[i] += currentWord[j] * currentWord.Length;
                    }
                    else
                    {
                        encrypted[i] += currentWord[j] / currentWord.Length;
                    }
                }
            }

            Array.Sort(encrypted);

            Console.WriteLine(String.Join("\n", encrypted));
        }
    }
}
