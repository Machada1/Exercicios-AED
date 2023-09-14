using System;
using System.Diagnostics;

class Program
{
    static void SelectionSort(int[] vetor)
    {
        int n = vetor.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int menorIndice = i;
            for (int j = i + 1; j < n; j++)
            {
                if (vetor[j] < vetor[menorIndice])
                {
                    menorIndice = j;
                }
            }

            if (menorIndice != i)
            {
                int temp = vetor[i];
                vetor[i] = vetor[menorIndice];
                vetor[menorIndice] = temp;
            }
        }
    }

    static void Main()
    {
        int[] tamanhos = { 5, 10, 50, 100, 500, 1000, 5000, 10000, 50000, 100000, 5000000 };
        Random random = new Random();

        foreach (int tamanho in tamanhos)
        {
            int[] vetor = new int[tamanho];


            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = random.Next();
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SelectionSort(vetor);
            stopwatch.Stop();

            Console.WriteLine($"Tamanho do vetor: {tamanho}, Tempo de execução: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
