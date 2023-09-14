using System;

class Program
{
    static int MultiplicacaoRecursiva(int a, int b)
    {

        if (a == 0 || b == 0)
        {
            return 0;
        }


        if (a == 1)
        {
            return b;
        }
        if (b == 1)
        {
            return a;
        }


        if (a > 1)
        {
            return b + MultiplicacaoRecursiva(a - 1, b);
        }
        else
        {
            return a + MultiplicacaoRecursiva(a, b - 1);
        }
    }

    static void Main()
    {
        Console.Write("Digite o primeiro número inteiro (A): ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número inteiro (B): ");
        int b = int.Parse(Console.ReadLine());

        int resultado = MultiplicacaoRecursiva(a, b);

        Console.WriteLine($"O resultado da multiplicação de {a} por {b} é {resultado}");
    }
}
