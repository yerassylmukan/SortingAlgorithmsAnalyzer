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
        // var irisDatasetBenchmarksSummary = BenchmarkRunner.Run<IrisDatasetBenchmarks>();
        // var studentDatasetBenchmarksSummary = BenchmarkRunner.Run<StudentDatasetBenchmarks>();
        // var wineDatasetBenchmarksSummary = BenchmarkRunner.Run<WineDatasetBenchmarks>();
        // var movieDatasetBenchmarksSummary = BenchmarkRunner.Run<MovieDatasetBenchmarks>();
        // var songDatasetBenchmarksSummary = BenchmarkRunner.Run<SongDatasetBenchmarks>();
        
        // var uniformNumbers10KArrayBenchmarksSummary = BenchmarkRunner.Run<UniformNumbers10KArrayBenchmarks>();
        // var uniformNumbers100KArrayBenchmarksSummary = BenchmarkRunner.Run<UniformNumbers100KArrayBenchmarks>();
        // var uniformNumbers500KArrayBenchmarksSummary = BenchmarkRunner.Run<UniformNumbers500KArrayBenchmarks>();
        // var uniformNumbers1MArrayBenchmarksSummary = BenchmarkRunner.Run<UniformNumbers1MArrayBenchmarks>();
        
        // var normalNumbers10KArrayBenchmarksSummary = BenchmarkRunner.Run<NormalNumbers10KArrayBenchmarks>();
        // var normalNumbers100KArrayBenchmarksSummary = BenchmarkRunner.Run<NormalNumbers100KArrayBenchmarks>();
        // var normalNumbers500KArrayBenchmarksSummary = BenchmarkRunner.Run<NormalNumbers500KArrayBenchmarks>();
        // var normalNumbers1MArrayBenchmarksSummary = BenchmarkRunner.Run<NormalNumbers1MArrayBenchmarks>();
        
        // var exponentialNumbers10KArrayBenchmarksSummary = BenchmarkRunner.Run<ExponentialNumbers10KArrayBenchmarks>();
        // var exponentialNumbers100KArrayBenchmarksSummary = BenchmarkRunner.Run<ExponentialNumbers100KArrayBenchmarks>();
        // var exponentialNumbers500KArrayBenchmarksSummary = BenchmarkRunner.Run<ExponentialNumbers500KArrayBenchmarks>();
        // var exponentialNumbers1MArrayBenchmarksSummary = BenchmarkRunner.Run<ExponentialNumbers1MArrayBenchmarks>();
        
        // var bimodalNumbers10KArrayBenchmarksSummary = BenchmarkRunner.Run<BimodalNumbers10KArrayBenchmarks>();
        // var bimodalNumbers100KArrayBenchmarksSummary = BenchmarkRunner.Run<BimodalNumbers100KArrayBenchmarks>();
        // var bimodalNumbers500KArrayBenchmarksSummary = BenchmarkRunner.Run<BimodalNumbers500KArrayBenchmarks>();
        // var bimodalNumbers1MArrayBenchmarksSummary = BenchmarkRunner.Run<BimodalNumbers1MArrayBenchmarks>();
        
        // AverageTimes(bimodalNumbers10KArrayBenchmarksSummary);
    }

    private static void AverageTimes(Summary summary)
    {
        foreach (var report in summary.Reports)
        {
            var mean = report.ResultStatistics.Mean;
            var methodName = report.BenchmarkCase.Descriptor.WorkloadMethod.Name;
            Console.WriteLine($"{methodName}: {mean / 1e6} ms");
        }
    }
}