namespace _05.LongestIncreasingSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] len = new int[numbers.Length];
            int[] prev = new int[numbers.Length];

            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i] && len[j] + 1 > len[i])
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }
                }

                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
            }

            int[] result = new int[maxLength];
            int index = maxLength - 1;

            while (lastIndex != -1)
            {
                result[index] = numbers[lastIndex];
                lastIndex = prev[lastIndex];
                index--;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
