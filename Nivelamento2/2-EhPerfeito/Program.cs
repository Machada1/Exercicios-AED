using System;

class Program
{
    static bool EhNumeroPerfeito(int numero)
    {
        int somaDivisores = 0;

        for (int i = 1; i < numero; i++)
        {
            if (numero % i == 0)
            {
                somaDivisores += i;
            }
        }

        return somaDivisores == numero;
    }

    static void Main()
    {
        Console.WriteLine("Números perfeitos de 1 a 1000:");

        for (int i = 1; i <= 1000; i++)
        {
            if (EhNumeroPerfeito(i))
            {
                Console.WriteLine(i);
            }
        }
    }
}
