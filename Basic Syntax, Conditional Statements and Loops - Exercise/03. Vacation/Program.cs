namespace Exercise

{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double price = 0;

            if (typeOfGroup == "Students")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = people * 8.45;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = people * 9.80;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = people * 10.46;
                }

                if (people >= 30)
                {
                    price -= price * 0.15;
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = people * 10.90;

                    if (people >= 100)
                    {
                        price = (people - 10) * 10.90;
                    }
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = people * 15.60;

                    if (people >= 100)
                    {
                        price = (people - 10) * 15.60;
                    }
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = people * 16;


                    if (people >= 100)
                    {
                        price = (people - 10) * 16;
                    }
                }

            }
            else if (typeOfGroup == "Regular")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = people * 15;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = people * 20;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = people * 22.50;
                }

                if (people >= 10 && people <= 20)
                {
                    price -= price * 0.05;
                }

            }

            Console.WriteLine($"Total price: {price:f2}");








        }
    }
}
