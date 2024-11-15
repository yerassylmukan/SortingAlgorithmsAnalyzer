using BenchmarkDotNet.Running;
using SortingAlgorithmAnalyzer.Benchmarks.BimodalNumbersBenchmarks;

namespace SortingAlgorithmAnalyzer;

public class Program
{
    public static async Task Main(string[] args)
    {
        BenchmarkRunner.Run<BimodalNumbers1MArrayBenchmarks>();
    }
}