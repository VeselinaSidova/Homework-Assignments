namespace _01.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                int number;
                float floatingPoint;
                char character;
                bool isBoolean;

                if (int.TryParse(input, out number))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out floatingPoint))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out character))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out isBoolean))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
        }
    }
}