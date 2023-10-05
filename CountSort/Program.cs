using System;
using System.Diagnostics;

class Program
{
    static int[] CountSort(int[] arr, int maxValue)
    {
        int[] count = new int[maxValue + 1];

        // Contagem das ocorrências de cada elemento no vetor
        for (int i = 0; i < arr.Length; i++)
        {
            count[arr[i]]++;
        }

        // Reconstrução do vetor ordenado
        int index = 0;
        for (int i = 0; i <= maxValue; i++)
        {
            while (count[i] > 0)
            {
                arr[index] = i;
                index++;
                count[i]--;
            }
        }

        return arr;
    }

    static void Main(string[] args)
    {
        int[] tamanhos = { 500, 1000, 5000, 10000, 50000, 100000, 5000000 };
        Random random = new Random();

        foreach (int tamanho in tamanhos)
        {
            int[] vetor = new int[tamanho];

            // Preenche o vetor com números aleatórios entre 1 e 75
            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = random.Next(1, 76);
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int maxValue = 75; // O intervalo é de 1 a 75
            int[] sortedVetor = CountSort(vetor, maxValue);

            stopwatch.Stop();
            TimeSpan tempoExecucao = stopwatch.Elapsed;

            Console.WriteLine($"Tamanho do vetor: {tamanho}, Tempo de execução: {tempoExecucao.TotalMilliseconds} ms");
        }
    }
}
