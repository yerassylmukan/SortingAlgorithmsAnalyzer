using BenchmarkDotNet.Attributes;
using SortingAlgorithmsAnalyzer.Mappers;

namespace SortingAlgorithmsAnalyzer.Benchmarks;

[Config(typeof(CustomConfig))]
public class SongDatasetBenchmarks
{
    private int[] _array;
    private List<int> _originalDataset;

    [GlobalSetup]
    public async Task Setup()
    {
        var databaseService = new DatabaseService();
        var songDatas = await databaseService.GetModelsAsync("SELECT * FROM song", SongMapper.MapToSongModel);
        _originalDataset = songDatas.Select(i => i.Popularity).ToList();
        _array = new int[_originalDataset.Count];
    }

    [IterationSetup]
    public void IterationSetup()
    {
        Array.Copy(_originalDataset.ToArray(), _array, _originalDataset.Count);
    }

    [Benchmark]
    public void SongDatasetBubbleSort()
    {
        SortingAlgorithms.BubbleSort(_array);
    }

    [Benchmark]
    public void SongDatasetInsertionSort()
    {
        SortingAlgorithms.InsertionSort(_array);
    }

    [Benchmark]
    public void SongDatasetSelectionSort()
    {
        SortingAlgorithms.SelectionSort(_array);
    }

    [Benchmark]
    public void SongDatasetMergeSort()
    {
        SortingAlgorithms.MergeSort(_array);
    }

    [Benchmark]
    public void SongDatasetQuickSort()
    {
        SortingAlgorithms.QuickSort(_array);
    }
}