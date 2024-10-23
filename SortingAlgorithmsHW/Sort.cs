using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsHW
{
    public static class Sort
    {
       public static int[] BubbleSort(int[] arr, int n = 0)
        {
            if (n == 0)
            {
                n = arr.Length;
            }
            int i, j, temp;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {

                        // Swap arr[j] and arr[j+1]
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // If no two elements were
                // swapped by inner loop, then break
                if (swapped == false)
                    break;
            }
            return arr;
        }

        public static int[] InsertionSort(int[] arr, int n = 0)
        {
            if (n == 0)
            {
                n = arr.Length;
            }
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                /* Move elements of arr[0..i-1], that are
                   greater than key, to one position ahead
                   of their current position */
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            return arr;
        }

        public static int[] MergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {

                // Find the middle point
                int m = l + (r - l) / 2;

                // Sort first and second halves
                MergeSort(arr, l, m);
                MergeSort(arr, m + 1, r);

                // Merge the sorted halves
                merge(arr, l, m, r);
            }
            return arr;
        }

        private static int[] merge(int[] arr, int l, int m, int r)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
            return arr;
        }

        public static int[] QuickSort(int[] arr)
        {
            // Partition function
            static int Partition(int[] arr, int low, int high)
            {

                // Choose the pivot
                int pivot = arr[high];

                // Index of smaller element and indicates 
                // the right position of pivot found so far
                int i = low - 1;

                // Traverse arr[low..high] and move all smaller
                // elements to the left side. Elements from low to 
                // i are smaller after every iteration
                for (int j = low; j <= high - 1; j++)
                {
                    if (arr[j] < pivot)
                    {
                        i++;
                        Swap(arr, i, j);
                    }
                }

                // Move pivot after smaller elements and
                // return its position
                Swap(arr, i + 1, high);
                return i + 1;
            }

            // Swap function
            static void Swap(int[] arr, int i, int j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            return arr;
        }
    }
}
