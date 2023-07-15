namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clicks = int.Parse(Console.ReadLine());

            string message = string.Empty;

            for (int i = 0; i < clicks; i++)
            {
                string digit = Console.ReadLine();

                if (int.Parse(digit) == 0)
                {
                    message += " ";
                    continue;
                }

                int numberOfDigits = digit.Length;
                int mainDigit = int.Parse(digit[0].ToString());
                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset = ((mainDigit - 2) * 3) + 1;
                }

                int letterIndex = offset + numberOfDigits - 1;

                char letter = (char)(letterIndex + 97);

                message += letter; 
            }

            Console.WriteLine(message);
        }
    }
}