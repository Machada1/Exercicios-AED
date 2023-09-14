using System;

class Program
{
    static int SomaElementosParesRecursiva(int[] vetor, int indice)
    {

        if (indice == vetor.Length)
        {
            return 0;
        }


        int elementoAtual = vetor[indice] % 2 == 0 ? vetor[indice] : 0;


        return elementoAtual + SomaElementosParesRecursiva(vetor, indice + 1);
    }

    static int SomaElementosPares(int[] vetor)
    {

        return SomaElementosParesRecursiva(vetor, 0);
    }

    static void Main()
    {
        int[] vetor = { 2, 5, 8, 10, 15, 6, 4 };

        int somaPares = SomaElementosPares(vetor);

        Console.WriteLine($"A soma dos elementos pares do vetor é: {somaPares}");
    }
}
