 namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte capacity = 255;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                short liters = short.Parse(Console.ReadLine());

                if (capacity < liters)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    capacity -= (byte)liters;
                }
            }

            Console.WriteLine(255 - capacity);
        }
    }
}