namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int produce = 0;
            int daysPassed = 0;
            const int dailyConsumption = 26;
            const int dailyYeildExaust = 10;
            const int minimumYeildRequired = 100;

                

            while (startingYield >= minimumYeildRequired)
            {
                produce += startingYield;
                daysPassed++;

                if (produce < dailyConsumption)
                {
                    produce = 0;
                }
                else if (produce >= dailyConsumption)
                {
                    produce -= dailyConsumption;
                }

                startingYield -= dailyYeildExaust;
            }


            if (startingYield <= minimumYeildRequired)
            {
                if (produce < dailyConsumption)
                {
                    produce = 0;
                }
                else if (produce >= dailyConsumption)
                {
                    produce -= dailyConsumption;
                }
            }

            Console.WriteLine(daysPassed);
            Console.WriteLine(produce);
        }
    }
}