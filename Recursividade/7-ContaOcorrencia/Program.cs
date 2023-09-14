using System;

class Program
{
    static int ContarOcorrenciasRecursivas(string frase, char letra, int indice)
    {

        if (indice == frase.Length)
        {
            return 0;
        }


        int ocorrenciaAtual = frase[indice] == letra ? 1 : 0;

        return ocorrenciaAtual + ContarOcorrenciasRecursivas(frase, letra, indice + 1);
    }

    static int ContarOcorrencias(string frase, char letra)
    {

        return ContarOcorrenciasRecursivas(frase, letra, 0);
    }

    static void Main()
    {
        Console.Write("Digite a frase: ");
        string frase = Console.ReadLine();

        Console.Write("Digite a letra a ser contada: ");
        char letra = Console.ReadLine()[0];

        int ocorrencias = ContarOcorrencias(frase, letra);

        Console.WriteLine($"A letra '{letra}' ocorre {ocorrencias} vezes na frase.");
    }
}
