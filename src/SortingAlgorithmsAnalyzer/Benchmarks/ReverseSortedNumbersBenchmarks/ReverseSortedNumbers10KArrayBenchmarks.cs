using BenchmarkDotNet.Attributes;

namespace SortingAlgorithmsAnalyzer.Benchmarks.ReverseSortedNumbersBenchmarks;

[Config(typeof(CustomConfig))]
public class ReverseSortedNumbers10KArrayBenchmarks
{
    private double[] _array;
    private List<double> _originalArray;

    [GlobalSetup]
    public void Setup()
    {
        _originalArray = DatasetGenerator.GenerateReverseSortedNumbers(10000);
        _array = new double[_originalArray.Count];
    }

    [IterationSetup]
    public void IterationSetup()
    {
        Array.Copy(_originalArray.ToArray(), _array, _originalArray.Count);
    }

    [Benchmark]
    public void ReverseSortedNumbers10KBubbleSort()
    {
        SortingAlgorithms.BubbleSort(_array);
    }

    [Benchmark]
    public void ReverseSortedNumbers10KInsertionSort()
    {
        SortingAlgorithms.InsertionSort(_array);
    }

    [Benchmark]
    public void ReverseSortedNumbers10KSelectionSort()
    {
        SortingAlgorithms.SelectionSort(_array);
    }

    [Benchmark]
    public void ReverseSortedNumbers10KMergeSort()
    {
        SortingAlgorithms.MergeSort(_array);
    }

    [Benchmark]
    public void ReverseSortedNumbers10KQuickSort()
    {
        SortingAlgorithms.QuickSort(_array);
    }
}