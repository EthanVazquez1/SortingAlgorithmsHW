using SortingAlgorithmsHW;
using System.Diagnostics;

Stopwatch stopwatch = Stopwatch.StartNew();

// usage 100 thousand values
stopwatch.Start();
int[] largeArr = GenerateRandomArray(100000, 1, 1000);
stopwatch.Stop();
DisplayRuntime(stopwatch);

// Write your function to test each algorithm here 
Console.WriteLine("Sorting...");
stopwatch.Start();
//int[] result = Sort.BubbleSort(largeArr, largeArr.Length); //Time: 00:00:27.60
//int[] result = Sort.InsertionSort(largeArr); //Time: 00:00:06.25
//int[] result = Sort.MergeSort(largeArr, 0, largeArr.Length - 1); //Time: 00:00:00.06
int[] result = Sort.QuickSort(largeArr); //Time: 00:00:00.01
stopwatch.Stop();
DisplayRuntime(stopwatch);

Console.WriteLine("Press any key to continue");
Console.ReadLine();

// Write individual functions for each algorithm here (Bubble, Insertion, Merge, and Quick sort)
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}

// function
static int[] GenerateRandomArray(int length, int minValue, int maxValue)
{
    Random rand = new Random((int)DateTime.Now.Ticks);
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(minValue, maxValue); // Generates a random integer within the specified range
    }

    return array;
}

static void DisplayRuntime(Stopwatch stopwatch, string custommessage = "")
{
    TimeSpan ts = stopwatch.Elapsed;

    // Format and display the TimeSpan value.
    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
        ts.Hours, ts.Minutes, ts.Seconds,
        ts.Milliseconds / 10);
    Console.WriteLine(custommessage + "Time Taken: " + elapsedTime);
}
