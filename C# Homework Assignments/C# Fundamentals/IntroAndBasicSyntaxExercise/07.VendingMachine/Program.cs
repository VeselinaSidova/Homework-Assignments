 namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sum = 0;

            while (input != "Start")
            {
                double coin = double.Parse(input);

                if (coin != 0.1 &&
                    coin != 0.2 &&
                    coin != 0.5 &&
                    coin != 1 &&
                    coin != 2)
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                else
                {
                    sum += coin;
                }

                input = Console.ReadLine();
            }

            if (input == "Start")
            {
                input = Console.ReadLine();

                while (input != "End")
                {
                    switch (input)
                    {
                        case "Nuts":
                            if (sum - 2 >= 0)
                            {
                                Console.WriteLine("Purchased nuts");
                                sum -= 2;
                            }
                            else if (sum - 2 < 0)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Water":
                            if (sum - 0.7 >= 0)
                            {
                                Console.WriteLine("Purchased water");
                                sum -= 0.7;
                            }
                            else if (sum - 0.7 < 0)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Crisps":
                            if (sum - 1.5 >= 0)
                            {
                                Console.WriteLine("Purchased crisps");
                                sum -= 1.5;
                            }
                            else if (sum - 1.5 < 0)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Soda":
                            if (sum - 0.8 >= 0)
                            {
                                Console.WriteLine("Purchased soda");
                                sum -= 0.8;
                            }
                            else if (sum - 0.8 < 0)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Coke":
                            if (sum - 1 >= 0)
                            {
                                Console.WriteLine("Purchased coke");
                                sum -= 1;
                            }
                            else if (sum - 1 < 0)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid product");
                            break;
                    }
                    input = Console.ReadLine();
                }

                if (input == "End")
                {
                    Console.WriteLine($"Change: {sum:F2}");
                }
            }
        }
    }
}