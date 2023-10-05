namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double volume = 0;


            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            volume = (width * length * hight) / 3;

            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:f2}");
        }
    }
}