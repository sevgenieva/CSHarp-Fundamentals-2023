using System;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            double countOfStudents = double.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());


            double moneyForLightsabers = (Math.Ceiling((countOfStudents + (countOfStudents * 0.1))) * priceLightsabers);
            double moneyForRobes = countOfStudents * priceRobes;
            double moneyBelt = countOfStudents * priceBelts;

            int countFreeBelt = 0;
            for (int i = 6; i <= countOfStudents; i += 6)
            {
                countFreeBelt++;
            }

            moneyBelt -= (countFreeBelt * priceBelts);

            double money = moneyForLightsabers + moneyForRobes + moneyBelt;

            if (money <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {money:f2}lv.");

            }
            else
            {
                Console.WriteLine($"John will need {(money - amountOfMoney):F2}lv more.");
            }


        }
    }
}
