using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];
            HashSet<string> set1 = new HashSet<string>();
            HashSet<string> set2 = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                set1.Add(Console.ReadLine());
            }
            for (int j = 0; j < m; j++)
            {
                set2.Add(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", set1.Intersect(set2)));
        }
    }
}
