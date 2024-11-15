public static class DatasetGenerator
{
    private static readonly Random _random = new();

    public static List<double> GenerateUniformNumbers(int size, double a, double b)
    {
        var numbers = new List<double>();

        for (var i = 0; i < size; i++)
        {
            
            double randomNumber = a + (b - a) * _random.NextDouble();
            numbers.Add(randomNumber);
        }

        return numbers;
    }

    public static List<double> GenerateNormalNumbers(int size, double mean, double standardDeviation)
    {
        var numbers = new List<double>();

        for (var i = 0; i < size; i++)
        {
            double u1 = _random.NextDouble();
            double u2 = _random.NextDouble();
            double z0 = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);
            double normalNumber = mean + z0 * standardDeviation;
            numbers.Add(normalNumber);
        }

        return numbers;
    }

    public static List<double> GenerateExponentialNumbers(int size, double mean)
    {
        List<double> numbers = new List<double>();
        double lambda = 1.0 / mean;

        for (int i = 0; i < size; i++)
        {
            double u = _random.NextDouble();

            double exponentialNumber = -Math.Log(1 - u) / lambda;
            numbers.Add(exponentialNumber);
        }

        return numbers;
    }

    public static List<double> GenerateBimodalNumbers(int size, double mean1, double stdDev1, double mean2, double stdDev2)
    {
        List<double> numbers = new List<double>();

        for (int i = 0; i < size; i++)
        {
            bool useFirstDistribution = _random.NextDouble() > 0.5;

            double normalNumber;

            if (useFirstDistribution)
            {
                normalNumber = GenerateNormal(mean1, stdDev1);
            }
            else
            {
                normalNumber = GenerateNormal(mean2, stdDev2);
            }

            numbers.Add(normalNumber);
        }

        return numbers;
    }

    private static double GenerateNormal(double mean, double standardDeviation)
    {
        double u1 = _random.NextDouble();
        double u2 = _random.NextDouble();
        double z0 = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);

        return mean + z0 * standardDeviation;
    }
}