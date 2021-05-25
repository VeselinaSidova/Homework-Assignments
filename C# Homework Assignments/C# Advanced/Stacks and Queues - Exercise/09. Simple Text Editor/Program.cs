using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> statesOfText = new Stack<string>();
            statesOfText.Push(text.ToString());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "1":
                        text.Append(command[1]);
                        statesOfText.Push(text.ToString());
                        break;
                    case "2":
                        text = text.Remove(text.Length - int.Parse(command[1]), int.Parse(command[1]));
                        statesOfText.Push(text.ToString());
                        break;
                    case "3":
                        char toPrint = text[int.Parse(command[1]) - 1];
                        Console.WriteLine(toPrint);
                        break;
                    case "4":
                        if (statesOfText.Any())
                        {
                            statesOfText.Pop();
                            text = new StringBuilder();
                            text.Append(statesOfText.Peek());
                        }
                        break;
                }
                
            }
        }
    }
}
