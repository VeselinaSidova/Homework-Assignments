namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string typeOfPeople = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double pricePerPerson = 0;

            switch (dayOfWeek)
            {
                case "Friday":
                    if (typeOfPeople == "Students")
                    {
                        pricePerPerson = 8.45;

                    }
                    else if (typeOfPeople == "Business")
                    {
                        pricePerPerson = 10.9;

                    }
                    else if (typeOfPeople == "Regular")
                    {
                        pricePerPerson = 15;

                    }
                    break;
                case "Saturday":
                    if (typeOfPeople == "Students")
                    {
                        pricePerPerson = 9.8;

                    }
                    else if (typeOfPeople == "Business")
                    {
                        pricePerPerson = 15.6;

                    }
                    else if (typeOfPeople == "Regular")
                    {
                        pricePerPerson = 20;

                    }
                    break;
                case "Sunday":
                    if (typeOfPeople == "Students")
                    {
                        pricePerPerson = 10.46;

                    }
                    else if (typeOfPeople == "Business")
                    {
                        pricePerPerson = 16;

                    }
                    else if (typeOfPeople == "Regular")
                    {
                        pricePerPerson = 22.5;

                    }
                    break;
            }

            double totalPrice = n * pricePerPerson;

            switch (typeOfPeople)
            {
                case "Students":
                    if (n >= 30)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }
                    break;
                case "Business":
                    if (n >= 100)
                    {
                        totalPrice = totalPrice - (10 * pricePerPerson);
                    }
                    break;
                case "Regular":
                    if (n >= 10 && n <= 20)
                    {
                        totalPrice -= totalPrice * 0.05;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}