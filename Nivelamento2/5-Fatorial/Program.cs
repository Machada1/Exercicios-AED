using System;

class Program
{
    static long CalcularFatorial(int numero)
    {
        if (numero == 0)
        {
            return 1; 
        }
        long fatorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            fatorial *= i;
        }
        return fatorial;
    }

    static void Main()
    {
        Console.Write("Digite um número inteiro para calcular o fatorial: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("Não é possível calcular o fatorial de um número negativo.");
        }
        else
        {
            long resultado = CalcularFatorial(numero);
            Console.WriteLine($"O fatorial de {numero} é {resultado}");
        }
    }
}
