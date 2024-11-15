using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using SortingAlgorithmAnalyzer.Benchmarks;
using SortingAlgorithmAnalyzer.Benchmarks.BimodalNumbersBenchmarks;
using SortingAlgorithmAnalyzer.Benchmarks.ExponentialNumbersBenchmarks;
using SortingAlgorithmAnalyzer.Benchmarks.NormalNumbersBenchmarks;
using SortingAlgorithmAnalyzer.Benchmarks.UniformNumbers;

namespace SortingAlgorithmAnalyzer;

public class Program
{
    public static async Task Main(string[] args)
    {
        BenchmarkRunner.Run<UniformNumbers10KArrayBenchmarks>();
        
    }
}