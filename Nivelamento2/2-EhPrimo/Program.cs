using System;

class Program
{
    static bool EhPrimo(int numero)
    {
        if (numero <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        if (EhPrimo(numero))
        {
            Console.WriteLine($"{numero} é um número primo.");
        }
        else
        {
            Console.WriteLine($"{numero} não é um número primo.");
        }
    }
}
