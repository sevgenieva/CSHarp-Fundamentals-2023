﻿namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());

            double convert = (pounds * 1.31);

            Console.WriteLine($"{convert:f3}");

        }
    }
}