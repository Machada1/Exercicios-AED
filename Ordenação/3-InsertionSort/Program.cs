using System;
using System.Diagnostics;

class Program
{
    static void InsertionSort(int[] vetor)
    {
        int n = vetor.Length;

        for (int i = 1; i < n; i++)
        {
            int chave = vetor[i];
            int j = i - 1;

            while (j >= 0 && vetor[j] > chave)
            {
                vetor[j + 1] = vetor[j];
                j--;
            }

            vetor[j + 1] = chave;
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
            InsertionSort(vetor);
            stopwatch.Stop();

            Console.WriteLine($"Tamanho do vetor: {tamanho}, Tempo de execução: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
