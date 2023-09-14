using System;

class Program
{
    static string DecimalParaBinarioRecursivo(int numero)
    {

        if (numero == 0)
        {
            return "0";
        }


        if (numero == 1)
        {
            return "1";
        }


        int bitMenosSignificativo = numero % 2;
        string binarioRestante = DecimalParaBinarioRecursivo(numero / 2);

        return binarioRestante + bitMenosSignificativo;
    }

    static string DecimalParaBinario(int numero)
    {

        if (numero == 0)
        {
            return "0";
        }


        return DecimalParaBinarioRecursivo(numero);
    }

    static void Main()
    {
        Console.Write("Digite um número decimal: ");
        int numero = int.Parse(Console.ReadLine());

        string binario = DecimalParaBinario(numero);

        Console.WriteLine($"O número {numero} em binário é: {binario}");
    }
}
