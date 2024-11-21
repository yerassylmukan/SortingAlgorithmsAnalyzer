using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;
using Perfolizer.Horology;

namespace SortingAlgorithmsAnalyzer;

public class CustomConfig : ManualConfig
{
    public CustomConfig()
    {
        var summaryStyle = SummaryStyle.Default
            .WithTimeUnit(TimeUnit.Millisecond);
        SummaryStyle = summaryStyle;
    }
}