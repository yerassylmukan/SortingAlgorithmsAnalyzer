using BenchmarkDotNet.Attributes;
using SortingAlgorithmAnalyzer.Mappers;

namespace SortingAlgorithmAnalyzer.Benchmarks;

public class IrisDatasetBenchmarks
{
    private float[] _array;
    private List<float> _originalDataset;

    [GlobalSetup]
    public async Task Setup()
    {
        var databaseService = new DatabaseService();
        var irisDatas = await databaseService.GetModelsAsync("SELECT * FROM iris", IrisMapper.MapToIrisModel);
        _originalDataset = irisDatas.Select(i => i.PetalLengthCm).ToList();
    }

    [IterationSetup]
    public void IterationSetup()
    {
        _array = _originalDataset.ToArray();
    }
    
    [Benchmark]
    public void BubbleSort()
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
    public void InsertionSort()
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
    public void SelectionSort()
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
    public void MergeSort()
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

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        Array.Copy(_array, left, leftArray, 0, n1);
        Array.Copy(_array, mid + 1, rightArray, 0, n2);

        int i = 0, j = 0, k = left;
        while (i < n1 && j < n2)
        {
            if (leftArray[i] <= rightArray[j])
                _array[k++] = leftArray[i++];
            else
                _array[k++] = rightArray[j++];
        }

        while (i < n1)
            _array[k++] = leftArray[i++];

        while (j < n2)
            _array[k++] = rightArray[j++];
    }

    [Benchmark]
    public void QuickSort()
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
        float pivot = _array[high];
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