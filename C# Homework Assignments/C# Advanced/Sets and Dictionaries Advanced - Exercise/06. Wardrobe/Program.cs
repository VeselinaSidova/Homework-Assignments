using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());         
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n ; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string[] clothes = input[1].Split(',');
                string color = input[0];

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe.ContainsKey(color))
                    {
                        wardrobe[color] = new Dictionary<string, int>();
                    }
                    if (wardrobe[color].ContainsKey(clothes[j]))
                    {
                        wardrobe[color][clothes[j]]++;                        
                    }
                    if (!wardrobe[color].ContainsKey(clothes[j]))
                    {
                        wardrobe[color][clothes[j]] = 1;
                    }
                }
            }
            string[] toFind = Console.ReadLine().Split();
            string colorToFind = toFind[0];
            string clothingToFind = toFind[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var clothing in color.Value)
                {
                    if (colorToFind == color.Key && clothingToFind == clothing.Key)
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                    }
                }
            }
        }
    }
}
