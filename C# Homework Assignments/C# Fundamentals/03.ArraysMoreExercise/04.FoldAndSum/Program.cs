namespace _04.FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] row1 = new int[input.Length / 2];
            int[] row2 = new int[input.Length / 2];
            int[] sum = new int[input.Length / 2];

            for (int i = 0; i < row1.Length / 2; i++)
            {
                row1[i] = input[row1.Length / 2 - i - 1];
                row1[(row1.Length / 2) + i] = input[input.Length - 1 - i];
            }

            for (int i = 0; i < row2.Length; i++)
            {
                row2[i] = input[i + row1.Length / 2];
            }

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = row1[i] + row2[i];
            }

            Console.WriteLine(string.Join(' ', sum));
        }
    }
}
