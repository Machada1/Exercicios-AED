using System;
using System.Diagnostics;

class Program
{
    static Random random = new Random();

    static void Main(string[] args)
    {
        int[] sizes = { 5, 10, 50, 100, 500, 1000, 5000, 10000, 50000, 100000, 5000000 };

        foreach (int size in sizes)
        {
            int[] arr = GenerateRandomArray(size);
            int[] temp = new int[size];

            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine($"Tamanho do vetor: {size}");

            // Merge Sort
            Array.Copy(arr, temp, size); 
            stopwatch.Start();
            MergeSort(temp, 0, size - 1);
            stopwatch.Stop();
            Console.WriteLine($"Merge Sort: Tempo de execução {stopwatch.ElapsedMilliseconds}ms");
            Console.WriteLine();
        }
    }

    static int[] GenerateRandomArray(int size)
    {
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(1000000); // Gere números aleatórios no intervalo de 0 a 999999
        }
        return arr;
    }


/*
    static void Merge(int[] arr, int left, int middle, int right)
    {
        //Merge com O(n)
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];

        Array.Copy(arr, left, leftArr, 0, n1);
        Array.Copy(arr, middle + 1, rightArr, 0, n2);

        int i = 0, j = 0, k = left;

        while (i < n1 && j < n2)
        {
            if (leftArr[i] <= rightArr[j])
            {
                arr[k] = leftArr[i];
                i++;
            }
            else
            {
                arr[k] = rightArr[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            arr[k] = leftArr[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            arr[k] = rightArr[j];
            j++;
            k++;
        }
    }

*/
/*
    static void Merge(int[] arr, int left, int middle, int right)
{
    //Merge com bubble sort
           int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
}
*/
//*
static void Merge(int[] arr, int left, int middle, int right)
{
    //Merge com selection sort
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
}
//*/
/*
static void Merge(int[] arr, int left, int middle, int right)
{
    //Merge com insertion sort
    int n = arr.Length;

        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }

            arr[j + 1] = key;
        }
}
*/

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;
            MergeSort(arr, left, middle);
            MergeSort(arr, middle + 1, right);
            Merge(arr, left, middle, right);
        }
    }
}    
