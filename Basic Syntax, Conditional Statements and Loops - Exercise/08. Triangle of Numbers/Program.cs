﻿using System;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                {

                    Console.Write($"{i} ");
                }
            }


        }
    }
}
