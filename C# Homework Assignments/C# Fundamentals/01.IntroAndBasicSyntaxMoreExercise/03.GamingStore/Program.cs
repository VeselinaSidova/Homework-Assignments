namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();

            double price = 0;
            double totalBought = 0;
            bool notFound = false;

            while (game != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        notFound = true;
                        break;
                }


                if (balance - price == 0)
                {
                    balance -= price;
                    totalBought += price;
                    Console.WriteLine($"Bought {game}");
                    Console.WriteLine("Out of money!");
                    break;
                }
                else if (balance - price < 0)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (balance - price > 0 && notFound == false)
                {
                    balance -= price;
                    totalBought += price;
                    Console.WriteLine($"Bought {game}");
                }

                game = Console.ReadLine();
            }

            if (balance > 0)
            {
                Console.WriteLine($"Total spent: ${totalBought:F2}. Remaining: ${balance:F2}");
            }
        }
    }
}