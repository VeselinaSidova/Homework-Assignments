namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool areIdentical = false;
            int sum = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i];

                if (arr1[i] == arr2[i])
                {
                    areIdentical = true;
                }
                else if (arr1[i] != arr2[i])
                {
                    areIdentical = false;
                }

                if (!areIdentical)
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }

            if (areIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}