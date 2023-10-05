using System;

namespace MoreExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int maxNumber = 0;
            int minNumber = 0;
            int number = 0;

            if (n1 >= n2 && n1 >= n3)
            {
                maxNumber = n1;
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                maxNumber = n2;
            }
            else if (n3 >= n1 && n3 >= n2)
            {
                maxNumber = n3;
            }
            else
            {
                maxNumber = n1;

            }

            if (n1 == 0 || n2 == 0 || n3 == 0)
            {
                minNumber = 0;
            }
            else if (n1 <= n2 && n1 <= n3)
            {
                minNumber = n1;
            }
            else if (n2 <= n1 && n2 <= n3)
            {
                minNumber = n2;
            }
            else if (n3 <= n1 && n3 <= n2)
            {
                minNumber = n3;
            }
            else
            {
                minNumber = n2;
            }

            if (n1 == 0 || n2 == 0 || n3 == 0)
            {
                number = 0;
            }
            else if (n1 < maxNumber && n1 > minNumber)
            {
                number = n1;
            }
            else if (n2 < maxNumber && n2 > minNumber)
            {
                number = n2;
            }
            else if (n3 < maxNumber && n3 > minNumber)
            {
                number = n3;
            }
            else
            {
                number = n3;

            }
            Console.WriteLine(maxNumber);
            Console.WriteLine(number);
            Console.WriteLine(minNumber);
        }
    }
}
