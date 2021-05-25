using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottlesArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> cups = new Queue<int>(cupsArr);
            Stack<int> bottles = new Stack<int>(bottlesArr);

            int totalWastedWater = 0;
       
            bool isFilled = false;

            while (cups.Any() && bottles.Any())
            {
                int currentCup = cups.Peek();
                int currentBottle = bottles.Pop();
                currentBottle -= currentCup;

                if (currentBottle >= 0)
                {
                    cups.Dequeue();
                    totalWastedWater += currentBottle;
                }

                
                
            }
        }
    }
}
