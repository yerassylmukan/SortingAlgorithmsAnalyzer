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

}