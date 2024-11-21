using BenchmarkDotNet.Attributes;
using SortingAlgorithmsAnalyzer.Mappers;

namespace SortingAlgorithmsAnalyzer.Benchmarks;

[Config(typeof(CustomConfig))]
public class IrisDatasetBenchmarks
{
    private float[] _array;
    private List<float> _originalDataset;

    [GlobalSetup]
    public async Task Setup()
    {
        var databaseService = new DatabaseService();
        var irisDatas = await databaseService.GetModelsAsync("SELECT * FROM iris", IrisMapper.MapToIrisModel);
        _originalDataset = irisDatas.Select(i => i.PetalLengthCm).ToList();
        _array = new float[_originalDataset.Count];
    }

    [IterationSetup]
    public void IterationSetup()
    {
        Array.Copy(_originalDataset.ToArray(), _array, _originalDataset.Count);
    }

    [Benchmark]
    public void IrisDatasetBubbleSort()
    {
        SortingAlgorithms.BubbleSort(_array);
    }

    [Benchmark]
    public void IrisDatasetInsertionSort()
    {
        SortingAlgorithms.InsertionSort(_array);
    }

    [Benchmark]
    public void IrisDatasetSelectionSort()
    {
        SortingAlgorithms.SelectionSort(_array);
    }

    [Benchmark]
    public void IrisDatasetMergeSort()
    {
        SortingAlgorithms.MergeSort(_array);
    }

    [Benchmark]
    public void IrisDatasetQuickSort()
    {
        SortingAlgorithms.QuickSort(_array);
    }
}