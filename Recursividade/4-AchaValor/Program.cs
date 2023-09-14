using System;

class Program
{
    static int BuscarValorRecursivo(int[] vetor, int valor, int indice)
    {

        if (indice == vetor.Length)
        {
            return -1;
        }


        if (vetor[indice] == valor)
        {
            return indice;
        }

        return BuscarValorRecursivo(vetor, valor, indice + 1);
    }

    static int BuscarValor(int[] vetor, int valor)
    {
        return BuscarValorRecursivo(vetor, valor, 0);
    }

    static void Main()
    {
        int[] vetor = { 2, 4, 6, 8, 10, 12, 14 };

        Console.Write("Digite o valor a ser buscado: ");
        int valor = int.Parse(Console.ReadLine());

        int posicao = BuscarValor(vetor, valor);

        if (posicao != -1)
        {
            Console.WriteLine($"O valor {valor} foi encontrado na posição {posicao} do vetor.");
        }
        else
        {
            Console.WriteLine($"O valor {valor} não foi encontrado no vetor.");
        }
    }
}
