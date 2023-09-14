using System;

class Program
{
    static void Main()
    {
        int tamanho = 5;
        int[] A = new int[tamanho];
        int[] B = new int[tamanho];
        int[] C = new int[tamanho];
        int[] D = new int[tamanho];

        
        Console.WriteLine("Digite os elementos do vetor A:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            A[i] = int.Parse(Console.ReadLine());
        }


        Console.WriteLine("\nDigite os elementos do vetor B:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            B[i] = int.Parse(Console.ReadLine());
        }

        int tamanhoC = 0;
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                if (A[i] == B[j])
                {
                    C[tamanhoC] = A[i];
                    tamanhoC++;
                    break;
                }
            }
        }


        int tamanhoD = 0;
        for (int i = 0; i < tamanho; i++)
        {
            bool encontrado = false;
            for (int j = 0; j < tamanho; j++)
            {
                if (A[i] == B[j])
                {
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                D[tamanhoD] = A[i];
                tamanhoD++;
            }
        }

        Console.WriteLine("\nElementos comuns entre A e B (vetor C):");
        for (int i = 0; i < tamanhoC; i++)
        {
            Console.Write(C[i] + " ");
        }

        Console.WriteLine("\n\nElementos de A que não existem em B (vetor D):");
        for (int i = 0; i < tamanhoD; i++)
        {
            Console.Write(D[i] + " ");
        }
    }
}
