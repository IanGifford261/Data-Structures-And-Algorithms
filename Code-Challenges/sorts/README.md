# Sorts

**Author**: Ian Gifford
**Version**: 1.0.0

## Overview of InsertSort
A Challenge that implements an ```InsertSort``` method to sort arrays
based off this Psuedo Code
``` 
1.		InsertionSort(int[] arr)
2.			FOR i = 1 to arr.length
3.				int j <-- i - 1
4.				int temp <-- arr[i]
5.
6.				WHILE j >= 0 AND temp < arr[j]
7.					arr[j + 1] <-- arr[j]
8.					j <-- j - 1
9.
10.				arr[j + 1] <-- temp
```

- [X] InsertSort build out
- [X] 5 testing params met, passing

#### Time and Efficiency of InsertSort
Space: O(1) do not create anything significant when calling this method
Time: O(n^2) when sort is ran on the array, it runs nested loops.

```-----------------------------------------------------------------```

## Overview of MergeSort
A Challenge that implements an ```MergeSort``` and ```Merge``` methods to partition an array into sub arrays, then merges the sub arrays in the correct order. 

Based off this Psuedo Code
```
ALGORITHM Mergesort(arr)
    DECLARE n <-- arr.length
           
    if arr > 1
       DECLARE mid <-- n/2
       DECLARE b <-- arr[0...mid]
        // put the second half in the other array
        DECLARE c <-- arr[mid...n]
        Mergesort(b)
        Mergesort(c)
        Merge(B, c, arr)

ALGORITHM Merge(b, c, a)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < b && j < c
        if b[i] <= c[j]
            a[k] <-- b[i]
            i <-- i + 1
        else
            a[k] = c[j]
            j <-- j + 1
            
        k <-- k + 1

    if i = b.Length
       add remaining of c to a
    else
       add remaining b to a
       
    return a

```

- [X] InsertSort build out
- [] 5 testing params met, passing

#### Time and Efficiency of MergeSort

Time: O(n log n)
Space: O(n)

## Architecture
Microsoft Visual Studio Community

Xunit

## Change Log
V1.0 *building out* 22 APR 2019
V1.1 *adding MergeSort and Merge Methods, testing* 23 APR 2019
