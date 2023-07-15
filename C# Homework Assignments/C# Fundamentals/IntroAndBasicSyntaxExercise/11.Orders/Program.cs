namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double pricePerCapsule = 0;
            int days = 0;
            int capsulesCount = 0;

            double orderPrice = 0;
            double total = 0;

            for (int i = 1; i <= n; i++)
            {
                pricePerCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsulesCount = int.Parse(Console.ReadLine());

                orderPrice = days * capsulesCount * pricePerCapsule;
                total += orderPrice;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
            }

            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}