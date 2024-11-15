using BenchmarkDotNet.Running;
using SortingAlgorithmAnalyzer;
using SortingAlgorithmAnalyzer.Benchmarks.UniformNumbers;
using SortingAlgorithmAnalyzer.Benchmarks.NormalNumbersBenchmarks;
using SortingAlgorithmAnalyzer.Benchmarks.ExponentialNumbersBenchmarks;
using SortingAlgorithmAnalyzer.Benchmarks.BimodalNumbersBenchmarks;

namespace SortingAlgorithmAnalyzer;

public class Program
{
    public static async Task Main(string[] args)
    {
        BenchmarkRunner.Run<UniformNumbers10KArrayBenchmarks>();
    }
}