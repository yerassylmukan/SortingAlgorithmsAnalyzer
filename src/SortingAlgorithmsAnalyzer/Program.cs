using BenchmarkDotNet.Running;
using SortingAlgorithmsAnalyzer.Benchmarks;
using SortingAlgorithmsAnalyzer.Benchmarks.UniformNumbers;
using SortingAlgorithmsAnalyzer.Benchmarks.NormalNumbersBenchmarks;
using SortingAlgorithmsAnalyzer.Benchmarks.ExponentialNumbersBenchmarks;
using SortingAlgorithmsAnalyzer.Benchmarks.BimodalNumbersBenchmarks;

namespace SortingAlgorithmsAnalyzer;

public class Program
{
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
        // BenchmarkRunner.Run<NormalNumbers10KArrayBenchmarks>();
        // BenchmarkRunner.Run<NormalNumbers100KArrayBenchmarks>();
        // BenchmarkRunner.Run<NormalNumbers500KArrayBenchmarks>();
        // BenchmarkRunner.Run<NormalNumbers1MArrayBenchmarks>();
        //
        // BenchmarkRunner.Run<ExponentialNumbers10KArrayBenchmarks>();
        // BenchmarkRunner.Run<ExponentialNumbers100KArrayBenchmarks>();
        // BenchmarkRunner.Run<ExponentialNumbers500KArrayBenchmarks>();
        // BenchmarkRunner.Run<ExponentialNumbers1MArrayBenchmarks>();
        //
        // BenchmarkRunner.Run<BimodalNumbers10KArrayBenchmarks>();
        // BenchmarkRunner.Run<BimodalNumbers100KArrayBenchmarks>();
        // BenchmarkRunner.Run<BimodalNumbers500KArrayBenchmarks>();
        BenchmarkRunner.Run<BimodalNumbers1MArrayBenchmarks>();
    }
}