namespace _06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string fullInput = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                fullInput += input;
            }

            bool isBalanced = false;
            bool openingPresent = false;
            int openingCounter = 0;
            int closingCounter = 0;
            
            for (int i = 0; i < fullInput.Length; i++)
            {
                if (fullInput[i] == '(')
                {
                    openingPresent = true;
                    openingCounter++;
                }

                if (fullInput[i] == ')')
                {
                    closingCounter++;
                }

                if (openingPresent && fullInput[i] == ')' && openingCounter == 1 && closingCounter == 1)
                {
                    isBalanced = true;
                    openingCounter = 0;
                    closingCounter = 0;
                }

                if (closingCounter > 0 || openingCounter > 0)
                {
                    isBalanced = false;
                }
            }

            string result = isBalanced ? "BALANCED" : "UNBALANCED"; 
            Console.WriteLine(result);
        }
    }
}