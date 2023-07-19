namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double poundsGBP = double.Parse(Console.ReadLine());

            double dollarsUSD = poundsGBP * 1.31;

            Console.WriteLine($"{dollarsUSD:F3}");
        }
    }
}