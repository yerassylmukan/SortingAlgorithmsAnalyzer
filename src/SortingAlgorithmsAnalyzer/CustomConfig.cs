﻿using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;
using Perfolizer.Metrology;

namespace SortingAlgorithmsAnalyzer;

public class CustomConfig : ManualConfig
{
    public CustomConfig()
    {
        SummaryStyle summaryStyle = SummaryStyle.Default
            .WithTimeUnit(Perfolizer.Horology.TimeUnit.Millisecond);
        this.SummaryStyle = summaryStyle;
    }
}