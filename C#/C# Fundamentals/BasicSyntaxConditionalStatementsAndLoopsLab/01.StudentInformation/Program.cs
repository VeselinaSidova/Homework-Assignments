﻿using System;

namespace _01.StudentInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string age = Console.ReadLine();
            string grade = Console.ReadLine();

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade}");
        }
    }
}
