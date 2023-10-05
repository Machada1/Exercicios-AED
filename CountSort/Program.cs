using System;
using System.Diagnostics;

class Program
{


    static void Main(string[] args)
    {
        int[] tamanhos = { 500, 1000, 5000, 10000, 50000, 100000, 5000000 };

        foreach (int tamanho in tamanhos)
        {
            int[] vetor = new int[tamanho];
            Random random = new Random();

            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = random.Next(1, 76); // Números entre 1 e 75
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int[] sortedVetor = CountSort(vetor);

            stopwatch.Stop();
            TimeSpan tempoExecucao = stopwatch.Elapsed;

            Console.WriteLine($"Tamanho do vetor: {tamanho}, Tempo de execução: {tempoExecucao.TotalSeconds:F6} segundos");
        }
    }
}