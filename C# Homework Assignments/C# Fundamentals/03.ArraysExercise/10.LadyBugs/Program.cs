namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] ladybugsLocations = Console.ReadLine().Split().Select(int.Parse).ToArray();

         
            int[] field = new int[n];

            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < ladybugsLocations.Length; j++)
                {
                    if (ladybugsLocations[j] < n && ladybugsLocations[j] >= 0)
                    {
                        field[ladybugsLocations[j]] = 1;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArr = command.Split().ToArray();

                int index = int.Parse(commandArr[0]);
                string direction = commandArr[1];
                int movement = int.Parse(commandArr[2]);


                if (field.Length > 0 && index < field.Length && index >= 0 && field[index] == 1 && movement != 0)
                {

                    field[index] = 0;

                    if (direction == "right")
                    {
                        if (index + movement < field.Length - 1 && index + movement >= 0)
                        {
                            if (field[index + movement] == 0)
                            {
                                field[index + movement] = 1;
                            }
                            else if (field[index + movement] == 1)
                            {
                                if (index + movement + movement < field.Length - 1 && index + movement + movement >= 0)
                                {
                                    field[index + movement + movement] = 1;
                                }
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        if (index - movement >= 0 && index - movement < field.Length - 1)
                        {
                            if (field[index - movement] == 0)
                            {
                                field[index - movement] = 1;
                            }
                            else if (field[index - movement] == 1)
                            {
                                if (index - movement - movement >= 0 && index - movement - movement < field.Length - 1)
                                {
                                    field[index - movement - movement] = 1;
                                }
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}