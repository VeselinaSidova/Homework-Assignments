namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalSabrePrice = sabrePrice * (students + Math.Ceiling(students * 0.1));
            
            double totalRobePrice = robePrice * students;
            
            int freeBelts = students / 6;
            double totalBeltPrice = beltPrice * (students - freeBelts);

            double totalPrice = totalSabrePrice + totalRobePrice + totalBeltPrice;

            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else if (money < totalPrice)
            {
                Console.WriteLine($"John will need {(totalPrice - money):F2}lv more.");
            }

        }
    }
}