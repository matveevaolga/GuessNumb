namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            x = double.Parse(Console.ReadLine()); 
            y = double.Parse(Console.ReadLine());
            if (x >= 0 && y <= x && (x * x + y * y <= 4)){
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}