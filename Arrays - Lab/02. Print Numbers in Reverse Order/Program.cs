namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] number = new int[n];

            for (int i = 0; i < number.Length; i++)
            {
                int num = int.Parse(Console.ReadLine());
                number[i] = num;

            }

            for (int i = 0; i < number.Length / 2; i++)
            {

                int firstNumber = number[i];
                int lastNumber = number[number.Length - 1 - i];

                number[i] = lastNumber;
                number[number.Length - 1 - i] = firstNumber;


            }
            Console.WriteLine(string.Join(" ", number));



        }



    }
}