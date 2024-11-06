public static class DatasetGenerator
{
    private static readonly Random _random = new();

    public static List<double> GenerateUniformNumbers(int size, double min, double max)
    {
        var numbers = new List<double>();

        for (var i = 0; i < size; i++) numbers.Add(_random.NextDouble() * (max - min) + min);

        return numbers;
    }

    public static List<double> GenerateNormalNumbers(int size, double mean, double stdDev)
    {
        var numbers = new List<double>();

        for (var i = 0; i < size; i++)
        {
            var u1 = _random.NextDouble();
            var u2 = _random.NextDouble();
            var z = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);
            numbers.Add(mean + z * stdDev);
        }

        return numbers;
    }

    public static List<double> GenerateExponentialNumbers(int size, double lambda)
    {
        var numbers = new List<double>();

        for (var i = 0; i < size; i++)
        {
            var expRandom = -Math.Log(1.0 - _random.NextDouble()) / lambda;
            numbers.Add(expRandom);
        }

        return numbers;
    }

    public static List<double> GenerateBimodalNumbers(int size, double mean1, double mean2, double stdDev)
    {
        var numbers = new List<double>();

        for (var i = 0; i < size; i++)
        {
            var mean = _random.NextDouble() < 0.5 ? mean1 : mean2;
            var u1 = _random.NextDouble();
            var u2 = _random.NextDouble();
            var z = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);
            numbers.Add(mean + z * stdDev);
        }

        return numbers;
    }
}