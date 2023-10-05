namespace _09._KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int bestCount = 0;
            int bestIndex = 0;
            int bestSample = 1;
            int bestCurrentSample = 0;
            int[] bestDNA = new int[n];


            while (input != "Clone them!")
            {
                int[] numbers = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                bestCurrentSample++;
                int bestCurrentCount = 0;
                int bestCurrentSum = 0;
                int bestCurrentIndex = 0;

                for (int i = 0; i < n; i++)
                {
                    int currentCount = 1;

                    if (numbers[i] == 0)
                    {
                        continue;
                    }

                    for (int index = i + 1; index < n; index++)
                    {
                        if (numbers[index] == 1)
                        {
                            currentCount++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (currentCount > bestCurrentCount)
                    {
                        bestCurrentCount = currentCount;
                        bestCurrentIndex = i;
                        bestCurrentSum = numbers.Sum();
                    }
                }

                if ((bestCurrentCount > bestCount) || 
                    (bestCurrentCount == bestCount && bestIndex > bestCurrentIndex) ||
                    (bestDNA.Sum() < bestCurrentSum))

                {
                    bestIndex = bestCurrentIndex;
                    bestCount = bestCurrentCount;
                    bestDNA = numbers.ToArray();
                    bestSample = bestCurrentSample;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestDNA.Sum()}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}