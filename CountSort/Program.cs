using System;
using System.Diagnostics;

class Program
{
    static int[] CountSort(int[] arr)
    {
        int maxVal = arr[0];
        int minVal = arr[0];
        int n = arr.Length;

        // Encontra o valor máximo e mínimo no vetor
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > maxVal)
                maxVal = arr[i];
            if (arr[i] < minVal)
                minVal = arr[i];
        }

        int k = maxVal - minVal + 1;

        // Inicializa o vetor de contagem com zeros
        int[] count = new int[k];

        // Conta as ocorrências de cada elemento no vetor original
        for (int i = 0; i < n; i++)
        {
            count[arr[i] - minVal]++;
        }

        // Constrói o vetor ordenado a partir das contagens
        int[] sortedArr = new int[n];
        int index = 0;
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < count[i]; j++)
            {
                sortedArr[index] = i + minVal;
                index++;
            }
        }

        return sortedArr;
    }

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
