using System.Reflection.Metadata.Ecma335;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            while (Math.Abs(number = int.Parse(Console.ReadLine())) % 2 == 1)
            {
                Console.WriteLine("Please write an even number.");


            }
            Console.WriteLine($"The number is: {Math.Abs(number)}");


        }
    }
}