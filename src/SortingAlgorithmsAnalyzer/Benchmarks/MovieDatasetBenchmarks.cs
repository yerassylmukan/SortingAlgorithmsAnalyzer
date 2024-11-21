using BenchmarkDotNet.Attributes;
using SortingAlgorithmsAnalyzer.Mappers;

namespace SortingAlgorithmsAnalyzer.Benchmarks;

[Config(typeof(CustomConfig))]
public class MovieDatasetBenchmarks
{
    private float[] _array;
    private List<float> _originalDataset;

    [GlobalSetup]
    public async Task Setup()
    {
        var databaseService = new DatabaseService();
        var movieDatas = await databaseService.GetModelsAsync("SELECT * FROM movie", MovieMapper.MapToMovieModel);
        _originalDataset = movieDatas.Select(i => i.Popularity).ToList();
        _array = new float[_originalDataset.Count];
    }

    [IterationSetup]
    public void IterationSetup()
    {
        Array.Copy(_originalDataset.ToArray(), _array, _originalDataset.Count);
    }

    [Benchmark]
    public void MovieDatasetBubbleSort()
    {
        SortingAlgorithms.BubbleSort(_array);
    }

    [Benchmark]
    public void MovieDatasetInsertionSort()
    {
        SortingAlgorithms.InsertionSort(_array);
    }

    [Benchmark]
    public void MovieDatasetSelectionSort()
    {
        SortingAlgorithms.SelectionSort(_array);
    }

    [Benchmark]
    public void MovieDatasetMergeSort()
    {
        SortingAlgorithms.MergeSort(_array);
    }

    [Benchmark]
    public void MovieDatasetQuickSort()
    {
        SortingAlgorithms.QuickSort(_array);
    }
}