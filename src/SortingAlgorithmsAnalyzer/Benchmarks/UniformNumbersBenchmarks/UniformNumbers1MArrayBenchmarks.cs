using BenchmarkDotNet.Attributes;

namespace SortingAlgorithmsAnalyzer.Benchmarks.UniformNumbers;

[Config(typeof(CustomConfig))]
public class UniformNumbers1MArrayBenchmarks
{
    private double[] _array;
    private List<double> _originalArray;

    [GlobalSetup]
    public void Setup()
    {
        _originalArray = DatasetGenerator.GenerateUniformNumbers(1000000, 0, 1000);
        _array = new double[_originalArray.Count];
    }

    [IterationSetup]
    public void IterationSetup()
    {
        Array.Copy(_originalArray.ToArray(), _array, _originalArray.Count);
    }

    [Benchmark]
    public void UniformNumbers1MMergeSort()
    {
        SortingAlgorithms.MergeSort(_array);
    }

    [Benchmark]
    public void UniformNumbers1MQuickSort()
    {
        SortingAlgorithms.QuickSort(_array);
    }
}