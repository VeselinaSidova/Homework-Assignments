namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool areEqual = false;

            for (int currIndex = 0; currIndex < numbers.Length; currIndex++)
            {
                int leftSum = 0;

                for (int i = currIndex - 1; i >= 0; i--)
                {
                    leftSum += numbers[i];
                }

                int rightSum = 0;

                for (int i = currIndex + 1; i < numbers.Length; i++)
                {
                    rightSum += numbers[i];
                }

                if (rightSum == leftSum)
                {
                    areEqual = true;
                    Console.WriteLine(currIndex);
                    break;
                }
            }

            if (!areEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}