using BenchmarkDotNet.Attributes;

namespace SortingAlgorithmsAnalyzer.Benchmarks.ReverseSortedNumbersBenchmarks;

[Config(typeof(CustomConfig))]
public class ReverseSortedNumbers500KArrayBenchmarks
{
    private double[] _array;
    private List<double> _originalArray;

    [GlobalSetup]
    public void Setup()
    {
        _originalArray = DatasetGenerator.GenerateReverseSortedNumbers(500000);
        _array = new double[_originalArray.Count];
    }

    [IterationSetup]
    public void IterationSetup()
    {
        Array.Copy(_originalArray.ToArray(), _array, _originalArray.Count);
    }

    [Benchmark]
    public void ReverseSortedNumbers500KMergeSort()
    {
        SortingAlgorithms.MergeSort(_array);
    }

    [Benchmark]
    public void ReverseSortedNumbers500KQuickSort()
    {
        SortingAlgorithms.QuickSort(_array);
    }
}