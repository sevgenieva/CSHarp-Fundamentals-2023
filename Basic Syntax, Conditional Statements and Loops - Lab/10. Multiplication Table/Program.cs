﻿namespace _10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int sum = number * i;
                Console.WriteLine($"{number} X {i} = {sum}");
            }
        }
    }
}