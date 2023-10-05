namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bestCount = 0;
            int bestIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];
                int currentCount = 1;

                for (int index = i + 1; index < numbers.Length; index++)
                {
                    if (current == numbers[index])
                    {
                        currentCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    bestIndex = i;
                }
            }
            string result = string.Empty;

            for (int i = 0; i < bestCount; i++)
            {
                result += numbers[bestIndex] + " ";
            }

            Console.WriteLine(result);
        }
    }
}