using System.Linq;

namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            string result = string.Empty;

            foreach (var element in arr2)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (element == arr1[i])
                    {
                        result += element + " "; 
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}