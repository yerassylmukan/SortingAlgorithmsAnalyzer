# Sorting Algorithms Analyzer

## Overview

The **Sorting Algorithms Analyzer** is a benchmarking tool designed to evaluate and compare the performance of different sorting algorithms across various datasets. The project uses [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) to provide detailed insights into execution times, error margins, and standard deviations.

---

## Benchmarks

### System Configuration

```
BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2314)
AMD Ryzen 5 7535HS with Radeon Graphics, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.403
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  Job-YOWTQC : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```

---

## Detailed Results

### Dataset: Iris (150 elements)

| Method                   | Mean      | Error     | StdDev    |
|------------------------- |----------:|----------:|----------:|
| IrisDatasetBubbleSort    | 0.0306 ms | 0.0007 ms | 0.0020 ms |
| IrisDatasetInsertionSort | 0.0125 ms | 0.0006 ms | 0.0018 ms |
| IrisDatasetSelectionSort | 0.0251 ms | 0.0005 ms | 0.0012 ms |
| IrisDatasetMergeSort     | 0.0286 ms | 0.0018 ms | 0.0051 ms |
| IrisDatasetQuickSort     | 0.0249 ms | 0.0005 ms | 0.0014 ms |

### Dataset: Student (1000 elements)

| Method                      | Mean      | Error     | StdDev    |
|---------------------------- |----------:|----------:|----------:|
| StudentDatasetBubbleSort    | 1.2007 ms | 0.0733 ms | 0.2150 ms |
| StudentDatasetInsertionSort | 0.1817 ms | 0.0026 ms | 0.0032 ms |
| StudentDatasetSelectionSort | 0.4497 ms | 0.0070 ms | 0.0078 ms |
| StudentDatasetMergeSort     | 0.1721 ms | 0.0071 ms | 0.0200 ms |
| StudentDatasetQuickSort     | 0.2225 ms | 0.0044 ms | 0.0094 ms |

### Dataset: Wine (6497 elements)

| Method                   | Mean       | Error     | StdDev    |
|------------------------- |-----------:|----------:|----------:|
| WineDatasetBubbleSort    | 23.5179 ms | 0.2871 ms | 0.2397 ms |
| WineDatasetInsertionSort |  5.5764 ms | 0.2049 ms | 0.6042 ms |
| WineDatasetSelectionSort | 26.4141 ms | 0.2102 ms | 0.1863 ms |
| WineDatasetMergeSort     |  0.8232 ms | 0.0128 ms | 0.0230 ms |
| WineDatasetQuickSort     |  6.4000 ms | 0.1279 ms | 0.3731 ms |

### Dataset: Movie (9994 elements)

| Method                    | Mean       | Error     | StdDev    |
|-------------------------- |-----------:|----------:|----------:|
| MovieDatasetBubbleSort    | 172.816 ms | 2.1641 ms | 1.8071 ms |
| MovieDatasetInsertionSort |  19.446 ms | 0.3079 ms | 0.2729 ms |
| MovieDatasetSelectionSort |  47.100 ms | 0.6630 ms | 0.5877 ms |
| MovieDatasetMergeSort     |   1.382 ms | 0.1807 ms | 0.5300 ms |
| MovieDatasetQuickSort     |   1.364 ms | 0.2171 ms | 0.6400 ms |

### Dataset: Song (50000 elements)

| Method                   | Mean         | Error      | StdDev     |
|------------------------- |-------------:|-----------:|-----------:|
| SongDatasetBubbleSort    | 2,596.712 ms | 19.4101 ms | 18.1562 ms |
| SongDatasetInsertionSort |   373.069 ms |  0.7345 ms |  0.6870 ms |
| SongDatasetSelectionSort |   577.286 ms |  0.7061 ms |  0.6260 ms |
| SongDatasetMergeSort     |     3.391 ms |  0.0770 ms |  0.2082 ms |
| SongDatasetQuickSort     |    12.250 ms |  0.2373 ms |  0.6771 ms |

### Dataset: Uniform Numbers (10K elements)

| Method                         | Mean      | Error     | StdDev    |
|------------------------------- |----------:|----------:|----------:|
| UniformNumbers10KBubbleSort    | 64.050 ms | 0.7621 ms | 0.6756 ms |
| UniformNumbers10KInsertionSort | 17.402 ms | 0.1652 ms | 0.1290 ms |
| UniformNumbers10KSelectionSort | 36.730 ms | 0.6333 ms | 0.5614 ms |
| UniformNumbers10KMergeSort     |  1.864 ms | 0.0777 ms | 0.2279 ms |
| UniformNumbers10KQuickSort     |  1.757 ms | 0.0693 ms | 0.2043 ms |

### Dataset: Uniform Numbers (100K elements)

| Method                      | Mean      | Error     | StdDev    |
|---------------------------- |----------:|----------:|----------:|
| UniformNumbers100KMergeSort | 10.638 ms | 0.2113 ms | 0.4020 ms |
| UniformNumbers100KQuickSort |  7.244 ms | 0.1436 ms | 0.2998 ms |

### Dataset: Uniform Numbers (500K elements)

