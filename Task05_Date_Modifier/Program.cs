﻿using System;

namespace DefiningClasses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int diff = DateModifier.CalculateDiff(firstDate, secondDate);

            Console.WriteLine(diff);
        }
    }
}
