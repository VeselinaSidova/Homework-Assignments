namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int index = int.Parse(Console.ReadLine());

            if (index >= 1 && index <= 7)
            {
                Console.WriteLine(daysOfWeek[index - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}