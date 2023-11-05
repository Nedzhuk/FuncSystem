namespace IntegrationTest
{
    public static class MathClass
    {
        public static double Tangens(double x)
        {
            return Math.Sin(x) / Cos.Cosinus(x);
        }
        public static double Cotangens(double x)
        {
            return Cos.Cosinus(x) / Math.Sin(x);
        }
        public static double Secanus(double x)
        {
            return 1 / Cos.Cosinus(x);
        }
    }
}
