using System;
using System.Threading;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            double sum = 0;
            while ((command = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(command);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

            }

            double price = 0;
            string newCommand;
            while ((newCommand = Console.ReadLine()) != "End")
            {


                if (newCommand == "Nuts")
                {
                    price = 2.0;
                    if (sum >= price)
                    {
                        sum -= 2.0;
                        Console.WriteLine($"Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }


                }
                else if (newCommand == "Water")
                {
                    price = 0.7;
                    if (sum >= price)
                    {
                        sum -= 0.7;
                        Console.WriteLine($"Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }


                }
                else if (newCommand == "Crisps")
                {
                    price = 1.5;
                    if (sum >= price)
                    {
                        sum -= 1.5;
                        Console.WriteLine($"Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }



                }
                else if (newCommand == "Soda")
                {
                    price = 0.8;
                    if (sum >= price)
                    {
                        sum -= 0.8;
                        Console.WriteLine($"Purchased soda");

                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }

                }
                else if (newCommand == "Coke")
                {
                    price = 1.0;
                    if (price <= sum)
                    {
                        sum -= 1.0;
                        Console.WriteLine($"Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid product");
                }




            }

            if (newCommand == "End")
            {
                Console.WriteLine($"Change: {sum:f2}");

            }



        }
    }
}
