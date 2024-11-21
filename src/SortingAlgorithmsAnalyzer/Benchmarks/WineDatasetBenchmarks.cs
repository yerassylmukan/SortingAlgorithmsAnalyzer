using BenchmarkDotNet.Attributes;
using SortingAlgorithmsAnalyzer.Mappers;

namespace SortingAlgorithmsAnalyzer.Benchmarks;

[Config(typeof(CustomConfig))]
public class WineDatasetBenchmarks
{
    private int[] _array;
    private List<int> _originalDataset;

    [GlobalSetup]
    public async Task Setup()
    {
        var databaseService = new DatabaseService();
        var wineDatas = await databaseService.GetModelsAsync("SELECT * FROM wine", WineMapper.MapToWineModel);
        _originalDataset = wineDatas.Select(i => i.Quality).ToList();
        _array = new int[_originalDataset.Count];
    }

    [IterationSetup]
    public void IterationSetup()
    {
        Array.Copy(_originalDataset.ToArray(), _array, _originalDataset.Count);
    }

    [Benchmark]
    public void WineDatasetBubbleSort()
    {
        SortingAlgorithms.BubbleSort(_array);
    }

    [Benchmark]
    public void WineDatasetInsertionSort()
    {
        SortingAlgorithms.InsertionSort(_array);
    }

    [Benchmark]
    public void WineDatasetSelectionSort()
    {
        SortingAlgorithms.SelectionSort(_array);
    }

    [Benchmark]
    public void WineDatasetMergeSort()
    {
        SortingAlgorithms.MergeSort(_array);
    }

    [Benchmark]
    public void WineDatasetQuickSort()
    {
        SortingAlgorithms.QuickSort(_array);
    }
}