namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetTrashCount = 0;
            int mouseTrashCount = 0;
            int keyboardTrashCount = 0;
            int displayTrashCount = 0;
            bool shouldTrashDisplay = false;


            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetTrashCount++;
                }
                if (i % 3 == 0)
                {
                    mouseTrashCount++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardTrashCount++;

                    if (keyboardTrashCount % 2 == 0)
                    {
                        shouldTrashDisplay = true;
                    }
                }

                if (shouldTrashDisplay == true)
                {
                    displayTrashCount++;
                    shouldTrashDisplay = false;
                }
            }

            double headsetExpenses = headsetTrashCount * headsetPrice;
            double mouseExpenses = mouseTrashCount * mousePrice;
            double keyboardExpenses = keyboardTrashCount * keyboardPrice;
            double displayExpenses = displayTrashCount * displayPrice;

            double rageExpenses = headsetExpenses + mouseExpenses + keyboardExpenses + displayExpenses;

            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}