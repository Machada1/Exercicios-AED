using System;
using System.Diagnostics;

class Program
{
    static void BubbleSort(int[] vetor)
    {
        int n = vetor.Length;
        bool trocou;

        do
        {
            trocou = false;
            for (int i = 1; i < n; i++)
            {
                if (vetor[i - 1] > vetor[i])
                {
                    int temp = vetor[i - 1];
                    vetor[i - 1] = vetor[i];
                    vetor[i] = temp;
                    trocou = true;
                }
            }
            n--;
        } while (trocou);
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
            BubbleSort(vetor);
            stopwatch.Stop();

            Console.WriteLine($"Tamanho do vetor: {tamanho}, Tempo de execução: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
