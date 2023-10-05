namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (current + numbers[j] == n && numbers.Length > 1)
                    {
                        Console.WriteLine(current + " " + numbers[j]);
                    }
                }
            }
        }
    }
}