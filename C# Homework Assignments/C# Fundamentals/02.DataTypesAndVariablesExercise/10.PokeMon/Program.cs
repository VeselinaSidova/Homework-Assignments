namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // poke power
            int m = int.Parse(Console.ReadLine()); // distance between targets
            int y = int.Parse(Console.ReadLine()); // exhaustion factor 

            int pokedTargets = 0;
            int originalPokePower = n;

            while (m <= n)
            {
                if (n == 0)
                {
                    break;
                }

                n -= m;
                pokedTargets++;

                if (originalPokePower / 2 == n && y != 0)
                {
                    n = n / y;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(pokedTargets);
        }
    }
}