namespace SortingAlgorithmsAnalyzer;

public static class SortingAlgorithms
{
    public static void BubbleSort<T>(T[] array) where T : IComparable<T>
    {
        bool swapped;
        for (var i = 0; i < array.Length - 1; i++)
        {
            swapped = false;
            for (var j = 0; j < array.Length - i - 1; j++)
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    swapped = true;
                }

            if (!swapped) break;
        }
    }

    public static void InsertionSort<T>(T[] array) where T : IComparable<T>
    {
        for (var i = 1; i < array.Length; i++)
        {
            var key = array[i];
            var j = i - 1;

            while (j >= 0 && array[j].CompareTo(key) > 0)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }
    }

    public static void SelectionSort<T>(T[] array) where T : IComparable<T>
    {
        for (var i = 0; i < array.Length - 1; i++)
        {
            var minIndex = i;
            for (var j = i + 1; j < array.Length; j++)
                if (array[j].CompareTo(array[minIndex]) < 0)
                    minIndex = j;

            (array[i], array[minIndex]) = (array[minIndex], array[i]);
        }
    }

    public static void MergeSort<T>(T[] array) where T : IComparable<T>
    {
        if (array.Length <= 1) return;

        var mid = array.Length / 2;
        T[] left = new T[mid];
        T[] right = new T[array.Length - mid];

        Array.Copy(array, 0, left, 0, mid);
        Array.Copy(array, mid, right, 0, array.Length - mid);

        MergeSort(left);
        MergeSort(right);
        Merge(array, left, right);
    }

    private static void Merge<T>(T[] array, T[] left, T[] right) where T : IComparable<T>
    {
        int i = 0, j = 0, k = 0;
        while (i < left.Length && j < right.Length)
            if (left[i].CompareTo(right[j]) <= 0)
                array[k++] = left[i++];
            else
                array[k++] = right[j++];

        while (i < left.Length) array[k++] = left[i++];
        while (j < right.Length) array[k++] = right[j++];
    }

    // public static void QuickSort<T>(T[] array) where T : IComparable<T>
    // {
    //     QuickSort(array, 0, array.Length - 1);
    // }
    //
    // private static void QuickSort<T>(T[] array, int low, int high) where T : IComparable<T>
    // {
    //     if (low < high)
    //     {
    //         int pivotIndex = Partition(array, low, high);
    //         QuickSort(array, low, pivotIndex - 1);
    //         QuickSort(array, pivotIndex + 1, high);
    //     }
    // }
    //
    // private static int Partition<T>(T[] array, int low, int high) where T : IComparable<T>
    // {
    //     Random rand = new Random();
    //     int pivotIndex = rand.Next(low, high + 1);
    //     // int pivotIndex = low;
    //     T pivot = array[pivotIndex];
    //     (array[pivotIndex], array[high]) = (array[high], array[pivotIndex]);
    //
    //     int i = low - 1;
    //     for (int j = low; j < high; j++)
    //     {
    //         if (array[j].CompareTo(pivot) <= 0)
    //         {
    //             i++;
    //             (array[i], array[j]) = (array[j], array[i]);
    //         }
    //     }
    //     (array[i + 1], array[high]) = (array[high], array[i + 1]);
    //     return i + 1;
    // }

    public static void QuickSort<T>(T[] array) where T : IComparable<T>
    {
        Shuffle(array); // Randomize the array
        QuickSort(array, 0, array.Length - 1);
    }

    // Quick Sort implementation
    private static void QuickSort<T>(T[] array, int low, int high) where T : IComparable<T>
    {
        if (low < high)
        {
            var pivotIndex = Partition(array, low, high);
            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    // Partition method
    private static int Partition<T>(T[] array, int low, int high) where T : IComparable<T>
    {
        // Random rand = new Random();
        var pivotIndex = low;
        var pivot = array[pivotIndex];
        (array[pivotIndex], array[high]) = (array[high], array[pivotIndex]); // Move pivot to end

        var i = low - 1;
        for (var j = low; j < high; j++)
            if (array[j].CompareTo(pivot) <= 0)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]); // Swap
            }

        (array[i + 1], array[high]) = (array[high], array[i + 1]); // Place pivot
        return i + 1;
    }

    // Fisher-Yates Shuffle
    private static void Shuffle<T>(T[] array)
    {
        var rand = new Random();
        for (var i = array.Length - 1; i > 0; i--)
        {
            var j = rand.Next(i + 1);
            (array[i], array[j]) = (array[j], array[i]); // Swap
        }
    }
}