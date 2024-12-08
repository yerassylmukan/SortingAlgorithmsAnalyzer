﻿using BenchmarkDotNet.Attributes;

namespace SortingAlgorithmsAnalyzer.Benchmarks.UniformNumbers;

[Config(typeof(CustomConfig))]
public class UniformNumbers10KArrayBenchmarks
{
    private double[] _array;
    private List<double> _originalArray;

    [GlobalSetup]
    public void Setup()
    {
        _originalArray = DatasetGenerator.GenerateUniformNumbers(10000, 0, 1000);
        _array = new double[_originalArray.Count];
    }

    [IterationSetup]
    public void IterationSetup()
    {
        Array.Copy(_originalArray.ToArray(), _array, _originalArray.Count);
    }

    [Benchmark]
    public void UniformNumbers10KBubbleSort()
    {
        SortingAlgorithms.BubbleSort(_array);
    }

    [Benchmark]
    public void UniformNumbers10KInsertionSort()
    {
        SortingAlgorithms.InsertionSort(_array);
    }

    [Benchmark]
    public void UniformNumbers10KSelectionSort()
    {
        SortingAlgorithms.SelectionSort(_array);
    }

    [Benchmark]
    public void UniformNumbers10KMergeSort()
    {
        SortingAlgorithms.MergeSort(_array);
    }

    [Benchmark]
    public void UniformNumbers10KQuickSort()
    {
        SortingAlgorithms.QuickSort(_array);
    }
}