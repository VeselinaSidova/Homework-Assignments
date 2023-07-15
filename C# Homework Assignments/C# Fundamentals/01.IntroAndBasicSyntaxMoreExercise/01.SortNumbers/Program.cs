namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallest = int.MinValue;
            int middle = int.MinValue;
            int largest = int.MinValue;

            for (
                int i = 0; i < 3; i++)
            {
                int n = int.Parse(Console.ReadLine());


                if (n > largest)
                {
                    smallest = middle;
                    middle = largest;
                    largest = n;
                }

                else if (n <= largest && n > middle)
                {
                    smallest = middle;
                    middle = n;
                }

                else if (n <= middle)
                {
                    smallest = n;
                }

            }

            Console.WriteLine(largest);
            Console.WriteLine(middle);
            Console.WriteLine(smallest);

        }
    }
}