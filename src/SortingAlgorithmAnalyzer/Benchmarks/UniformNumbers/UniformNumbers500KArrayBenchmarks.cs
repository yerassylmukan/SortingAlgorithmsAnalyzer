using BenchmarkDotNet.Attributes;

namespace SortingAlgorithmAnalyzer.Benchmarks.UniformNumbers;

[Config(typeof(CustomConfig))]
public class UniformNumbers500KArrayBenchmarks
{
    private List<double> _originalArray;
    private double[] _array;

    [GlobalSetup]
    public void Setup()
    {
        _originalArray = DatasetGenerator.GenerateUniformNumbers(500000, 0, 1000);
    }
    
    [IterationSetup]
    public void IterationSetup()
    {
        _array = _originalArray.ToArray();
    }

    [Benchmark]
    public void UniformNumbers500KMergeSort()
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
    public void UniformNumbers500KQuickSort()
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