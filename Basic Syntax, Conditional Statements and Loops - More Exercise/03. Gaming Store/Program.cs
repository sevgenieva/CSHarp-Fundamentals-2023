namespace MoreExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double spendMoney = 0;

            string command;

            while ((command = Console.ReadLine()) != "Game Time")
            {
                double priceGame = 0;

                if (command == "OutFall 4")
                {
                    priceGame = 39.99;
                }
                else if (command == "CS: OG")
                {
                    priceGame = 15.99;
                }
                else if (command == "Zplinter Zell")
                {
                    priceGame = 19.99;
                }
                else if (command == "Honored 2")
                {
                    priceGame = 59.99;
                }
                else if (command == "RoverWatch")
                {
                    priceGame = 29.99;
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    priceGame = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    continue;
                }

                if (budget >= priceGame)
                {
                    Console.WriteLine($"Bought {command}");
                    budget -= priceGame;
                    spendMoney += priceGame;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }


                if (budget <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }

            if (command == "Game Time" && budget > 0)
            {
                Console.WriteLine($"Total spent: ${spendMoney:f2}. Remaining: ${budget:F2}");

            }

        }
    }
}