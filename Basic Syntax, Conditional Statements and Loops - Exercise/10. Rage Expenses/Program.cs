using System;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double countHeadset = 0;
            double coutMouse = 0;
            double countKeyboard = 0;
            double countDisplay = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    countHeadset++;
                }

                if (i % 3 == 0)
                {
                    coutMouse++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    countKeyboard++;

                    if (countKeyboard % 2 == 0)
                    {
                        countDisplay++;
                    }

                }



            }

            double price = (countHeadset * headsetPrice) + (coutMouse * mousePrice) + (countKeyboard * keyboardPrice) + (countDisplay * displayPrice);
            Console.WriteLine($"Rage expenses: {price:F2} lv.");
        }
    }
}
