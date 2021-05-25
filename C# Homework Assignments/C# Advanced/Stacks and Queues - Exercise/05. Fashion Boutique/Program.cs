using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesValue = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> boxes = new Stack<int>(clothesValue);
            int racksCounter = 1;
            int currentRackCapacity = rackCapacity;

            while (boxes.Count > 0)
            {
                int currentClothes = boxes.Peek();
                
                if (currentRackCapacity >= currentClothes)
                {
                    currentRackCapacity -= currentClothes;
                    boxes.Pop();
                }
                else
                {
                    racksCounter++;
                    currentRackCapacity = rackCapacity;
                }
            }
            Console.WriteLine(racksCounter);
        }
    }
}
