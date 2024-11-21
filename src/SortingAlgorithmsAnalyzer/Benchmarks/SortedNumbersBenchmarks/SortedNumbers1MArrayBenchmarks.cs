using BenchmarkDotNet.Attributes;

namespace SortingAlgorithmsAnalyzer.Benchmarks.SortedNumbersBenchmarks;

[Config(typeof(CustomConfig))]
public class SortedNumbers1MArrayBenchmarks
{
    private double[] _array;
    private List<double> _originalArray;

    [GlobalSetup]
    public void Setup()
    {
        _originalArray = DatasetGenerator.GenerateSortedNumbers(1000000);
        _array = new double[_originalArray.Count];
    }

    [IterationSetup]
    public void IterationSetup()
    {
        Array.Copy(_originalArray.ToArray(), _array, _originalArray.Count);
    }
    
    [Benchmark]
    public void SortedNumbers1MBubbleSort()
    {
        SortingAlgorithms.BubbleSort(_array);
    }

    [Benchmark]
    public void SortedNumbers1MInsertionSort()
    {
        SortingAlgorithms.InsertionSort(_array);
    }

    [Benchmark]
    public void SortedNumbers1MMergeSort()
    {
        SortingAlgorithms.MergeSort(_array);
    }

    [Benchmark]
    public void SortedNumbers1MQuickSort()
    {
        SortingAlgorithms.MergeSort(_array);
    }
}