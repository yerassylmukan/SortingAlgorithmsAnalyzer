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
| IrisDatasetBubbleSort    | 0.0237 ms | 0.0009 ms | 0.0023 ms |
| IrisDatasetInsertionSort | 0.0096 ms | 0.0004 ms | 0.0010 ms |
| IrisDatasetSelectionSort | 0.0173 ms | 0.0003 ms | 0.0008 ms |
| IrisDatasetMergeSort     | 0.0329 ms | 0.0019 ms | 0.0052 ms |
| IrisDatasetQuickSort     | 0.0167 ms | 0.0004 ms | 0.0012 ms |


### Dataset: Student (1000 elements)

| Method                      | Mean      | Error     | StdDev    |
|---------------------------- |----------:|----------:|----------:|
| StudentDatasetBubbleSort    | 0.6082 ms | 0.0342 ms | 0.0997 ms |
| StudentDatasetInsertionSort | 0.1795 ms | 0.0029 ms | 0.0025 ms |
| StudentDatasetSelectionSort | 0.3808 ms | 0.0061 ms | 0.0051 ms |
| StudentDatasetMergeSort     | 0.1942 ms | 0.0038 ms | 0.0102 ms |
| StudentDatasetQuickSort     | 0.1327 ms | 0.0022 ms | 0.0043 ms |

### Dataset: Wine (6497 elements)

| Method                   | Mean       | Error     | StdDev    |
|------------------------- |-----------:|----------:|----------:|
| WineDatasetBubbleSort    | 18.1158 ms | 0.2877 ms | 0.2692 ms |
| WineDatasetInsertionSort |  4.9753 ms | 0.0942 ms | 0.1769 ms |
| WineDatasetSelectionSort | 11.7243 ms | 0.2294 ms | 0.2253 ms |
| WineDatasetMergeSort     |  0.8684 ms | 0.0934 ms | 0.2589 ms |
| WineDatasetQuickSort     |  3.4269 ms | 0.0679 ms | 0.1825 ms |

### Dataset: Movie (9994 elements)

| Method                    | Mean      | Error     | StdDev    |
|-------------------------- |----------:|----------:|----------:|
| MovieDatasetBubbleSort    | 63.822 ms | 0.5440 ms | 0.4542 ms |
| MovieDatasetInsertionSort | 16.511 ms | 0.3145 ms | 0.3744 ms |
| MovieDatasetSelectionSort | 30.247 ms | 0.5619 ms | 0.5519 ms |
| MovieDatasetMergeSort     |  1.403 ms | 0.2063 ms | 0.6082 ms |
| MovieDatasetQuickSort     |  1.210 ms | 0.1620 ms | 0.4778 ms |


### Dataset: Song (50000 elements)

| Method                   | Mean         | Error      | StdDev     |
|------------------------- |-------------:|-----------:|-----------:|
| SongDatasetBubbleSort    | 2,433.526 ms | 20.3734 ms | 18.0605 ms |
| SongDatasetInsertionSort |   362.731 ms |  5.7809 ms |  4.8273 ms |
| SongDatasetSelectionSort |   661.010 ms |  2.1474 ms |  1.6766 ms |
| SongDatasetMergeSort     |     8.540 ms |  0.1589 ms |  0.1409 ms |
| SongDatasetQuickSort     |     7.542 ms |  0.1505 ms |  0.2862 ms |

### Dataset: Uniform Numbers (10K elements)

| Method                         | Mean      | Error     | StdDev    |
|------------------------------- |----------:|----------:|----------:|
| UniformNumbers10KBubbleSort    | 59.849 ms | 1.0922 ms | 0.9682 ms |
| UniformNumbers10KInsertionSort | 14.791 ms | 0.2140 ms | 0.1897 ms |
| UniformNumbers10KSelectionSort | 30.546 ms | 0.5784 ms | 0.5940 ms |
| UniformNumbers10KMergeSort     |  1.825 ms | 0.1839 ms | 0.5278 ms |
| UniformNumbers10KQuickSort     |  1.173 ms | 0.1886 ms | 0.5562 ms |

### Dataset: Uniform Numbers (100K elements)

| Method                      | Mean      | Error     | StdDev    |
|---------------------------- |----------:|----------:|----------:|
| UniformNumbers100KMergeSort | 10.782 ms | 0.1702 ms | 0.2843 ms |
| UniformNumbers100KQuickSort |  6.751 ms | 0.1343 ms | 0.2977 ms |

### Dataset: Uniform Numbers (500K elements)

| Method                      | Mean     | Error    | StdDev   |
|---------------------------- |---------:|---------:|---------:|
| UniformNumbers500KMergeSort | 58.91 ms | 0.870 ms | 0.813 ms |
| UniformNumbers500KQuickSort | 35.83 ms | 0.381 ms | 0.337 ms |

### Dataset: Uniform Numbers (1M elements)

| Method                    | Mean      | Error    | StdDev   |
|-------------------------- |----------:|---------:|---------:|
| UniformNumbers1MMergeSort | 121.78 ms | 2.343 ms | 2.698 ms |
| UniformNumbers1MQuickSort |  74.93 ms | 0.501 ms | 0.444 ms |

### Dataset: Normal Numbers (10K elements)

