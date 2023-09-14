using System;

class Program
{
    static void Main()
    {
        int linhas = 5;
        int colunas = 3;
        int[,] matriz = new int[linhas, colunas];
        

        Console.WriteLine("Digite os elementos da matriz:");
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Elemento ({i + 1},{j + 1}): ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }


        Console.WriteLine("\nSoma das linhas:");
        for (int i = 0; i < linhas; i++)
        {
            int somaLinha = 0;
            for (int j = 0; j < colunas; j++)
            {
                somaLinha += matriz[i, j];
            }
            Console.WriteLine($"Linha {i + 1}: {somaLinha}");
        }


        Console.WriteLine("\nSoma das colunas:");
        for (int j = 0; j < colunas; j++)
        {
            int somaColuna = 0;
            for (int i = 0; i < linhas; i++)
            {
                somaColuna += matriz[i, j];
            }
            Console.WriteLine($"Coluna {j + 1}: {somaColuna}");
        }
    }
}
