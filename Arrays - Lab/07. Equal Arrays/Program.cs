namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool finish = true;
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    sum += arr1[i];

                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    finish = false;
                    break;
                }
            }

            if (finish)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");

            }
        }
    }
}