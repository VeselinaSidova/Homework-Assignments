using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int[] ordersArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(ordersArr);

            Console.WriteLine(ordersArr.Max());

            while (orders.Any())
            {
                int currentOrder = orders.Peek();

                if (food < currentOrder)
                {
                    break;
                }
                orders.Dequeue();
                food -= currentOrder;
            }

            if (orders.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");

            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
