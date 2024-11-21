using BenchmarkDotNet.Attributes;
using SortingAlgorithmsAnalyzer.Mappers;

namespace SortingAlgorithmsAnalyzer.Benchmarks;

[Config(typeof(CustomConfig))]
public class StudentDatasetBenchmarks
{
    private int[] _array;
    private List<int> _originalDataset;

    [GlobalSetup]
    public async Task Setup()
    {
        var databaseService = new DatabaseService();
        var studentDatas = await databaseService.GetModelsAsync("SELECT * FROM student", StudentMapper.MapToMovieModel);
        _originalDataset = studentDatas.Select(i => i.MathScore).ToList();
        _array = new int[_originalDataset.Count];
    }

    [IterationSetup]
    public void IterationSetup()
    {
        Array.Copy(_originalDataset.ToArray(), _array, _originalDataset.Count);
    }

    [Benchmark]
    public void StudentDatasetBubbleSort()
    {
        SortingAlgorithms.BubbleSort(_array);
    }

    [Benchmark]
    public void StudentDatasetInsertionSort()
    {
        SortingAlgorithms.InsertionSort(_array);
    }

    [Benchmark]
    public void StudentDatasetSelectionSort()
    {
        SortingAlgorithms.SelectionSort(_array);
    }

    [Benchmark]
    public void StudentDatasetMergeSort()
    {
        SortingAlgorithms.MergeSort(_array);
    }

    [Benchmark]
    public void StudentDatasetQuickSort()
    {
        SortingAlgorithms.QuickSort(_array);
    }
}