| Method                      | Mean     | Error    | StdDev   |
|---------------------------- |---------:|---------:|---------:|
| UniformNumbers500KMergeSort | 59.02 ms | 0.415 ms | 0.388 ms |
| UniformNumbers500KQuickSort | 41.41 ms | 0.368 ms | 0.307 ms |

### Dataset: Uniform Numbers (1M elements)

| Method                    | Mean      | Error    | StdDev   |
|-------------------------- |----------:|---------:|---------:|
| UniformNumbers1MMergeSort | 120.37 ms | 2.313 ms | 2.663 ms |
| UniformNumbers1MQuickSort |  86.29 ms | 1.100 ms | 0.975 ms |

### Dataset: Sorted Numbers (10K elements)

| Method                        | Mean       | Error     | StdDev    |
|------------------------------ |-----------:|----------:|----------:|
| SortedNumbers10KBubbleSort    |  0.0153 ms | 0.0008 ms | 0.0022 ms |
| SortedNumbers10KInsertionSort |  0.0154 ms | 0.0005 ms | 0.0015 ms |
| SortedNumbers10KSelectionSort | 35.1282 ms | 0.3994 ms | 0.3335 ms |
| SortedNumbers10KMergeSort     |  1.0784 ms | 0.0579 ms | 0.1706 ms |
| SortedNumbers10KQuickSort     |  1.7272 ms | 0.0696 ms | 0.2052 ms |

### Dataset: Sorted Numbers (100K elements)

| Method                         | Mean      | Error     | StdDev    |
|------------------------------- |----------:|----------:|----------:|
| SortedNumbers100KBubbleSort    | 0.0778 ms | 0.0014 ms | 0.0017 ms |
| SortedNumbers100KInsertionSort | 0.0855 ms | 0.0011 ms | 0.0013 ms |
| SortedNumbers100KMergeSort     | 4.0390 ms | 0.1158 ms | 0.3131 ms |
| SortedNumbers100KQuickSort     | 7.3419 ms | 0.1466 ms | 0.2606 ms |

### Dataset: Sorted Numbers (500K elements)

| Method                         | Mean       | Error     | StdDev    |
|------------------------------- |-----------:|----------:|----------:|
| SortedNumbers500KBubbleSort    |  0.3842 ms | 0.0030 ms | 0.0023 ms |
| SortedNumbers500KInsertionSort |  0.4385 ms | 0.0086 ms | 0.0089 ms |
| SortedNumbers500KMergeSort     | 22.3445 ms | 0.5079 ms | 1.4896 ms |
| SortedNumbers500KQuickSort     | 41.6732 ms | 0.5847 ms | 0.5183 ms |

### Dataset: Sorted Numbers (1M elements)

| Method                       | Mean       | Error     | StdDev    |
|----------------------------- |-----------:|----------:|----------:|
| SortedNumbers1MBubbleSort    |  0.7617 ms | 0.0089 ms | 0.0074 ms |
| SortedNumbers1MInsertionSort |  0.9148 ms | 0.0170 ms | 0.0323 ms |
| SortedNumbers1MMergeSort     | 42.6026 ms | 0.8502 ms | 2.1945 ms |
| SortedNumbers1MQuickSort     | 41.9616 ms | 0.8137 ms | 0.9371 ms |

### Dataset: Reverse Sorted Numbers (10K)

| Method                               | Mean        | Error     | StdDev    |
|------------------------------------- |------------:|----------:|----------:|
| ReverseSortedNumbers10KBubbleSort    | 104.1944 ms | 1.9162 ms | 2.3533 ms |
| ReverseSortedNumbers10KInsertionSort |  35.4977 ms | 0.5230 ms | 0.6982 ms |
| ReverseSortedNumbers10KSelectionSort |  46.4951 ms | 0.4458 ms | 0.4170 ms |
| ReverseSortedNumbers10KMergeSort     |   0.9437 ms | 0.1470 ms | 0.4289 ms |
| ReverseSortedNumbers10KQuickSort     |   1.2381 ms | 0.1708 ms | 0.5036 ms |

### Dataset: Reverse Sorted Numbers (100K)

| Method                            | Mean     | Error     | StdDev    |
|---------------------------------- |---------:|----------:|----------:|
| ReverseSortedNumbers100KMergeSort | 4.255 ms | 0.1247 ms | 0.3306 ms |
| ReverseSortedNumbers100KQuickSort | 7.322 ms | 0.1458 ms | 0.2553 ms |

### Dataset: Reverse Sorted Numbers (500K)

| Method                            | Mean     | Error    | StdDev   |
|---------------------------------- |---------:|---------:|---------:|
| ReverseSortedNumbers500KMergeSort | 23.91 ms | 0.362 ms | 0.283 ms |
| ReverseSortedNumbers500KQuickSort | 40.93 ms | 0.475 ms | 0.421 ms |

### Dataset: Reverse Sorted Numbers (1M)

| Method                          | Mean     | Error    | StdDev   |
|-------------------------------- |---------:|---------:|---------:|
| ReverseSortedNumbers1MMergeSort | 43.61 ms | 0.857 ms | 0.801 ms |
| ReverseSortedNumbers1MQuickSort | 87.18 ms | 0.941 ms | 0.880 ms |

---

## Run:

Run `dotnet run -c Release` in the root directory of the project.
