namespace _03.RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //using Memoization
            int[] fibMemoization = new int[n + 1];
            Array.Fill(fibMemoization, - 1); 

            Console.WriteLine(GetFibonacci(n, fibMemoization));
            //Console.WriteLine(GetFibonacci(n));
        }

        private static int GetFibonacci(int n, int[] fibMemoization)
        {
            if (n <= 1)
            {
                return n;
            }

            //Checking if the value is already calculated
            if (fibMemoization[n] != -1)
            {
                return fibMemoization[n];
            }

            //int result = GetFibonacci(n - 1) + GetFibonacci(n - 2);
            //return result;

            //Assigning value in the fibMemoization array
            fibMemoization[n] = GetFibonacci(n - 1, fibMemoization) + GetFibonacci(n - 2, fibMemoization);
            return fibMemoization[n];
        }
    }
}
