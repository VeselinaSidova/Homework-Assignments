namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string correctPassword = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                correctPassword += username[i];
            }

            int badPasswordCounter = 0;

            string password = Console.ReadLine();

            while (password != correctPassword)
            {
                badPasswordCounter++;

                if (badPasswordCounter >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
            }

            if (password == correctPassword)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}