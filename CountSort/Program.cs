using System;
using System.Diagnostics;

class Program
{
    static void CountSort(int[] arr)
    {
        int[] countingArray = new int[75]; // Array de contagem com 75 elementos

        for (int i = 0; i < arr.Length; i++)
        {
            countingArray[arr[i] - 1]++; // Incrementa a contagem para o valor atual - 1
        }

        int index = 0;
        for (int i = 0; i < countingArray.Length; i++)
        {
            while (countingArray[i] > 0)
            {
                arr[index] = i + 1; // Define o valor no índice apropriado
                index++;
                countingArray[i]--;
            }
        }
    }

    static void Main()
    {
        Random random = new Random();

        int[] sizes = { 500, 1000, 5000, 10000, 50000, 100000, 5000000 };

        foreach (int size in sizes)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(1, 76); // Preenche o vetor com números aleatórios entre 1 e 75
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            CountSort(arr);

            stopwatch.Stop();
            Console.WriteLine($"Tamanho do vetor: {size}, Tempo de execução: {stopwatch.ElapsedMilliseconds} ms");
                        Console.WriteLine("Vetor ordenado:");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            
        }
    }
}
