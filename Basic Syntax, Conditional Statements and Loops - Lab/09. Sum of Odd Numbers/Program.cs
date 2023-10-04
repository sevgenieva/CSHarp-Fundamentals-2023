namespace _9._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {



                oddSum = ((2 * i) - 1);
                Console.WriteLine(oddSum);
                sum += oddSum;

            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}