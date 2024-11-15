﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using SortingAlgorithmsAnalyzer.Mappers;

namespace SortingAlgorithmsAnalyzer.Benchmarks;

[Config(typeof(CustomConfig))]
public class IrisDatasetBenchmarks
{
    private List<float> _originalDataset;
    private float[] _array;

    [GlobalSetup]
    public async Task Setup()
    {
        var databaseService = new DatabaseService();
        var irisDatas = await databaseService.GetModelsAsync("SELECT * FROM iris", IrisMapper.MapToIrisModel);
        _originalDataset = irisDatas.Select(i => i.PetalLengthCm).ToList();
        _array = new float[_originalDataset.Count];
    }
    
    [IterationSetup]
    public void IterationSetup()
    {
        Array.Copy(_originalDataset.ToArray(), _array, _originalDataset.Count);
    }
    
    [Benchmark]
    public void IrisDatasetBubbleSort()
    {
        bool swapped;
        for (int i = 0; i < _array.Length - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < _array.Length - 1 - i; j++)
            {
                if (_array[j] > _array[j + 1])
                {
                    Swap(j, j + 1);
                    swapped = true;
                }
            }
            if (!swapped)
                break;
        }
    }

    [Benchmark]
    public void IrisDatasetInsertionSort()
    {
        for (int i = 1; i < _array.Length; i++)
        {
            float key = _array[i];
            int j = i - 1;
            while (j >= 0 && _array[j] > key)
            {
                _array[j + 1] = _array[j];
                j--;
            }
            _array[j + 1] = key;
        }
    }

    [Benchmark]
    public void IrisDatasetSelectionSort()
    {
        for (int i = 0; i < _array.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < _array.Length; j++)
            {
                if (_array[j] < _array[minIndex])
                    minIndex = j;
            }
            Swap(i, minIndex);
        }
    }

    [Benchmark]
    public void IrisDatasetMergeSort()
    {
        MergeSortRecursive(0, _array.Length - 1);
    }

    private void MergeSortRecursive(int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSortRecursive(left, mid);
            MergeSortRecursive(mid + 1, right);
            Merge(left, mid, right);
        }
    }

    private void Merge(int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        float[] leftArray = new float[n1];
        float[] rightArray = new float[n2];

        for (int i = 0; i < n1; i++)
            leftArray[i] = _array[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = _array[mid + 1 + j];

        int iLeft = 0, iRight = 0, k = left;
        while (iLeft < n1 && iRight < n2)
        {
            if (leftArray[iLeft] <= rightArray[iRight])
                _array[k++] = leftArray[iLeft++];
            else
                _array[k++] = rightArray[iRight++];
        }

        while (iLeft < n1)
            _array[k++] = leftArray[iLeft++];

        while (iRight < n2)
            _array[k++] = rightArray[iRight++];
    }

    [Benchmark]
    public void IrisDatasetQuickSort()
    {
        QuickSortRecursive(0, _array.Length - 1);
    }

    private void QuickSortRecursive(int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(low, high);
            QuickSortRecursive(low, pivotIndex - 1);
            QuickSortRecursive(pivotIndex + 1, high);
        }
    }

    private int Partition(int low, int high)
    {
        double pivot = _array[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (_array[j] < pivot)
            {
                i++;
                Swap(i, j);
            }
        }
        Swap(i + 1, high);
        return i + 1;
    }

    private void Swap(int i, int j)
    {
        (_array[i], _array[j]) = (_array[j], _array[i]);
    }
}