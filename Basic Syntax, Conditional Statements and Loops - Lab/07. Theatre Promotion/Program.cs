namespace _7._Theatre_Promotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int priceOfTicket = 0;

            if (typeOfDay == "Weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    priceOfTicket = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    priceOfTicket = 18;

                }
                else if (age > 64 && age <= 122)
                {
                    priceOfTicket = 12;
                }

            }
            else if (typeOfDay == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    priceOfTicket = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    priceOfTicket = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    priceOfTicket = 15;
                }

            }
            else if (typeOfDay == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    priceOfTicket = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    priceOfTicket = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    priceOfTicket = 10;
                }


            }

            if (age >= 0 && age <= 122)
            {
                Console.WriteLine($"{priceOfTicket}$");
            }
            else
            {
                Console.WriteLine("Error!");

            }

        }
    }
}