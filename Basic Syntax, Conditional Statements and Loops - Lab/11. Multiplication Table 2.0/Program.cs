using System.Threading.Tasks;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int sum = 0;


            if (multiplier > 10)
            {
                sum = number * multiplier;
                Console.WriteLine($"{number} X {multiplier} = {sum}");

            }
            else
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    sum = number * i;
                    Console.WriteLine($"{number} X {i} = {sum}");


                }
            }


        }
    }
}