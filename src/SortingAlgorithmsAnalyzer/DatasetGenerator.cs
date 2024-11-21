public static class DatasetGenerator
{
    private static readonly Random _random = new();

    public static List<double> GenerateUniformNumbers(int size, double a, double b)
    {
        var numbers = new List<double>();

        for (var i = 0; i < size; i++)
        {
            var randomNumber = a + (b - a) * _random.NextDouble();
            numbers.Add(randomNumber);
        }

        return numbers;
    }

    public static List<double> GenerateSortedNumbers(int size)
    {
        var numbers = new List<double>();

        for (var i = 1; i <= size; i++) numbers.Add(i);

        return numbers;
    }

    public static List<double> GenerateReverseSortedNumbers(int size)
    {
        var numbers = new List<double>();

        for (var i = size; i >= 1; i--) numbers.Add(i);

        return numbers;
    }

    public static List<double> GenerateBimodalNumbers(int size, double mean1, double stdDev1, double mean2,
        double stdDev2)
    {
        var numbers = new List<double>();

        for (var i = 0; i < size; i++)
        {
            var useFirstDistribution = _random.NextDouble() > 0.5;

            double normalNumber;

            if (useFirstDistribution)
                normalNumber = GenerateNormal(mean1, stdDev1);
            else
                normalNumber = GenerateNormal(mean2, stdDev2);

            numbers.Add(normalNumber);
        }

        return numbers;
    }

    private static double GenerateNormal(double mean, double standardDeviation)
    {
        var u1 = _random.NextDouble();
        var u2 = _random.NextDouble();
        var z0 = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);

        return mean + z0 * standardDeviation;
    }
}