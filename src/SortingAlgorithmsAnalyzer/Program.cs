using BenchmarkDotNet.Running;
using SortingAlgorithmsAnalyzer.Benchmarks;
using SortingAlgorithmsAnalyzer.Benchmarks.UniformNumbers;
using SortingAlgorithmsAnalyzer.Benchmarks.SortedNumbersBenchmarks;
using SortingAlgorithmsAnalyzer.Benchmarks.ReverseSortedNumbersBenchmarks;

namespace SortingAlgorithmsAnalyzer;

public class Program
{
    private static double[] _array = new double[100000];

    public static async Task Main(string[] args)
    {
        // BenchmarkRunner.Run<IrisDatasetBenchmarks>();
        // BenchmarkRunner.Run<StudentDatasetBenchmarks>();
        // BenchmarkRunner.Run<WineDatasetBenchmarks>();
        // BenchmarkRunner.Run<MovieDatasetBenchmarks>();
        // BenchmarkRunner.Run<SongDatasetBenchmarks>();
        //
        // BenchmarkRunner.Run<UniformNumbers10KArrayBenchmarks>();
        // BenchmarkRunner.Run<UniformNumbers100KArrayBenchmarks>();
        // BenchmarkRunner.Run<UniformNumbers500KArrayBenchmarks>();
        // BenchmarkRunner.Run<UniformNumbers1MArrayBenchmarks>();
        //
        // BenchmarkRunner.Run<SortedNumbers10KArrayBenchmarks>();
        // BenchmarkRunner.Run<SortedNumbers100KArrayBenchmarks>();
        // BenchmarkRunner.Run<SortedNumbers500KArrayBenchmarks>();
        // BenchmarkRunner.Run<SortedNumbers1MArrayBenchmarks>();
        //
        // BenchmarkRunner.Run<ReverseSortedNumbers10KArrayBenchmarks>();
        // BenchmarkRunner.Run<ReverseSortedNumbers100KArrayBenchmarks>();
        // BenchmarkRunner.Run<ReverseSortedNumbers500KArrayBenchmarks>();
        BenchmarkRunner.Run<ReverseSortedNumbers1MArrayBenchmarks>();
    }
}