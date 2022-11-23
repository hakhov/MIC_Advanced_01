int[] arr = { -1, 85, 90, 5, 13, 5, 2, 20, 1, 8, -9, 10, -50 };
int firstIndex = 0;
int lastIndex = arr.Length - 1;

int[] sortedArray = QuickSort(arr, firstIndex, lastIndex);


Console.WriteLine($"Sorted Array: {string.Join(", ", sortedArray)}");

