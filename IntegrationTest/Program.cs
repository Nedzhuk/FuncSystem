namespace IntegrationTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x <= 0) Console.WriteLine($"{Functions.Function1(x)}");
            else Console.WriteLine($"{Functions.Function2(x)}");
        }
    }
}