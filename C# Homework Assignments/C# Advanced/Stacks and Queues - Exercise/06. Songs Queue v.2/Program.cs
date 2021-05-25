using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] initialSongs = Console.ReadLine().Split(", ").ToArray();
            Queue<string> songsQueue = new Queue<string>(initialSongs);

            while (songsQueue.Any())
            {
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (command.StartsWith("Add"))
                {
                    string songName = command.Substring(4);
                    if (songsQueue.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained! ");
                    }
                    else
                    {
                        songsQueue.Enqueue(songName);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}