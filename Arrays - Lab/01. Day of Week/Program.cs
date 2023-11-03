namespace _01._Day_Of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                if (number > 0 && number <= 7)
                {
                    Console.WriteLine(daysOfWeek[number - 1]);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid day!");
                    break;
                }
            }
        }
    }
}