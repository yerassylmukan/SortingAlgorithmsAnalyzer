using BenchmarkDotNet.Attributes;

namespace SortingAlgorithmsAnalyzer.Benchmarks.SortedNumbersBenchmarks;

[Config(typeof(CustomConfig))]
public class SortedNumbers500KArrayBenchmarks
{
    private double[] _array;
    private List<double> _originalArray;

    [GlobalSetup]
    public void Setup()
    {
        _originalArray = DatasetGenerator.GenerateSortedNumbers(500000);
        _array = new double[_originalArray.Count];
    }

    [IterationSetup]
    public void IterationSetup()
    {
        Array.Copy(_originalArray.ToArray(), _array, _originalArray.Count);
    }
    
    [Benchmark]
    public void SortedNumbers500KBubbleSort()
    {
        SortingAlgorithms.BubbleSort(_array);
    }

    [Benchmark]
    public void SortedNumbers500KInsertionSort()
    {
        SortingAlgorithms.InsertionSort(_array);
    }

    [Benchmark]
    public void SortedNumbers500KMergeSort()
    {
        SortingAlgorithms.MergeSort(_array);
    }

    [Benchmark]
    public void SortedNumbers500KQuickSort()
    {
        SortingAlgorithms.QuickSort(_array);
    }
}