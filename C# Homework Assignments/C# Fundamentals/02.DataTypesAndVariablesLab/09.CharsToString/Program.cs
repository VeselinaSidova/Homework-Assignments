namespace _09.CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string print = string.Empty;

            for (int i = 1; i <= 3; i++)
            {
                char input = char.Parse(Console.ReadLine());
                print += input;
            }

            Console.WriteLine(print);
        }
    }
}