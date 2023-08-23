namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] items = values.Split();
            double[] numbers = new double[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                numbers[i] = double.Parse(items[i]);
            }

            // int[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();  Using LINQ

            int[] roundedNumbers = new int[numbers.Length];


            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNumbers[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {roundedNumbers[i]}");
            }
        }
    }
}