namespace _03.FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());


            if (Math.Abs(a - b) < 0.000001M)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}