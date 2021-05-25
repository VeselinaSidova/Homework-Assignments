using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] initial = Console.ReadLine().Split(", ").ToArray();
            Queue<string> playlist = new Queue<string>(initial);
            string song = "";

            while (playlist.Count > 0)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[0] == "Add")
                {
                    if (command.Length > 2)
                    {
                        for (int i = 1; i < command.Length; i++)
                        {
                            song += command[i] + " ";
                        }
                        song = song.Remove(song.Length - 1, 1);
                        if (playlist.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            playlist.Enqueue(song);
                        }
                    }
                    else
                    {
                        if (!playlist.Contains(command[1]))
                        {
                            playlist.Enqueue(command[1]);
                        }
                        else
                        {
                            Console.WriteLine($"{command[1]} is already contained!");
                        }
                    }
                    song = "";
                }
                else if (command[0] == "Play")
                {
                    playlist.Dequeue();
                }
                else if (command[0] == "Show")
                {
                    if (playlist.Count == 1)
                    {
                        Console.WriteLine(playlist.Peek());
                    }
                    else
                    {
                        string toPrint = "";
                        foreach (var item in playlist)
                        {
                            toPrint += item + ", ";
                        }
                        toPrint = toPrint.Remove(toPrint.Length - 2, 2);
                        Console.WriteLine(toPrint);
                    }
                }
            }
            Console.WriteLine("No more songs!");

        }
    }
}

        
        
