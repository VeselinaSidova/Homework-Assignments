namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string largestKegName = string.Empty;
            double largestKegVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());


                if ((Math.PI * Math.Pow(radius, 2) * height) >= largestKegVolume)
                {
                    largestKegVolume = Math.PI * Math.Pow(radius, 2) * height;
                    largestKegName = model;
                }
            }

            Console.WriteLine(largestKegName);
        }
    }
}