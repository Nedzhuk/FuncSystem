namespace IntegrationTest
{
    public static class Cos
    {
        public static double Cosinus(double x)
        {
            return Math.Sqrt(1 - Math.Pow(Math.Sin(x), 2));
        }
    }
}
