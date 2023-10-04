using System;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                char newPass = userName[i];
                password += newPass;


            }

            int countPassword = 1;
            string enteredPassword;
            while ((enteredPassword = Console.ReadLine()) != password)
            {


                if (countPassword >= 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;

                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

                countPassword++;

            }


            Console.WriteLine($"User {userName} logged in.");


        }
    }
}
