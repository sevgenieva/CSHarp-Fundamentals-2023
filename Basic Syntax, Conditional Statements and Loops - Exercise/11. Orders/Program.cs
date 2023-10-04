using System;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            double sum = 1;
            double total = 0;

            for (int i = countOfOrders; i > 0; i--)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCaount = int.Parse(Console.ReadLine());

                sum = ((days * capsuleCaount) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${sum:f2}");
                total += sum;



            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
