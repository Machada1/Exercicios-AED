using System;

class Program
{
    static string RemoverVogaisRecursivo(string frase, int indice)
    {

        if (indice == frase.Length)
        {
            return "";
        }

        char caractereAtual = frase[indice];


        if (!"AEIOUaeiou".Contains(caractereAtual))
        {

            return caractereAtual + RemoverVogaisRecursivo(frase, indice + 1);
        }


        return RemoverVogaisRecursivo(frase, indice + 1);
    }

    static string RemoverVogais(string frase)
    {

        return RemoverVogaisRecursivo(frase, 0);
    }

    static void Main()
    {
        Console.Write("Digite a frase: ");
        string frase = Console.ReadLine();

        string fraseSemVogais = RemoverVogais(frase);

        Console.WriteLine($"Frase sem vogais: {fraseSemVogais}");
    }
}
