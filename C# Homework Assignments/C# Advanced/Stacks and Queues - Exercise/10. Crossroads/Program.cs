using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int durationGreenLight = int.Parse(Console.ReadLine());
            int durationFreeWindow = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Queue<string> cars = new Queue<string>();

            int passedCarsCount = 0;

            while (input != "END")
            {
                if (input != "green")
                {
                    string car = input;
                    cars.Enqueue(car);
                }
                else if (input == "green")
                {
                    if (!cars.Any())
                    {
                        break;
                    }
                    int timeLeft = durationGreenLight;

                    while (timeLeft > 0)
                    {
                        string carToPass = cars.Dequeue();
                        for (int i = 0; i < carToPass.Length; i++)
                        {
                            if (timeLeft == 0)
                            {
                                timeLeft += durationFreeWindow;
                                int carLeft = carToPass.Length - i;
                                for (int j = carLeft; j > 0; j--)
                                {
                                    timeLeft--;
                                    carLeft--;
                                    i++;
                                    if (carLeft == 0 || timeLeft == 0)
                                    {
                                        break;
                                    }
                                }
                                if (carLeft > 0 && timeLeft == 0)
                                {
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{carToPass} was hit at {carToPass[i]}.");
                                    return;
                                }
                                if (carLeft == 0 || timeLeft == 0)
                                {
                                    timeLeft = 0;
                                    break;
                                }
                               
                            }
                            if (timeLeft == 0)
                            {
                                break;
                            }
                            timeLeft--;
                        }
                        passedCarsCount++;

                        if (!cars.Any())
                        {
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCarsCount} total cars passed the crossroads.");
        }
    }
}