| Method                        | Mean      | Error     | StdDev    |
|------------------------------ |----------:|----------:|----------:|
| NormalNumbers10KBubbleSort    | 58.623 ms | 1.1085 ms | 0.9826 ms |
| NormalNumbers10KInsertionSort | 14.723 ms | 0.1852 ms | 0.1641 ms |
| NormalNumbers10KSelectionSort | 30.438 ms | 0.3292 ms | 0.2918 ms |
| NormalNumbers10KMergeSort     |  1.881 ms | 0.1398 ms | 0.4122 ms |
| NormalNumbers10KQuickSort     |  1.424 ms | 0.0132 ms | 0.0103 ms |

### Dataset: Normal Numbers (100K elements)

| Method                     | Mean      | Error     | StdDev    |
|--------------------------- |----------:|----------:|----------:|
| NormalNumbers100KMergeSort | 10.638 ms | 0.2118 ms | 0.3479 ms |
| NormalNumbers100KQuickSort |  6.479 ms | 0.1293 ms | 0.2125 ms |

### Dataset: Normal Numbers (500K elements)

| Method                     | Mean     | Error    | StdDev   |
|--------------------------- |---------:|---------:|---------:|
| NormalNumbers500KMergeSort | 58.92 ms | 0.534 ms | 0.473 ms |
| NormalNumbers500KQuickSort | 36.64 ms | 0.247 ms | 0.231 ms |

### Dataset: Normal Numbers (1M elements)

| Method                   | Mean      | Error    | StdDev   |
|------------------------- |----------:|---------:|---------:|
| NormalNumbers1MMergeSort | 122.04 ms | 2.350 ms | 2.886 ms |
| NormalNumbers1MQuickSort |  75.71 ms | 0.399 ms | 0.333 ms |

### Dataset: Exponential Numbers (10K)

| Method                             | Mean      | Error     | StdDev    |
|----------------------------------- |----------:|----------:|----------:|
| ExponentialNumbers10KBubbleSort    | 59.484 ms | 0.9713 ms | 0.8111 ms |
| ExponentialNumbers10KInsertionSort | 14.964 ms | 0.2965 ms | 0.5422 ms |
| ExponentialNumbers10KSelectionSort | 30.045 ms | 0.4652 ms | 0.3885 ms |
| ExponentialNumbers10KMergeSort     |  1.852 ms | 0.1369 ms | 0.3973 ms |
| ExponentialNumbers10KQuickSort     |  1.172 ms | 0.1866 ms | 0.5501 ms |

### Dataset: Exponential Numbers (100K)

| Method                          | Mean      | Error     | StdDev    |
|-------------------------------- |----------:|----------:|----------:|
| ExponentialNumbers100KMergeSort | 10.410 ms | 0.2036 ms | 0.2854 ms |
| ExponentialNumbers100KQuickSort |  6.523 ms | 0.1292 ms | 0.2725 ms |

### Dataset: Exponential Numbers (500K)

| Method                          | Mean     | Error    | StdDev   |
|-------------------------------- |---------:|---------:|---------:|
| ExponentialNumbers500KMergeSort | 59.93 ms | 0.442 ms | 0.369 ms |
| ExponentialNumbers500KQuickSort | 35.56 ms | 0.112 ms | 0.093 ms |

### Dataset: Exponential Numbers (1M)

| Method                        | Mean      | Error    | StdDev   |
|------------------------------ |----------:|---------:|---------:|
| ExponentialNumbers1MMergeSort | 120.20 ms | 1.774 ms | 1.659 ms |
| ExponentialNumbers1MQuickSort |  76.19 ms | 0.535 ms | 0.447 ms |

### Dataset: Bimodal Numbers (10K)

| Method                         | Mean      | Error     | StdDev    |
|------------------------------- |----------:|----------:|----------:|
| BimodalNumbers10KBubbleSort    | 57.937 ms | 1.1035 ms | 0.9215 ms |
| BimodalNumbers10KInsertionSort | 14.933 ms | 0.2964 ms | 0.3641 ms |
| BimodalNumbers10KSelectionSort | 30.446 ms | 0.4259 ms | 0.3556 ms |
| BimodalNumbers10KMergeSort     |  1.867 ms | 0.1543 ms | 0.4476 ms |
| BimodalNumbers10KQuickSort     |  1.205 ms | 0.2003 ms | 0.5906 ms |

### Dataset: Bimodal Numbers (100K)

| Method                      | Mean      | Error     | StdDev    |
|---------------------------- |----------:|----------:|----------:|
| BimodalNumbers100KMergeSort | 10.438 ms | 0.2045 ms | 0.3243 ms |
| BimodalNumbers100KQuickSort |  6.673 ms | 0.1334 ms | 0.2664 ms |

### Dataset: Bimodal Numbers (500K)

| Method                      | Mean     | Error    | StdDev   |
|---------------------------- |---------:|---------:|---------:|
| BimodalNumbers500KMergeSort | 59.04 ms | 0.639 ms | 0.567 ms |
| BimodalNumbers500KQuickSort | 35.92 ms | 0.105 ms | 0.093 ms |

### Dataset: Bimodal Numbers (1M)

| Method                    | Mean      | Error    | StdDev   |
|-------------------------- |----------:|---------:|---------:|
| BimodalNumbers1MMergeSort | 121.56 ms | 1.878 ms | 1.568 ms |
| BimodalNumbers1MQuickSort |  73.95 ms | 1.211 ms | 1.073 ms |

---

## Run:

Run `dotnet run -c Release` in the root directory of the project.
