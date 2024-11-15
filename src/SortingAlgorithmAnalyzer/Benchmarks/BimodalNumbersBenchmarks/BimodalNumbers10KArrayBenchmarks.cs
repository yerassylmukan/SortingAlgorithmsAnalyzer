using BenchmarkDotNet.Attributes;

namespace SortingAlgorithmAnalyzer.Benchmarks.BimodalNumbersBenchmarks;

[Config(typeof(CustomConfig))]
public class BimodalNumbers10KArrayBenchmarks
{
    private List<double> _originalArray;
    private double[] _array;

    [GlobalSetup]
    public void Setup()
    {
        _originalArray = DatasetGenerator.GenerateBimodalNumbers(10000, 100, 50, 900, 100);
        _array = new double[_originalArray.Count];
    }
    
    [IterationSetup]
    public void IterationSetup()
    {
        Array.Copy(_originalArray.ToArray(), _array, _originalArray.Count);
    }
    
    [Benchmark]
    public void BimodalNumbers10KBubbleSort()
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
    public void BimodalNumbers10KInsertionSort()
    {
        for (int i = 1; i < _array.Length; i++)
        {
            double key = _array[i];
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
    public void BimodalNumbers10KSelectionSort()
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
    public void BimodalNumbers10KMergeSort()
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

        double[] leftArray = new double[n1];
        double[] rightArray = new double[n2];

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
    public void BimodalNumbers10KQuickSort()
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