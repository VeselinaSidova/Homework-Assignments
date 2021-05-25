using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> pumps = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
                pumps.Enqueue(Console.ReadLine());
            }

            int fuel = 0;
            int index = 0;
            int length = pumps.Count;
            bool isCompleted = false;

            for (int i = 0; i < length; i++)
            {
                fuel = 0;
                isCompleted = true; 

                for (int j = 0; j < length; j++)
                {
                    string currentPump = pumps.Dequeue();
                    int[] currentValues = currentPump.Split().Select(int.Parse).ToArray();
                    int currentFuel = currentValues[0];
                    int distance = currentValues[1];

                    fuel += currentFuel;

                    if (fuel >= distance)
                    {
                        fuel -= distance;
                    }
                    else
                    {
                        isCompleted = false;
                    }
                    pumps.Enqueue(currentPump);
                }
                if (isCompleted)
                {
                    index = i;
                    break;
                }
                pumps.Enqueue(pumps.Dequeue());
            }
            Console.WriteLine(index);
        }
    }
}
