namespace IntegrationTest
{
    public static class Functions
    {
        public static double Function1(double x)
        {
            return (((((MathClass.Cotangens(x) / MathClass.Secanus(x))) - MathClass.Tangens(x)) * Math.Sin(x)) / Cos.Cosinus(x)) * (Math.Pow(((Math.Sin(x) + Cos.Cosinus(x)) + Cos.Cosinus(x)), 2));
        }
        public static double Function2(double x)
        {
            return ((((Math.Pow(MathClassLog.Log(x, 5), 3)) * MathClassLog.Log(x, 10)) + MathClassLog.Log(x, 3)) / MathClassLog.Ln(x)) + (MathClassLog.Ln(x) * MathClassLog.Log(x, 5));
        }
    }
}
